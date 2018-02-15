
CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Studentnumber] VARCHAR(50) NOT NULL, 
    [Firstname] VARCHAR(50) NOT NULL, 
    [Lastname] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [Phonenumber] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Course]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Coursenumber] VARCHAR(50) NOT NULL, 
    [Title] VARCHAR(50) NOT NULL, 
    [Teacher] VARCHAR(50) NOT NULL 
)

CREATE TABLE [dbo].[Student_Course]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [StudentId] INT NOT NULL, 
    [CourseId] INT NOT NULL, 
    [Timestamp] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Student_Course_toStudent] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student]([Id]), 
    CONSTRAINT [FK_Student_Course_toCourse] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course]([Id]) 
)


CREATE TABLE [dbo].[Course_Week]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CourseId] INT NOT NULL, 
    [Date] VARCHAR(50) NOT NULL, 
    [Title] VARCHAR(50) NOT NULL, 
    [Week_objective] VARCHAR(500) NOT NULL, 
    [Description] VARCHAR(500) NOT NULL, 
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
VALUES (1,'18.8.2017', 'Introduction', 'Introduction to Maven & Spring Boot, First Spring Boot Project, Controllers & Routing, Request parameters', 'Week 1 text....'),
(1,'25.8.2017', 'Model & View', 'Views, Thymeleaf, Model', 'Week 2 text...'),
(1,'02.9.2017', 'Database', 'ORM (JPA), JDBC, H2 database', 'Week 3 text...'),
(1,'09.9.2017', 'REST service', 'REST service with Spring', 'Week 4 text...')



