﻿
USE MASTER
GO
DROP DATABASE  IF EXISTS ASM_NET103_QLSV
GO
CREATE DATABASE ASM_NET103_QLSV
GO
USE ASM_NET103_QLSV
GO
CREATE TABLE USERS (
    username NVARCHAR(50) NOT NULL PRIMARY KEY,
    password VARBINARY(MAX),
    role NVARCHAR(50)
)
GO
CREATE TABLE SINHVIEN (
    MaSV NVARCHAR(50) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(50),
    Email NVARCHAR(50),
    SoDT NVARCHAR(15),
    GioiTinh BIT,
    DiaChi NVARCHAR(50),
    Hinh VARBINARY(MAX)
)
GO
CREATE TABLE GRADE (
    ID INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    MaSV NVARCHAR(50),
    TiengAnh FLOAT,
    TinHoc FLOAT,
    GDTC FLOAT
)
GO
ALTER TABLE GRADE
ADD CONSTRAINT FK_Grade_SinhVien
FOREIGN KEY (MaSV) REFERENCES SINHVIEN(MaSV)
GO
INSERT INTO USERS (username, password, role)
VALUES ('ADMIN1', HASHBYTES('MD5', 'ADMIN@123'), 'ADMIN'),
       ('CBDT1', HASHBYTES('MD5', 'CBDT@123'), 'CBDT'),
       ('GV1', HASHBYTES('MD5', 'GV@123'), 'GV'),
       ('SV1', HASHBYTES('MD5', 'SV@123'), 'SV');
GO