create table Carriage_types(
 type_id NUMBER not null,
 type_name VARCHAR(35),
 sits_count NUMBER not null,
 constraint types_pk primary key (type_id)
 );

create table Carriages(
 carriage_id NUMBER not null,
 carriage_number VARCHAR(10),
 type_id NUMBER not null,
 constraint carriages_pk primary key (carriage_id),
 constraint  type_fk
    foreign key (type_id)
    references Carriage_types(type_id)
 );
 
create table Trains(
 train_id NUMBER not null,
 train_number NUMBER not null,
 constraint trains_pk primary key (train_id)
 );
 
create table Train_composition(
  composition_id NUMBER not null,
  train_id NUMBER not null,
  carriage_id NUMBER not null,
  constraint composition_pk primary key (composition_id),
  constraint  train_fk
    foreign key (train_id)
    references Trains(train_id),
  constraint  carriage_fk
    foreign key (carriage_id)
    references Carriages(carriage_id)
);

create table Positions(
 position_id NUMBER not null,
 position_name VARCHAR(20),
 salary NUMBER not null,
 constraint position_pk primary key (position_id),
 constraint salary check (salary>0)
);

create table Employee(
 employee_id NUMBER not null,
 first_name varchar(30) not null,
 last_name varchar(30) not null,
 telephone varchar(10) not null,
 hire_date VARCHAR(10) not null,
 constraint employee_pk primary key (employee_id)
);

create table employee_positions(
  id_ep NUMBER not null,
  employee_id NUMBER not null,
  position_id NUMBER not null,
  constraint ep_fk primary key (id_ep),
  constraint  employee_fk
    foreign key (employee_id)
    references Employee(employee_id),
   constraint  position_id
    foreign key (position_id)
    references Positions(position_id) 
 );

create table Train_staff(
 staff_id NUMBER not null,
 train_id NUMBER not null,
 employee_id NUMBER not null,
 constraint staff_pk primary key (staff_id),
 constraint train_fk2 foreign key (train_id)
  references Trains(train_id),
 constraint employee_fk2 foreign key (employee_id)
  references Employee(employee_id)
);

create table Stations(
 station_id NUMBER not null, 
 station_name VARCHAR(30) not null,
 stop_time NUMBER,
 constraint station_pk primary key (station_id) 
);

create table Routes(
 route_id NUMBER not null,
 route_name VARCHAR(50) not null,
 depature_time VARCHAR(5) not null,
 arrival_time VARCHAR(5) not null,
 train_id NUMBER not null,
 constraint route_pk primary key (route_id),
 constraint train_fk3 foreign key (train_id)
  references Trains(train_id)
 );

create table Halt(
 halt_id NUMBER not null,
 route_id NUMBER not null,
 train_id NUMBER not null,
 depture_time VARCHAR(5) not null,
 constraint halt_pk primary key (halt_id),
 constraint route_id foreign key (route_id)
  references Routes(route_id),
 constraint train_id4 foreign key (train_id)
  references Trains(train_id)
);

create sequence  seq_1 increment by 1 minvalue 50;
drop sequence seq_1;

insert into Trains 
select seq_1.NEXTVAL,  train_number+10 from Trains
where train_number=6666;

select * from Trains;
drop table Trains

insert into Trains(train_id, train_number) values (seq_1.NEXTVAL, 2110);
insert into Trains(train_id, train_number) values (seq_1.NEXTVAL, 3003);

update Trains set train_id=seq_1.NEXTVAL where train_number=3003;
update Trains set train_id=seq_1.NEXTVAL where train_number=2110;

delete from Trains where train_id=1;

create force view main 
as select composition_id, train_number, type_name
from train_composition, Trains, Carriages, carriage_types
where train_composition.train_id=Trains.train_id and train_composition.carriage_id=carriages.carriage_id and carriages.type_id=carriage_types.type_id;




insert into Positions(position_id, position_name, salary) values (1, 'проводник',10000);
select * from Positions; 
 


insert into Carriage_types(type_id, type_name, sits_count) values (1,  'купе', 80);
insert into Carriage_types(type_id, type_name, sits_count) values (2,  'плацкарт', 100);
insert into Carriage_types(type_id, type_name, sits_count) values (3,  'сидячий экспресс', 160);

insert into Carriages(carriage_id, carriage_number, type_id) values (1, 'К-121', 1);
insert into Carriages(carriage_id, carriage_number, type_id) values (2, 'М-122', 3);
insert into Carriages(carriage_id, carriage_number, type_id) values (3, 'Н-221', 2);

insert into Train_composition(composition_id, train_id, carriage_id) values (1, 1, 1);
insert into Train_composition(composition_id, train_id, carriage_id) values (2, 1, 2);
insert into Train_composition(composition_id, train_id, carriage_id) values (3, 1, 3); 


drop table Carriage_types;
drop table Carriages;
drop table Trains;
drop table Сomposition;

select * from Trains;
select * from Carriage_types;
select * from Carriages;
select * from Train_composition;

select  carriage_id, carriage_number, Carriage_types.type_name
from Carriages, Carriage_types
where Carriages.type_id=Carriage_types.type_id;

CREATE TABLE LOADER_TEST (
   train_id          NUMBER NOT NULL ,
   train_number        NUMBER NOT NULL 
);
select * from  LOADER_TEST;

