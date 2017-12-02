CREATE ROLE steven LOGIN
SUPERUSER CREATEDB CREATEROLE REPLICATION
VALID UNTIL 'infinity';

CREATE DATABASE eventos;

--USE eventos;

CREATE SCHEMA scheventos
       AUTHORIZATION steven;

ALTER USER steven SET search_path = 'schevento';

CREATE SEQUENCE scheventos.secuencia_id
  INCREMENT 1
  MINVALUE 1
  MAXVALUE 9223372036854775807
  START 3
  CACHE 1;
ALTER TABLE scheventos.secuencia_id
  OWNER TO steven;


CREATE TABLE scheventos.usuaria
(
  usuario character varying(20) NOT NULL,
  nombre character varying,
  contrasenna character varying(20),
  rol character varying(20),
  CONSTRAINT usuario_pkey PRIMARY KEY (usuario)
)

CREATE TABLE scheventos.evento
(
  id integer NOT NULL DEFAULT nextval('scheventos.secuencia_id'::regclass),
  lugar_choque character varying,
  placa_vehiculo character varying,
  link_foto character varying,
  estado character varying,
  propietario character varying,
  numero_de_parte character varying,
  numero_de_registro integer,
  CONSTRAINT evento_pkey PRIMARY KEY (id),
  CONSTRAINT fk_propietario FOREIGN KEY (propietario)
      REFERENCES scheventos.usuario (usuario) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)