CREATE DATABASE MedicalDB;
GO
USE MedicalDB;
GO

CREATE TABLE Doctors (
    DoctorID INT IDENTITY(1,1) PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Specialty VARCHAR(100) NOT NULL,
    Availability BIT NOT NULL
);

CREATE TABLE Patients (
    PatientID INT IDENTITY(1,1) PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(150) NOT NULL
);

CREATE TABLE Appointments (
    AppointmentID INT IDENTITY(1,1) PRIMARY KEY,
    DoctorID INT NOT NULL FOREIGN KEY REFERENCES Doctors(DoctorID),
    PatientID INT NOT NULL FOREIGN KEY REFERENCES Patients(PatientID),
    AppointmentDate DATETIME NOT NULL,
    Notes VARCHAR(250)
);

INSERT INTO Doctors (FullName, Specialty, Availability) VALUES
('Dr. Ama Boateng', 'Cardiology', 1),
('Dr. Kwesi Mensah', 'Dermatology', 1),
('Dr. Yaa Asante', 'Pediatrics', 0),
('Dr. Edinam','Surgery', 0),
('Dr. Kojo Baido','Optomology', 1),
('Dr. Joseph Goodnews','Dentistry', 1),
('Dr. Erskine Mensah','Surgery', 0),
('Dr. Aku Marvel','Dermatology', 0),
('Dr. Ami John','Pediatrics', 1),
('Dr. Kojo Owusu', 'General Medicine', 1);

INSERT INTO Patients (FullName, Email) VALUES
('John Doe', 'john.doe@example.com'),
('Mary Mensah', 'mary.mensah@example.com'),
('Nana','kwame'),
('Ama','Baido'),
('Doe','John'),
('King','herbet'),
('Elsie','Atsu'),
('David','Berk'),
('kojo','Ike'),
('Kofi Adjei', 'kofi.adjei@example.com');
