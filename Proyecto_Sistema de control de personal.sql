CREATE DATABASE bd_control_personal
go

USE bd_control_personal
go


----Creación de tablas del sistema----

CREATE TABLE Departamento
( 
	ID_departam          int identity(2000,1)  NOT NULL ,
	Nombre               nvarchar(50)  NOT NULL ,
	Descripcion          nvarchar(100)  NULL,
	Num_trab             int  NULL
)
go

ALTER TABLE Departamento
	ADD CONSTRAINT XPKDepartamento PRIMARY KEY  CLUSTERED (ID_departam ASC)
go

CREATE TABLE Asistencia
( 
	ID_asistencia        int identity(8000,1)  NOT NULL ,
	Hora_entrada         time(2)  NOT NULL ,
	Hora_salida          time(2)  NOT NULL ,
	Fecha                date  NOT NULL ,
	Descripcion          nvarchar(50)  NOT NULL ,
	ID_empleado          int   NOT NULL 
)
go

ALTER TABLE Asistencia
	ADD CONSTRAINT XPKAsistencia PRIMARY KEY  CLUSTERED (ID_asistencia ASC)
go

CREATE TABLE Cargo
( 
	ID_cargo             int identity(3000,1)  NOT NULL ,
	Nombre               nvarchar(50)  NOT NULL ,
	Descripcion          nvarchar(200)  NULL ,
	ID_departam          int NOT NULL
)
go

ALTER TABLE Cargo
	ADD CONSTRAINT XPKCargo PRIMARY KEY  CLUSTERED (ID_cargo ASC)
go

CREATE TABLE Empleado
( 
	ID_empleado          int identity(1000,1)  NOT NULL ,
	Ape_paterno          nvarchar(50)  NOT NULL ,
	Ape_materno          nvarchar(50)  NOT NULL ,
	Nombres              nvarchar(50)  NOT NULL ,
	Dni                  char(8)  NOT NULL ,
	Sexo                 nvarchar(9)  NOT NULL,
	Tel_fijo             char(7)  NULL ,
	Celular              char(9)  NULL ,
	Direccion            nvarchar(100)  NOT NULL ,
	Ciudad               nvarchar(50)  NOT NULL ,
	Distrito             nvarchar(50)  NOT NULL ,
	Estado               nvarchar(10)  NOT NULL ,
	ID_turno             int  NOT NULL ,
	ID_horario           int  NOT NULL ,
	ID_departam          int  NOT NULL ,
	ID_cargo             int  NOT NULL 
)
go

ALTER TABLE Empleado
	ADD CONSTRAINT XPKEmpleado PRIMARY KEY  CLUSTERED (ID_empleado ASC)
go

CREATE TABLE Horario
( 
	ID_horario           int identity(5000,1) NOT NULL ,
	Hora_inicio          time(2)  NOT NULL ,
	Hora_salida          time(2)  NOT NULL ,
	Inicio_descan        time(2)  NULL,
	Fin_descan           time(2)  NULL,
	Descripcion          nvarchar(100)  NOT NULL ,
	ID_turno             int   NOT NULL
)
go

ALTER TABLE Horario
	ADD CONSTRAINT XPKHorario PRIMARY KEY  CLUSTERED (ID_horario ASC)
go

CREATE TABLE Turno
( 
	ID_turno             int identity(4000,1)  NOT NULL ,
	Tipo                 nvarchar(20)  NOT NULL ,
	Hora_entrada         time(2)  NOT NULL ,
	Hora_salida          time(2)  NOT NULL 
)
go

ALTER TABLE Turno
	ADD CONSTRAINT XPKTurno PRIMARY KEY  CLUSTERED (ID_turno ASC)
go

CREATE TABLE Usuario
( 
	ID_usuario           int identity(6000,1)  NOT NULL ,
	Nombre               nvarchar(50) NOT NULL unique ,
	Contraseña           nvarchar(50)  NOT NULL ,
	Nivel_privil         int  NOT NULL ,
	ID_empleado          int  NOT NULL unique
)
go

ALTER TABLE Usuario
	ADD CONSTRAINT XPKUsuario PRIMARY KEY  CLUSTERED (ID_usuario ASC)
go

CREATE TABLE Dias_labor
( 
	ID_diaslab           int identity(7000,1)  NOT NULL ,
	Dia                  nvarchar(20)  NOT NULL 
)
go

ALTER TABLE Dias_labor
	ADD CONSTRAINT XPKDias_labor PRIMARY KEY  CLUSTERED (ID_diaslab ASC)
go

CREATE TABLE Detalle_horario
( 
	ID_diaslab           int   NOT NULL ,
	ID_horario           int   NOT NULL 
)
go



