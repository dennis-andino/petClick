use master 
if exists (select * from sys.databases where name='veterinaria')
drop database veterinaria
go

create database veterinaria
go

use veterinaria
go

--------------------------------------------------------------------------------------------------------
------------------------------TABLAS INDEPENDIENTES-----------------------------------------------------
--------------------------------------------------------------------------------------------------------

create table dbo.cliente(
cli_Id int identity (1,1) not null,
cli_Nombre varchar(15) not null,
cli_Apellido varchar(15) not null,
cli_DireccionT varchar(50) not null,
cli_DireccionC varchar(50) not null,
cli_Telefono varchar(20) not null,
cli_Celular varchar (20) not null,
cli_Correo varchar(30)
primary key(cli_ID)
)
go
--------------------------------------------------------------------------------------------------------
--tabla especialidades 
create table dbo.especialidades(
esp_Id int identity (1,1) not null,
esp_Nombre varchar(20) not null,
esp_Otros varchar(50) not null,
primary key(esp_Id)
)
go
--------------------------------------------------------------------------------------------------------
--tabla Servicios
create table dbo.servicios(
ser_Id int identity(1,1) not null,
ser_Nombre varchar(20) not null,
primary key(ser_Id)
)
go
--------------------------------------------------------------------------------------------------------
--tabla enfermedad
create table dbo.enfermedades(
enf_Id int identity(1,1) not null,
enf_Nombre varchar (20) not null,
enf_Descripcion varchar(500)
primary key(enf_Id) 
)
go
--------------------------------------------------------------------------------------------------------
create table dbo.farmacias(
far_Id int identity(1,1) not null,
far_Nombre varchar(20) not null,
far_Direccion varchar(60) not null
primary key(far_Id)
)
go
--------------------------------------------------------------------------------------------------------
--tabla Especie
create table dbo.especie(
esp_Id int identity (1,1) not null,
esp_Nombre varchar(25) not null
primary key(esp_Id)
)
go
--------------------------------------------------------------------------------------------------------
--tabla usuarios
create table dbo.usuarios(
usu_Nickname int identity(1000,1) not null,
usu_Clave varchar(10),
usu_NombreCompleto varchar(35) not null,
usu_Puesto varchar(14) not null,
primary key(usu_Nickname)
)
go
--------------------------------------------------------------------------------------------------------
------------------------------TABLAS DEPENDIENTES-------------------------------------------------------
--------------------------------------------------------------------------------------------------------

create table dbo.medicamentos(
med_Id int identity(1,1) not null,
med_Nombre varchar(30) not null,
med_Descripcion varchar (70),
med_Costo decimal(8,2) not null,
med_Enfermedad int not null,
med_proveedor int not null,
primary key(med_Id),
foreign key (med_Enfermedad) references dbo.enfermedades(enf_Id),
foreign key (med_proveedor) references dbo.farmacias(far_Id)
)
go
--------------------------------------------------------------------------------------------------------
create table dbo.raza(
raz_Id int identity (1,1) not null,
raz_EspId int not null,
raz_Nombre varchar(20),
primary key(raz_Id),
foreign key(raz_EspId) references dbo.especie(esp_Id)
)
go
--------------------------------------------------------------------------------------------------------
--tabla Mascota
create table dbo.Mascota(
mas_Id int identity(1,1) not null,
mas_DuenhoID int not null,
mas_Nombre varchar(25) not null,
mas_Sexo char not null,
mas_EspecieId int not null,
mas_EspecieTipoId int not null,
mas_FechaNac date,
mas_TipoSangre varchar(8) not null,
mas_Color varchar (30)not null,
mas_Habitat varchar(30),
mas_Peso decimal(6,2) not null,
mas_Otros varchar(100)
primary key(mas_Id)
foreign key(mas_DuenhoID) references dbo.cliente(cli_Id),
foreign key(mas_EspecieId) references dbo.especie(esp_Id),
foreign key(mas_EspecieTipoId) references dbo.raza(raz_Id)
)
go
--------------------------------------------------------------------------------------------------------

--tabla Veterinario
create table dbo.veterinario(
vet_Id int identity (1,1) not null,
vet_Nombres varchar(25) not null,
vet_Apellidos varchar(25) not null,
vet_DireccionC varchar(50) not null,
vet_Telefono varchar(15) not null,
vet_Celular varchar(15) not null,
vet_Correo varchar (30) ,
vet_EspecialidadId int not null
primary key(vet_Id),
foreign key(vet_EspecialidadId)references dbo.especialidades(esp_Id)
)
go

