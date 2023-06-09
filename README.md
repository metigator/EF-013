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
| 7  | Full Stack Dev.        |    S_FSD       | Nadia Ali        |  Twice-a-Week | 16:00:00   | 18:00:00 |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |    |
| 8  |  Automation Test.        |    S_AUT       | Omar Ibrahim     |  Weekend      | 08:00:00   | 10:00:00 |    |    |    |    |    |  :heavy_check_mark:  |  :heavy_check_mark:  |
| 9  | Full Stack Dev.           |    S_FSD        | Nadia Ali        |  Weekend      | 10:00:00   | 15:00:00 |    |    |    |    |    |  :heavy_check_mark:  |  :heavy_check_mark:  |
| 10 | Automation Test.           |    S_AUT       | Omar Ibrahim     |  Twice-a-Week | 14:00:00   | 16:00:00 |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |    |
| 11 | Full Stack Dev.           |    S_FSD        | Nadia Ali     |  Compact | 09:00:00   | 11:00:00 |  :heavy_check_mark:   |  :heavy_check_mark:  | :heavy_check_mark:    |  :heavy_check_mark:  |  :heavy_check_mark:   |  :heavy_check_mark:   |  :heavy_check_mark:   |
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

```

#### Student Table 

>> Requirement 

1) Student Table to be renamed to participant
2) Two type of participant (individual, corporate)



  ```csharp
// Participant Table
-- Students Table
public class Participants 
{
    public int Id {get; set;}
    public string FName {get; set;}
    public string LName {get; set;}
}

// Individual (الأفراد)
public class IndividualParticipant : Participant
{
    public string University {get; set;}
    public int YearOfGraduation {get; set;}
    public bool IsIntern {get; set;}
}

