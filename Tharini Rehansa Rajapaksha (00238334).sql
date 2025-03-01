/*-------Create Database---------*/
/* create database E_Space_Solutions;*/

/*-------Use Created Database----*/
/*use E_Space_Solutions;*/

/*-------Create Table Colonists----*/
/*CREATE TABLE Colonist(
    Colonization_ID int primary key,
    First_Name varchar(255),
    Middle_Name varchar(255),
    Surname varchar(255),
    DateOfBirth varchar(255),
	Qualification varchar(255),
	Age int,
	EarthAddress varchar(255),
	Gender varchar(255),
	Contact int,
	CivilStatus varchar(255),
	FamilyMembers int
);
INSERT INTO Colonists (Colonization_ID, First_Name, Middle_Name, Surname, DateOfBirth, Qualification, Age,
EarthAddress, Gender, Contact, CivilStatus, FamilyMembers)
VALUES ('1', 'Anna ', 'rosen', 'Wang', '1995/08/08', 'Bachelor’s degree in physics', '29',
'Anna Wang 4455 Landing Lange APT 4 Louisville KY 40018-1234', 'Female', '61564847', 'Married', '5');
INSERT INTO Colonists (Colonization_ID, First_Name, Middle_Name, Surname, DateOfBirth, Qualification, Age,
EarthAddress, Gender, Contact, CivilStatus, FamilyMembers)
VALUES ('2', 'Lily ', 'Park', 'Jun', '1997/06/23', 'Bachelor’s degree in Computer Science', '27',
'Lily Park Jun 6677 Landing Lange APT 5 Lagos 105102 Nigeria.', 'Female', '91568423', 'Single', '2');
INSERT INTO Colonists (Colonization_ID, First_Name, Middle_Name, Surname, DateOfBirth, Qualification, Age,
EarthAddress, Gender, Contact, CivilStatus, FamilyMembers)
VALUES ('3', 'Emma', 'Aleshia', 'Watson', '2000/10/26', 'Bachelor’s degree in Accounting', '24',
'Emma Aleshia Watson 132 My Street Kingston New York 12401 United States', 'Female', '01056584', 'Single', '0');
select * from Colonists;*/


/*-------Create Table Colonists' Dependents----*/
/*CREATE TABLE Colonists_Dependents(
    Name varchar(255),
    DateOfBirth varchar(255),
	Age int,
	Gender varchar(255),
	RelationshipWithColonist varchar(255),
	Colonization_ID int,
	FOREIGN KEY (Colonization_ID) REFERENCES Colonists(Colonization_ID)
);
INSERT INTO Colonists_Dependents (Name, DateOfBirth, Age, Gender, RelationshipWithColonist, Colonization_ID)
VALUES ('Emily Warden', '1990/12/12', '34', 'Female', '44154533', '1');
INSERT INTO Colonists_Dependents (Name, DateOfBirth, Age, Gender, RelationshipWithColonist, Colonization_ID)
VALUES ('Elena Warden', '1988/07/14', '37', 'Female', '12458795', '1');
INSERT INTO Colonists_Dependents (Name, DateOfBirth, Age, Gender, RelationshipWithColonist, Colonization_ID)
VALUES ('Elena Cullen', '1980/08/25', '44', 'Male', '48662155', '2');
select * from Colonists_Dependents;*/



/*-------Create Table Colonists' House----*/
/*CREATE TABLE Colonists_House(
    ColonyLotNumber int primary key,
    NumberOfRooms int,
	SquareFeet int,
	Colonization_ID int,
	FOREIGN KEY (Colonization_ID) REFERENCES Colonists(Colonization_ID)
);
INSERT INTO Colonists_House (ColonyLotNumber, NumberOfRooms, SquareFeet, Colonization_ID)
VALUES ('001', '3', '2250', '1');
INSERT INTO Colonists_House (ColonyLotNumber, NumberOfRooms, SquareFeet, Colonization_ID)
VALUES ('002', '4', '3050', '2');
INSERT INTO Colonists_House (ColonyLotNumber, NumberOfRooms, SquareFeet, Colonization_ID)
VALUES ('003', '1', '1050', '3');
select * from Colonists_House;*/


/*-------Create Table Colonists' Jobs----*/
/*CREATE TABLE Jobs(
    Jobs_ID int primary key,
    Job_Name varchar(255),
	Job_Details varchar(255),
	Colonization_ID int,
	FOREIGN KEY (Colonization_ID) REFERENCES Colonists(Colonization_ID)
);
INSERT INTO Jobs (Jobs_ID, Job_Name, Job_Details, Colonization_ID)
VALUES ('22', 'Security', 'Who is eligible for the job', '1');
INSERT INTO Jobs (Jobs_ID, Job_Name, Job_Details, Colonization_ID)
VALUES ('08', 'Education', 'Who is eligible for the job', '2');
INSERT INTO Jobs (Jobs_ID, Job_Name, Job_Details, Colonization_ID)
VALUES ('14', 'Administration', 'Who is eligible for the job', '3');
select * from Jobs;*/



