--Ejecutar una vez para crear la base de datos y la tabla de registros.
create database DBCsharp


Create table RegistroVentas(
# int primary key identity (1,1) not null,
PRODUCTO varchar(20) not null,
CANT int not null,
PRECIO decimal not null,
TIPO_PAGO varchar(20) not null,
DESCUENTO decimal not null,
RECARGO decimal not null,
PRECIO_FINAL decimal not null,
REGISTRO varchar(30) not null,
REFERENCIA varchar(9) not null
);
 
 SELECT *FROM RegistroVentas

 