--------------------------------------------------------------------------------------------------------
create table dbo.historial(
his_id int identity(1,1) not null,
his_motivo varchar(80),
his_fecha date not null,
his_diagnostico varchar(350),
his_tratamiento varchar(350),
his_proximacita date,
his_costo decimal (8,2),
his_paciente int not null,
his_cliente int not null,
his_personal int not null,
his_servicio int not null,
primary key(his_id),
foreign key(his_paciente) references dbo.mascota(mas_Id),
foreign key(his_cliente) references dbo.cliente(cli_Id),
foreign key(his_personal) references dbo.veterinario(vet_Id),
foreign key(his_servicio) references dbo.servicios(ser_Id)
)
go

--------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS MOSTRAR----------------------------------------------------
--------------------------------------------------------------------------------------------------------
create procedure sp_sCliente as 
select *from veterinaria.dbo.cliente order by dbo.cliente.cli_Id
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sPacienteCliente as 
select dbo.Mascota.mas_Id,dbo.Mascota.mas_Nombre,dbo.cliente.cli_Nombre,dbo.cliente.cli_Id 
from dbo.Mascota inner join dbo.cliente on dbo.Mascota.mas_DuenhoID=dbo.cliente.cli_Id
order by dbo.Mascota.mas_Nombre
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sClienteResumen as 
select dbo.cliente.cli_Id,dbo.cliente.cli_Nombre,dbo.cliente.cli_Apellido  from veterinaria.dbo.cliente order by dbo.cliente.cli_Id
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sEspecialidades as 
select *from dbo.especialidades order by esp_Id 
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sEspecialidades_lista as 
select dbo.especialidades.esp_Id,dbo.especialidades.esp_Nombre from dbo.especialidades order by esp_Nombre
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sServicios as 
select *from dbo.servicios order by ser_Id 
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sEnfermedades as 
select * from veterinaria.dbo.enfermedades order by enf_Id
go
--------------------------------------------------------------------------------------------------------
create procedure  sp_sEnfermedadesBasico as 
select dbo.enfermedades.enf_Id,dbo.enfermedades.enf_Nombre from dbo.enfermedades 
order by dbo.enfermedades.enf_Nombre
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sFarmacias as 
select * from dbo.farmacias order by far_Id 
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sFarmaciab as 
select dbo.farmacias.far_Id,dbo.farmacias.far_Nombre from dbo.farmacias
order by dbo.farmacias.far_Nombre
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sEspecie as 
select * from dbo.especie order by esp_Id 
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sUsuarios as
select * from dbo.usuarios order by usu_Nickname
go 
--------------------------------------------------------------------------------------------------------
create procedure sp_LoginUsuarios 
@usu_Clave varchar(10),
@usu_Nickname int as 
select usu_NombreCompleto,usu_Puesto from veterinaria.dbo.usuarios where dbo.usuarios.usu_Clave=@usu_Clave and dbo.usuarios.usu_Nickname=@usu_Nickname
go
--------------------------------------------------------------------------------------------------------
create procedure sp_sMedicamentos as 
select dbo.medicamentos.med_Id, dbo.medicamentos.med_Nombre, dbo.medicamentos.med_Descripcion, dbo.medicamentos.med_Costo,
dbo.enfermedades.enf_Nombre,dbo.farmacias.far_Nombre from dbo.medicamentos inner join dbo.enfermedades on dbo.medicamentos.med_Enfermedad=dbo.enfermedades.enf_Id
inner join  dbo.farmacias on dbo.medicamentos.med_proveedor=dbo.farmacias.far_Id order by dbo.medicamentos.med_Nombre
go
--------------------------------------------------------------------------------------------------------
create procedure  sp_sraza as
select dbo.raza.raz_Id,dbo.especie.esp_Nombre,dbo.raza.raz_Nombre from dbo.raza inner join dbo.especie   on
dbo.raza.raz_EspId=dbo.especie.esp_Id  order by esp_Nombre  
go
--------------------------------------------------------------------------------------------------------
create procedure sp_srazaPorEspecie
@especieId int as
select dbo.raza.raz_Id,dbo.raza.raz_Nombre from dbo.raza where dbo.raza.raz_EspId=@especieId
order by dbo.raza.raz_Nombre
go


