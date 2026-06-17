CREATE DATABASE HospitalDB;
GO

USE HospitalDB;

CREATE TABLE Patients (
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Phone NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(200) NULL,
    BloodType NVARCHAR(5) NULL,
    MedicalHistory NVARCHAR(MAX) NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
)

CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT FOREIGN KEY REFERENCES Patients(PatientID),
    DoctorName NVARCHAR(100) NOT NULL,
    AppointmentDate DATETIME NOT NULL,
    Reason NVARCHAR(200) NULL,
    Status NVARCHAR(20) DEFAULT 'Scheduled'
)

CREATE TABLE Inventory (
    ItemID INT PRIMARY KEY IDENTITY(1,1),
    ItemName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    Quantity INT NOT NULL,
    Unit NVARCHAR(20) NOT NULL,
    LowStockThreshold INT NOT NULL,
    LastUpdated DATETIME DEFAULT GETDATE()
)