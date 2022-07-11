create database empleado_db

CREATE TABLE EMPLEADO(
id NVARCHAR(15),
nombres NVARCHAR(100)  NOT NULL,
apellidos NVARCHAR(100) NOT NULL,
edad int NOT NULL,
direccion NVARCHAR(100) NOT NULL,
fecha_nac DATE,
CONSTRAINT pk_compuesta PRIMARY KEY(id, fecha_nac)
)

select * from EMPLEADO where id = '225PH'and fecha_nac = '2000-07-23'
insert into EMPLEADO values('225PH', 'Juan Carlos', 'Ibarra Sanchez', 28, 'Cerrada San quintin', '2000-07-23')
select * from EMPLEADO
delete from EMPLEADO where id = '224V'

update EMPLEADO set fecha_nac = '2000-02-20' where id = '224PH'
