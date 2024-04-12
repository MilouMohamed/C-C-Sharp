create database IH_BASE;
use  IH_BASE;
use master;
DROP database IH_BASE

create table MATERIL_IH(
id int primary key identity,
disg varchar(200),
categore varchar(150),
qttInit int default 0,
qttReel int default 0, 
qttStock   int  default 0,
qttSort int default 0,
qttEntr int default 0,
emplacem VARCHAR(250),
descrep VARCHAR(250),
  image_ varbinary(max) default null
)   
     
    
select * from MATERIL_IH where image_ is null;  
     

create table USER_IH(
id int primary key identity,
NOM varchar(50),
MDP varchar(50) 
);
insert into USER_IH (NOM, MDP)values('admin','0000'),('00000','00000');

select * from USER_IH 

ALTER TABLE USER_IH
  ADD CONSTRAINT df_val
  DEFAULT 0 FOR TT; 

select *fROM  USER_IH; 
 