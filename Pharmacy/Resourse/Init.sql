create table employees
(
	id bigint generated always as identity primary key,
	first_name varchar(50) not null,
	last_name varchar(50),
	experience smallint,
	passport_seria_number text,
	is_male bool,
	descriptions text,
	created_At timestamp with time zone,
	updated_At timestamp with time zone
);

create table country_drugs
(
	id bigint generated always as identity primary key,
	country_name varchar(50) not null,
	firma_name varchar(50),
	passport_seria_number text,
	created_date date,
	descriptions text,
	created_At timestamp with time zone,
	updated_At timestamp with time zone
);

create table drugs
(
	id bigint generated always as identity primary key,
	country_drugs_id bigint not null,
	type varchar(50),
	date_of_manufacture date,
	end_date_of date,
	price real,
	drugs_locations varchar(50),
	count int,
	descriptions text,
	created_At timestamp with time zone,
	updated_At timestamp with time zone
);

create table Emails 
(
	id bigint generated always as identity primary key,
	employee_id bigint not null,
	email varchar(50) not null,
	password_hash text not null,
	salt text
);