ALTER TABLE Detalle_horario
	ADD CONSTRAINT R_1 FOREIGN KEY (ID_diaslab) REFERENCES Dias_labor(ID_diaslab)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Detalle_horario
	ADD CONSTRAINT R_2 FOREIGN KEY (ID_horario) REFERENCES Horario(ID_horario)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Cargo
	ADD CONSTRAINT R_3 FOREIGN KEY (ID_departam) REFERENCES Departamento(ID_departam)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Usuario
	ADD CONSTRAINT R_4 FOREIGN KEY (ID_empleado) REFERENCES Empleado(ID_empleado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Asistencia
	ADD CONSTRAINT R_5 FOREIGN KEY (ID_empleado) REFERENCES Empleado(ID_empleado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Horario
	ADD CONSTRAINT R_6 FOREIGN KEY (ID_turno) REFERENCES Turno(ID_turno)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Empleado
	ADD CONSTRAINT R_7 FOREIGN KEY (ID_turno) REFERENCES Turno(ID_turno)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Empleado
	ADD CONSTRAINT R_8 FOREIGN KEY (ID_horario) REFERENCES Horario(ID_horario)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Empleado
	ADD CONSTRAINT R_9 FOREIGN KEY (ID_departam) REFERENCES Departamento(ID_departam)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE Empleado
	ADD CONSTRAINT R_10 FOREIGN KEY (ID_cargo) REFERENCES Cargo(ID_cargo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


--------Permiso para crear el diagrama físico--------

ALTER AUTHORIZATION ON DATABASE :: bd_control_personal TO SA
go


--------Para dar formato a la fecha--------

set dateformat dmy

--------Datos que se deben ingresar por defecto------

insert into Departamento values('Departamento de ventas','Se realizan ventas, ya sea es la misma tienda, como por medio de delivery.','10')
insert into Departamento values('Departamento de contabilidad','Se gestiona los ingresos y egresos de la empresa.','10')
insert into Departamento values('Departamento de administración','Se organiza y gestiona la empresa.','10')
insert into Departamento values('Departamento de RRHH','Área de contratación de empleados.','10')


insert into Cargo values('Vendedor','Realiza ventas.','2000')
insert into Cargo values('Vendedor delivery','Realiza ventas por medio de delivery.','2000')
insert into Cargo values('Jefe de contabilidad','Maneja la cuenta de ingresos y egresos de la empresa.','2001')
insert into Cargo values('Contador','Elabora planilla.','2001')
insert into Cargo values('Administrador','Gestiona la empresa en general.','2002')
insert into Cargo values('Secretaria','Asiste al administrador.','2002')
insert into Cargo values('Supervisor','Supervisa las acciones de los trabajadores.','2002')
insert into Cargo values('Asistente de RRHH','Asistente de contratos.','2003')
insert into Cargo values('Director de RRHH','Gestiona el área de RRHH en general.','2003')


insert into Turno values('Mañana','09:00:00','13:00:00')
insert into Turno values('Tarde','13:00:00','18:00:00')
insert into Turno values('General','09:00:00','18:00:00')


insert into Dias_labor values('lunes')
insert into Dias_labor values('martes')
insert into Dias_labor values('miercoles')
insert into Dias_labor values('jueves')
insert into Dias_labor values('viernes')
insert into Dias_labor values('sábado')


insert into Horario values('09:00:00','13:00:00','00:00:00','00:00:00','De 9 a.m. a 1 p.m. Diario','4000')
insert into Horario values('14:00:00','18:00:00','00:00:00','00:00:00','De 2 p.m. a 6 p.m. Diario','4001')
insert into Horario values('09:00:00','18:00:00','13:00:00','14:00:00','De 9 a.m. a 6 p.m. Diario','4002')
insert into Horario values('09:00:00','13:00:00','00:00:00','00:00:00','De 9 a.m. a 1 p.m. Interdiario','4000')
insert into Horario values('14:00:00','18:00:00','00:00:00','00:00:00','De 2 p.m. a 6 p.m. Interdiario','4001')
insert into Horario values('09:00:00','18:00:00','13:00:00','14:00:00','De 9 a.m. a 6 p.m. Interdiario','4002')
insert into Horario values('09:00:00','18:00:00','13:00:00','14:00:00','De 9 a.m. a 6 p.m. Solo sábados','4002')

insert into Detalle_horario values('7000','5000')
insert into Detalle_horario values('7001','5000')
insert into Detalle_horario values('7002','5000')
insert into Detalle_horario values('7003','5000')
insert into Detalle_horario values('7004','5000')
insert into Detalle_horario values('7005','5000')

insert into Detalle_horario values('7000','5001')
insert into Detalle_horario values('7001','5001')
insert into Detalle_horario values('7002','5001')
insert into Detalle_horario values('7003','5001')
insert into Detalle_horario values('7004','5001')
insert into Detalle_horario values('7005','5001')

insert into Detalle_horario values('7000','5002')
insert into Detalle_horario values('7001','5002')
insert into Detalle_horario values('7002','5002')
insert into Detalle_horario values('7003','5002')
insert into Detalle_horario values('7004','5002')
insert into Detalle_horario values('7005','5002')

insert into Detalle_horario values('7000','5003')
insert into Detalle_horario values('7002','5003')
insert into Detalle_horario values('7004','5003')

insert into Detalle_horario values('7000','5004')
insert into Detalle_horario values('7002','5004')
insert into Detalle_horario values('7004','5004')

insert into Detalle_horario values('7000','5005')
insert into Detalle_horario values('7002','5005')
insert into Detalle_horario values('7004','5005')

insert into Detalle_horario values('7005','5006')


--------Datos que se ingresan por el sistema--------

insert into Empleado values ('Gutierrez', 'Molina', 'Pool Erick', '75388432', 'Masculino', null, '997316240', 'Nicolas Ayllon 2037', 'Lima', 'Ate','Activo', '4002', '5002', '2002', '3004')
insert into Empleado values ('Rodriguez', 'Cansaya', 'Alejandro', '74529683', 'Masculino', null, '991016031', 'Las Praderas 2037', 'Lima', 'Santa Anita','Activo', '4000', '5003', '2003', '3008')
insert into Empleado values ('Perez', 'Alvela', 'Richard', '74125698', 'Masculino', '5263485', '985632596', 'Av Las vendimias 4532', 'Lima', 'La Molina','Activo', '4001', '5004', '2000', '3000')
insert into Empleado values ('Portocarrero', 'Lopez', 'Liliana Rosa', '85632546', 'Femenino', '4152635', '999555862', 'Calle Los barros 1520', 'Lima', 'Santa Anita','Activo', '4002', '5005', '2003', '3007')
insert into Empleado values ('Gomez', 'Delta', 'Diana', '10526348', 'Femenino', null, '999454512', 'Nicolas Ayllon 1452', 'Lima', 'Ate','Activo', '4002', '5002', '2002', '3006')
insert into Empleado values ('Lopez', 'Guerrero', 'Kevin Roberto', '54632865', 'Masculino', null, '977485126', 'Los Girasoles 2037', 'Lima', 'Breña','Activo', '4001', '5004', '2000', '3000')
insert into Empleado values ('Galarza', 'Goñi', 'Brianna', '74852365', 'Femenino', '7485632', '956222301', 'Calle Los Rosales 1623', 'Lima', 'Ate','Activo', '4000', '5000', '2000', '3000')
insert into Empleado values ('Condori', 'Chavez', 'Romero', '15249638', 'Masculino', null, '900101523', 'Los Tulipanes 1652', 'Lima', 'Lurigancho','Activo', '4000', '5000', '2000', '3000')
insert into Empleado values ('Fernandez', 'Riera', 'Raúl Nelson', '45967125', 'Masculino', '1236526', '974000101', 'Pedregal Mz A Lt 5', 'Lima', 'Salamanca','Activo', '4001', '5001', '2000', '3000')
insert into Empleado values ('Montalvo', 'León', 'Jimena Caroll', '98645235', 'Femenino', null, '976555523', 'La Rotonda Mz F Lt 10', 'Lima', 'La Molina','Activo', '4001', '5001', '2002', '3005')
insert into Empleado values ('Hernandez', 'Flores', 'Diego Edson', '68532168', 'Masculino', '7452121', '952000362', 'Virgen del Carmen Mz G Lt 9', 'Lima', 'Ate','Activo', '4001', '5004', '2001', '3003')
insert into Empleado values ('Rivera', 'Gomez', 'Adrian Leonel', '74862351', 'Masculino', '6565326', '941000012', 'Primera entrada Mz K Lt 15', 'Lima', 'Lurigancho','Activo', '4000', '5000', '2002', '3005')
insert into Empleado values ('Medina', 'Tito', 'Luna Analy', '78456385', 'Femenino', null, '950000120', 'Nicolas Ayllon 4263', 'Lima', 'Ate','Activo', '4002', '5006', '2000', '3000')
insert into Empleado values ('Romero', 'Chavez', 'Adriana Lucia', '42536849', 'Femenino', '1549020', '942532610', 'Huarochiri 2036', 'Lima', 'Santa Anita','Activo', '4002', '5006', '2000', '3000')
insert into Empleado values ('Riviere', 'Rodriguez', 'Paul James', '12121536', 'Masculino', '1025202', '975889965', 'Los Oracles Mz L Lt 10', 'Lima', 'Breña','Activo', '4002', '5006', '2001', '3002')
insert into Empleado values ('Curi', 'León', 'Cristian Raul', '41200152', 'Masculino', '1068595', '985162306', 'Fontana 1463', 'Lima', 'Santa Anita','Activo', '4000', '5000', '2003', '3007')
insert into Empleado values ('Torrez', 'Lapaleta', 'Jazmin', '71020236', 'Femenino', '5510225', '998998956', 'Los Angeles Mz D Lt 6', 'Lima', 'Ate','Activo', '4000', '5000', '2000', '3000')
insert into Empleado values ('De la Cruz', 'Cente', 'Camilo', '98620035', 'Masculino', null, '946584325', 'Los Barracones 2037', 'Lima', 'San Miguel','Activo', '4000', '5000', '2000', '3001')
insert into Empleado values ('Castillo', 'Lopez', 'Fernando Rick', '45152630', 'Masculino', null, '976995864', 'Los Girasoles Mz a Lt 20', 'Lima', 'Breña','Activo', '4001', '5004', '2002', '3006')
insert into Empleado values ('Tapia', 'Cervante', 'Miguel', '85263020', 'Masculino', '1010256', '999666421', 'Andahuaylas Cr 10 2503', 'Lima', 'Santa Anita','Activo', '4002', '5006', '2000', '3001')

insert into Empleado values ('Cori', 'Ramirez', 'Raul', '11984001', 'Masculino', '1415325', '994521863', 'Fontana 1452', 'Lima', 'Santa Anita','Inactivo', '4000', '5000', '2003', '3007')
insert into Empleado values ('Castillo', 'Lapadula', 'Rosa', '30015201', 'Femenino', '1142586', '900000200', 'Los Angeles Mz F Lt 10', 'Lima', 'Ate','Inactivo', '4000', '5000', '2000', '3000')
insert into Empleado values ('Armando', 'Cente', 'Carlos', '45162002', 'Masculino', null, '974100502', 'Los Barrancos 2037', 'Lima', 'San Miguel','Inactivo', '4000', '5000', '2000', '3001')
insert into Empleado values ('Dominguez', 'Lopez', 'Roberto', '11410035', 'Masculino', null, '909025152', 'Los Tulipanes Mz a Lt 20', 'Lima', 'Breña','Inactivo', '4001', '5004', '2002', '3006')
insert into Empleado values ('Cervando', 'Gomez', 'Martin ', '74880015', 'Masculino', '1020154', '991486352', 'Huamanchuco Cr 10 2503', 'Lima', 'Santa Anita','Inactivo', '4002', '5006', '2000', '3001')

insert into Asistencia values ('08:48:59', '13:05:14', '08-07-2019', 'Asistió', '1007')
insert into Asistencia values ('08:50:23', '13:10:15', '08-07-2019', 'Asistió', '1001')
insert into Asistencia values ('08:51:38', '18:02:15', '08-07-2019', 'Asistió', '1004')
insert into Asistencia values ('08:52:23', '18:10:15', '08-07-2019', 'Asistió', '1000')
insert into Asistencia values ('08:54:33', '12:49:15', '08-07-2019', 'Asistió', '1015')
insert into Asistencia values ('08:55:23', '18:04:34', '08-07-2019', 'Asistió', '1010')
insert into Asistencia values ('08:56:13', '18:10:34', '08-07-2019', 'Asistió', '1003')
insert into Asistencia values ('08:56:33', '12:58:15', '08-07-2019', 'Asistió', '1016')
insert into Asistencia values ('08:58:23', '13:11:15', '08-07-2019', 'Asistió', '1011')
insert into Asistencia values ('08:59:23', '13:02:24', '08-07-2019', 'Asistió', '1006')
insert into Asistencia values ('09:36:45', '13:04:15', '08-07-2019', 'Tardanza', '1017')
insert into Asistencia values ('13:49:23', '18:09:34', '08-07-2019', 'Asistió', '1002')
insert into Asistencia values ('13:52:23', '18:05:45', '08-07-2019', 'Asistió', '1008')
insert into Asistencia values ('13:55:42', '18:10:04', '08-07-2019', 'Asistió', '1018')
insert into Asistencia values ('13:56:23', '18:15:45', '08-07-2019', 'Asistió', '1009')
insert into Asistencia values ('14:49:23', '18:12:24', '08-07-2019', 'Tardanza', '1005')

insert into Asistencia values ('08:59:16', '18:05:15', '09-07-2019', 'Asistió', '1000')
insert into Asistencia values ('09:25:25', '13:02:59', '09-07-2019', 'Tardanza', '1011')
insert into Asistencia values ('09:26:54', '13:06:06', '09-07-2019', 'Tardanza', '1017')
insert into Asistencia values ('09:30:16', '18:05:15', '09-07-2019', 'Tardanza', '1004')
insert into Asistencia values ('13:59:16', '18:05:55', '09-07-2019', 'Asistió', '1008')
insert into Asistencia values ('14:29:16', '18:14:55', '09-07-2019', 'Tardanza', '1009')
insert into Asistencia values ('00:00:00', '00:00:00', '09-07-2019', 'Faltó', '1015')
insert into Asistencia values ('00:00:00', '00:00:00', '09-07-2019', 'Faltó', '1016')
insert into Asistencia values ('00:00:00', '00:00:00', '09-07-2019', 'Faltó', '1001')

insert into Asistencia values ('08:49:25', '18:15:14', '10-07-2019', 'Asistió', '1000')
insert into Asistencia values ('08:50:12', '13:09:14', '10-07-2019', 'Asistió', '1001')
insert into Asistencia values ('08:51:24', '13:06:44', '10-07-2019', 'Asistió', '1007')
insert into Asistencia values ('08:53:34', '18:08:14', '10-07-2019', 'Asistió', '1004')

insert into Asistencia values ('08:57:59', '13:08:19', '10-07-2019', 'Asistió', '1017')
insert into Asistencia values ('08:59:54', '13:05:19', '10-07-2019', 'Asistió', '1016')
insert into Asistencia values ('09:30:54', '13:01:14', '10-07-2019', 'Tardanza', '1015')
insert into Asistencia values ('09:30:12', '13:19:14', '10-07-2019', 'Tardanza', '1011')
insert into Asistencia values ('09:32:31', '13:16:15', '10-07-2019', 'Tardanza', '1006')
insert into Asistencia values ('09:51:31', '18:05:15', '10-07-2019', 'Tardanza', '1010')
insert into Asistencia values ('13:49:25', '18:12:24', '10-07-2019', 'Asistió', '1009')
insert into Asistencia values ('13:51:31', '18:19:15', '10-07-2019', 'Asistió', '1005')
insert into Asistencia values ('13:52:25', '18:06:24', '10-07-2019', 'Asistió', '1008')
insert into Asistencia values ('13:53:31', '18:12:15', '10-07-2019', 'Asistió', '1002')
insert into Asistencia values ('13:55:11', '18:15:57', '10-07-2019', 'Asistió', '1018')
insert into Asistencia values ('00:00:00', '00:00:00', '10-07-2019', 'Faltó', '1003')

insert into Asistencia values ('08:49:56', '18:05:25', '11-07-2019', 'Asistió', '1000')
insert into Asistencia values ('08:51:56', '18:05:25', '11-07-2019', 'Asistió', '1004')
insert into Asistencia values ('08:53:15', '13:05:25', '11-07-2019', 'Asistió', '1001')
insert into Asistencia values ('08:55:52', '12:59:25', '11-07-2019', 'Asistió', '1016')
insert into Asistencia values ('08:57:52', '13:04:25', '11-07-2019', 'Asistió', '1015')
insert into Asistencia values ('08:59:15', '13:04:25', '11-07-2019', 'Asistió', '1011')
insert into Asistencia values ('09:37:01', '13:07:34', '11-07-2019', 'Tardanza', '1017')
insert into Asistencia values ('13:58:56', '18:04:25', '11-07-2019', 'Asistió', '1009')
insert into Asistencia values ('13:49:56', '18:04:25', '11-07-2019', 'Asistió', '1008')

insert into Asistencia values ('08:46:54', '18:12:45', '12-07-2019', 'Asistió', '1000')
insert into Asistencia values ('08:47:58', '13:13:45', '12-07-2019', 'Asistió', '1001')
insert into Asistencia values ('08:48:54', '18:10:25', '12-07-2019', 'Asistió', '1003')
insert into Asistencia values ('08:49:35', '18:10:45', '12-07-2019', 'Asistió', '1004')
insert into Asistencia values ('08:51:54', '13:07:35', '12-07-2019', 'Asistió', '1006')
insert into Asistencia values ('08:52:48', '13:07:26', '12-07-2019', 'Asistió', '1007')
insert into Asistencia values ('08:53:54', '18:04:25', '12-07-2019', 'Asistió', '1010')
insert into Asistencia values ('08:54:58', '12:45:45', '12-07-2019', 'Asistió', '1015')
insert into Asistencia values ('08:55:58', '12:55:45', '12-07-2019', 'Asistió', '1016')
insert into Asistencia values ('08:56:05', '13:05:04', '12-07-2019', 'Asistió', '1017')
insert into Asistencia values ('09:40:58', '13:03:45', '12-07-2019', 'Tardanza', '1011')
insert into Asistencia values ('13:55:54', '18:06:35', '12-07-2019', 'Asistió', '1005')
insert into Asistencia values ('13:59:08', '18:16:23', '12-07-2019', 'Asistió', '1018')
insert into Asistencia values ('14:25:00', '19:15:16', '12-07-2019', 'Tardanza', '1009')
insert into Asistencia values ('14:59:54', '18:25:25', '12-07-2019', 'Tardanza', '1002')
insert into Asistencia values ('00:00:00', '00:00:00', '12-07-2019', 'Faltó', '1008')

insert into Asistencia values ('08:49:24', '18:04:02', '13-07-2019', 'Asistió', '1019')
insert into Asistencia values ('08:51:10', '18:09:42', '13-07-2019', 'Asistió', '1000')
insert into Asistencia values ('08:53:26', '13:04:42', '13-07-2019', 'Asistió', '1001')
insert into Asistencia values ('08:54:26', '13:04:42', '13-07-2019', 'Asistió', '1011')
insert into Asistencia values ('08:56:57', '18:14:54', '13-07-2019', 'Asistió', '1012')
insert into Asistencia values ('08:57:14', '18:20:24', '13-07-2019', 'Asistió', '1013')
insert into Asistencia values ('08:58:45', '18:25:04', '13-07-2019', 'Asistió', '1014')
insert into Asistencia values ('09:29:33', '13:06:44', '13-07-2019', 'Tardanza', '1016')
insert into Asistencia values ('09:39:37', '13:05:12', '13-07-2019', 'Tardanza', '1017')
insert into Asistencia values ('13:54:10', '18:09:12', '13-07-2019', 'Asistió', '1008')
insert into Asistencia values ('13:59:10', '18:16:12', '13-07-2019', 'Asistió', '1009')
insert into Asistencia values ('00:00:00', '00:00:00', '13-07-2019', 'Faltó', '1015')
insert into Asistencia values ('00:00:00', '00:00:00', '14-07-2019', 'Faltó', '1004')


--Ingresar este dato obligatoriamente ya que es el usuario principal que accederá al sistema--

Insert into Usuario values ('Administrador', 'Idat123', 1, 1000)
Insert into Usuario values ('Director', 'Sistema123', 2, 1001)
Insert into Usuario values ('Vendedor', 'Sistema123', 3, 1005)
Insert into Usuario values ('Vendedor123', 'Sistema123', 3, 1002)

--------Algunas consultas--------

select *from Departamento
select *from Cargo
select *from Turno
select *from Horario
select *from Detalle_horario
select *from Dias_labor
select *from Usuario u join Empleado e on u.ID_empleado=e.ID_empleado
select *from Empleado
select *from Asistencia
Select ID_empleado, Ape_paterno, Ape_materno, Nombres, Dni, Direccion, ID_cargo, Horario.Descripcion from Empleado 
join Horario on Empleado.ID_horario = Horario.ID_horario

--------Consultas--------

select H.ID_horario, H.Descripcion, D.Dia from Horario H join Detalle_horario DH on 
(H.ID_horario = DH.ID_horario) join Dias_labor D on (DH.ID_diaslab = D.ID_diaslab)


select H.ID_horario, H.Descripcion, D.Dia from Horario H join Detalle_horario DH on 
(H.ID_horario = DH.ID_horario) join Dias_labor D on (DH.ID_diaslab = D.ID_diaslab) 
where H.Descripcion = 'De 9 a.m. a 1 p.m. Diario'


select E.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, Tipo, H.Hora_inicio, H.Hora_salida, Descripcion 
from Empleado E join Turno T on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = h.ID_horario)


select A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion, A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni 
from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado)


select A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion, A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni 
from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) where A.Descripcion = 'Asistió'


