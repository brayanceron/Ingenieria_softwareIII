
--create database ENTIDADAYP;

create table prestatario (
codprestatario varchar(8) not null primary key,
cedulaprestatario varchar(10),
nombreprestatario varchar(50),
direccionprestatario varchar(50),
telefonoprestatario char(10),
modalidadpagoprestatario varchar(20)
);

create table inversionista(
codinversionista varchar(8) not null primary key,
cedulainversionista varchar(10),
nombreinversionista varchar(50),
direccioninversionista varchar(50),
telefonoinversionista char(10),
modalidadpagoprestatario varchar(20),
numcuentainversionista varchar(15),
bancoinversionista varchar(50),
tipocuentainversionista varchar(15)
);

create table fiador (
codfiador varchar(8) not null primary key,
cedulafiador varchar(10),
nombrefiador varchar(50),
direccionfiador varchar(50),
telefonofiador char(10),
modalidadpagoprestatario varchar(20)
);

create table garantia (
codgarantia varchar(8)  not null primary key,
valorgarantia varchar(12),
ubicaciongarantia varchar(50)
);

create table cuotas_inversion (

codcuotainversion varchar(15) not null primary key,
codcronograma varchar(8) ,
inversion varchar(8),
valorcuotainversion varchar(12),
tasacuotainversion numeric(4,2),
comprobante varchar (20),
modalidad varchar (20),
estadocuotainversion varchar (15),
numcuenta char(15),
tipocuenta varchar (15),
banco varchar (50),
fechaplaneadainversion date,
fechaefectivainversion date
);

create table cuotas_prestamo (

codcuotaprestamo varchar(15) not null primary key,
codcronograma varchar(8),
prestamo varchar(8),
valorcuotaprestamo varchar(12),
tasacuotaprestamo numeric(4,2),
comprobante varchar (20),
modalidad varchar (20),
estadocuotaprestamo varchar (15),
fechaplaneadaprestamo date,
fechaefectivaprestamo date
);

create table transacciones_inversion (
codinversion varchar(8) not null primary key,
cronogramainversion varchar(8),
inversionista varchar(8),
fechasolicitudinvesion date,
montoinversion varchar(12),
tasainversion numeric(4,2),
tiempoinversion varchar(20),
estadoinversion varchar(20),
fecharealizacioninversion date,
fechaterminoinversion date
);

create table transacciones_prestamo (
codprestamo varchar(8) not null primary key,
cronogramaprestamo varchar(8),
prestatario varchar(8),
fechasolicitudprestamo date,
montoprestamo varchar(12),
tasaprestamo numeric(4,2),
tiempoprestamo varchar(20),
estadoprestamo varchar (20),
fechaprobacionprestamo date,
fechainicioprestamo date,
fechaterminoprestamo date,
fiador varchar(8),
garantia varchar(8)
);




create table cronograma_prestamo(
codcronogramaprestamo varchar(8) not null primary key,
prestamo varchar(8)
);

create table cronograma_inversion(
codcronogramainversion varchar(8)not null primary key,
inversion varchar(8)
);



alter table cuotas_inversion add foreign key(codcronograma) references cronograma_inversion(codcronogramainversion);

alter table cuotas_prestamo add foreign key(codcronograma) references cronograma_prestamo(codcronogramaprestamo);


alter table cronograma_inversion add foreign key(inversion) references transacciones_inversion(codinversion);

alter table cronograma_prestamo add foreign key(prestamo) references transacciones_prestamo(codprestamo);

alter table transacciones_prestamo add foreign key(garantia) references garantia(codgarantia);
alter table transacciones_inversion add foreign key(cronogramainversion) references cronograma_inversion(codcronogramainversion);
alter table transacciones_inversion add foreign key(inversionista) references inversionista(codinversionista);
alter table transacciones_prestamo add foreign key(cronogramaprestamo) references cronograma_prestamo(codcronogramaprestamo);
alter table transacciones_prestamo add foreign key(prestatario) references prestatario(codprestatario);