// Corporate (الشركات)dfd
public class CorporateParticipant : Participant
{
    public string Company { get; set; }
    public string JobTitle { get; set; } 
}

  ```
  
  
> TPH (1 table per heirarchy)


<div style="padding: 10px; font-size: 10px; font-weight: bold">

* Participant Table 

| Id   |FName| LName| Participant_Type |University | Year Of Graduation| IsIntern|  Company |  JobTitle  |
|------|------|-----------|------------|-------| -----| ---|------|------------|
| 1    | Fatima| Ali     |     I       |  XYZ    |  2024  |   |       |            |
| 2    | Noor |Saleh     |     C        | POQ    |  2023 |  :heavy_check_mark: |       |
| 3    | Omar| Youssef   |     I       |      |      |   |ABC    |  Developer |
| 4    | Huda| Ahmed     |     C       |      |      |   |ABC    |  Developer |
| 5    | Amira |Tariq    |     I        |  POQ   |  2025  |   |        |            |
| 6    | Zainab |Ismail  |     I        |  POQ   |  2023  | :heavy_check_mark:  |       |
| 7    | Yousef| Farid   |     C        |     |      |   |EFG    |   QA       |
| 8    | Layla| Mustafa  |     C        |     |      |   |EFG    |   QA       |  
| 9    | Mohammed| Adel  |     I        |  XYZ   |  2024 |   |       |            |
| 10   | Samira| Nabil   |     I        | XYZ    |  2024  |   |       |            |

</div>



```sql
CREATE TABLE Participants (
    Id INTEGER NOT NULL PRIMARY KEY,
    FName NVARCHAR(50) NOT NULL,
    LName NVARCHAR(50) NOT NULL,
    ParticipantType VARCHAR(1) NOT NULL,
    University NVARCHAR(50) NULL,
    YearOfGraduation INT NULL,
    IsIntern bit NULL,
    Company NVARCHAR(50) NULL,
    JobTitle NVARCHAR(50) NULL
);
```




> TPT Table Per Type (1 table per type)



* Participant Table 
<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id   |FName| LName|
|------|------|-----------|
| 1    | Fatima| Ali     | 
| 2    | Noor |Saleh     | 
| 3    | Omar| Youssef   |
| 4    | Huda| Ahmed     |
| 5    | Amira |Tariq    |
| 6    | Zainab |Ismail  |
| 7    | Yousef| Farid   |
| 8    | Layla| Mustafa  |
| 9    | Mohammed| Adel  |
| 10   | Samira| Nabil   |

</div>



```sql
-- Participants
CREATE TABLE Participants (
    Id INT PRIMARY KEY,
    FName NVARCHAR(50) NOT NULL
);
```


* Individual Table 


<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id    | University  | Year Of Graduation | IsIntern | ParticipantId (FK)|
|-------|--------|---------|---------|---------|
| 1     |   XYZ   | 2024       | | 1|
| 2     |   POQ  | 2023       |:heavy_check_mark:| 2|
| 3     |   POQ   | 2025       || 5|
| 4     |   POQ   | 2023       | :heavy_check_mark:| 5|
| 5     |   XYZ  | 2024      || 9|
| 6     |   XYZ   | 2024     || 10|
    
</div>

```sql
-- Individual
    CREATE TABLE IndividualParticipants (
    Id INT  PRIMARY KEY, 
    University NVARCHAR(50) NULL,
    YearOfGraduation INT NULL,
    IsIntern bit NULL,
    ParticipantId INT NOT NULL REFERENCES Participants("Id")
);
```
    
* Corporate Table 

<div style="padding: 10px; font-size: 10px; font-weight: bold">
    
| Id    | Company |  JobTitle |  ParticipantId |
|-------|---------|-----------|-----|
| 1     |   ABC   | Developer |  3   |
| 2     |   ABC   | Developer | 4   |
| 3     |   EFG   |    QA     | 7   |
| 4     |   EFG   |    QA     | 8   |

</div>

```sql
-- Corporate
    CREATE TABLE Corporates (
    Id INT  PRIMARY KEY,
    Company NVARCHAR(50) NOT NULL
    JobTitle NVARCHAR(50) NOT NULL 
    ParticipantId INT NOT NULL REFERENCES Participants("Id")
);
```

> TPC Table Per Concrete Type (1 table per concrete type)

<div style="padding: 10px; font-size: 10px; font-weight: bold">

* Individual Table 

| Id   |FName| LName| University  | Year Of Graduation | IsIntern |
|------|------|-----------|--------|---------|---------|
| 1    | Fatima| Ali     |    XYZ   | 2024       | |
| 2    | Noor |Saleh     |    POQ  | 2023       |:heavy_check_mark:|
| 5    | Amira |Tariq    |   POQ   | 2025       |
| 6    | Zainab |Ismail  |   POQ   | 2023       | :heavy_check_mark:|
| 9    | Mohammed| Adel  |   XYZ  | 2024      ||
| 10   | Samira| Nabil   |   XYZ   | 2024     ||

    
    
```sql
-- Individuals
    CREATE TABLE Individual (
    Id INTEGER NOT NULL PRIMARY KEY,
    FName NVARCHAR(50) NOT NULL,
    LName NVARCHAR(50) NOT NULL, 
    University NVARCHAR(50) NOT NULL,
    YearOfGraduation INT NOT NULL,
    IsIntern bit NOT NULL,
);
```


* Corporates Table 

| Id   |FName| LName|        Company |  JobTitle |
|------|------|-----------|---------|-----------|
| 3    | Omar| Youssef   |   ABC   | Developer |
| 4    | Huda| Ahmed     |   ABC   | Developer |
| 7    | Yousef| Farid   |   EFG   |    QA     |
| 8    | Layla| Mustafa  |   EFG   |    QA     |



</div>

```sql
-- CorporateParticipants
    CREATE TABLE CorporateParticipants (
    Id INT  PRIMARY KEY,
    FName NVARCHAR(50) NOT NULL,
    LName NVARCHAR(50) NOT NULL, 
    Company NVARCHAR(50) NOT NULL,
    JobTitle NVARCHAR(50) NOT NULL
);
```


#### + Participant Enrollment :man: :girl:
  

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

-- Enrollments Table
CREATE TABLE Enrollments (
    ParticipantId INT,
    SectionId INT,
    PRIMARY KEY (ParticipantId, SectionId),
    FOREIGN KEY (ParticipantId) REFERENCES Participants(Id),
    FOREIGN KEY (SectionId) REFERENCES Sections(Id)
);

```