/*-------Create Table E-Jets----*/
/*CREATE TABLE E_Jets(
    JetUniqueCode int primary key,
    WeightOfJet int,
	PowerSource varchar(255),
	NoOfPassengerSeat int,
	NuclearEnginePower int,
	MadeYear varchar(255)
);
INSERT INTO E_Jets (JetUniqueCode, WeightOfJet, PowerSource, NoOfPassengerSeat, NuclearEnginePower, MadeYear)
VALUES ('33045', '224500', 'The turbine', '70', '168000', '19/02/2002');
INSERT INTO E_Jets (JetUniqueCode, WeightOfJet, PowerSource, NoOfPassengerSeat, NuclearEnginePower, MadeYear)
VALUES ('33128', '145500', 'The turbine', '60', '168000', '19/02/2002');
INSERT INTO E_Jets (JetUniqueCode, WeightOfJet, PowerSource, NoOfPassengerSeat, NuclearEnginePower, MadeYear)
VALUES ('33076', '122000', 'Gas turbine', '55', '168000', '04/03/2004');
select * from E_Jets;*/



/*-------Create Table Trips----*/
/*CREATE TABLE Trips(
    Trip_ID int primary key,
    JetCode int,
	LaunchDate varchar(255),
	ReturnDate varchar(255),
	JetUniqueCode int,
	Colonization_ID int,
	FOREIGN KEY (JetUniqueCode) REFERENCES E_Jets(JetUniqueCode),
	FOREIGN KEY (Colonization_ID) REFERENCES Colonists(Colonization_ID)
);
INSERT INTO Trips (Trip_ID, JetCode, LaunchDate, ReturnDate, JetUniqueCode, Colonization_ID)
VALUES ('1', '330', '25/04/2025', '30/07/2048', '33045', '1');
INSERT INTO Trips (Trip_ID, JetCode, LaunchDate, ReturnDate, JetUniqueCode, Colonization_ID)
VALUES ('2', '450', '19/03/2027', '14/10/2050', '33045', '3');
INSERT INTO Trips (Trip_ID, JetCode, LaunchDate, ReturnDate, JetUniqueCode, Colonization_ID)
VALUES ('3', '330', '25/04/2025', '30/07/2048', '33045', '2');
INSERT INTO Trips (Trip_ID, JetCode, LaunchDate, ReturnDate, JetUniqueCode, Colonization_ID)
VALUES ('3', '330', '25/04/2025', '30/07/2047', '33076', '2');
INSERT INTO Trips (Trip_ID, JetCode, LaunchDate, ReturnDate, JetUniqueCode, Colonization_ID)
VALUES ('4', '450', '25/04/2025', '30/07/2047', '33076', '1');
select * from Trips;*/


/*-------Create Table Pilots----*/
/*CREATE TABLE Pilots(
    Pilot_ID int primary key,
    Name varchar(255),
	NoOfSpace int,
	Qualification varchar(255),
	Ranks int,
);
INSERT INTO Pilots (Pilot_ID, Name, NoOfSpace, Qualification, Ranks)
VALUES ('1', 'Suresh Rajitha', '4500', 'Bacholors In Electronics', '15');

select * from Pilots;*/

/*-------UPDATE Table Colonists----*/
/*UPDATE Colonists
SET First_Name = 'Agnes'
WHERE Colonization_ID = 1;

select * from Colonists;*/



/*-------Delete Data From Trip Table----*/
/*DELETE FROM Trips WHERE Trip_ID='3';

select * from Trips;*/


/*-------GroupBy Table E-Jets----*/
/*use E_Space_Solutions;
SELECT COUNT(JetUniqueCode), WeightOfJet
FROM E_Jets
GROUP BY WeightOfJet
HAVING COUNT(JetUniqueCode) > 0;*/


/*-------Create Table For User Registration----*/
/*use E_Space_Solutions;
CREATE TABLE User_Registration(
    Name varchar(255),
    Contact varchar(255),
	Username varchar(255),
	Password varchar(255)
);
INSERT INTO User_Registration (Name, Contact, Username, Password)
VALUES ('Tharini Rajapaksha', '0771740070', '@Tharini', '123.Tharini');
select * from User_Registration;*/



/*-------Create Table For Admin Registration----*/
/*use E_Space_Solutions;
CREATE TABLE Admin_Registration(
    Name varchar(255),
    Contact varchar(255),
	Position varchar(255),
	Username varchar(255),
	Password varchar(255)
);
INSERT INTO Admin_Registration (Name, Contact, Position, Username, Password)
VALUES ('Rakitha', '0779970602', 'Staff Member', '@Rakitha', '123.Rakitha');
select * from Admin_Registration;*/


/*-------Create Table For User Login----*/
/*use E_Space_Solutions;
CREATE TABLE User_Login(
	Username varchar(255),
	Password varchar(255)
);
select * from User_Login;
use E_Space_Solutions;
INSERT INTO User_Login (Username, Password)
VALUES ('@Tharini', '123.Tharini');
select * from User_Login;*/

/*-------Create Table For Admin Login----*/
/*use E_Space_Solutions;
CREATE TABLE Admin_Login(
	Username varchar(255),
	Password varchar(255)
);
select * from Admin_Login;
INSERT INTO Admin_Login (Username, Password)
VALUES ('@Rakitha', '123.Rakitha');
select * from Admin_Login;*/