--------------------------------------------------------------------------------------------------------
create procedure sp_sMascota as
select 
dbo.Mascota.mas_Id,
dbo.Mascota.mas_Nombre,
dbo.cliente.cli_Nombre,
dbo.cliente.cli_Apellido,
dbo.Mascota.mas_Sexo,
dbo.especie.esp_Nombre,
dbo.raza.raz_Nombre,
dbo.Mascota.mas_FechaNac,
dbo.Mascota.mas_TipoSangre,
dbo.Mascota.mas_Color,
dbo.Mascota.mas_Habitat,
dbo.Mascota.mas_Peso,
dbo.Mascota.mas_Otros
  from dbo.Mascota  inner join  dbo.cliente on dbo.Mascota.mas_DuenhoID=dbo.cliente.cli_Id
  inner join dbo.raza on dbo.raza.raz_Id=mas_EspecieTipoId
  inner join dbo.especie on dbo.especie.esp_Id=mas_EspecieId
order by dbo.Mascota.mas_Id
go
--------------------------------------------------------------------------------------------------------
create procedure sp_shistorial as
select dbo.historial.his_id,dbo.historial.his_fecha,dbo.Mascota.mas_Nombre,dbo.cliente.cli_Nombre,dbo.cliente.cli_Apellido,dbo.historial.his_motivo,
dbo.veterinario.vet_Nombres,dbo.veterinario.vet_Apellidos,dbo.historial.his_diagnostico,dbo.servicios.ser_Nombre,dbo.historial.his_tratamiento,dbo.historial.his_costo,dbo.historial.his_proximacita from
dbo.historial inner join dbo.Mascota on dbo.historial.his_paciente=dbo.Mascota.mas_Id inner join dbo.cliente on dbo.historial.his_cliente=dbo.cliente.cli_Id
inner join dbo.veterinario on dbo.historial.his_personal=dbo.veterinario.vet_Id inner join dbo.servicios on dbo.historial.his_servicio=dbo.servicios.ser_Id
order by dbo.Mascota.mas_Nombre
go

--------------------------------------------------------------------------------------------------------
create procedure sp_sVeterinarioEspecialidad as 
select dbo.veterinario.vet_Id,dbo.veterinario.vet_Nombres,dbo.veterinario.vet_Apellidos,dbo.especialidades.esp_Id,dbo.especialidades.esp_Nombre 
from dbo.veterinario inner join dbo.especialidades on dbo.veterinario.vet_EspecialidadId=dbo.especialidades.esp_Id order by dbo.veterinario.vet_Nombres
go

create procedure sp_sVeterinario as select
	dbo.veterinario.vet_Id,dbo.veterinario.vet_Nombres,dbo.veterinario.vet_Apellidos,
	dbo.especialidades.esp_Nombre,dbo.veterinario.vet_DireccionC,dbo.veterinario.vet_Telefono,
	dbo.veterinario.vet_Celular,veterinario.vet_Correo from dbo.veterinario inner join dbo.especialidades
	on dbo.veterinario.vet_EspecialidadId=dbo.especialidades.esp_Id
	go
--------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS INSERTAR----------------------------------------------------
--------------------------------------------------------------------------------------------------------

create procedure sp_iMedicamentos
@med_Nombre varchar(30),
@med_Descripcion varchar(70),
@med_Costo decimal(8,2),
@med_Enfermedad int, 
@med_proveedor int  as insert into dbo.medicamentos (med_Nombre,med_Descripcion,med_Costo,med_Enfermedad,med_proveedor)
values(@med_Nombre,@med_Descripcion,@med_Costo,@med_Enfermedad,@med_proveedor)
go
--------------------------------------------------------------------------------------------------------
create procedure sp_iFarmacias
@far_Nombre varchar(20),
@far_Direccion varchar(60) as
insert into dbo.farmacias (far_Nombre,far_Direccion)
values (@far_Nombre,@far_Direccion)
go
--------------------------------------------------------------------------------------------------------
create procedure sp_ihistorial 
@his_motivo varchar(80),
@his_fecha date,
@his_diagnostico varchar(350),
@his_tratamiento varchar(350),
@his_proximacita date,
@his_costo decimal (8,2),
@his_paciente int ,
@his_cliente int,
@his_personal int ,
@his_servicio int as 
insert into dbo.historial (his_motivo,his_fecha ,his_diagnostico,his_tratamiento,his_proximacita,his_costo ,his_paciente,his_cliente,his_personal,his_servicio) 
values (@his_motivo,@his_fecha ,@his_diagnostico,@his_tratamiento,@his_proximacita,@his_costo,@his_paciente,@his_cliente,@his_personal,@his_servicio)
go
--------------------------------------------------------------------------------------------------------
create procedure sp_iCliente
@cli_Nombre varchar(15),
@cli_Apellido varchar(15),
@cli_DireccionT varchar(50),
@cli_DireccionC varchar(50),
@cli_Telefono varchar(20),
@cli_Celular varchar (20),
@cli_Correo varchar(30)
as insert into dbo.cliente (cli_Nombre,cli_Apellido,cli_DireccionT,cli_DireccionC,cli_Telefono,cli_Celular,cli_Correo)
values
(@cli_Nombre,@cli_Apellido,@cli_DireccionT,@cli_DireccionC,@cli_Telefono,@cli_Celular,@cli_Correo)
go

