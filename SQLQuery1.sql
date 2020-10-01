drop table Guard_Duty

drop table Parking_Details

create table Guard_Duty(
Visitor_ID int primary key identity(1,1),
Visitor_Name varchar(50)not null,
In_Datetime varchar(50) not null,
Out_Datetime varchar(50) null,
Details varchar(50) not null,
House_ID varchar(10) References House(House_ID),
Require int  null)

create table AvailableSlots(
Slot_ID varchar(5) primary key)

create table EngagedSlots(
Slot_ID varchar(5) primary key)

drop table AvailableSlots

create table Parking_Details(
Parking_ID int primary key identity(1,1),
Vechile_Number varchar(50) not null,
Visitor_ID int References Guard_Duty(Visitor_ID),
slot_id varchar(5) references EngagedSlots(Slot_ID))



create table Parking_Details(
    Parking_ID int primary key identity(1,1),
    Vechile_Number varchar(50) not null,
    Visitor_ID int References Guard_Duty(Visitor_ID),
    Slot_Id varchar(5)
)

 

drop table Parking_Details

create table Parking_Details(
    Parking_ID int primary key identity(1,1),
    Vechile_Number varchar(50) not null,
    Visitor_ID int References Guard_Duty(Visitor_ID),
    Slot_Id varchar(5)
)

create trigger SlotHandeller
on Parking_Details
for insert
as
begin
    declare @pid int,@slta varchar(5),@slte varchar(5)
    select @pid=Parking_ID,@slte=Slot_Id from inserted
    select @slta=Slot_Id from AvailableSlots where Slot_Id=@slte
    if @slte=@slta
        begin
            insert into EngagedSlots values(@slte);
            delete from AvailableSlots where Slot_Id=@slte;
            commit;
        end;
    else
        begin
            Print 'Invalid Slot';
            rollback;
        end;
end;

drop database ESocietyProject