select A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion, A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni 
from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) where A.Descripcion = 'Tardanza'


select A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion, A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni 
from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) where A.Descripcion = 'Faltó'


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion 
from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado)


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, 
A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T 
on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario)


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, 
A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T 
on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) where A.Hora_salida < H.Hora_salida and A.Hora_salida > '00:00:00'


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, 
A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T 
on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) where A.Fecha = '2019-07-08' 


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, 
A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T 
on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) where A.Fecha = '2019-07-13' 


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, 
A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T 
on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) where T.Tipo = 'Mañana'


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, 
A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T 
on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) where T.Tipo = 'Tarde'


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion 
from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) where T.Tipo = 'General'


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, 
A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion, D.Nombre from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T 
on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) join Departamento D on (E.ID_departam = D.ID_departam)
where D.Nombre = 'Departamento de ventas' 


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion, D.Nombre 
from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) join Departamento D on (E.ID_departam = D.ID_departam)
where D.Nombre = 'Departamento de contabilidad' 


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion, C.Nombre
from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) join Cargo C on (E.ID_cargo = C.ID_cargo)
where C.Nombre = 'Vendedor' 


select A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, 
A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion, C.Nombre from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T 
on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) join Cargo C on (E.ID_cargo = C.ID_cargo)
where C.Nombre like 'Vendedor%' 


