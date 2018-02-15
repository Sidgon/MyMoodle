
CREATE TABLE [dbo].[Student]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Studentnumber] VARCHAR(50) NOT NULL, 
    [Firstname] VARCHAR(50) NOT NULL, 
    [Lastname] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [Phonenumber] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Course]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [Coursenumber] VARCHAR(50) NOT NULL, 
    [Title] VARCHAR(50) NOT NULL, 
    [Teacher] VARCHAR(50) NOT NULL 
)

CREATE TABLE [dbo].[Student_Course]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [StudentId] INT NOT NULL, 
    [CourseId] INT NOT NULL, 
    [Timestamp] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Student_Course_toStudent] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student]([Id]), 
    CONSTRAINT [FK_Student_Course_toCourse] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course]([Id]) 
)


CREATE TABLE [dbo].[Course_Week]
(
	[Id] INT IDENTITY (1, 1) NOT NULL, 
    [CourseId] INT NOT NULL, 
    [Date] VARCHAR(50) NOT NULL, 
    [Title] VARCHAR(50) NOT NULL, 
    [Week_objective] VARCHAR(500) NOT NULL, 
    [Description] VARCHAR(1000) NOT NULL, 
    CONSTRAINT [FK_Course_Week_Course] FOREIGN KEY ([CourseId]) REFERENCES [Course]([Id]), 
    
	)

GO
INSERT INTO [dbo].[Student]
VALUES ('a8975321', 'admin', 'David', 'Gsponer', 'St. Jodernstrasse 12', '+3586457895'),
('a723156', 'admin', 'Anton', 'Haufen', 'Hubelstrasse 73', '+3584681354'),
('a7895643', 'admin', 'Joey', 'Seed', 'Berchtoldstrasse 13', '+3587823256'),
('a1235464', 'admin', 'Matthias', 'Poner', 'Klaneettitie 1B 062', '+3582579866')


INSERT INTO [dbo].[Course]
VALUES ('BITE7896', 'Server Programming', 'Juha Hinkula'),
('BITE6548', 'Mobile Programming', 'Juha Hinkula'),
('BITE2356', 'Multidisciplinary Software Project', 'Juhani Välimäki'),
('BITE7896', 'Thesis Seminar', 'Juhani Välimäki')

INSERT INTO [dbo].[Student_Course]
VALUES (1, 1, '18.08.2017'),
(2, 1, '18.08.2017'),
(3, 1, '18.08.2017'),
(1, 2, '18.08.2017')

