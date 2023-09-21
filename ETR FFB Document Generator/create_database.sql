CREATE DATABASE roster;

USE roster;

CREATE TABLE roster (
  StudentID INT PRIMARY KEY,
  Firstname VARCHAR(50),
  Lastname VARCHAR(50),
  DOB VARCHAR(50),
  DOE VARCHAR(50),
  Email VARCHAR(100),
  Trade VARCHAR(50),
  Size VARCHAR(10),
  Incentive VARCHAR(20)
);