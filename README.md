### Metigator Academy  :school:
Database for an Academy that provide trainings

``` sql
Create Database MetigatorAcademy;
Go
Use MetigatorAcademy;
```

##### + Courses  :book:
<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id | Course Name    | Price |
|----|----------------|------|
| 1  | Mathematics    |$1000.00|
| 2  | Physics        |$2000.00|
| 3  | Chemistry      |$1500.00|
| 4  | Full Stack Development        |$1200.00|
| 5  | Automation Testing |$3000.00|

</div>

``` sql

-- Courses Table
CREATE TABLE Courses (
    Id INT PRIMARY KEY,
    CourseName VARCHAR(255) NOT NULL,
    Price DECIMAL(15, 2) NOT NULL
);

    -- Inserting data for Courses
    INSERT INTO Courses (Id, CourseName, Price) VALUES (1, 'Mathematics', 1000.00);
    INSERT INTO Courses (Id, CourseName, Price) VALUES (2, 'Physics', 2000.00);
    INSERT INTO Courses (Id, CourseName, Price) VALUES (3, 'Chemistry', 1500.00);
    INSERT INTO Courses (Id, CourseName, Price) VALUES (4, 'Full Stack Development', 1200.00);
    INSERT INTO Courses (Id, CourseName, Price) VALUES (5, 'Automation Testing', 3000.00);

```

##### + Office  :book:
<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id | Office Name    | Location |
|----|----------------|----------|
| 1  | Off_05    |Building A|
| 2  | Off_12        |building B|
| 3  | Off_32      |Adminstration|
| 4  | Off_44        |IT Department|
| 5  |Off_43 |IT Department|

</div>

``` sql

-- Courses Table
CREATE TABLE Offices (
    Id INT PRIMARY KEY,
    OfficeName VARCHAR(50) NOT NULL,
    OfficeLocation VARCHAR(50) NOT NULL
);

    -- Inserting data for Offices
    INSERT INTO Courses (Id, OfficeName, OfficeLocation) VALUES (1, 'Off_05', building A);
    INSERT INTO Courses (Id, OfficeName, OfficeLocation) VALUES (2, 'Off_12', building B);
    INSERT INTO Courses (Id, OfficeName, OfficeLocation) VALUES (3, 'Off_32', Adminstration);
    INSERT INTO Courses (Id, OfficeName, OfficeLocation) VALUES (4, 'Off_44', IT Department);
    INSERT INTO Courses (Id, OfficeName, OfficeLocation) VALUES (5, 'Off_43', IT Department);

```

##### + Instructors Table :mens:

<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id | Name             | Location |
|----|------------------|----------|
| 1  | Ahmed Abdullah  | Off_05|
| 2  | Yasmeen Mohammed |Off_12|
| 3  | Khalid Hassan   |Off_32|
| 4  | Nadia Ali       |Off_44|
| 5  | Omar Ibrahim    |Off_43|
</div>

``` sql

-- Instructors Table
CREATE TABLE Instructors (
    Id INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    OfficeId INT NOT NULL REFERENCES Offices(Id),
);

    -- Inserting data for Instructors
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (1, 'Ahmed Abdullah', 1);
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (2, 'Yasmeen Mohammed', 2);
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (3, 'Khalid Hassan', 3);
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (4, 'Nadia Ali', 4);
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (5, 'Omar Ibrahim', 5);

```

##### + Schedules Table :department_store:
<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id | Title        | SUN | MON | TUE | WED | THU | FRI | SAT |
|----|--------------|-----|-----|-----|-----|-----|-----|-----|
| 1  | Daily        |  :heavy_check_mark:   |   :heavy_check_mark:  |   :heavy_check_mark:  |   :heavy_check_mark:  |   :heavy_check_mark:  |    |     |   
| 2  | DayAfterDay  |  :heavy_check_mark:   |    |    :heavy_check_mark: |    |  :heavy_check_mark:   |    |    |  
| 3  | Twice-a-Week |    |   :heavy_check_mark:  |    |  :heavy_check_mark:   |     |    |   |  
| 4  | Weekend      |     |    |    |    |    |  :heavy_check_mark:   |  :heavy_check_mark:   |  
| 5  | Compact      |  :heavy_check_mark:   | :heavy_check_mark:    | :heavy_check_mark:    |  :heavy_check_mark:   | :heavy_check_mark:    |  :heavy_check_mark:   |   :heavy_check_mark:  |  

