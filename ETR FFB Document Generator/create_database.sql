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
    Code VARCHAR(50),
    Definition VARCHAR(255)
);

CREATE TABLE Level2 (
    Infraction VARCHAR(255),
    Code VARCHAR(50),
    Definition VARCHAR(255)
);

CREATE TABLE contacts (
  Name VARCHAR(100),
  Center VARCHAR(100),
  Email VARCHAR(100),
  Phone VARCHAR(20),
  C2C VARCHAR(50) PRIMARY KEY
);

DELETE FROM Level1;

INSERT INTO Level1 (infraction, code, Definition) VALUES
('Possession of a weapon on center or under center supervision', '5.1a','Possessing a weapon, as defined below, while on center or while off center but on a center-supervised activity.'),
('Assault', '5.1a', 'Taking a physical action with the intent to cause immediate bodily harm to another person unless taken in immediate response to another person taking such an action with the intent to prevent its continuation.'),
('Threat of assault', '5.1a', 'Making a verbal or written threat to harm another person or group. This includes threats made on social media.'),
('Threat to safety', '5.1a','Any action or threat of action that could jeopardize the safety or well-being of others.'),
('Sexual assault', '5.1a','Any unwanted or coerced sexual act or behavior, including rape.'),
('Drugs: Possession or distribution of drugs on center or under center supervision', '5.2b','Possessing or distributing illegal drugs or controlled substances while on center or while off center but on a center-supervised activity. NOTE: Students who refuse to submit to a drug test or provide a sample for drug testing shall be presumed guilty of this infraction.'),
('Drugs: Use of drugs as evidenced by a positive drug test', '5.2a','Consuming illegal drugs or controlled substances as evidenced by a positive result from a urinalysis test.'),
('Alcohol: Possession, consumption, or distribution while on center or under center supervision', '5.3c','While on center or while off center but on a center- supervised activity, knowingly: Possessing alcohol, Consuming alcohol, Distributing alcohol to others.'),
('Abuse of Alcohol', '5.3c','A pattern of alcohol consumption-related incidents demonstrated by receiving more than two Level II “Intoxication on center or under center supervision” infractions where the intoxication is the result of alcohol while enrolled in the program. The 3rd infraction elevates the behavior to Level I Abuse of Alcohol.'),
('Arrest for a felony or violent misdemeanor on or off center', '5.1a', 'Being arrested by law enforcement for a felony. Being arrested by law enforcement for a misdemeanor involving the use, attempted use, or threatened use of physical force against the person or property of another.'),
('Illegal Activity', '5.1a', 'Being convicted of a felony or misdemeanor as defined by Federal or state law, where the crime occurred while the student was enrolled in Job Corps.'),
('Robbery or Extortion', '5.1a','Taking money or possessions of another from his/her person by force or intimidation.'),
('Arson', '5.1a','The malicious setting of fire to a structure or personal property belonging to another person or entity.'),
('Cruelty to animals', '5.1a','The torture, ill-treatment, abandonment, willful infliction of injury or pain, beating, maiming, mutilating, or killing of any animal, whether belonging to the individual or another.'),
('Inciting a disturbance or creating disorder', '5.1a','Persuading, encouraging, instigating, taunting, pressuring or threatening persons to disrupt a peaceful situation. Causing disorder or disrupting a peaceful situation.');;

DELETE FROM Level2;

INSERT INTO Level2 (infraction, code, Definition) VALUES
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
('Rasheed Carter', 'Wilmington', 'Carter.Rasheed@jobcorps.org', '235.2525', '302.230.2525'),
('Steven Ochieng', 'Excelsior Springs', 'Ochieng.steven@jobcorps.org', '135.3117', '816.629.3117'),
('Adrese Davis', 'Westover', 'Davis.adrese@jobcorps.org', '208.4049', '413.593.4049'),
('Keith White', 'ETR Rochester', 'Keith.white@etrky.com', 'N/A', '585.202.5018');

