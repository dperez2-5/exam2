CREATE DATABASE ClinicDeviceDB;
GO

USE ClinicDeviceDB;
GO

CREATE TABLE MedicalDevices
(
    DeviceID VARCHAR(50) PRIMARY KEY,
    DeviceName VARCHAR(100) NOT NULL,
    BatteryLife INT NOT NULL,
    WardNumber INT NOT NULL,
    DeviceType VARCHAR(30) NOT NULL,
    SpecialAttribute VARCHAR(50)
);