</div>


``` sql
-- Schedules Table
CREATE TABLE Schedules
(
    Id INT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    SUN BIT NOT NULL,
    MON BIT NOT NULL,
    TUE BIT NOT NULL,
    WED BIT NOT NULL,
    THU BIT NOT NULL,
    FRI BIT NOT NULL,
    SAT BIT NOT NULL
);

    -- Inserting data for Schedules
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (1, 'Daily', 1, 1, 1, 1, 1, 0, 0);
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (2, 'DayAfterDay', 1, 0, 1, 0, 1, 0, 0);
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (3, 'Twice-a-Week', 0, 1, 0, 1, 0, 0, 0);
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (4, 'Weekend', 0, 0, 0, 0, 0, 1, 1);
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (5, 'Compact', 1, 1, 1, 1, 1, 1, 1);
```

##### + Sections Table :department_store:

<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id | Course Name    | Section Name   | Instructor Name  | ScheduleTitle | Start Time | End Time | SUN | MON | TUE | WED | THU | FRI | SAT |
|----|----------------|----------------|------------------|---------------|------------|----------|-----|-----|-----|-----|-----|-----|-----|
| 1  | Mathematics    |    S_MA1       | Ahmed Abdullah   |  DayAfterDay  | 10:00:00   | 12:00:00 |  :heavy_check_mark:  |  :heavy_check_mark: |  :heavy_check_mark:  |  :heavy_check_mark:  |:heavy_check_mark:  
| 2  | Mathematics    |    S_MA2       | Yasmeen Mohammed |  Twice-a-Week | 14:00:00   | 16:00:00 |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |    |
| 3  | Physics        |    S_PH1       | Ahmed Abdullah   |  Weekend      | 16:00:00   | 18:00:00 |    |    |    |    |    |  :heavy_check_mark:  |  :heavy_check_mark:  |
| 4  | Physics        |    S_PH2       | Khalid Hassan    |  Daily        | 08:00:00   | 10:00:00 |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |    |    |
| 5  | Chemistry      |    S_CH1       | Yasmeen Mohammed |  Daily        | 10:00:00   | 12:00:00 |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |    |    |
| 6  | Chemistry      |    S_CH2       | Khalid Hassan    |  DayAfterDay  | 14:00:00   | 16:00:00 |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |
| 7  | Biology        |    S_FSD       | Nadia Ali        |  Twice-a-Week | 16:00:00   | 18:00:00 |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |    |
| 8  | Biology        |    S_AUT       | Omar Ibrahim     |  Weekend      | 08:00:00   | 10:00:00 |    |    |    |    |    |  :heavy_check_mark:  |  :heavy_check_mark:  |
| 9  | CS50           |    S_FSD        | Nadia Ali        |  Weekend      | 10:00:00   | 15:00:00 |    |    |    |    |    |  :heavy_check_mark:  |  :heavy_check_mark:  |
| 10 | CS50           |    S_AUT       | Omar Ibrahim     |  Twice-a-Week | 14:00:00   | 16:00:00 |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |    |
| 11 | CS50           |    S_FSD        | Nadia Ali     |  Compact | 09:00:00   | 11:00:00 |  :heavy_check_mark:   |  :heavy_check_mark:  | :heavy_check_mark:    |  :heavy_check_mark:  |  :heavy_check_mark:   |  :heavy_check_mark:   |  :heavy_check_mark:   |
</div>

