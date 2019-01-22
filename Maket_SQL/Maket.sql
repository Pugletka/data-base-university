
IF DB_ID('Maket') IS NULL
CREATE DATABASE Maket;
USE Maket;

-- ��
IF OBJECT_ID('dbo.EI', 'U') IS NOT NULL
DROP TABLE dbo.EI;
CREATE TABLE dbo.EI (
idEI BIGINT IDENTITY (1,1) CONSTRAINT PK_EI PRIMARY KEY,
NameEI VARCHAR (100) NOT NULL,
YearOfFoundation VARCHAR (4) NOT NULL,
AddressEI VARCHAR (100) NOT NULL,
UNIQUE (NameEI),
);

--���������� 
IF OBJECT_ID('dbo.Faculties', 'U') IS NOT NULL
DROP TABLE dbo.Faculties;
CREATE TABLE dbo.Faculties (
idFaculties BIGINT IDENTITY (1,1) CONSTRAINT PK_Faculties PRIMARY KEY,
idEI BIGINT NOT NULL, 
NameFac VARCHAR (100) NOT NULL,
YearOfFoundation VARCHAR (4) NOT NULL,
LINK varchar(30) NULL,
UNIQUE (NameFac),
);


--�������
IF OBJECT_ID('dbo.Departments', 'U') IS NOT NULL
DROP TABLE dbo.Departments;
CREATE TABLE dbo.Departments (
idDepartments BIGINT IDENTITY (1,1) CONSTRAINT PK_Departments PRIMARY KEY,
idFaculties BIGINT NOT NULL, 
NameDep VARCHAR (100) NOT NULL,
YearOfFoundation VARCHAR (4) NOT NULL,
Number VARCHAR (11) NULL,
UNIQUE (NameDep),
);

-- ������
IF OBJECT_ID('dbo.Groups', 'U') IS NOT NULL
DROP TABLE dbo.Groups;
CREATE TABLE dbo.Groups (
idGroups BIGINT IDENTITY (1,1) CONSTRAINT PK_Groups PRIMARY KEY,
IndexGroup VARCHAR (10) NOT NULL,
idDepartments BIGINT NOT NULL,
SurnameOfMonitor VARCHAR (25) NOT NULL,
NameOfMonitor VARCHAR (25) NOT NULL,
PatronymicOfMonitor VARCHAR (25) NULL,
UNIQUE (IndexGroup),
);

-- ��������
IF OBJECT_ID('dbo.Learners', 'U') IS NOT NULL
DROP TABLE dbo.Learners;
CREATE TABLE dbo.Learners (
idLearners BIGINT IDENTITY (1,1) CONSTRAINT PK_Learners PRIMARY KEY,
idGroups BIGINT NOT NULL,
Surname VARCHAR (25) NOT NULL,
NameLearner VARCHAR (25) NOT NULL,
Patronymic VARCHAR (25) NULL,
);
-- �����������
IF OBJECT_ID('dbo.Administration', 'U') IS NOT NULL
DROP TABLE dbo.Administration;
CREATE TABLE dbo.Administration(
idAdministration BIGINT IDENTITY (1,1) CONSTRAINT PK_Administration PRIMARY KEY,
idEI BIGINT NOT NULL, 
Surname VARCHAR (25) NOT NULL,
NameAdmin VARCHAR (25) NOT NULL,
Patronymic VARCHAR (25) NULL,
Position VARCHAR (100) NOT NULL,
Salary MONEY NULL, 
);

-- ����������
IF OBJECT_ID('dbo.Employees', 'U') IS NOT NULL
DROP TABLE dbo.Employees;
CREATE TABLE dbo.Employees (
idEmployees BIGINT IDENTITY (1,1) CONSTRAINT PK_Employees PRIMARY KEY,
idDepartments BIGINT NULL, 
Surname VARCHAR (25) NOT NULL,
NameEmp VARCHAR (25) NOT NULL,
Patronymic VARCHAR (25) NULL,
Position VARCHAR (100) NOT NULL,
AcademicDegree VARCHAR (100) NULL,
AcademicTitle VARCHAR (100) NULL,
);

