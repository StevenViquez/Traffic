CREATE ROLE steven LOGIN
SUPERUSER CREATEDB CREATEROLE REPLICATION
VALID UNTIL 'infinity';

CREATE DATABASE eventos;

CREATE SCHEMA scheventos
       AUTHORIZATION steven;

ALTER USER steven SET search_path = 'schevento';

CREATE TABLE scheventos.Usuario(
	usuario VARCHAR(20) NOT NULL PRIMARY KEY,
	nombre VARCHAR,
	contrasenna VARCHAR(20),
	rol VARCHAR(20)	
)

CREATE TABLE scheventos.Evento(
	id INTEGER NOT NULL PRIMARY KEY,
	lugar_choque VARCHAR,
	placa_vehiculo VARCHAR,
	link_foto VARCHAR,
	estado VARCHAR	
)