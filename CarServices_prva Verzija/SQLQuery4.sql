use CarServices
go

CREATE TABLE login (
ID int primary key IDENTITY,
username varchar(50),
password varchar(50))


INSERT INTO login VALUES ('demir', 123456);
INSERT INTO login VALUES ('ajdin', 123);
INSERT INTO login VALUES ('aaa', 987);