-- ������
IF OBJECT_ID('dbo.Reading', 'U') IS NOT NULL
DROP TABLE dbo.Reading;
CREATE TABLE dbo.Reading (
idReading BIGINT IDENTITY (1,1) CONSTRAINT PK_Reading PRIMARY KEY,
idEmployees BIGINT NOT NULL, 
idSubjects BIGINT NOT NULL,
);


-- ����������
IF OBJECT_ID('dbo.Subjects', 'U') IS NOT NULL
DROP TABLE dbo.Subjects;
CREATE TABLE dbo.Subjects (
idSubjects BIGINT IDENTITY (1,1) CONSTRAINT PK_Subjects PRIMARY KEY,
NameofSubject VARCHAR (100) NOT NULL,
);

-- ����� --
ALTER TABLE dbo.Faculties
ADD CONSTRAINT FK_Faculties_EI
FOREIGN KEY (idEI) 
REFERENCES EI (idEI);

ALTER TABLE dbo.Administration
ADD CONSTRAINT FK_Administration_EI
FOREIGN KEY (idEI) 
REFERENCES EI (idEI);

ALTER TABLE dbo.Groups
ADD CONSTRAINT FK_Groups_Departments
FOREIGN KEY (idDepartments) 
REFERENCES Departments (idDepartments);

ALTER TABLE dbo.Employees
ADD CONSTRAINT FK_Employees_Departments
FOREIGN KEY (idDepartments) 
REFERENCES Departments (idDepartments);

ALTER TABLE dbo.Learners
ADD CONSTRAINT FK_Learners_Groups
FOREIGN KEY (idGroups) 
REFERENCES Groups (idGroups);

ALTER TABLE dbo.Departments
ADD CONSTRAINT FK_Departments_Faculties
FOREIGN KEY (idFaculties) 
REFERENCES Faculties (idFaculties);

ALTER TABLE dbo.Reading
ADD CONSTRAINT FK_Reading_Employees
FOREIGN KEY (idEmployees) 
REFERENCES Employees (idEmployees);

ALTER TABLE dbo.Reading
ADD CONSTRAINT FK_Reading_Subjects
FOREIGN KEY (idSubjects)
REFERENCES Subjects (idSubjects);

-- ���������� ������ -- 

SELECT * FROM EI

INSERT INTO EI VALUES('���� ����� �. �. �������', 1830,'2-� ���������� ��., 5, ������, 105005');
INSERT INTO EI VALUES('��� ����� �.�. ����������', 1755,'��. ��������� ����, 1, ������, 119991');
INSERT INTO EI VALUES('����', 1946 ,'�. ������������, ������������ ��������,���������� �������, �.9 141701');
INSERT INTO EI VALUES('���� ����� �. �. ��������',1930 ,'����� ��������� ��., 8�2, ������, 119992');

SELECT * FROM Faculties

INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'����������� � ������� ����������', 1988 ,'http://iu.bmstu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'����������� ��������������',1938,'http://www.sm.bmstu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'���������������� � �������� �������',1987,'http://rlm.bmstu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'����������� ���������',1755,'http://www.law.msu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'����������� ���������',1755,'http://www.philos.msu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'��������� ����� � ���������� ������',1951,'http://����.��/index.php');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (2,'��������� ��������� � ������� ����������',2000,'https://mipt.ru/diht/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (3,'�������� ���������',1758,'https://sechenov.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (4,'������-���������������� ���������',1930,'https://sechenov.ru/univers/');

SELECT * FROM Departments

INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (1,'������� ��������� ���������� � ����������', 1938 ,81545487512);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (1,'����������� ����������� ��� � �������������� ����������',1989,84712185215);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (1,'������ ������',2007 ,85757817886  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (2,'����������� �������� � ������ ��������',1948 ,82451785754);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (2,'��������������� �������',1960 ,85557575747);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (3,'�������� � ������-����������� �������',1998 ,85577858477 );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (3,'���������� ���������������',1992 ,82542574157  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (12,'������� ����������������� �����',1954 ,84514545457  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (13,'������� ������',1947 ,87574854757  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (13,'������� ��������� ����� � ������������',2008 ,87575757571  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (14,'������������� ����������� � ��������� ������ ����',2012 ,85857575757);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (15,'������� ������ ����������� � ����� � �����������',1942 ,84575178578);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (16,'������� ����������, ��������� � �����������',1863 ,87757575778);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (17,'������� ������������',1764 ,87578587578 );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (17,'������� ����������� �������� � ������������ ��������',2009 ,87857575875);

SELECT * FROM Groups 

INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��5-41',31 , '������', '����', '���������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��5-42',31, '�����������', '������', ' ');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��5-43',31, '��������', '���������', '����������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��5-44',31, '��������', '����', '��������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��7-41',32, '����', '��������', '������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��11-11�',33, '����', '�����', ' ');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��6-12',34, '�����', '�����', '����������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��2-64',35, '������', '����', '�������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��2-42',36, '�����', '������', '����������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��6-32',37, '�����', '���', '-');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��1-11',46, '���������', '��', '���');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��2-7�',47, '����', '����', '����');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('���-001',48, '��', '���', '���');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('��4-002',49, '������', '�����', '������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('���-22',50, '�������', '�����', '���������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('���1-01',51, '�������', '����', '��������');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('���2-02',52, '������', '����', ' ');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('���4-44',53, '������', '����', ' ');

SELECT * FROM Learners

INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '����������', '�������', '����������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '��������', '�����', '������������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '������', '������', '������ ����');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '���������', '������', '���������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '���������', '����', '���������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '�����', '�����', '����������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '�������', '���������', '�����������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '������', '����', '���������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '�������', '�������', '�������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, '���������', '���������', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '��������', '������', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '�����������', '������', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '������', '���������', '�����������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '�������', '����', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '��������', '�����', '���������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '������', '������', '����������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '�������', '������', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '��������', '����', '��� ����');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '�������', '����', '�������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , '�������', '����', '����������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (5, '��������', '���������', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (5, '�������� ', ' ���������', '����������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (5, '������', '�����', '��������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (6, '�������', '�������', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (6, '��������', '����', '���������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (6, '���������', '����', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (7, '��������', '�������', '�������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (7, '����', '��������', '������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (8, '����', '�����', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (8, '������', '���', '��������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (9, '�����', '�����', '�����������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (9, '��������', '���', '�����������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (10, '������', '����', '��������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (11, '�����', '������', '����������');;
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (12, '�����', '���', '-');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (13, '���������', '��', '���');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (14, '����', '����', '����');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (15, '��', '���', '���');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (16, '������', '�����', '������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (17, '�������', '�����', '���������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (18, '�������', '����', '��������');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (19,'������', '����', ' ');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (37, '������', '����', ' ');

SELECT * FROM Administration

INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '����������� ','�������� ','�������������','������',100000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '�������� ','����� ','����������','������ ��������� � ��������� �� ������� ������',65000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '����� ','��������','����������','������ ��������� � ��������� �� ������� ������',60000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '�������',' ����',' ���������','	��������� �� ������������� ������ � ������������ �������������',67000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '��������� ','���� ','����������','��������� �� ������������',4500 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '�����',' ��������',' �����������','��������� �� ��������� � ����������', 40000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '��������','������� ','���������','	�������� �������', 40000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '�����������',' ��������',' ��������','�������� ����',55000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '������� ','����� ','����������','��������� �� ������-������������ ������',47000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, '�������� ','������ ','����������','	��������� �� �������������� � ������������',40000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (2, '�������� ','��������',' �����������','������',80000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (2, '�������',' ������',' ����������','�������� �������', 40000);
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (2, '������� ','������ ','����������','��������� �� ���������������� � �������� ������',60000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (3, '������ ','�������',' �����������','������',85000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (3, '������',' ������ ','����������','�������� �������',41000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (3, '������ ','�������� ','�����������','��������� �� ������� ������', 65000);
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (4, '�������','�����','���������','������',80000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (4, '��������','����','�����������','�������� �������',45000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (4, '����','������','��������','��������� �� ������� ������',55000 );

SELECT * FROM Employees WHERE idDepartments = 33;

INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '����������','�������','����������','���������� ��������', '������ ����������� ����', '���������' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (32, '�����','�������','���������','���������� ��������', '������ ����������� ����', '���������' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, '��������','����','���������','���������� ��������', '������ ����������� ����', '������' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '��������','�����������','�������������','������� �������������','�������� ����������� ����', '������' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '������������','������','����������','������� �������������', '������ ����������� ����', '���������' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '��������','��������','����������','������� �������������', '������ ����������� ����', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '�������','������','��������','������� �������������', '�������� ����������� ����', '������' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, '�������','�������','���������','������� �������������', '�������� ����������� ����', '������' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, '������','�����','��������','������� �������������', '�������� ����������� ����', '������' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, '���������','�����','�����������','������� �������������', '�������� ����������� ����', '������' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '��������','�������','��������','�������������', '', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '���������','������','����������','�������������', '', '');
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '������','����','����������','�������������','', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (32, '��������','���','������������','�������������','', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (32, '�������','���������','������������','�������������','', '');
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '�����������','���������','���������','������� ��������', '', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, '���������','�������','����������','���������', '', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (32, '��������','����','�����������','������� ��������', '', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, '������','��������','�������������','�������������','','' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, '������','�������','���������','�������������','','' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, '��������','ϸ��','����������','�������������','', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, '�����','����������','��������','���������', '', '' );

SELECT * FROM Reading

INSERT INTO Reading (idEmployees, idSubjects) VALUES (23,2);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (23,3);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (26,3);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (26,9);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (27,4);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (27,5);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (28,4);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (28,5);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (29,6);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (33,10);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (33,11);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (34,8);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (35,7);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (24,2);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (24,3);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (36,4);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (37,5);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (25,6);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (30,7);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (31,12);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (32,9);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (41,4);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (41,5);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (42,3);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (42,4);
INSERT INTO Reading (idEmployees, idSubjects) VALUES (43,15);

SELECT * FROM Subjects

INSERT INTO Subjects (NameofSubject) VALUES ('Web-����������');
INSERT INTO Subjects (NameofSubject) VALUES ('��������� � ��������� ������');
INSERT INTO Subjects (NameofSubject) VALUES ('����������� ���������������� �� C/C++');
INSERT INTO Subjects (NameofSubject) VALUES ('����������� ���������������� �� Java');
INSERT INTO Subjects (NameofSubject) VALUES ('���� ������');
INSERT INTO Subjects (NameofSubject) VALUES ('�������� ����������');
INSERT INTO Subjects (NameofSubject) VALUES ('���������� �������');
INSERT INTO Subjects (NameofSubject) VALUES ('���������� ����������');
INSERT INTO Subjects (NameofSubject) VALUES ('�����');
INSERT INTO Subjects (NameofSubject) VALUES ('������');
INSERT INTO Subjects (NameofSubject) VALUES ('������������');
INSERT INTO Subjects (NameofSubject) VALUES ('���������������');
INSERT INTO Subjects (NameofSubject) VALUES ('��������');
INSERT INTO Subjects (NameofSubject) VALUES ('�����������');
INSERT INTO Subjects (NameofSubject) VALUES ('������');
INSERT INTO Subjects (NameofSubject) VALUES ('����������');
INSERT INTO Subjects (NameofSubject) VALUES ('���������');

-- �������� ������ --
USE Maket;

SELECT * FROM EI
SELECT * FROM Faculties
SELECT * FROM Departments
SELECT * FROM Groups 
SELECT * FROM Learners
SELECT * FROM Administration
SELECT * FROM Employees
SELECT * FROM Reading
SELECT * FROM Subjects


-- �������

	-- ��� ������
	
--1 �� ������� ���������� ������� ���, � ���� ������ ������� = ���

SELECT * FROM Employees WHERE AcademicDegree= '������ ����������� ����';

--2 ���������� ���������� ���������, ����������� �� ������ ������� (�����������)

SELECT NameDep, COUNT (Learners.NameLearner) As CountStudOnDep
FROM Departments, Groups, Learners 
WHERE Learners.idGroups=Groups.idGroups AND Groups.idDepartments=Departments.idDepartments 
GROUP BY NameDep;

--3 ����� ���������

GO
CREATE PROCEDURE SearchLearner
@X int
AS
SELECT *FROM Learners WHERE idLearners=@X
GO
EXEC SearchLearner 1;

	-- ��� ����������

--4 �� ������������� �� ����
--SELECT, WHERE, GROUP BY � HAVING �������������� �������

SELECT NameEI, AVG(Salary) AS AVG_Salary 
FROM Administration JOIN EI ON (Administration.idEI = EI.idEI) 
GROUP BY NameEI
HAVING AVG(Salary)>60000;

--5 ������� ���������, ������� ������� ���������� � ����� ���.

SELECT Surname FROM Learners WHERE Surname LIKE '�%';

--6 ����������� ��������� �� ��������, �������, ��������. (����������)

SELECT NameDep, IndexGroup, Surname, NameLearner 
FROM Departments, Groups, Learners 
WHERE Learners.idGroups=Groups.idGroups AND Groups.idDepartments=Departments.idDepartments 
ORDER BY nameDep, IndexGroup, Surname, NameLearner;

--7 ���������� � ������ � � ���������� (���-�� ���������)

SELECT IndexGroup, NameOfMonitor, SurnameOfMonitor, PatronymicOfMonitor, COUNT (Learners.NameLearner) As CountStudInGroups 
FROM Groups, Learners
WHERE Learners.idGroups=Groups.idGroups 
GROUP BY IndexGroup,NameOfMonitor, SurnameOfMonitor, PatronymicOfMonitor;

	-- ��� ��������

--8 ���������� � ����������, ������� ������ ����������

USE Maket;
GO
CREATE PROCEDURE SearchEmployees
@X varchar(25)
AS
SELECT Surname, NameEmp, Patronymic, Position, NameofSubject  
FROM (Employees JOIN Reading ON (Employees.idEmployees=Reading.idEmployees))
JOIN Subjects ON (Subjects.idSubjects=Reading.idSubjects) 
WHERE Surname=@X;;
GO
EXEC SearchEmployees '�����'
GO
DROP Procedure SearchEmployees
GO

--9 ���������� � ����������� �� ���������� ����

GO
CREATE PROCEDURE SearchAdministration
@X varchar(25)
AS
SELECT Surname, NameAdmin, Patronymic, Position FROM Administration WHERE idEI=@X;;
GO
EXEC SearchAdministration 2
GO
DROP Procedure SearchAdministration
GO

----8)
----DDL-�������
--USE Maket;
--GO
--CREATE TRIGGER  Safety
--   ON  DATABASE
--      FOR DROP_TABLE, ALTER_TABLE
--AS 
--	PRINT '�������� � ��������� ������ ���������! '
--ROLLBACK ;
--GO
--DROP TRIGGER  Safety

CREATE TABLE [dbo].[Users]( 
[ID] BIGINT IDENTITY(1,1) CONSTRAINT PK_Users PRIMARY KEY,
[Loginn] [nvarchar] (255) NULL, 
[Pass] [nvarchar] (255) NULL 
) ON [PRIMARY]

INSERT INTO Users (Loginn, Pass) VALUES ('�������������', '12345');
INSERT INTO Users (Loginn, Pass) VALUES ('���������', '1234');
INSERT INTO Users (Loginn, Pass) VALUES ('��������', '123');

SELECT * FROM Users



