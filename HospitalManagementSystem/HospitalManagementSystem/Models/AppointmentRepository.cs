using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem
{
    public class AppointmentRepository
    {
        private readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

        public List<Appointment> GetAllAppointments()
        {
            var appointments = new List<Appointment>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT AppointmentID, PatientID, DoctorName, AppointmentDate, Reason, Status FROM Appointments ORDER BY AppointmentDate";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        appointments.Add(new Appointment
                        {
                            AppointmentID = (int)reader["AppointmentID"],
                            PatientID = (int)reader["PatientID"],
                            DoctorName = reader["DoctorName"].ToString(),
                            AppointmentDate = (DateTime)reader["AppointmentDate"],
                            Reason = reader["Reason"]?.ToString(),
                            Status = reader["Status"].ToString()
                        });
                    }
                }
            }

            return appointments;
        }

        public int AddAppointment(Appointment appt)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Appointments (PatientID, DoctorName, AppointmentDate, Reason, Status)
                                  VALUES (@PatientID, @DoctorName, @AppointmentDate, @Reason, @Status);
                                  SELECT CAST(SCOPE_IDENTITY() as int);";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", appt.PatientID);
                    cmd.Parameters.AddWithValue("@DoctorName", appt.DoctorName);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appt.AppointmentDate);
                    cmd.Parameters.AddWithValue("@Reason", appt.Reason ?? "");
                    cmd.Parameters.AddWithValue("@Status", appt.Status ?? "Scheduled");

                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void CancelAppointment(int appointmentId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Appointments SET Status = 'Cancelled' WHERE AppointmentID = @AppointmentID";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