--------------------------------------------------------------------------------------------------------
create procedure sp_iEspecialidades
@esp_Nombre varchar(20),
@esp_Otros varchar(50) as insert into dbo.especialidades 
(esp_Nombre,esp_Otros) values (@esp_Nombre,@esp_Otros)
go
--------------------------------------------------------------------------------------------------------
create procedure sp_iServicios
@ser_Nombre varchar(20) as insert into dbo.servicios (ser_Nombre)
values(@ser_Nombre)
go
--------------------------------------------------------------------------------------------------------
create procedure sp_iEnfermedades
@enf_Nombre varchar (20),
@enf_Descripcion varchar(500) as 
insert into dbo.enfermedades (enf_Nombre,enf_Descripcion)values (@enf_Nombre,@enf_Descripcion)
go
--------------------------------------------------------------------------------------------------------
create procedure sp_iEspecie
@esp_Nombre varchar(25) as insert into dbo.especie (esp_Nombre) 
values (@esp_Nombre)
go
--------------------------------------------------------------------------------------------------------
create procedure sp_iUsuarios
@usu_Clave varchar(10),
@usu_NombreCompleto varchar(35),
@usu_Puesto varchar(14) as insert into dbo.usuarios (usu_Clave,usu_NombreCompleto,usu_Puesto)
values (@usu_Clave,@usu_NombreCompleto,@usu_Puesto)
go
--------------------------------------------------------------------------------------------------------

create procedure sp_iraza
@raz_EspId int,
@raz_Nombre varchar(20) as insert into dbo.raza(raz_EspId,raz_Nombre)
values (@raz_EspId,@raz_Nombre)
go
--------------------------------------------------------------------------------------------------------
create procedure sp_iMascota 
@mas_DuenhoID int ,
@mas_Nombre varchar(25),
@mas_Sexo char ,
@mas_EspecieId int ,
@mas_EspecieTipoId int ,
@mas_FechaNac date,
@mas_TipoSangre varchar(8) ,
@mas_Color varchar (30),
@mas_Habitat varchar(30),
@mas_Peso decimal(6,2),
@mas_Otros varchar(100) as insert into dbo.Mascota (mas_DuenhoID,mas_Nombre,mas_Sexo ,
mas_EspecieId,mas_EspecieTipoId,
mas_FechaNac ,mas_TipoSangre ,
mas_Color,mas_Habitat,
mas_Peso,mas_Otros)
values(@mas_DuenhoID,@mas_Nombre,@mas_Sexo ,
@mas_EspecieId,@mas_EspecieTipoId,
@mas_FechaNac ,@mas_TipoSangre ,
@mas_Color,@mas_Habitat,
@mas_Peso,@mas_Otros)
go

--------------------------------------------------------------------------------------------------------
create procedure sp_iVeterinario
@vet_Nombres varchar(20),
@vet_Apellidos varchar(20),
@vet_DireccionC varchar(30),
@vet_Telefono varchar(15),
@vet_Celular varchar(15),
@vet_Correo varchar (30),
@vet_EspecialidadId int as 
insert into dbo.veterinario (vet_Nombres,vet_Apellidos,vet_DireccionC ,vet_Telefono ,vet_Celular,vet_Correo,vet_EspecialidadId)
values (@vet_Nombres,@vet_Apellidos,@vet_DireccionC ,@vet_Telefono ,@vet_Celular,@vet_Correo,@vet_EspecialidadId)
go
--------------------------------------------------------------------------------------------------------

--------------------------------------------------------------------------------------------------------
------------------------------PROCEDIMIENTOS ACTUALIZAR----------------------------------------------------
--------------------------------------------------------------------------------------------------------

--------------------------------------------------------------------------------------------------------
create procedure sp_uMedicametos
@med_Id int,
@med_Nombre varchar(30),
@med_Descripcion varchar(70),
@med_Costo decimal(8,2),
@med_Enfermedad int, 
@med_proveedor int  as update dbo.medicamentos set
med_Nombre=@med_Nombre,
med_Descripcion=@med_Descripcion,
med_Costo=@med_Costo,
med_Enfermedad=@med_Enfermedad,
med_proveedor=@med_proveedor where med_Id=@med_Id
go