select E.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, D.Dia
from Empleado E join Turno T on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) join Detalle_horario DH on (H.ID_horario = DH.ID_horario) join Dias_labor D on (DH.ID_diaslab = D.ID_diaslab) 
where D.Dia = 'Lunes' 


select E.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, D.Dia
from Empleado E join Turno T on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) join Detalle_horario DH 
on (H.ID_horario = DH.ID_horario) join Dias_labor D on (DH.ID_diaslab = D.ID_diaslab) where D.Dia = 'Sábado' 


select top 10 A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, 
A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) 
join Turno T on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) where T.Tipo = 'Mañana' and A.Hora_entrada > '00:00:00'  
order by A.Hora_entrada


select top 10 A.ID_empleado, E.Ape_paterno, E.Ape_materno, E.Nombres, E.Dni, T.Tipo, Hora_inicio, H.Hora_salida, H.Descripcion, A.ID_asistencia, A.Hora_entrada, A.Hora_salida, A.Fecha, A.Descripcion 
from Asistencia A join Empleado E on (A.ID_empleado = E.ID_empleado) join Turno T on (E.ID_turno = T.ID_turno) join Horario H on (E.ID_horario = H.ID_horario) 
where T.Tipo = 'Mañana' and A.Hora_entrada > '00:00:00'  order by A.Hora_entrada

