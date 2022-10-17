/*
.     გვაქვს Teacher ცხრილი, რომელსაც აქვს შემდეგი მახასიათებლები: სახელი, გვარი, სქესი, საგანი. გვაქვს Pupil ცხრილი,
 რომელსაც აქვს შემდეგი მახასიათებლები: სახელი, გვარი, სქესი, კლასი. ააგეთ ნებისმიერ რელაციურ ბაზაში ისეთი დამოკიდებულება,
  რომელიც საშუალებას მოგვცემს, რომ მასწავლებელმა ასწავლოს რამოდენიმე მოსწავლეს და ამავდროულად მოსწავლეს ჰყავდეს რამდენიმე 
  მასწავლებელი (როგორც რეალურ ცხოვრებაში).
  N:M

1. დაწერეთ sql რომელიც ააგებს შესაბამის table-ებს.
2. დაწერეთ sql რომელიც დააბრუნებს ყველა მასწავლებელს, რომელიც ასწავლის მოსწავლეს, რომელის სახელია: „გიორგი“ .

*/

create database sweeft_test_database1


use sweeft_test_database1
drop database sweeft_test_database

 create table Teacher
(
teacherID  int identity primary key ,
name nvarchar(50),
surname nvarchar(50),
gender nvarchar(10),
subjec nvarchar(40)
constraint inok unique(teacherID)-- maswavlebeli aris unikaluri anu erti
)

--1:N kavshiri
create table pupil
(
pupilID int identity primary key,
name nvarchar(50),
surname nvarchar(50),
gender nvarchar(10),
class numeric,

-- agretve shegvidzlia kavshiri gavaketot  shualeduri cxrilit 1:1-N:M  magram ase  kodi ufro tvalsachinoa
)
create table forconection--  table  kavshiristvis shualeduri cxrili N:M  kavshiristvis
(
forconectionid int identity primary key,
teacherid  int references Teacher(teacherID),
pupilid int references Pupil(pupilID) ,
)
drop table forconection

insert into Teacher([name],[surname],[gender],[subjec])values
(N'გურამ',N'აფხაზავა',N'მამრობითი',N'მათემატიკა'),
(N'გიო',N'აფხაზავა',N'მამრობითი',N'სტატისტიკა'),
(N'ირინა',N'არჩუაძე',N'მამრობითი',N'ალგორითმები'),
(N'ვახტანგ',N'მამეიშვილი',N'მამრობითი',N'დაპროგრამება')

select * from Teacher

insert into [dbo].[pupil]([name],[surname],[gender],[class])values
(N'გურამ',N'ეზეკიანი',N'მამრობითი',3),
(N'გიო',N'მამაცი',N'მამრობითი',2),
(N'ირინა',N'არევაძე',N'მამრობითი',3),
(N'ლელა',N'ალხაზიშვილი',N'მამრობითი',4),
('gio','shavadze','mamrobiti',5)


--2. დაწერეთ sql რომელიც დააბრუნებს ყველა მასწავლებელს, რომელიც ასწავლის მოსწავლეს, რომელის სახელია: „გიორგი“ .
select * from teacher 
inner join pupil on pupil.pupilID=Teacher.teacherID and pupil.name=N'გიო'