``` sql

-- sections table
CREATE TABLE Sections (
    Id INT PRIMARY KEY,
    SectionName VARCHAR(50) NOT NULL,
    StartTime time(7) NOT NULL,
    EndTime time(7) NOT NULL,
    ScheduleId INT NOT NULL REFERENCES Schedules(Id)
    CourseId INT,
    InstructorId INT,
    FOREIGN KEY (CourseId) REFERENCES Courses(Id),
    FOREIGN KEY (InstructorId) REFERENCES Instructors(Id)
);

    -- indexes
    CREATE INDEX idx_sections_course_id ON Sections (CourseId);
    CREATE INDEX idx_sections_instructor_id ON Sections (InstructorId);

    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (1, 'S_MA1', 1, 1, 1, '08:00:00', '10:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (2, 'S_MA2', 1, 2, 3, '14:00:00', '18:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (3, 'S_PH1', 2, 1, 4, '10:00:00', '15:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (4, 'S_PH2', 2, 3, 1, '10:00:00', '12:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (5, 'S_CH1', 3, 2, 1, '16:00:00', '18:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (6, 'S_CH2', 3, 3, 2, '08:00:00', '10:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (7, 'S_FSD', 4, 4, 3, '11:00:00', '14:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (8, 'S_AUT', 4, 5, 4, '10:00:00', '14:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (9, 'S_FSD', 5, 4, 4, '16:00:00', '18:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (10,'S_AUT', 5, 5, 3, '12:00:00', '15:00:00');
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId, ScheduleId, StartTime, EndTime) VALUES (11,'S_FSD', 5, 4, 5, '09:00:00', '11:00:00');
```
#### Student Table 
1) Student Table to be renamed to participant
2) Two type of participant (individual, corporate)



  ```csharp
// Participant Table
public abstract class Participant
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Individual (الأفراد)
public class IndividualParticipant : Participant
{
    public string Major {get; set;}
}

// Corporate (الشركات)dfd
public class CorporateParticipant : Participant
{
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public string GroupNo { get; set; }
}


  ```
  
##### TPH (1 table per heirarchy)

<div style="padding: 10px; font-size: 10px; font-weight: bold">

#### Participant Table 

| Id   |         Name   | Participant_Type  | Major|  Company |  JobTitle  |  GroupNo |
|------|----------------|-------------------| -----| ---------|------------|----------|
| 1    | Fatima Ali     |     I             |  CS  |          |            |          |
| 2    | Noor Saleh     |     C             |  BIS |          |            |          |
| 3    | Omar Youssef   |     I             |      |   ABC    |  Developer |   G01    |
| 4    | Huda Ahmed     |     C             |      |   ABC    |  Developer |   G01    |
| 5    | Amira Tariq    |     I             |  CS  |          |            |          |
| 6    | Zainab Ismail  |     I             |  CS  |          |            |          |
| 7    | Yousef Farid   |     C             |      |   EFG    |   QA       |   G02    |
| 8    | Layla Mustafa  |     C             |      |   EFG    |   QA       |   G02    | 
| 9    | Mohammed Adel  |     I             |  MIS |          |            |          |
| 10   | Samira Nabil   |     I             |  CS  |          |            |          |

</div>


##### TPT (1 table per type)

<div style="padding: 10px; font-size: 10px; font-weight: bold">

#### Participant Table 


| Id   | Student Name   |
|------|----------------|
| 1    | Fatima Ali     |
| 2    | Noor Saleh     |
| 3    | Omar Youssef   |
| 4    | Huda Ahmed     |
| 5    | Amira Tariq    |
| 6    | Zainab Ismail  |
| 7    | Yousef Farid   |
| 8    | Layla Mustafa  |
| 9    | Mohammed Adel  |
| 10   | Samira Nabil   |
 
#### IndividualParticipant Table 

| Id    | Major  | PId(FK) |
|-------|--------|---------|
| 1     |   CS   | 1       |
| 2     |   BIS  | 2       |
| 3     |   CS   | 5       |
| 4     |   CS   | 6       | 
| 5     |   MIS  | 9       |
| 6     |   CS   | 10      |
    
#### CorporateParticipant Table 