/*CREATE TABLE User_Login(
	Username varchar(255),
	Password varchar(255),
	FOREIGN KEY (Username, Password)
        REFERENCES User_Registration(Username, Password)
);*/
/*ALTER TABLE User_Registration
ADD CONSTRAINT UC_User_Registration UNIQUE (Username, Password);*/


/*use E_Space_Solutions;
CREATE TABLE User_Login(
	Username varchar(255),
	Password varchar(255),
	CONSTRAINT fk_User_Registration FOREIGN KEY (Username, Password) REFERENCES User_Registration(Username, Password)
);
select * from User_Login;
use E_Space_Solutions;
INSERT INTO User_Login (Username, Password)
VALUES ('@Tharini', '123.Tharini');
select * from User_Registration;
*/

/*use E_Space_Solutions;
CREATE TABLE Admin_Registration(
    Name varchar(255),
    Contact varchar(255),
	Position varchar(255),
	Username varchar(255),
	Password varchar(255),
	CONSTRAINT unique_key_names UNIQUE (Username, Password)
);
INSERT INTO Admin_Registration (Name, Contact, Position, Username, Password)
VALUES ('Rakitha', '0779970602', 'Staff Member', '@Rakitha', '123.Rakitha');
select * from Admin_Registration;*/

/*CREATE TABLE Admin_Login(
	Username varchar(255),
	Password varchar(255),
	CONSTRAINT fk_Admin_Registration FOREIGN KEY (Username, Password) REFERENCES Admin_Registration(Username, Password)
);
INSERT INTO Admin_Login (Username, Password)
VALUES ('@Rakitha', '123.Rakitha');*/

/*CREATE TABLE Admin_Login(
	Username varchar(255),
	Password varchar(255),
	CONSTRAINT fk_Admin_Registration FOREIGN KEY (Username, Password) REFERENCES Admin_Registration(Username, Password)
);

select * from Admin_Login;
ALTER TABLE Admin_Registration
ADD CONSTRAINT UC_Admin_Registration UNIQUE (Username, Password);*/

/*-- Drop the existing UserID column if it exists
ALTER TABLE User_Registration
DROP COLUMN UserID;

-- Add UserID column with IDENTITY property
ALTER TABLE User_Registration
ADD UserID INT IDENTITY(1,1) PRIMARY KEY;

-- Select all records from User_Registration table
SELECT * FROM User_Registration;*/


/*-- ColonistTrip Table (junction table between Colonist and Trip)
CREATE TABLE ColonistTrip (
    ColonistTripID INT IDENTITY(1,1) PRIMARY KEY,
    Colonization_ID INT NOT NULL FOREIGN KEY REFERENCES Colonists(Colonization_ID) ON DELETE CASCADE,
    Trip_ID INT NOT NULL FOREIGN KEY REFERENCES Trips(Trip_ID) ON DELETE CASCADE
);*/
/*INSERT INTO ColonistTrip (Colonization_ID, Trip_ID)
VALUES (3, 4);
SELECT * FROM ColonistTrip;*/

-- HouseAssignment Table (to link Colonists with Houses)
/*CREATE TABLE HouseAssignment (
    HouseAssignmentID INT IDENTITY(1,1) PRIMARY KEY,
    Colonization_ID INT NOT NULL FOREIGN KEY REFERENCES Colonists(Colonization_ID) ON DELETE CASCADE,
    ColonyLotNumber INT NOT NULL FOREIGN KEY REFERENCES Colonists_House(ColonyLotNumber)
);
INSERT INTO HouseAssignment (Colonization_ID, ColonyLotNumber)
VALUES (1, 1);
SELECT * FROM HouseAssignment;*/


-- ColonistJob Table (junction table between Colonist and Job)
/*CREATE TABLE ColonistJob (
    ColonistJobID INT IDENTITY(1,1) PRIMARY KEY,
    Colonization_ID INT NOT NULL FOREIGN KEY REFERENCES Colonists(Colonization_ID) ON DELETE CASCADE,
    Jobs_ID INT NOT NULL FOREIGN KEY REFERENCES Jobs(Jobs_ID) ON DELETE CASCADE
);
INSERT INTO ColonistJob (Colonization_ID, Jobs_ID)
VALUES (2, 8);
select * from ColonistJob;*/


-- JetAssignment Table (junction table between Pilot and E_Jet)
/*CREATE TABLE JetAssignment (
    JetAssignmentID INT IDENTITY(1,1) PRIMARY KEY,
    Pilot_ID INT NOT NULL FOREIGN KEY REFERENCES Pilots(Pilot_ID) ON DELETE CASCADE,
	Trip_ID INT NOT NULL FOREIGN KEY REFERENCES Trips(Trip_ID),
    JetUniqueCode INT NOT NULL FOREIGN KEY REFERENCES E_Jets(JetUniqueCode)
);
INSERT INTO JetAssignment (Pilot_ID, Trip_ID, JetUniqueCode)
VALUES (1, 1, 33045);*/