create procedure sp_uFarmacias
@far_Id int ,
@far_Nombre varchar(20),
@far_Direccion varchar(60) as update dbo.farmacias set
far_Nombre=@far_Nombre,
far_Direccion=@far_Direccion where far_Id=@far_Id
go
create procedure sp_uCliente
@cli_Id int,
@cli_Nombre varchar(15),
@cli_Apellido varchar(15),
@cli_DireccionT varchar(50),
@cli_DireccionC varchar(50),
@cli_Telefono varchar(20),
@cli_Celular varchar (20),
@cli_Correo varchar(30)
as update dbo.cliente set
cli_Nombre=@cli_Nombre,
cli_Apellido=@cli_Apellido,
cli_DireccionT=@cli_DireccionT,
cli_DireccionC=@cli_DireccionC,
cli_Telefono=@cli_Telefono,
cli_Celular=@cli_Celular,
cli_Correo=@cli_Correo
where cli_Id=@cli_Id
go


create procedure sp_uEspecialidades
@esp_Id int,
@esp_Nombre varchar(20),
@esp_Otros varchar(50) 
as update dbo.especialidades set
esp_Nombre=@esp_Nombre,
esp_Otros=@esp_Otros
where esp_Id =@esp_Id
go


create procedure sp_uEnfermedades
@enf_Id int,
@enf_Nombre varchar (20),
@enf_Descripcion varchar(500) as 
update dbo.enfermedades set 
enf_Nombre=@enf_Nombre,
enf_Descripcion=@enf_Descripcion
where enf_Id =@enf_Id 
go

create procedure sp_uMascota 
@mas_Id int ,
@mas_Nombre varchar(25), 
@mas_Sexo char ,
@mas_EspecieId int ,
@mas_EspecieTipoId int ,
@mas_FechaNac date,
@mas_TipoSangre varchar(8) ,
@mas_Color varchar (30),
@mas_Habitat varchar(30),
@mas_Peso decimal(6,2),
@mas_Otros varchar(100) as update dbo.Mascota set
mas_Nombre=@mas_Nombre,
mas_Sexo=@mas_Sexo,
mas_EspecieId=@mas_EspecieId,
mas_EspecieTipoId=@mas_EspecieTipoId,
mas_FechaNac=@mas_FechaNac,
mas_TipoSangre=@mas_TipoSangre,
mas_Color=@mas_Color,
mas_Habitat=@mas_Habitat,
mas_Peso=@mas_Peso,
mas_Otros=@mas_Otros where mas_Id=@mas_Id
go



create procedure sp_uVeterinario
@vet_Id int,
@vet_Nombres varchar(20),
@vet_Apellidos varchar(20),
@vet_DireccionC varchar(30),
@vet_Telefono varchar(15),
@vet_Celular varchar(15),
@vet_Correo varchar (30),
@vet_EspecialidadId int as 
update dbo.veterinario set 
vet_Nombres=@vet_Nombres,
vet_Apellidos=@vet_Apellidos,
vet_DireccionC=@vet_DireccionC ,
vet_Telefono=@vet_Telefono ,
vet_Celular=@vet_Celular,
vet_Correo=@vet_Correo,
vet_EspecialidadId=@vet_EspecialidadId
where vet_Id=@vet_Id 
go



--ELIMINAR---------------------------------------------------------
create procedure sp_dFarmacias
@far_Id int as delete from dbo.farmacias where far_Id=@far_Id
go

create procedure sp_dMedicamentos 
@med_Id int as delete from dbo.medicamentos where med_Id=@med_Id
go


create procedure sp_dCliente
@cli_Id int as 
delete from veterinaria.dbo.cliente where cli_Id=@cli_Id
go

create procedure sp_dEspecialidades 
@esp_Id int as 
delete from dbo.especialidades where esp_Id=@esp_Id  
go


create procedure sp_dEnfermedades 
@enf_Id int as 
delete from dbo.enfermedades where enf_Id=@enf_Id
go

create procedure sp_dMascota 
@mas_Id int as
delete from dbo.Mascota where mas_Id=@mas_Id
go



create procedure sp_dVeterinario 
@vet_Id int as 
delete from dbo.veterinario where vet_Id=@vet_Id
go