--PROCESOS ALMACENADOS----------------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_listar_emp
as
Select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, e.Celular, c.Nombre, h.Descripcion from Empleado e join Cargo c on e.ID_cargo = c.ID_cargo 
join Horario h on e.ID_horario = h.ID_horario
go


create procedure sp_listar_hor
as
Select h.ID_horario, h.Hora_inicio, h.Hora_salida, h.Inicio_descan, h.Fin_descan, h.Descripcion, t.Tipo from Horario h join Turno t on h.ID_turno = t.ID_turno
go


create procedure sp_listar_asis
as
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, a.Hora_entrada, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
go


create procedure sp_filtrar_asis
(
	@idemp			int	,
	@idcargo		int	,
	@descripcion	varchar(50)
)
as
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, a.Hora_entrada, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
join Cargo c on e.ID_cargo = c.ID_cargo where e.ID_empleado = @idemp  or e.ID_cargo = @idcargo or a.Descripcion = @descripcion
go

create procedure sp_filtrar_asisfecha
(
	@fecha1			date	,
	@fecha2			date
)
as
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, a.Hora_entrada, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
where a.Fecha between @fecha1 and @fecha2
go


create procedure sp_filtrar_empasisfecha
(
	@idemp			int		,
	@fecha1			date	,
	@fecha2			date
)
as
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, a.Hora_entrada, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
where a.ID_empleado = @idemp and a.Fecha between @fecha1 and @fecha2
go