| Id    | Company |  JobTitle | GroupNo | PId |
|-------|---------|-----------|---------|-----|
| 1     |   ABC   | Developer |   G01   | 3   |
| 2     |   ABC   | Developer |   G01   | 4   |
| 3     |   EFG   |    QA     |   G02   | 7   |
| 4     |   EFG   |    QA     |   G02   | 8   |

</div>

##### TPC (1 table per concrete type)

<div style="padding: 10px; font-size: 10px; font-weight: bold">

#### Participant Table 


| Id   | Student Name   |
|------|----------------|
| 1    | Fatima Ali     |
| 2    | Noor Saleh     |
| 3    | Omar Youssef   |
| 4    | Huda Ahmed     |
| 5    | Amira Tariq    |
| 6    | Zainab Ismail  |
| 7    | Yousef Farid   |
| 8    | Layla Mustafa  |
| 9    | Mohammed Adel  |
| 10   | Samira Nabil   |
 
#### IndividualParticipant Table 

| Id    | Major  | PId(FK) |
|-------|--------|---------|
| 1     |   CS   | 1       |
| 2     |   BIS  | 3       |
| 3     |   CS   | 5       |
| 4     |   CS   | 6       | 
| 5     |   MIS  | 9       |
| 6     |   CS   | 10      |
    
#### CorporateParticipant Table 

| Id    | Company |  JobTitle | GroupNo | PId |
|-------|---------|-----------|---------|-----|
| 1     |   ABC   | Developer |   G01   | 2   |
| 2     |   EFG   | Developer |   G02   | 4   |
| 3     |   ABC   |    QA     |   G01   | 7   |
| 4     |   EFG   |    QA     |   G02   | 8   |

</div>

#### + Student Enrollment :man: :girl:
  


<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Section Name | Participant    |
|--------------|----------------|
| S_MA2        | Fatima Ali     |
| S_MA2        | Noor Saleh     |
| S_PH1        | Omar Youssef   |
| S_PH1        | Huda Ahmed     |
| S_PH2        | Amira Tariq    |
| S_PH2        | Zainab Ismail  |
| S_BI1        | Yousef Farid   |
| S_BI1        | Layla Mustafa  |
| S_CS1        | Mohammed Adel  |
| S_CS2        | Samira Nabil   |

</div>

``` sql

-- Students Table
CREATE TABLE Students (
    Id INT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
);

    -- Inserting data for Students
    INSERT INTO Students (Id, Name) VALUES (1, 'Fatima Ali');
    INSERT INTO Students (Id, Name) VALUES (2, 'Noor Saleh');
    INSERT INTO Students (Id, Name) VALUES (3, 'Omar Youssef');
    INSERT INTO Students (Id, Name) VALUES (4, 'Huda Ahmed');
    INSERT INTO Students (Id, Name) VALUES (5, 'Amira Tariq');
    INSERT INTO Students (Id, Name) VALUES (6, 'Zainab Ismail');
    INSERT INTO Students (Id, Name) VALUES (7, 'Yousef Farid');
    INSERT INTO Students (Id, Name) VALUES (8, 'Layla Mustafa');
    INSERT INTO Students (Id, Name) VALUES (9, 'Mohammed Adel');
    INSERT INTO Students (Id, Name) VALUES (10, 'Samira Nabil');


-- Enrollments Table
CREATE TABLE Enrollments (
    ParticipantId INT,
    SectionId INT,
    PRIMARY KEY (ParticipantId, SectionId),
    FOREIGN KEY (ParticipantId) REFERENCES Participants(Id),
    FOREIGN KEY (SectionId) REFERENCES Sections(Id)
);


    -- indexes
    CREATE INDEX idx_enrollments_section_id ON Enrollments (SectionId);

    -- Inserting data for Enrollments
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (1, 6);
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (2, 6);
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (3, 7);
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (4, 7);
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (5, 8);
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (6, 8);
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (7, 9);
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (8, 9);
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (9, 10);
    INSERT INTO Enrollments (ParticipantId, SectionId) VALUES (10, 10);

```
