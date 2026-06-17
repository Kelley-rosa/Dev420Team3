using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BloodType { get; set; }
        public string MedicalHistory { get; set; }
        public DateTime CreatedDate { get; set; }

        // read only property to display full name
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}