create procedure sp_listar_usu
as
select u.ID_usuario, u.Nombre, u.Contraseña, u.Nivel_privil, e.ID_empleado, e.Ape_paterno, e.Nombres, c.Nombre as Cargo
from Usuario u join Empleado e on u.ID_empleado = e.ID_empleado
join Cargo c on e.ID_cargo = c.ID_cargo
go


create procedure sp_listar_emp2
as
Select e.ID_empleado, e.Ape_paterno, e.Nombres, c.Nombre from Empleado e join Cargo c on e.ID_cargo = c.ID_cargo 
go


create procedure sp_listar_dep
as
Select * from Departamento  
go


create procedure sp_listar_car
as
Select c.ID_cargo, c.Nombre, c.Descripcion, d.Nombre as Departamento from Cargo c join Departamento d on c.ID_departam = d.ID_departam
go


create procedure sp_listar_empactivo
as
Select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, e.Celular, e.Estado, c.Nombre from Empleado e join Cargo c on e.ID_cargo = c.ID_cargo 
where e.Estado = 'Activo'
go


create procedure sp_listar_empinactivo
as
Select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, e.Celular, e.Estado, c.Nombre from Empleado e join Cargo c on e.ID_cargo = c.ID_cargo 
where e.Estado = 'Inactivo'
go


create procedure sp_select_usu
(
@Nombre               nvarchar(50),
@Contraseña           nvarchar(50)
)
as
Select Nombre, Contraseña, Nivel_privil, ID_empleado from 
Usuario where Nombre = @Nombre and Contraseña = @Contraseña
go 


create procedure sp_listar_tur
as
Select * from Turno  
go


create procedure sp_buscar_usuario
(
@ID_usuario          int
)
as
select * from Usuario where ID_usuario = @ID_usuario
go 


create procedure sp_validar_usuario
(
@ID_emp          int   
)
as
select * from Usuario where ID_empleado = @ID_emp
go

create procedure sp_validar_nomusu
(
@nombre          varchar(50)   
)
as
select * from Usuario where Nombre = @nombre
go 


create procedure sp_actualizar_nomusu
(
@idemp			 int  ,
@contraseña      varchar(50)   ,
@nombre          varchar(50)   
)
as
update Usuario set Nombre = @nombre 
where ID_empleado = @idemp and Contraseña = @contraseña
go


create procedure sp_actualizar_contra
(
@idemp			 int  ,
@contraseña      varchar(50)  ,
@contranew       varchar(50)    
)
as
update Usuario set Contraseña = @contranew 
where ID_empleado = @idemp and Contraseña = @contraseña
go


--SP DE EMPLEADO-------------------------

create procedure sp_registrar_emp
(
	@Ape_paterno          nvarchar(50) ,
	@Ape_materno          nvarchar(50) ,
	@Nombres              nvarchar(50) ,
	@Dni                  char(8) ,
	@Sexo                 nvarchar(9) ,
	@Tel_fijo             char(7) ,
	@Celular              char(9) ,
	@Direccion            nvarchar(100) ,
	@Ciudad               nvarchar(50) ,
	@Distrito             nvarchar(50) ,
	@Estado               nvarchar(10) ,
	@ID_turno             int ,
	@ID_horario           int ,
	@ID_departam          int ,
	@ID_cargo             int 
	)
as
insert into Empleado values(@Ape_paterno, @Ape_materno, @Nombres, @Dni, @Sexo, @Tel_fijo, 
@Celular, @Direccion, @Ciudad, @Distrito, @Estado, @ID_turno, @ID_horario, @ID_departam, @ID_cargo)
go


create procedure sp_validar_dni
(
@Dni   char(8)
)
as
Select Dni from Empleado where Dni = @Dni
go 


create procedure sp_buscar_idemp
(
@Dni   char(8)
)
as
select ID_empleado from Empleado where Dni = @Dni
go 


create procedure sp_registrar_usu
(
	@Nombre               nvarchar(50)  ,
	@Contraseña           nvarchar(50)  ,
	@Nivel_privil         int  ,
	@ID_empleado          int 
)
as
insert into Usuario values(@Nombre, @Contraseña, @Nivel_privil, @ID_empleado)
go

create procedure sp_actualizar_usu
(
	@id_usu				  int  ,
	@Nombre               nvarchar(50)  ,
	@Contraseña           nvarchar(50)  ,
	@Nivel_privil         int  ,
	@ID_empleado          int 
)
as
update Usuario set Nombre = @Nombre, Contraseña = @Contraseña, Nivel_privil = @Nivel_privil
where ID_usuario = @id_usu
go

create procedure sp_validar_asis
(
	@ID_empleado          int ,
	@Contraseña           nvarchar(50)
)
as
select ID_empleado, Contraseña from Usuario where ID_empleado = @ID_empleado and Contraseña = @Contraseña 
go

create procedure sp_actualizar_emp
(
    @id_emp                int ,
    @Ape_paterno          nvarchar(50) ,
	@Ape_materno          nvarchar(50) ,
	@Nombres              nvarchar(50) ,
	@Dni                  char(8) ,
	@Sexo                 nvarchar(9) ,
	@Tel_fijo             char(7) ,
	@Celular              char(9) ,
	@Direccion            nvarchar(100) ,
	@Ciudad               nvarchar(50) ,
	@Distrito             nvarchar(50) ,
	@ID_turno             int ,
	@ID_horario           int ,
	@ID_departam          int ,
	@ID_cargo             int 
)
as 
update Empleado
set  Ape_paterno=@Ape_paterno, Ape_materno=@Ape_materno,Nombres=@Nombres, Dni=@Dni, Sexo=@Sexo, Tel_fijo=@Tel_fijo, 
Celular=@Celular, Direccion=@Direccion, Ciudad=@Ciudad, Distrito=@Distrito, ID_turno=@ID_turno, ID_horario=@ID_horario,
 ID_departam=@ID_departam, ID_cargo=@ID_cargo