INSERT INTO [dbo].[Course_Week]
VALUES (1,'18.8.2017', 'Introduction', 'Introduction to Maven & Spring Boot, First Spring Boot Project, Controllers & Routing, Request parameters', 'Annuities have become an extraordinarily popular alternative investment for retirement income planning in modern times, but they are not new. In fact, annuities can actually trace their origins back to Roman times.
Annuity contracts during the Emperor’s time were known as annua, or “annual stipends” in Latin. Back then, Roman citizens would make a one-time payment to the annua, in exchange for lifetime payments made once a year. Annuity comes from the Latin word annuus, meaning yearly.'),
(1,'25.8.2017', 'Model & View', 'Views, Thymeleaf, Model', 'During the 17th century, annuities were used as fundraising vehicles. In Europe, governments were constantly looking for revenue to pay for massive, on-going battles with neighboring countries.'),
(1,'02.9.2017', 'Database', 'ORM (JPA), JDBC, H2 database', 'The United Kingdom, locked in many wars with France, started one of the first group annuity contracts called the State of Tontine of 1693. Participants in these early government annuities would purchase a share of the Tontine for £100 from the UK Government.'),
(1,'09.9.2017', 'REST service', 'REST service with Spring', 'In return, the owner of the share received an annuity during the lifetime of their nominated person (often a child). As each nominee died, the annuity for the remaining proprietors gradually became larger and larger. This growth and division of wealth would continue until there were no nominees left. Proprietors could assign their annuities to other parties by deed or will, or they passed on at death to the next of kin.'),

(2,'18.8.2017', 'Introduction', 'Introduction to Mobile Programming', 'Annuities have become an extraordinarily popular alternative investment for retirement income planning in modern times, but they are not new. In fact, annuities can actually trace their origins back to Roman times.
Annuity contracts during the Emperor’s time were known as annua, or “annual stipends” in Latin. Back then, Roman citizens would make a one-time payment to the annua, in exchange for lifetime payments made once a year. Annuity comes from the Latin word annuus, meaning yearly.'),
(2,'25.8.2017', 'Phonegap', 'Views, Model', 'During the 17th century, annuities were used as fundraising vehicles. In Europe, governments were constantly looking for revenue to pay for massive, on-going battles with neighboring countries.'),
(2,'02.9.2017', 'Database', 'MySQL', 'The United Kingdom, locked in many wars with France, started one of the first group annuity contracts called the State of Tontine of 1693. Participants in these early government annuities would purchase a share of the Tontine for £100 from the UK Government.'),
(2,'09.9.2017', 'REST service', 'REST service Phonegap', 'In return, the owner of the share received an annuity during the lifetime of their nominated person (often a child). As each nominee died, the annuity for the remaining proprietors gradually became larger and larger. This growth and division of wealth would continue until there were no nominees left. Proprietors could assign their annuities to other parties by deed or will, or they passed on at death to the next of kin.'),

(3,'18.8.2017', 'Introduction', 'Introduction to React, React native and Redux', 'Annuities have become an extraordinarily popular alternative investment for retirement income planning in modern times, but they are not new. In fact, annuities can actually trace their origins back to Roman times.
Annuity contracts during the Emperor’s time were known as annua, or “annual stipends” in Latin. Back then, Roman citizens would make a one-time payment to the annua, in exchange for lifetime payments made once a year. Annuity comes from the Latin word annuus, meaning yearly.'),
(3,'25.8.2017', 'React', 'Understand basic functionalities', 'During the 17th century, annuities were used as fundraising vehicles. In Europe, governments were constantly looking for revenue to pay for massive, on-going battles with neighboring countries.'),
(3,'02.9.2017', 'React-native', 'Able to code components', 'The United Kingdom, locked in many wars with France, started one of the first group annuity contracts called the State of Tontine of 1693. Participants in these early government annuities would purchase a share of the Tontine for £100 from the UK Government.'),
(3,'09.9.2017', 'Redux', 'Understand the usability of Redux', 'In return, the owner of the share received an annuity during the lifetime of their nominated person (often a child). As each nominee died, the annuity for the remaining proprietors gradually became larger and larger. This growth and division of wealth would continue until there were no nominees left. Proprietors could assign their annuities to other parties by deed or will, or they passed on at death to the next of kin.'),

(4,'18.8.2017', 'Introduction', 'What is a thesis', 'Annuities have become an extraordinarily popular alternative investment for retirement income planning in modern times, but they are not new. In fact, annuities can actually trace their origins back to Roman times.
Annuity contracts during the Emperor’s time were known as annua, or “annual stipends” in Latin. Back then, Roman citizens would make a one-time payment to the annua, in exchange for lifetime payments made once a year. Annuity comes from the Latin word annuus, meaning yearly.'),
(4,'25.8.2017', 'Thesis structure', 'Understanding a Thesis structure', 'During the 17th century, annuities were used as fundraising vehicles. In Europe, governments were constantly looking for revenue to pay for massive, on-going battles with neighboring countries.'),
(4,'02.9.2017', 'Types of Thesis', 'Understanding the different Thesis types', 'The United Kingdom, locked in many wars with France, started one of the first group annuity contracts called the State of Tontine of 1693. Participants in these early government annuities would purchase a share of the Tontine for £100 from the UK Government.'),
(4,'09.9.2017', 'Topic proposel', 'How to find a topic, how to write a topic proposel', 'In return, the owner of the share received an annuity during the lifetime of their nominated person (often a child). As each nominee died, the annuity for the remaining proprietors gradually became larger and larger. This growth and division of wealth would continue until there were no nominees left. Proprietors could assign their annuities to other parties by deed or will, or they passed on at death to the next of kin.')

