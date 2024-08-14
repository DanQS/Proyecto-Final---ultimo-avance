create table Registro_de_Estudiantes (
 numero_cedula_estudiante int primary key, 
 nombre_estudiante varchar (20) not null, 
 primer_apellido_estudiante varchar (30) not null, 
 segundo_apellido_estudiante varchar (30) not null,
 fecha_nacimiento_estudiante date not null, 
 direccion_estudiante nvarchar (300) not null,
 grado_a_matricular int check (grado_a_matricular >= 7 and grado_a_matricular <=11),
 adjuntos bit not null,
 )

 create table Registro_de_padres_o_encargados (
 numero_cedula_encargado_legal int primary key, 
 nombre_encargado_legal varchar (20) not null, 
 primer_apellido_encargado_legal varchar (30) not null, 
 segundo_apellido_encargado_legal varchar (30) not null, 
 datos_trabajo_encargado_legal nvarchar (300) not null,
 numero_telefonico nvarchar (8) not null,
 numero_cedula_estudiante int unique not null 
 foreign key (numero_cedula_estudiante) references Registro_de_Estudiantes (numero_cedula_estudiante),
 )

create table Beca_Comedor (
 beca_comedor bit primary key not null,
 numero_cedula_estudiante int unique not null 
 foreign key (numero_cedula_estudiante) references Registro_de_Estudiantes (numero_cedula_estudiante),
 )

create table Estado_de_Matricula (
estado_matricula bit primary key not null,
numero_cedula_estudiante int unique not null 
foreign key (numero_cedula_estudiante) references Registro_de_Estudiantes (numero_cedula_estudiante),
)