where ID_empleado=@id_emp
go


create procedure sp_buscar_empleado
(
@id_emp  int
)
as
select * from Empleado 
where ID_empleado = @id_emp
go


create procedure sp_baja_emp
(
    @id_emp                int ,
	@Estado                nvarchar(100)
)
as 
update Empleado
set  Estado=@Estado where ID_empleado=@id_emp
go


create procedure sp_alta_emp
(
    @id_emp                int ,
	@Estado                nvarchar(100)
)
as 
update Empleado
set  Estado=@Estado where ID_empleado=@id_emp
go


create procedure sp_eliminar_emp
(
    @id_emp                int 
)
as 
delete from Empleado where ID_empleado = @id_emp
go


create procedure sp_eliminar_usu
(
	@id_emp		int
)
as
delete from Usuario where ID_empleado = @id_emp
go

create procedure sp_eliminar_usuario
(
	@id_usu		int
)
as
delete from Usuario where ID_usuario = @id_usu
go

create procedure sp_select_emp
as
select ID_empleado, Ape_paterno + ' ' + Ape_materno + ' ' + Nombres as Nombres from Empleado
go


create procedure sp_listar_actfiltro
(
	@idcargo		int  ,
	@iddep			int
)
as
Select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, e.Celular, e.Estado, c.Nombre 
from Empleado e join Cargo c on e.ID_cargo = c.ID_cargo 
where e.Estado = 'Activo' and(e.ID_departam = @iddep or e.ID_cargo = @idcargo)
go

create procedure sp_listar_inacfiltro
(
	@idcargo		int  ,
	@iddep			int
)
as
Select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, e.Celular, e.Estado, c.Nombre 
from Empleado e join Cargo c on e.ID_cargo = c.ID_cargo 
where e.Estado = 'Inactivo' and(e.ID_departam = @iddep or e.ID_cargo = @idcargo)
go

--SP DE INFORME GENERAL--------------------------------------------------------------

create procedure sp_contar_emptur
(
	@idturno		int
)
as
select count(ID_empleado) from Empleado 
where ID_turno = @idturno
go

create procedure sp_contar_emphor
(
	@idhorario		int
)
as
select count(ID_empleado) from Empleado 
where ID_horario = @idhorario
go

create procedure sp_contar_empdep
(
	@iddep		int
)
as
select count(ID_empleado) from Empleado 
where ID_departam = @iddep
go

create procedure sp_contar_empcar
(
	@idcar		int
)
as
select count(ID_empleado) from Empleado 
where ID_cargo = @idcar
go


--SP DE ASISTENCIA--------------------------

create procedure sp_registrar_entrada
(
	@Hora_entrada         time(2) ,
	@Hora_salida          time(2) ,
	@Fecha                date ,
	@Descripcion          nvarchar(50) ,
	@ID_empleado          int
)
as
insert into Asistencia values(@Hora_entrada, @Hora_salida, @Fecha, @Descripcion, @ID_empleado)
go


create procedure sp_buscar_dia
(
	@ID_empleado		int  ,
	@Dia                nvarchar(20)
)
as
select d.Dia from Empleado e join Horario h on e.ID_horario = h.ID_horario join Detalle_horario dh on h.ID_horario = dh.ID_horario 
join Dias_labor d on dh.ID_diaslab = d.ID_diaslab where e.ID_empleado = @ID_empleado and d.Dia = @Dia
go


create procedure sp_registrar_salida
(
	@Hora_salida          time(2) ,
	@Fecha                date ,
	@ID_empleado          int 
)
as
update Asistencia set Hora_salida = @Hora_salida where Fecha = @Fecha and ID_empleado = @ID_empleado and Hora_salida = '00:00:00'
go


create procedure sp_validar_entrada
(
	@Fecha                date ,
	@ID_empleado          int 
)
as
select *from Asistencia where Fecha = @Fecha and ID_empleado = @ID_empleado
go


create procedure sp_validar_salida
(
	@Hora_salida          time(2) ,
	@Fecha                date ,
	@ID_empleado          int 
)
as
select *from Asistencia where Hora_salida = @Hora_salida and Fecha = @Fecha and ID_empleado = @ID_empleado
go


create procedure sp_consultar_dni
(
	@Dni                  char(8) 
)
as
select ID_empleado from Empleado where Dni = @Dni
go


create procedure sp_buscar_emp
(
	@ID_empleado           int 
)
as
Select e.Ape_paterno, e.Ape_materno, e.Nombres, h.Descripcion from Empleado e 
join Horario h on e.ID_horario = h.ID_horario where e.ID_empleado = @ID_empleado
go


create procedure sp_validar_horario
(
	@ID_empleado           int 
)
as
select h.Hora_inicio
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado 
join Horario h on e.ID_horario = h.ID_horario
where a.ID_empleado = @ID_empleado
group by h.Hora_inicio
go


--SP DE HORARIO-----------------------

Create procedure sp_registrar_horario
(
	@Hora_inicio          time(2) ,
	@Hora_salida          time(2) ,
	@Inicio_descan        time(2) ,
	@Fin_descan           time(2) ,
	@Descripcion          nvarchar(100) ,
	@ID_turno             int 
)
as 
insert Into Horario
values(@Hora_inicio,@Hora_salida,@Inicio_descan,@Fin_descan,@Descripcion,@ID_turno)  
go 


create procedure sp_registrar_detalle
(
@id_dias_laborales int,
@id_horario   int
)
as 
insert Into Detalle_horario
values(@id_dias_laborales,@id_horario) 
go


create procedure sp_buscar_idhor
as
Select max(ID_horario) as idhor from horario  
go


