create table Car(
Id int identity primary key,
Company nvarchar(200) not null,
Model nvarchar(200) not null,
ManufactureYear int not null,
AdditionalInformation nvarchar(100) null
)