Create table Courses(CourseId int primary key Identity,
Name Varchar(150))

create table Machzor(MachzorId int primary key Identity,
name varchar(150),
Course_Id int foreign key references Courses(CourseId),
StartTime varchar(150),
Cost Decimal )
select * from machzor

create Table Subjects(SubjectId	int primary key Identity,
Course_Id int foreign key references Courses(CourseId),
Name Varchar(150),
Hours1 int,
Professor varchar(150),
Price Decimal)
select * from Subjects

insert into Subjects values(1,'Math',400,'Mike',100),
(1,'Math',400,'Mike',100),
(1,'Math',400,'Mike',300),
(1,'Math',400,'Mike',100),
(1,'Math',400,'Mike',500),
(1,'Math',400,'Mike',100)
create table ScheduleDays(DayOftWeek Varchar(150),
Hours1 Varchar(200),
Machzor_Id int foreign key references Machzor(MachzorId)
)


Create table students(StudentId int primary key Identity,
name varchar(150),
Machzor_Id int foreign key references Machzor(MachzorId))


----calculate when enough Money Came in
--Select * from Machzor left Join Students on Students.Machzor_id =Machzor.machzorid
-- left join Courses on courses.CourseId = Machzor.Course_Id left join Subjects
-- On Subjects.Course_Id = Courses.CourseId 
-- ---Calculate the amount each course costs
-- Select * from Courses left Join  Subjects
-- On Subjects.Course_Id = Courses.CourseId  join Machzor on Machzor.Course_Id = Courses.CourseId
-- Students on Students.Machzor_id =Machzor.machzorid
-- left join Courses on courses.CourseId = Machzor.Course_Id left join Subjects
-- On Subjects.Course_Id = Machzor.Course_Id 
-- select * from machzor
--adds student 
declare @sname Varchar(150)= 'Lieby'
declare @Mname Varchar(150) = 'Machzor4'
insert into Students Values(@sname ,(select MachzorId from machzor 
where name =@Mname))
select * from students

--add Scedule
declare @m7name varchar(150) = 'Machzor4'
declare @day Varchar(150) = 's'
declare @hour Varchar(150) = '988'

if exists(select name from Machzor where name = @M7name)
	begin
		insert into ScheduleDays values(@day,@hour,(select MachzorId from
		machzor where name = @m7name))
	end
select * from ScheduleDays
--inserts balance into payments

insert into payments values(
(select studentId from students
where name =@s1name),(select Machzor_Id from students where name = @s1name)
,(select cost
from machzor where name =@M1name))

--gives the balance
declare @answer decimal =
(select payments.balance from payments left join students on 
payments.student = Students.studentId where Students.name = 'Lieby')
select @answer

---updates the balance

UPDATE payments 
SET balance = Payments.balance - @amount
WHERE Student = (Select studentId from Students where name = @s5name)


---adds Machzor with conditions
declare @m2name Varchar(150) = 'Machzor2'
declare @cname VArchar(150) = 'Kodcod'
declare @StartTme VArchar(150) = '20/15/25'
declare @price decimal = 7000
 (select Courseid from Courses where name = @cname)
 if  exists(select name from Courses where name = @cname)
	begin
		if not exists(select name from Machzor where name = @Mname)
			begin
				insert into Machzor values(@Mname,(select Courseid from Courses 
				where name = @cname),@StartTme,@price)
			end
end
Select * from machzor 

--creates table
 
 Create table payments(Student int foreign key references Students(StudentId),
 Machzor_Id int foreign key references Machzor(MachzorId),
 balance Decimal)

 select* from ScheduleDays
 select * from Machzor
 
