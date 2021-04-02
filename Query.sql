create database banking;

show databases;


CREATE TABLE usuario (
  idusuario INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  correo VARCHAR(100) NULL,
  contrasena VARCHAR(100) NULL,
  nombre VARCHAR(150) NULL,
  username VARCHAR(100) NULL
);

Insert into usuarios(username,contrasena,correo,nombre) values("bbqms","bryanxd123","bbqms@hotmail.com","Bryan Miramira")
