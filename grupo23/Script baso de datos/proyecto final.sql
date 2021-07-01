create database proyecto_final3;
use proyecto_final3;
set lc_time_names='en_US';

create table vaccination(
id int primary key auto_increment,
date_vaccine datetime,
id_cabin int,
id_Side_effects int
);

alter table vaccination add foreign key (id_cabin) references cabin (id);
alter table vaccination add foreign key (id_Side_effects) references Side_effects (id);
alter table vaccination add DUI_pacient varchar(20);
alter table vaccination add foreign key (DUI_pacient) references pacient (DUI);

create table Side_effects (
id int primary key auto_increment,
side_effects varchar (50)
);

create table cabin(
id int primary key auto_increment,
adress varchar (50),
email varchar (50),
phone varchar (50),
mandated varchar(50)
);

create table quotee(
id int primary key auto_increment,
date_vaccine datetime,
place_vaccination varchar (50),
id_cabin int,
DUI_pacient varchar(20) 
);

alter table quotee add foreign key (id_cabin) references cabin (id);
alter table quotee add foreign key (DUI_pacient) references pacient (DUI);

create table pacient (
DUI varchar(20) primary key not null,
name_pacient varchar (50),
adress_pacient varchar (50),
email varchar (50),
phone varchar (50),
id_Disease int,
id_type_institution int,
id_group_priority int
);

alter table pacient add foreign key (id_Disease) references Disease (id);
alter table pacient add foreign key (id_type_institution) references type_institution (id);
alter table pacient add foreign key (id_group_priority) references group_priority (id);

create table Disease (
id int primary key auto_increment not null,
disease varchar (50)
);

create table type_institution (
id int primary key auto_increment,
typee varchar (50)
);

create table group_priority (
id int primary key auto_increment,
groupp varchar (50)
);


create table employee (
id int primary key auto_increment,
name_employee varchar (50),
email varchar (50),
adress varchar (50),
user_employee varchar (50),
password_employee varchar (50),
id_type_employee int
);

alter table employee add foreign key (id_type_employee) references type_employee (id);

create table type_employee(
id int primary key auto_increment,
typee varchar (50)
);

create table record(
id int primary key auto_increment,
date_record datetime,
id_cabin int,
id_employee int
);

alter table record add foreign key (id_cabin) references cabin(id);
alter table record add foreign key (id_employee) references employee(id);

create table cabinXemployee(
id_cabin int not null,
id_employee int not null,
constraint pk_CabinXEmployee primary key (id_cabin, id_employee)
);

alter table cabinXemployee add constraint FK_cabinxemployee_cabin foreign key (id_cabin) references cabin (id);
alter table cabinxemployee add constraint fk_cabinXemployee_employee foreign key (id_employee) references employee (id);

SELECT * FROM record;
SELECT * FROM pacient; 
SELECT * FROM cabin; 
SELECT * FROM employee; 
SELECT * FROM type_employee;


insert into  Disease values (1, 'calentura');
insert into  Disease values (2, 'nauseas');
insert into  Disease values (3, 'tos');

insert into type_employee values (1,' secretaria' );
insert into type_employee values (2,' vacunador');
insert into type_employee values ( 3,' encargado');

insert into group_priority values (1,'Adultos mayores de 60 años');
insert into group_priority values (2,'Personal del sistema integrado de salud');
insert into group_priority values (3,'Encargados de la seguridad nacional');
insert into group_priority values (4,'mayor de 18 años con discapacidad o enfermad');
insert into group_priority values (5,'Personal del gobierno central');

insert into type_institution values (1,'Educacion');
insert into type_institution values (2,'Salud');
insert into type_institution values (3,'Policia Nacional Civil');
insert into type_institution values (4,'Gobierno');
insert into type_institution values (5,'Fuerza Armada');
insert into type_institution values (6,'Periodismo');

insert into side_effects values(1,'Dolor en el sitio de la inyeccion');
insert into side_effects values(2,'Sensibilidad en el sitio de la inyeccion');
insert into side_effects values(3,'Fatiga');
insert into side_effects values(4,'Dolor de cabeza');
insert into side_effects values(5,'Fiebre');
insert into side_effects values(6,'Mialgia');
insert into side_effects values(7,'Artralgia');
insert into side_effects values(8,'Anafilaxia');