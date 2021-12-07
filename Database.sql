create database MedicalTreatment
use MedicalTreatment
set dateformat DMY

create table Account
(
	AccountID INT IDENTITY PRIMARY KEY,
	Username nvarchar(50) not null,
	Password nvarchar(50) not null,
	type nvarchar(20) not null,
	EmployeeID int not null foreign key references Employee(EmployeeID)
)

create table Employee
(
	EmployeeID INT IDENTITY PRIMARY KEY,
	Name nvarchar(60),
	Position nvarchar(20) not null,
	Salary money default 500000,
	Email nvarchar(70),
)
--alter table Account add EmployeeID int not null foreign key references Employee(EmployeeID)
--alter table Employee drop column AccountID

create table PaySalary
(
	PaySalaryID INT IDENTITY Primary key,
	Date smalldatetime not null,
	Value money not null,
	EmployeeID int not null foreign key references Employee(EmployeeID)
)

create table Patient
(
	PatientID int identity primary key,
	Name nvarchar(60) not null,
	Phone nvarchar(20),
	Address nvarchar(100),
	HealthInsuarance nvarchar(20),
	Gender nvarchar(10),
	DateOfBirth smalldatetime,
	Nation nvarchar(50),
	WorkPlace nvarchar(50)
)

create table Drug
(
	DrugID int identity primary key,
	Name nvarchar(60) not null,
	Type nvarchar(20),
	Unit nvarchar(20),
	Price money not null,
	Quantity int default 1,
	Producer nvarchar(40),
	ExprirationDate smalldatetime not null,
	ImportDate smalldatetime not null,
)

create table ExaminationForm
(
	ExaminationFormID int identity primary key,
	Ordinal int,
	Date smalldatetime not null,
	Reason nvarchar(1000),
	State nvarchar(20) default 'inGP',
	PatientID int not null foreign key references Patient(PatientID),
	SecretaryID int not null foreign key references Employee(EmployeeID)
)

create table SpecialistExamination
(
	SpecialExaminationID int identity primary key,
	Name nvarchar(60) not null,
	Price money not null,
)

create table SpecialistExaminationRequest
(
	SErequestID int identity primary key,
	Date smalldatetime not null,
	SpecialExaminationID int not null foreign key references SpecialistExamination(SpecialExaminationID),
	PatientID int not null foreign key references Patient(PatientID),
	GPID int not null foreign key references Employee(EmployeeID)
)

create table SpecialistExaminationResult
(
	SEresultID int identity primary key,
	Date smalldatetime not null,
	Result nvarchar(700),
	Conclusion nvarchar(400),
	SpecialExaminationID int not null foreign key references SpecialistExamination(SpecialExaminationID),
	PatientID int not null foreign key references Patient(PatientID),
	SpecialistID int not null foreign key references Employee(EmployeeID)
)

create table DiagnoseResult
(
	DiagnoseResultID int identity primary key,
	Date smalldatetime not null,
	Result nvarchar(500),
	Direction nvarchar(500),
	ExaminationFormID int not null foreign key references ExaminationForm(ExaminationFormID),
	PatientID int not null foreign key references Patient(PatientID),
	GPID int not null foreign key references Employee(EmployeeID)
)

create table Prescription
(
	PrescriptionID int identity primary key,
	Date smalldatetime not null,
	DoctorDirection nvarchar(500),
	PatientID int not null foreign key references Patient(PatientID),
	GPID int not null foreign key references Employee(EmployeeID)
)

create table GPdrugDetail
(
	GPdrugID int identity primary key,
	Quantity int,
	PrescriptionID int not null foreign key references Prescription(PrescriptionID),
	PatientID int not null foreign key references Patient(PatientID),
	GPID int not null foreign key references Employee(EmployeeID)
)

create table Invoice
(
	InvoiceID int identity primary key,
	Date smalldatetime not null,
	TotalPrice money,
	PatientID int not null foreign key references Patient(PatientID),
	PharmacistID int not null foreign key references Employee(EmployeeID)
)

create table ExaminationInvoiceDetail
(
	Quantity int,
	InvoiceID int not null foreign key references Invoice(InvoiceID),
	SpecialExaminationID int not null foreign key references SpecialistExamination(SpecialExaminationID)
)

create table DrugInvoiceDetail
(
	Quantity int,
	InvoiceID int not null foreign key references Invoice(InvoiceID),
	DrugID int not null foreign key references Drug(DrugID)
)

-- datatime format: dd/mm/yyyy     vd: '15/12/2021'

--insert into Employee(Name, Position, Salary, Email) values ('Reyan Jain', 'pharmacist', 2000000, 'reyanjain@gmail.com') 
--insert into Employee(Name, Position, Salary, Email) values ('Sonia Bush', 'secretary', 1000000, 'sonia@gmail.com')  

--insert into OAccount(Username, Password, type, EmployeeID) values ('admin0', '0', 'admin', 0) 
--insert into Account(Username, Password, type, EmployeeID) values ('pharmacist1', '1', 'pharmacist', 2) 
--insert into Account(Username, Password, type, EmployeeID) values ('pharmacist1', '1', 'pharmacist', 1)
insert into Patient(Name, Phone, Address, HealthInsuarance, Gender, DateOfBirth, Nation, WorkPlace) 
values ('Sanu Roy', '0938527419', '', 'SV4576584594234', 'female', '22/6/2002', 'Viet Nam', '')




-- Drug--------------------------------------------------------------------------------------------------------------
insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00001','Acetaminophen','effervescent','650 mg','1100','2000','Actamin','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00002','Afatinib','oral tablet','30 mg','500','3000','Gilotrif','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00003','Molnupiravir','oral tablet','500 mg','600','8000','Merck','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00004','Paracetamol','oral tablet','500 mg','900','8000','Tylenol','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00005','Dexamethasone','oral tablet','0.5mg','900','7000','Decadron','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00006','Methylprednisolone','oral tablet','16mg','400','8000','Medrol','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00007','Rivaroxaban','oral tablet','10mg','550','8000','Xarelto','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00008','Apixaban','oral tablet','2.5 mg','660','7500','Eliquis','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00009','Dabigatran','oral capsule','110 mg','470','6000','Pradaxa','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00010','Ibuprofen','oral capsule','200 mg','830','3000','Advil','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00011','Cephalexin','oral capsule','250 mg','530','2000','Keflex','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00012','Trazodone','oral tablet','100 mg','580','2000','Desyrel','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00013','Methadone','oral tablet','150 mg','1800','400','Dolophine','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00014','Lisinopril','oral tablet','10 mg','770','1500','Prinivil','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00015','Omeprazole','oral delayed release tablet','20 mg','2000','600','FIRST Omeprazole','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00016','Mesalamine','oral delayed release capsule','400 mg','1200','1500','Apriso','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00017','Felodipine','oral tablet','10 mg','1500','700','Plendil','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00018','Flutamide','oral capsule','125 mg','1130','1000','Eulexin','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00019','Flurazepam','oral capsule','15 mg','350','1400','Dalmane','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00020','Osimertinib','oral tablet','40 mg','700','2300','Tagrisso','1/12/2025','1/12/2021')

insert into Drug(DrugID, Name, Type, Unit, Price, Quantity, Producer, ExprirationDate, ImportDate )
values ('00021','Oxandrolone','oral tablet','10 mg','1700','3100','Oxandrin','1/12/2025','1/12/2021')
-------------------------------------------------------------------------------------------------------------------