--REGISTROS--------------------------------------------------------
 execute sp_iFarmacias 'Farsimal','Cualquier Sucursal'
 execute sp_iFarmacias 'Laboratorios Francelia','Jardies de Toncontin'
 execute sp_iFarmacias 'petshop one','cualquier sucursal'
 execute sp_iFarmacias 'Lab. made in china','col.Torocagua'
 execute sp_iFarmacias 'Kipet','Sps. mall Dorado'
 execute  sp_sFarmacias
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
exec sp_iUsuarios 'Password','Administrador','Administrador'
exec sp_iUsuarios 'Clave','Dennis Fermin Motinho Andino','Estandar'
exec sp_iUsuarios 'Password','Carlos Vijil  ','Administrador'
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
execute sp_iCliente 'Celena Antonia',' Castillo Palma','Claro Sercom Castanhos Teg.','Col.Hato de enmedio bloque 5 casa 12','22332245','98765432','celenac@gmail.com'
execute sp_iCliente 'Dulce Carolina',' Martinez Godoy','Hondutel HN Teg.bl Centroamerica','Col.Hato de enmedio bloque 5 casa 12','22332245','98765432','dulce@outlook.com'
execute sp_iCliente 'Aquiles Tomas',' Brinco Rico','Girl Fashion era avenida 4ta calle','Col.Hato de enmedio bloque 5 casa 12','22332245','98765432','aquilesrico@yahoo.es'
execute sp_iCliente 'Aitor Jose ','Tillas Blancas','Claro Sercom Castanhos Teg.','Col.Hato de enmedio bloque 5 casa 12','22332245','98765432','aitortilla@outlook.com'
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
execute sp_iEnfermedades 'CÓLERA PORCINO','Enfermedad de los cerdos muy contagiosa,de carácter fatal
Causa: Virus
Síntomas: deshidratación,Conjuntivitis,párpados pegados,Depresión,inapetencia,Fiebre,Cianosis cutánea.
Prevención: Vacunación.'
execute sp_iEnfermedades 'ECZEMA/Dermatitis','Afecta  la piel de los perros durante los meses calurosos.
Causa: estreptococos,estafilococos,hongos,Alimentación,Irritación local,Lavado excesivo con jabones fuertes,insectos.
Síntomas: llagas y lesiones cutáneas.
Tratamiento: alimentación correcta. Parasiticidas, lociones astringentes.'
execute sp_iEnfermedades 'GRIPE PORCINA','Enfermedad febril y contagiosa del cerdo
Causa: acción sinérgica del virus de la influenza porcina con el Hemophilus suis.
Síntomas: Tos,Bronquitis,Neumonía,Fiebre,Respiración rápida,Inapetencion,Secreción ocular.
Prevención: buena higiene.'
execute sp_iEnfermedades 'NEUMONÍA/Pulmonía','presentación posible en todos los animales.
Causa: Pasteurella,multocida,Cornybacterium pyogenes,Salmonella supestifer. Virus.
Síntomas: Fiebre,Respiración acelerada,Corazón débil,Secreción nasal,Falta de apetito,Congestión de las mucosas,Sonidos respiratorios anormales.'
execute sp_iEnfermedades 'PERITONITIS','Inflamación de la membrana de recubrimiento del interior del abdomen, como consecuencia de una infección.
Causa: diferentes bacterias.
Síntomas: estremecimientos,Malestar,Aumento de la temperatura,Dolor,Boca seca, Falta de apetito,El animal deja de rumiar.'
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

