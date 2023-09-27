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

CREATE TABLE Level1 (
    Infraction VARCHAR(255),
    Code VARCHAR(50)
);

CREATE TABLE Level2 (
    Infraction VARCHAR(255),
    Code VARCHAR(50)
);

CREATE TABLE contacts (
  Name VARCHAR(100),
  Center VARCHAR(100),
  Email VARCHAR(100),
  Phone VARCHAR(20),
  C2C VARCHAR(50) PRIMARY KEY
);

DELETE FROM Level1;

INSERT INTO Level1 (infraction, code) VALUES
('Possession of a weapon on center or under center supervision', '5.1a'),
('Assault', '5.1a'),
('Threat of assault', '5.1a'),
('Threat to safety', '5.1a'),
('Sexual assault', '5.1a'),
('Drugs: Possession or distribution of drugs on center or under center supervision', '5.2b'),
('Drugs: Use of drugs as evidenced by a positive drug test', '5.2a'),
('Alcohol: Possession, consumption, or distribution while on center or under center supervision', '5.3c'),
('Abuse of Alcohol', '5.3c'),
('Arrest for a felony or violent misdemeanor on or off center', '5.1a'),
('Illegal Activity', '5.1a'),
('Robbery or Extortion', '5.1a'),
('Arson', '5.1a'),
('Cruelty to animals', '5.1a'),
('Inciting a disturbance or creating disorder', '5.1a');

DELETE FROM Level2;

INSERT INTO Level2 (infraction, code) VALUES
('Possession of a potentially dangerous item', '5.1b'),
('Theft/stealing', '5.1b'),
('Intoxication on center or under center supervision', '5.3b'),
('Possession of stolen goods', '5.1b'),
('Bullying or harassment', '5.1b'),
('Sexual harassment', '5.1b'),
('False accusation', '5.1b'),
('Unfair money lending', '5.1b'),
('Hazing or initiation', '5.1b'),
('Gang representation or activity', '5.1b'),
('Vandalism', '5.1b'),
('Plagiarism', '5.1b'),
('Cheating', '5.1b'),
('Arrest for a non-violent misdemeanor on or off center', '5.3b'),
('Bringing disrepute to the program', '5.1b'),
('Pattern of minor infractions', '5.3a'),
('Unauthorized exit', '5.3d');

DELETE FROM contacts;

INSERT INTO contacts (Name, Center, Email, C2C, Phone) VALUES
('Pierre Stinson', 'Benjamin L. Hooks', 'Stinson.pierre@jobcorps.org', '254.5832', '901.344.5832'),
('Roosevelt Wilensky', 'Hubert H. Humphrey', 'Wilensky.roosevelt@jobcorps.org', '152.1823', '651.444.1823'),
('Robert Eaton', 'Iroquois', 'Eaton.robert@jobcorps.org', '157.6716', '585.344.6716'),
('Angela Taylor', 'Montgomery', 'Taylor.angela@jobcorps.org', '258.2423', '334.420.2423'),
('John Berry', 'Northlands', 'Berry.john@jobcorps.org', '174.0189', '802.877.0189'),
('Christina Eastwood', 'Oneonta', 'Eastwood.christina@jobcorps.org', '177.1469', '607.431.1469'),
('James Ross', 'Wilmington', 'Ross.james@jobcorps.org', '235.2525', '302.230.2525'),
('Steven Ochieng', 'Excelsior Springs', 'Ochieng.steven@jobcorps.org', '135.3117', '816.629.3117'),
('Adrese Davis', 'Westover', 'Davis.adrese@jobcorps.org', '208.4049', '413.593.4049'),
('Keith White', 'ETR Rochester', 'Keith.white@etrky.com', 'N/A', '585.202.5018');

