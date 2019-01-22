
IF DB_ID('Maket') IS NULL
CREATE DATABASE Maket;
USE Maket;

-- УЗ
IF OBJECT_ID('dbo.EI', 'U') IS NOT NULL
DROP TABLE dbo.EI;
CREATE TABLE dbo.EI (
idEI BIGINT IDENTITY (1,1) CONSTRAINT PK_EI PRIMARY KEY,
NameEI VARCHAR (100) NOT NULL,
YearOfFoundation VARCHAR (4) NOT NULL,
AddressEI VARCHAR (100) NOT NULL,
UNIQUE (NameEI),
);

--Факультеты 
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


--Кафедры
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

-- Группы
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

-- Учащиеся
IF OBJECT_ID('dbo.Learners', 'U') IS NOT NULL
DROP TABLE dbo.Learners;
CREATE TABLE dbo.Learners (
idLearners BIGINT IDENTITY (1,1) CONSTRAINT PK_Learners PRIMARY KEY,
idGroups BIGINT NOT NULL,
Surname VARCHAR (25) NOT NULL,
NameLearner VARCHAR (25) NOT NULL,
Patronymic VARCHAR (25) NULL,
);
-- Руководство
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

-- Сотрудники
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

-- Читают
IF OBJECT_ID('dbo.Reading', 'U') IS NOT NULL
DROP TABLE dbo.Reading;
CREATE TABLE dbo.Reading (
idReading BIGINT IDENTITY (1,1) CONSTRAINT PK_Reading PRIMARY KEY,
idEmployees BIGINT NOT NULL, 
idSubjects BIGINT NOT NULL,
);


-- Дисциплины
IF OBJECT_ID('dbo.Subjects', 'U') IS NOT NULL
DROP TABLE dbo.Subjects;
CREATE TABLE dbo.Subjects (
idSubjects BIGINT IDENTITY (1,1) CONSTRAINT PK_Subjects PRIMARY KEY,
NameofSubject VARCHAR (100) NOT NULL,
);

-- Связи --
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

-- Заполнение таблиц -- 

SELECT * FROM EI

INSERT INTO EI VALUES('МГТУ имени Н. Э. Баумана', 1830,'2-я Бауманская ул., 5, Москва, 105005');
INSERT INTO EI VALUES('МГУ имени М.В. Ломоносова', 1755,'ул. Ленинские Горы, 1, Москва, 119991');
INSERT INTO EI VALUES('МФТИ', 1946 ,'г. Долгопрудный, Институтский переулок,Московская область, д.9 141701');
INSERT INTO EI VALUES('МГМУ имени И. М. Сеченова',1930 ,'Малая Трубецкая ул., 8с2, Москва, 119992');

SELECT * FROM Faculties

INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'Информатика и системы управления', 1988 ,'http://iu.bmstu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'Специальное машиностроение',1938,'http://www.sm.bmstu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'Радиоэлектроника и лазерная техника',1987,'http://rlm.bmstu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'Юридический факультет',1755,'http://www.law.msu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'Философский факультет',1755,'http://www.philos.msu.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (1,'Факультет общей и прикладной физики',1951,'http://фопф.рф/index.php');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (2,'Факультет инноваций и высоких технологий',2000,'https://mipt.ru/diht/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (3,'Лечебный факультет',1758,'https://sechenov.ru/');
INSERT INTO Faculties (idEI,NameFac,YearOfFoundation, LINK) VALUES (4,'Медико-профилактический факультет',1930,'https://sechenov.ru/univers/');

SELECT * FROM Departments

INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (1,'Системы обработки информации и управления', 1938 ,81545487512);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (1,'Программное обеспечение ЭВМ и информационные технологии',1989,84712185215);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (1,'Анализ данных',2007 ,85757817886  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (2,'Космические аппараты и ракеты носители',1948 ,82451785754);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (2,'Аэрокосмические системы',1960 ,85557575747);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (3,'Лазерные и оптико-электронные системы',1998 ,85577858477 );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (3,'Технологии приборостроения',1992 ,82542574157  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (12,'Кафедра административного права',1954 ,84514545457  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (13,'Кафедра логики',1947 ,87574854757  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (13,'Кафедра философии языка и коммуникации',2008 ,87575757571  );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (14,'Теоретическая астрофизика и квантовая теория поля',2012 ,85857575757);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (15,'Кафедра теории государства и права и политологии',1942 ,84575178578);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (16,'Кафедра гистологии, цитологии и эмбриологии',1863 ,87757575778);
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (17,'Кафедра фармакологии',1764 ,87578587578 );
INSERT INTO Departments (idFaculties, NameDep, YearOfFoundation, Number) VALUES (17,'Кафедра тропической медицины и паразитарных болезней',2009 ,87857575875);

SELECT * FROM Groups 

INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ИУ5-41',31 , 'Зенгер', 'Анна', 'Сергеевна');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ИУ5-42',31, 'Губайдулина', 'Карина', ' ');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ИУ5-43',31, 'Покасова', 'Анастасия', 'Руслановна');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ИУ5-44',31, 'Корнеева', 'Анна', 'Миронова');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ИУ7-41',32, 'Алан', 'Мьэтисон', 'Тюринг');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ИУ11-11М',33, 'Стив', 'Джобс', ' ');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('СМ6-12',34, 'Дуров', 'Павел', 'Валерьевич');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('СМ2-64',35, 'Мимиев', 'Мими', 'Мамытов');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('РЛ2-42',36, 'Бугай', 'Кирилл', 'Евгеньевич');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('РЛ6-32',37, 'Нгуен', 'Нхы', '-');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ЮР1-11',46, 'Доржсурэн', 'Од', 'Каа');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ЮР2-7М',47, 'Тюнь', 'Минь', 'Пунь');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ФИЛ-001',48, 'Ут', 'Кар', 'Шаа');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ФН4-002',49, 'Стивен', 'Ульям', 'Хокинг');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('ФИЛ-22',50, 'Добмоев', 'Дунай', 'Ширинович');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('БМТ1-01',51, 'Вахтюнг', 'Миша', 'Олегович');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('БМТ2-02',52, 'Яковук', 'Олег', ' ');
INSERT INTO Groups (IndexGroup, idDepartments,SurnameOfMonitor, NameOfMonitor, PatronymicOfMonitor) VALUES ('БМТ4-44',53, 'Козлов', 'Дима', ' ');

SELECT * FROM Learners

INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Абросимова', 'Надежда', 'Георгиевна');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Авлияров', 'Марат', 'Вячеславович');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Алиева', 'Довлет', 'Гусейн кызы');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Афанасьев', 'Родион', 'Артурович');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Вахромеев', 'Илья', 'Андреевич');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Водка', 'Игорь', 'Эдуардович');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Гладова', 'Анастасия', 'Григорьевна');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Зенгер', 'Анна', 'Сергеевна');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Качанюк', 'Татьяна', 'Юрьевна');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (1, 'Черепанов', 'Екатерина', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Атаманюк', 'Андрей', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Губайдулина', 'Карина', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Ершова', 'Анастасия', 'Григорьевна');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Лескина', 'Ника', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Лебедева', 'Дарья', 'Сергеевна');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Бакаев', 'Сергей', 'Дмитриевич');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Бакаева', 'Валера', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Нурлыева', 'Дана', 'Нур кызы');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Олюшкин', 'Олег', 'Кимович');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (2 , 'Гапанюк', 'Юрий', 'Евгеньевич');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (5, 'Солосина', 'Екатерина', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (5, 'Покасова ', ' Анастасия', 'Руслановна');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (5, 'Замула', 'Настя', 'Мишурина');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (6, 'Брысина', 'Наталья', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (6, 'Корнеева', 'Анна', 'Артуровна');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (6, 'Кучеренко', 'Миша', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (7, 'Васильев', 'Василий', 'Сергеев');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (7, 'Алан', 'Мьэтисон', 'Тюринг');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (8, 'Стив', 'Джобс', '');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (8, 'Больше', 'Нет', 'Фантазии');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (9, 'Дуров', 'Павел', 'Вальерьевич');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (9, 'Любитель', 'ВПН', 'Любителевич');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (10, 'Владов', 'Влад', 'Владович');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (11, 'Бугай', 'Кирилл', 'Евгеньевич');;
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (12, 'Нгуен', 'Нхы', '-');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (13, 'Доржсурэн', 'Од', 'Каа');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (14, 'Тюнь', 'Минь', 'Пунь');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (15, 'Ут', 'Кар', 'Шаа');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (16, 'Стивен', 'Ульям', 'Хокинг');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (17, 'Добмоев', 'Дунай', 'Ширинович');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (18, 'Вахтюнг', 'Миша', 'Олегович');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (19,'Яковук', 'Олег', ' ');
INSERT INTO Learners (idGroups, Surname, NameLearner, Patronymic) VALUES (37, 'Козлов', 'Дима', ' ');

SELECT * FROM Administration

INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Александров ','Анатолий ','Александрович','Ректор',100000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Падалкин ','Борис ','Васильевич','Первый проректор — проректор по учебной работе',65000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Зимин ','Владимир','Николаевич','Первый проректор — проректор по научной работе',60000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Цветков',' Юрий',' Борисович','	Проректор по хозяйственной работе и капитальному строительству',67000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Шахвердов ','Олег ','Лентошович','Проректор по безопасности',4500 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Юрков',' Анатолий',' Анатольевич','Проректор по экономике и инновациям', 40000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Старожук','Евгений ','Андреевич','	Помощник ректора', 40000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Стымковский',' Владимир',' Иванович','Директор МТКП',55000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Коробец ','Борис ','Николаевич','Проректор по учебно-методической работе',47000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (1, 'Коршунов ','Сергей ','Валерьевич','	Проректор по информатизации и модернизации',40000  );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (2, 'Колмыков ','Анатолий',' Серафимович','Ректор',80000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (2, 'Сафонов',' Михаил',' Дмитриевич','Помощник ректора', 40000);
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (2, 'Царьков ','Андрей ','Васильевич','Проректор по административной и правовой работе',60000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (3, 'Лесков ','Алексей',' Григорьевич','Ректор',85000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (3, 'Санаев',' Виктор ','Георгиевич','Помощник ректора',41000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (3, 'Киреев ','Владимир ','Анатольевич','Проректор по научной работе', 65000);
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (4, 'Лавроев','Марго','Рамазанов','Ректор',80000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (4, 'Журавлёва','Лина','Альбертовна','Помощник ректора',45000 );
INSERT INTO Administration (idEI, Surname, NameAdmin, Patronymic, Position, Salary) VALUES (4, 'Боил','Сергей','Иванович','Проректор по научной работе',55000 );

SELECT * FROM Employees WHERE idDepartments = 33;

INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Черненький','Валерий','Михайлович','Заведующий Кафедрой', 'Доктор технических наук', 'Профессор' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (32, 'Бугай','Тимофей','Замуллаев','Заведующий Кафедрой', 'Доктор технических наук', 'Профессор' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, 'Михайлюк','Олег','Сергеевич','Заведующий Кафедрой', 'Доктор технических наук', 'Доцент' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Анатолий','Александров','Александрович','Старший преподаватель','Кандидат технических наук', 'Доцент' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Пролетарский','Андрей','Викторович','Старший преподаватель', 'Доктор технических наук', 'Профессор' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Зеленцов','Валентин','Викторович','Старший преподаватель', 'Доктор технических наук', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Чужиков','Михаил','Иванович','Старший преподаватель', 'Кандидат технических наук', 'Доцент' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, 'Меликов','Тимофей','Ефремович','Старший преподаватель', 'Кандидат технических наук', 'Доцент' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, 'Шашков','Вадим','Ефимович','Старший преподаватель', 'Кандидат технических наук', 'Доцент' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, 'Муравьёва','Марфа','Альбертовна','Старший преподаватель', 'Кандидат технических наук', 'Доцент' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Гордеева','Надежда','Глебовна','Преподаватель', '', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Антонович','Виктор','Садовничий','Преподаватель', '', '');
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Осипов','Фрол','Даниилович','Преподаватель','', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (32, 'Кабанова','Зоя','Валерьяновна','Преподаватель','', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (32, 'Романов','Святослав','Вячеславович','Преподаватель','', '');
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Лаврентьева','Маргарита','Романовна','Старший лаборант', '', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (31, 'Кудрявцев','Николай','Николаевич','Ассистент', '', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (32, 'Сюкосева','Рима','Геннадиевна','Старший лаборант', '', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, 'Попова','Виктория','Святославовна','Преподаватель','','' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, 'Даниил','Сергеев','Никитевич','Преподаватель','','' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, 'Глыбочко','Пётр','Витальевич','Преподаватель','', '' );
INSERT INTO Employees (idDepartments, Surname, NameEmp, Patronymic, Position, AcademicDegree, AcademicTitle) VALUES (33, 'Некий','Константин','Глебович','Ассистент', '', '' );

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

INSERT INTO Subjects (NameofSubject) VALUES ('Web-технологии');
INSERT INTO Subjects (NameofSubject) VALUES ('Алгоритмы и структуры данных');
INSERT INTO Subjects (NameofSubject) VALUES ('Углубленное программирование на C/C++');
INSERT INTO Subjects (NameofSubject) VALUES ('Углубленное программирование на Java');
INSERT INTO Subjects (NameofSubject) VALUES ('Базы данных');
INSERT INTO Subjects (NameofSubject) VALUES ('Фронтенд разработка');
INSERT INTO Subjects (NameofSubject) VALUES ('Инженерная графика');
INSERT INTO Subjects (NameofSubject) VALUES ('Дискретная математика');
INSERT INTO Subjects (NameofSubject) VALUES ('Химия');
INSERT INTO Subjects (NameofSubject) VALUES ('Физика');
INSERT INTO Subjects (NameofSubject) VALUES ('Правоведение');
INSERT INTO Subjects (NameofSubject) VALUES ('Приборостроение');
INSERT INTO Subjects (NameofSubject) VALUES ('Биология');
INSERT INTO Subjects (NameofSubject) VALUES ('Астрофизика');
INSERT INTO Subjects (NameofSubject) VALUES ('Логика');
INSERT INTO Subjects (NameofSubject) VALUES ('Гистология');
INSERT INTO Subjects (NameofSubject) VALUES ('География');

-- Просмотр таблиц --
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


-- Запросы

	-- ДЛЯ АДМИНА
	
--1 Из таблицы сотрудники вывести тех, у кого Учёная степень = ДТН

SELECT * FROM Employees WHERE AcademicDegree= 'Доктор технических наук';

--2 Подсчитать количество студентов, обучающихся на каждой кафедре (группировка)

SELECT NameDep, COUNT (Learners.NameLearner) As CountStudOnDep
FROM Departments, Groups, Learners 
WHERE Learners.idGroups=Groups.idGroups AND Groups.idDepartments=Departments.idDepartments 
GROUP BY NameDep;

--3 Поиск учащегося

GO
CREATE PROCEDURE SearchLearner
@X int
AS
SELECT *FROM Learners WHERE idLearners=@X
GO
EXEC SearchLearner 1;

	-- ДЛЯ СОТРУДНИКА

--4 СЗ Руководителей по ВУЗу
--SELECT, WHERE, GROUP BY и HAVING Дополнительное условие

SELECT NameEI, AVG(Salary) AS AVG_Salary 
FROM Administration JOIN EI ON (Administration.idEI = EI.idEI) 
GROUP BY NameEI
HAVING AVG(Salary)>60000;

--5 Выбрать студентов, фамилии которых начинаются с буквы «А».

SELECT Surname FROM Learners WHERE Surname LIKE 'А%';

--6 Упорядочить студентов по кафедрам, группам, фамилиям. (сортировка)

SELECT NameDep, IndexGroup, Surname, NameLearner 
FROM Departments, Groups, Learners 
WHERE Learners.idGroups=Groups.idGroups AND Groups.idDepartments=Departments.idDepartments 
ORDER BY nameDep, IndexGroup, Surname, NameLearner;

--7 Информация о Группе и её содержимом (кол-во студентов)

SELECT IndexGroup, NameOfMonitor, SurnameOfMonitor, PatronymicOfMonitor, COUNT (Learners.NameLearner) As CountStudInGroups 
FROM Groups, Learners
WHERE Learners.idGroups=Groups.idGroups 
GROUP BY IndexGroup,NameOfMonitor, SurnameOfMonitor, PatronymicOfMonitor;

	-- ДЛЯ УЧАЩИХСЯ

--8 Информация о Сотруднике, который читает дисциплину

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
EXEC SearchEmployees 'Бугай'
GO
DROP Procedure SearchEmployees
GO

--9 Информация о Руководстве по выбранному ВУЗу

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
----DDL-триггер
--USE Maket;
--GO
--CREATE TRIGGER  Safety
--   ON  DATABASE
--      FOR DROP_TABLE, ALTER_TABLE
--AS 
--	PRINT 'Удаление и изменение таблиц запрещено! '
--ROLLBACK ;
--GO
--DROP TRIGGER  Safety

CREATE TABLE [dbo].[Users]( 
[ID] BIGINT IDENTITY(1,1) CONSTRAINT PK_Users PRIMARY KEY,
[Loginn] [nvarchar] (255) NULL, 
[Pass] [nvarchar] (255) NULL 
) ON [PRIMARY]

INSERT INTO Users (Loginn, Pass) VALUES ('Администратор', '12345');
INSERT INTO Users (Loginn, Pass) VALUES ('Сотрудник', '1234');
INSERT INTO Users (Loginn, Pass) VALUES ('Учащийся', '123');

SELECT * FROM Users