execute sp_iEspecialidades 'Oftalmología','vacio'
execute sp_iEspecialidades 'Cardiología','vacio'
execute sp_iEspecialidades 'Anestesiología','vacio'
execute sp_iEspecialidades 'Oncología','vacio'
execute sp_iEspecialidades 'Fisioterapia','vacio'
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
execute sp_iVeterinario 'Mario Roberto','Zelaya Hernandez','Res. Lomas Norte casa 25 calle 3 ','22254356','98765678','maro@outlook.com','1'
execute sp_iVeterinario 'Manuela Ariela','Lopez Lopez','Res Monte Fresco bloque 3 casa 2','23456789','99887766','mana@petclick.com','2'
execute sp_iVeterinario 'Jose Antonio','Mendoza','Col. suyapa frte Tropigas casa 14','23456789','99666666','jja@ppetclick.com','3'
execute sp_iVeterinario 'Maria','Escobar','col. Pinos casa 5 bloque 2','23666666','99999999','maes@petclik.com','5'
execute sp_iVeterinario 'Kate','Lopez','Col.Kennedy calle 2 casa 25','23456777','99775533','kate@petclick.com','4'
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
execute sp_iEspecie 'Canino'
execute sp_iEspecie 'Felino'
execute sp_iEspecie 'Ganado'
execute sp_iEspecie 'Aves'
execute sp_iEspecie 'Peces'
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
execute sp_iraza '1','BULLDOG FRANCES'
execute sp_iraza '1','DALMATA'
execute sp_iraza '2','GT SIAMES'
execute sp_iraza '2','GT ANGORA TURCO'
execute sp_iraza '3','BRAHMAN'
execute sp_iraza '3','BEEFMASTER'
execute sp_iraza '4','GALLINA BABCOCK'
execute sp_iraza '4','LR GUACAMAYO'
execute sp_iraza '5','PEZ GATO'
execute sp_iraza '5','PEZ ÁNGEl'
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
exec sp_iServicios 'Analisis Clinicos'
exec sp_iServicios 'Radiologia'
exec sp_iServicios 'Ecografia'
exec sp_iServicios 'Ecocardiorama'
exec sp_iServicios 'Cirugia'
exec sp_iServicios 'Hospitalizacion'
exec sp_iServicios 'Odontologia'
exec sp_iServicios 'P.Antiparasitario'
exec sp_iServicios 'Vacunaciones'
exec sp_iServicios 'Consulta'
exec sp_iServicios 'P.Senior'
exec sp_iServicios 'Atenc.Domiciliaria'
exec sp_iServicios 'Peluqueria'
exec sp_iServicios 'Especialidad'
exec sp_iServicios 'Informe Tecnico'
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
exec sp_iMascota '1','Firulai','M','1','1','31/12/2015','DEA-8','Cafe Claro','Casa','50.3','El perro esta feo'
exec sp_iMascota '1','Garfield','M','2','4','18/7/2016','AB','Rojizo','Finca','25.2','el gato esta desnutrido'
exec sp_iMascota '2','Margarita','F','3','5','12/2/2012','Z','Negra','Finca','400.24','Usada para reproduccion.'
exec sp_iMascota '3','Lola','F','4','8','12/6/2014','ABO','Verde Rojo','Casa','5','mudando plumas'
exec sp_iMascota '2','Misifu','M','2','3','12/6/2011','B','Gris','Casa','15','el gato morira'

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
execute sp_iMedicamentos 'paracetamol',' El Paracetamol es un medicamento analgésico puro','50.90','1','1'
execute sp_iMedicamentos 'Sulfonamidas','bacteriostático para  intestino,vías respiratorias y urinarias','300','2','2'
execute sp_iMedicamentos 'Penicilina','para todas las infecciones','67','5','3'
execute sp_iMedicamentos ' Tetraciclinas','contra la Ehrlichiosis canina y la Hemobartonella felis. También para la psitacosis','400','1','3'
execute sp_iMedicamentos 'Cloranfenicol','antibiotico','100','1','4'

exec sp_ihistorial 'Consulta','31/12/2016','Leusemia Canina','carne de gato por 25 dias','28/1/2017','400.54','3','2','1','10'
exec sp_ihistorial 'Corte de cabello','5/1/2017','Ninguno','Ninguno','28/1/2017','400.54','3','2','1','10'
exec sp_ihistorial 'Dolor de Muelas','31/3/2018','Caries en molar','Extraccion','28/1/2017','400.54','1','2','1','10'
exec sp_ihistorial 'Chequeo de Rutina','31/3/2018','Saludable','Vitaminas','28/1/2017','400.54','3','6','1','10'
exec sp_ihistorial 'Cansancio al correr','31/12/2016','Sobrepeso','Dieta','28/1/2017','400.54','3','8','1','10'






--tabla Sub-Servicio
--create table dbo.subServicios(
--sub_Id int identity(1,1) not null,
--sub_CategoriaId int not null,
--sub_Descripcion varchar(50) not null,
--sub_Costo decimal(8,2) not null,
--sub_Otros varchar(50) not null,
--primary key(sub_Id),
--foreign key(sub_CategoriaId) references dbo.servicios(ser_Id)
--)
--go


--create procedure sp_sMedicamentos as
--select * from dbo.medicamentos order by med_Id 
--go

--create procedure sp_sSubServicios as 
--select * from dbo.subServicios order by sub_Id
--go

--create procedure sp_stratamiento as
--select * from dbo.tratamiento order by tra_Id 
--go

--create procedure sp_sHistoria as 
--select * from dbo.historia order by his_Id 
--go

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--PROCEDIMIENTOS ALMACENADOS  [INSERTAR]
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--(Independientes)





--create procedure sp_iMedicamentos
--@med_Nombre varchar,
--@med_Costo decimal(8,2) as insert into dbo.medicamentos(med_Nombre,med_Costo)
--values(@med_Nombre,@med_Costo)
--go

