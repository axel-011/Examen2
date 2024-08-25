CREATE DATABASE Escuela;

USE Escuela;

CREATE TABLE Estudiantes (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Edad INT,
    Correo VARCHAR(100)
);

INSERT INTO Estudiantes (Nombre, Apellido, Edad, Correo) VALUES ('Juan', 'Pérez', 20, 'juan.perez@example.com');
INSERT INTO Estudiantes (Nombre, Apellido, Edad, Correo) VALUES ('María', 'García', 22, 'maria.garcia@example.com');
INSERT INTO Estudiantes (Nombre, Apellido, Edad, Correo) VALUES ('Carlos', 'López', 19, 'carlos.lopez@example.com');
INSERT INTO Estudiantes (Nombre, Apellido, Edad, Correo) VALUES ('Ana', 'Martínez', 21, 'ana.martinez@example.com');
INSERT INTO Estudiantes (Nombre, Apellido, Edad, Correo) VALUES ('Luis', 'Gómez', 23, 'luis.gomez@example.com');
INSERT INTO Estudiantes (Nombre, Apellido, Edad, Correo) VALUES ('Sofía', 'Díaz', 20, 'sofia.diaz@example.com');