Create procedure sp_actualizar_horario
(
	@id_horario           int,
	@Hora_inicio          time(2) ,
	@Hora_salida          time(2) ,
	@Inicio_descan        time(2) ,
	@Fin_descan           time(2) ,
	@Descripcion          nvarchar(100) ,
	@ID_turno             int 
)
as 
update Horario
set Hora_inicio=@Hora_inicio,Hora_salida=@Hora_salida,Inicio_descan=@Inicio_descan,Fin_descan=@Fin_descan,Descripcion=@Descripcion,ID_turno=@ID_turno 
where ID_horario=@id_horario
go 


create procedure sp_buscar_horario
(
@id_horario int
)
as
select * from Horario
where ID_horario = @id_horario
go

create procedure sp_buscar_detalle
(
@id_horario int
)
as
select * from Detalle_horario
where ID_horario = @id_horario
go


Create procedure sp_actualizar_detalle
(
	@id_horario           int	 
)
as 
delete from Detalle_horario where ID_horario=@id_horario
go 


--SP DE DEPARTAMENTO--------------------

create procedure sp_registrar_departamento
(
	@nombre          varchar(50) ,
	@descripcion      varchar(100) ,
	@num_trab        int 	
)
as 
insert into Departamento
values(@nombre, @descripcion, @num_trab)
go


Create procedure sp_actualizar_departamento
(
	@id_departam            int,
	@nombre          varchar(50) ,
	@descripcion      varchar(100) ,
	@num_trab        int 	
)
as 
update Departamento
set Nombre=@nombre,Descripcion=@descripcion,Num_trab=@num_trab
where ID_departam=@id_departam
go
 

create procedure sp_buscar_departamento
(
@id_departamento int
)
as
select * from Departamento
where ID_departam = @id_departamento
go 


--SP DE CARGO---------------------------
create procedure sp_registrar_cargo
(
	@nombre         varchar(50) ,
	@descripcion    varchar(100) ,
	@id_dep			int
)
as 
insert into Cargo
values(@nombre, @descripcion, @id_dep)
go

create procedure sp_actualizar_cargo
(
    @id_cargo          int,
	@nombre            varchar(50) ,
	@descripcion       varchar(100) ,
	@id_departam       int 
)
as 
update Cargo
set Nombre=@nombre,Descripcion=@descripcion,ID_departam=@id_departam
where ID_cargo=@id_cargo
go

create procedure sp_buscar_cargo
(
@id_cargo int
)
as
select * from Cargo
where ID_cargo = @id_cargo
go

create procedure sp_consultar_rep
(
@id_emp int
)
as
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, a.Hora_entrada, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
where a.ID_empleado = @id_emp
go


--SP DE TURNO----------------------------

create procedure sp_registrar_turno
(
	@tipo         varchar(50) ,
	@entrada      time(2) ,
	@salida	      time(2)
)
as 
insert into Turno
values(@tipo, @entrada, @salida)
go

create procedure sp_actualizar_turno
(
    @id_turno     int,
	@tipo         varchar(50) ,
	@entrada      time(2) ,
	@salida	      time(2)
)
as 
update Turno
set Tipo=@tipo,Hora_entrada=@entrada,Hora_salida=@salida
where ID_turno=@id_turno
go

create procedure sp_buscar_turno
(
@id_turno		int
)
as
select * from Turno
where ID_turno = @id_turno
go


--SP DE REPORTES-------------------------

create procedure sp_reporte_asisxemp
(
	@id_emp		int
)
as
begin
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, c.Nombre, h.Hora_inicio, a.Hora_entrada, 
h.Hora_salida, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
join Cargo c on e.ID_cargo = c.ID_cargo
where a.ID_empleado = @id_emp
end


create procedure sp_reporte_asisxfecha
(
	@fecha1			date	,
	@fecha2			date
)
as
begin
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, c.Nombre, h.Hora_inicio, a.Hora_entrada, 
h.Hora_salida, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
join Cargo c on e.ID_cargo = c.ID_cargo
where a.Fecha between @fecha1 and @fecha2
end


create procedure sp_reporte_asisxprmt
(
	@idcargo		int  ,
	@descripcion    varchar(50) 
)
as
begin
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, c.Nombre, h.Hora_inicio, a.Hora_entrada, 
h.Hora_salida, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
join Cargo c on e.ID_cargo = c.ID_cargo 
where e.ID_cargo = @idcargo or a.Descripcion = @descripcion
end


create procedure sp_reporte_asisgen
as
begin
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, c.Nombre, h.Hora_inicio, a.Hora_entrada, 
h.Hora_salida, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
join Cargo c on e.ID_cargo = c.ID_cargo 
end


create procedure sp_reporte_empasisxfecha
(
	@idemp			int		,
	@fecha1			date	,
	@fecha2			date
)
as
begin
select e.ID_empleado, e.Ape_paterno, e.Ape_materno, e.Nombres, e.Dni, c.Nombre, h.Hora_inicio, a.Hora_entrada, 
h.Hora_salida, a.Hora_salida, a.Fecha, a.Descripcion,
	CASE 
	WHEN a.Hora_salida = '00:00:00:00' THEN 0
	WHEN a.Descripcion = 'Faltó' THEN 0 
	WHEN a.Hora_salida < h.Inicio_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	WHEN a.Hora_salida BETWEEN H.Inicio_descan AND H.Fin_descan THEN (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60)
	ELSE (DATEDIFF(minute, a.Hora_entrada, a.Hora_salida)/60) - (DATEDIFF(minute, h.Inicio_descan, h.Fin_descan)/60) 
	END as [Horas_trabajadas] 
from Asistencia a join Empleado e on a.ID_empleado = e.ID_empleado join Horario h on e.ID_horario = h.ID_horario
join Cargo c on e.ID_cargo = c.ID_cargo
where e.ID_empleado = @idemp and a.Fecha between @fecha1 and @fecha2
end


create procedure sp_borrar_reportesxfecha
(
	@fecha1			date	,
	@fecha2			date
)
as
begin
delete from Asistencia 
where Fecha between @fecha1 and @fecha2
end