--create procedure sp_iFarmacias
--@far_Nombre varchar(20) ,
--@far_Direccion varchar(60) as insert into dbo.farmacias (far_Nombre,far_Direccion)
--values (@far_Nombre,@far_Direccion)
--go


--create procedure sp_iSubServicios
--@sub_Descripcion varchar(50),
--@sub_Costo decimal(8,2) ,
--@sub_Otros varchar(50) as insert into dbo.subServicios (sub_Descripcion,
--sub_Costo,sub_Otros)
--values
--(@sub_Descripcion,@sub_Costo,@sub_Otros)
--go

--create procedure sp_iTratamiento
--@tra_FechaI date ,
--@tra_FechaF date,
--@tra_Otros varchar(50) as insert into dbo.tratamiento (tra_FechaI,tra_FechaF)
--values 
--(@tra_FechaI,@tra_FechaF)
--go



--create procedure sp_iHistoria
--@his_FechVisita date,
--@his_Costo decimal(8,2) ,
--@his_Resultados varchar(50),
--@his_TrabajoRealizado varchar(60),
--@his_ProximaCita date,
--@his_Otros varchar(50) as insert into dbo.historia (his_FechVisita,his_Costo,his_Resultados,his_TrabajoRealizado,his_ProximaCita,his_Otros)
--values(@his_FechVisita,@his_Costo,@his_Resultados,@his_TrabajoRealizado,@his_ProximaCita,@his_Otros)
--go

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--PROCEDIMIENTOS ALMACENADOS [ACTUALIZAR]
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--TABLAS INDEPENDIENTES 

--create procedure sp_uServicios
--@ser_Id int ,
--@ser_Nombre varchar(20) as update dbo.servicios set
--ser_Nombre=@ser_Nombre
--where ser_Id =@ser_Id 
--go


--create procedure sp_uMedicamentos
--@med_Id int ,
--@med_Nombre varchar,
--@med_Costo decimal(8,2) as update dbo.medicamentos 
--set
--med_Nombre=@med_Nombre,
--med_Costo=@med_Costo
--where med_Id=@med_Id 
--go

--create procedure sp_uFarmacias
--@far_Id int ,
--@far_Nombre varchar(20) ,
--@far_Direccion varchar(60) as update dbo.farmacias set
--far_Nombre=@far_Nombre,
--far_Direccion=@far_Direccion
--where far_Id =@far_Id
--go

--create procedure sp_uEspecie
--@esp_Id int,
--@esp_Nombre varchar(25) as update dbo.especie set
--esp_Nombre=@esp_Nombre
--where esp_Id=@esp_Id
--go

--create procedure sp_uTipoEspecie
--@tip_Id int,
--@tip_EspId int,
--@tip_Nombre varchar(20) as update dbo.tipoEspecie set 
--tip_Nombre =@tip_Nombre 
--where tip_Id=@tip_Id
--go

--create procedure sp_uSubServicios
--@sub_Id int,
--@sub_Descripcion varchar(50),
--@sub_Costo decimal(8,2) ,
--@sub_Otros varchar(50) as update dbo.subServicios set
--sub_Descripcion=@sub_Descripcion,
--sub_Costo=@sub_Costo,
--sub_Otros=@sub_Otros
--where sub_Id=@sub_Id
--go

--create procedure sp_uTratamiento
--@tra_Id int,
--@tra_FechaI date ,
--@tra_FechaF date,
--@tra_Otros varchar(50) as update dbo.tratamiento set 
--tra_FechaI=@tra_FechaI,
--tra_FechaF=@tra_FechaF
--where tra_Id =@tra_Id
--go


----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
----PROCEDIMIENTOS ALMACENADOS  [ELIMINAR]
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

----TABLAS INDEPENDIENTES


--create procedure sp_dMedicamentos
--@med_Id int as
--delete from dbo.medicamentos where med_Id =@med_Id
--go

--create procedure sp_dFarmacias 
--@far_Id int as
--delete from dbo.farmacias where far_Id=@far_Id 
--go

--create procedure sp_dEspecie
--@esp_Id int as 
--delete from dbo.especie where esp_Id=@esp_Id
--go

--create procedure sp_dServicios
--@ser_Id int as 
--delete from dbo.servicios where ser_Id=@ser_Id
--go


--TABLAS DEPENDIENTES



--create procedure sp_dSubServicios as 
--delete from dbo.subServicios where sub_Id
--go

--create procedure sp_dtratamiento as
--delete from dbo.tratamiento where tra_Id 
--go


--create procedure sp_dHistoria as 
--delete from dbo.historia where his_Id 
--go
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
