create database blood_bank;
use blood_bank;
create table recptionest (
rssn char (14) not null ,
fname varchar(50) not null ,
lname varchar(50) not null,
address nvarchar(50) not null ,
phone char (11) not null ,
bb_name nvarchar (50) references blood_bank (bb_name) ,
salary double  ,
primary key (rssn)
);

create table donor (
dssn char (14) not null ,
gender char(1) not null ,
fname nvarchar (50) not null ,
lname nvarchar (50) not null ,
age int not null ,
rec_ssn char (14) not null references recptionest (rssn) ,
weight double not null ,
height double not null ,
date_of_donation date not null ,
tempreture char (50) not null ,
perrsure char(50) not null ,
plusrate char(50) not null ,
primary key (dssn),
CONSTRAINT check_age CHECK (age > 18),
CONSTRAINT check_gender CHECK (gender='F' OR gender='M') );


create table patient (
pssn char (14) not null,
blood_type char (5) not null ,
weight double not null ,
hospital_name nvarchar (50) not null references hospital(name),
fname nvarchar (50) not null,
lname nvarchar (50) not null,
phone char (11) not null,
address nvarchar (50) not null,
CONSTRAINT check_blood_typee CHECK (blood_type='O+' or blood_type= 'O-' or blood_type='AB-' or blood_type= 'B-'or blood_type='AB+'or blood_type= 'B+'or blood_type= 'A+' or blood_type= 'A-'),
primary key (pssn)
);

create table blood_bag(
bcode char (14) not null,
cost double not null,
type char(10) not null,
bb_name nvarchar (50) not null references blood_bank(bb_name),
assn char (14) not null references donor (dssn),
donation_type char (50) not null,
donation_amount double not null,
primary key (bcode)
);

create table blood_bank(
bb_name nvarchar (50) not null,
bb_manager_name nvarchar (50) not null references bb_manager(ssn),
phone char (11) not null,
address nvarchar (50) not null,
primary key (bb_name)
);

create table hospital(
name nvarchar (50) not null,
phone char (11) not null,
address nvarchar (50) not null,
primary key (name)
);

create table bb_manager(
ssn char (14) not null,
name nvarchar (50) not null,
email text not null,
phone char (11) not null,
primary key (ssn)
);
create table bb_hospital(
bb_name nvarchar (50) not null references blood_bank (bb_name),
h_name nvarchar (50) not null references hospital (name));
    
insert into donor values ( 'p1' ,  'M' ,'jhon', 'centra' , '23' , 'a1' , '127' , '186' , '2019-1-10' , '98.6' ,'120/80'  , '70');
insert into donor values ( 'p2' ,  'F' ,'anne', 'parker' , '42' , 'a2' , '149' , '170' , '2019-2-10' , '98.5' ,'110/70'  , '75');
insert into donor values ( 'p3' ,  'M' ,'ryan', 'fowlar' , '32' , 'a3' , '90' , '190' , '2019-3-10' , '98.5' ,'130/85'  , '59');
insert into donor values ( 'p4' ,  'M' ,'peter', 'cruz' , '21' , 'a4' , '127' , '200' , '2019-4-10' , '98.4' ,'120/80'  , '67');
insert into donor values ( 'p5' ,  'M' ,'stephanie', 'collins' , '46' , 'a5' , '86' , '186' , '2019-5-10' , '98.3' ,'90/80'  , '90');
insert into donor values ( 'p6' , 'M' ,'harry', 'bryant' , '62' , 'a6' , '90' , '186' , '2019-5-10' , '98.1' ,'110/70'  , '44');
insert into donor values ( 'p7' ,  'M' ,'james', 'bond' , '40' , 'a7' , '100' , '196' , '2019-5-11' , '98.7' ,'110/70'  , '82');
insert into donor values ( 'p8' ,  'M' ,'david', 'king' , '34' , 'a8' , '56' , '176' , '2019-5-11' , '98.9' ,'120/80'  , '71');
insert into donor values ( 'p9' ,  'M' ,'thomas', 'tank' , '24' , 'a9' , '70' , '176' , '2019-1-11' , '98.6' ,'120/80'  , '72');
insert into donor values ( 'p10' ,  'M' ,'jessica', 'roberts' , '42' , 'a10' , '80' , '186' , '2018-12-11' , '98.2' ,'120/70'  , '73');
insert into donor values ( 'p11' ,  'M' ,'carol', 'porter' , '62' , 'a11' , '60' , '150' , '2019-5-11' , '98.4' ,'110/70'  , '52');
insert into donor values ( 'p12' ,  'M' ,'emily', 'murphy' , '21' , 'a12' , '90' , '172' , '2019-3-11' , '98.4' ,'130/80'  , '65');
insert into donor values ( 'p13' ,  'M' ,'mattew', 'mcderm' , '37' , 'a13' , '95' , '190' , '2019-3-11' , '98.0' ,'140/70'  , '72');
insert into donor values ( 'p14' ,  'F' ,'emily', 'john' , '31' , 'a14' , '90' , '192' , '2019-2-13' , '93.4' ,'120/80'  , '65');
insert into donor values ( 'p15' ,  'F' ,'lelly', 'mcderm' , '38' , 'a15' , '95' , '170' , '2019-5-16' , '99.0' ,'140/70'  , '82');


insert into patient values ( 'p1' , 'A-' , '100' , '57357' , 'joseph','ruggiero','01256789635','Nemis Assuit');
insert into patient values ( 'p2' , 'A+' , '99' , 'adam', 'hannah','taylor','01008765439','Sadat Assuit');
insert into patient values ( 'p3' , 'O+' , '100' , '3een4ams' , 'anne','mille','01256789100','Saliba Street');
insert into patient values ( 'p4' , 'O-' , '100' , '3een4ams university' , 'caroline','powers','01256789101','Qasr El Nil Street');
insert into patient values ( 'p5' , 'B-' , '100' , 'new cairo' , 'emily','mcfelice','01256789102','Qasr El Eyni Street');
insert into patient values ( 'p6' , 'AB-' , '100' , 'agial' , 'pattricia','wilson','01256789103','Muizz Street');
insert into patient values ( 'p7' , 'A-' , '100' , 'alzahra' , 'bale','powerman','01256789104','Aspen Street');
insert into patient values ( 'p8' , 'A-' , '100' , 'dar elhekma' , 'micky','glob','01256789105','Austin Court');
insert into patient values ( 'p9' , 'A-' , '100' , 'dar elteb' , 'leo','messi','01256789106','Avery Park Court');
insert into patient values ( 'p10' , 'A-' , '100' , 'elnozha international' , 'zlatan','ibrahimovic','01256789107','Avon Place');
insert into patient values ( 'p11' , 'A-' , '100' , 'ibn sina' , 'gareth','bale','01256789108','Azalea Cove Terrace');
insert into patient values ( 'p12' , 'A-' , '100' , 'dar elshefa' , 'karem','benzema','01256789109','Azalea Cove Terrace');
insert into patient values ( 'p13' , 'A-' , '100' , 'german hospital' , 'sergio','ramos','01256789111','Ashwood Drive');



insert into hospital values( '57357' , '01012345678' , 'El-Sayeda Zainab, Cairo ');
insert into hospital values( 'adam' , '01012345666' , 'tahrir square,cairo');
insert into hospital values( 'Aeenshams' , '01012345777' , 'talaat harb st,cairo');
insert into hospital values( 'Aeenshams university' , '01012345888' , 'Abbasia,cairo');
insert into hospital values( 'new cairo' , '01012345999' , 'roxy,cairo' );
insert into hospital values( 'agial' , '01012345555' , 'naser st,sohag');
insert into hospital values( 'alzahra' , '01012345444' , 'alzahraa,assuit');
insert into hospital values( 'dar elhekma' , '01012345333' , 'alhelaly,assuit');
insert into hospital values( 'dar elteb' , '01012345222' , 'maadi,cairo');
insert into hospital values( 'elnozha international' , '01012345111' , 'helioplis,cairo');
insert into hospital values( 'ibn sina' , '01012345000' , 'mahmoud rashwan,assuit');
insert into hospital values( 'dar elshefa' , '01012345876' , 'zamalek,cairo');
insert into hospital values( 'german hospital' , '01012345768' , 'elgomharia,mansoura');



insert into bb_manager values( 'p1' , 'dina emad' , 'dinaemad234@gmail.com' ,'01112345000');
insert into bb_manager values( 'p2' , 'rofida gamal' , 'rofidagamal345@gmai.com', '01112345111');
insert into bb_manager values( 'p3' , 'margo sabry ' , 'margosabry@gmail.com', '01112345222');
insert into bb_manager values( 'p4' , 'sandy emad' , 'sandyemad34@gmail.com' , '01112345333');
insert into bb_manager values( 'p5' , 'zyad baset' , 'zyadbaset12@gmail.com' , '01112345444');
insert into bb_manager values( 'p6' , 'samir monir' , 'samirmonir890@gmail.com','01112345555');
insert into bb_manager values( 'p7' , 'amira hesham' , 'amirahassan234@gmail.com' , '01112345666');
insert into bb_manager values( 'p8' , 'ahmed ali' , 'ahmedali678@gmail.com' , '01112345777'); 
insert into bb_manager values( 'p9' , 'sara ahmed' , 'saraahmed874@gmail.com' , '01112345888');
insert into bb_manager values( 'p10' , 'amr mohamed' , 'amrmohamed908@gmail.com' , '01112345999');
insert into bb_manager values( 'p11' , 'asmaa omar ' , 'asmaaomar247@gmail.com' ,'01112345786');
insert into bb_manager values( 'p12' , 'nada khaled' , 'nadakhaled89@gmail.com' ,'01112345178');
insert into bb_manager values( 'p13' , 'ahmed hany' , 'ahmedhany871@gmail.com' , '01112345876');



insert into bb_hospital values('plasma center' , 'dar elhekma' );
insert into bb_hospital values('Aman' , 'german hospital');
insert into bb_hospital values('NBTC' , '57357');
insert into bb_hospital values('Alexandria Regional','dar elshefa');
insert into bb_hospital values('kima lab' ,'adam');
insert into bb_hospital values('Blood transfusion center' , 'ibn sina');
insert into bb_hospital values('Isaileya Regional blood transfusion center' ,'Aeenshams');
insert into bb_hospital values('Blood transfusion services' ,'elnozha international' );
insert into bb_hospital values('Genome for laboratories supply & blood banks' , 'new cairo' );
insert into bb_hospital values('cell safe cord' , 'agial');
insert into bb_hospital values('El mansoura ' , 'dar elteb' );
insert into bb_hospital values('cell safe cord', 'dar elhekma');
insert into bb_hospital values('CIC herart & blood vessels center', 'alzahra');




insert into recptionest values('a1','Ahmed','Ali','elzahraa,Asyut','01098884445','p1','1000');
insert into recptionest values('a2','Mohamed','Ali','elgomohria,Asyut','01098884455','p2','1000');
insert into recptionest values('a3','mina','george','elnemias,Asyut','01198884445','p3','1000');
insert into recptionest values('a4','john','adel','fesal,Cairo','01098888888','p4','1000');
insert into recptionest values('a5','samia','mohamed','elzahraa,Aswan','01444546789','p5','2000');
insert into recptionest values('a6','laila','kamal','elzahraa,Asyut','01198884445','p6','999');
insert into recptionest values('a7','Ali','omar','elharm,Giza','01178884445','p7','1500');
insert into recptionest values('a8','eyad','hamdy','elmotazh,Alexndria','01068884445','p8','1200');
insert into recptionest values('a9','Amr','zaki','elmamora,Alexndria','01097884445','p9','1300');
insert into recptionest values('a10','Amira','Emad','elnaser,Cairo','01034884445','p10','1100');
insert into recptionest values('a11','Abd elraheem','Maged','elmedan,Cairo','01021884445','p11','1800');
insert into recptionest values('a12','sayed','Gamal','elharm,Giza','01067884445','p12','1100');
insert into recptionest values('a13','samy','Ali','elsadat,Asyut','01010884445','p13','2000');


insert into bb_hospital values('plasma center' , 'dar elhekma' );
insert into bb_hospital values('Aman' , 'german hospital');
insert into bb_hospital values('NBTC' , '57357');
insert into bb_hospital values('Alexandria Regional','dar elshefa');
insert into bb_hospital values('kima lab' ,'adam');
insert into bb_hospital values('Blood transfusion center' , 'ibn sina');
insert into bb_hospital values('Isaileya Regional blood transfusion center' ,'3een4ams');
insert into bb_hospital values('Blood transfusion services' ,'elnozha international' );
insert into bb_hospital values('Genome for laboratories supply & blood banks' , 'new cairo' );
insert into bb_hospital values('cell safe cord' , 'agial');
insert into bb_hospital values('El mansoura ' , 'dar elteb' );
insert into bb_hospital values('cell safe cord', 'dar elhekma');
insert into bb_hospital values('CIC herart & blood vessels center', 'alzahra');

insert into blood_bank values('Aman','p1','01098734667','Maadi,Cairo');
insert into blood_bank values('Alexandria Regional','p2 ','01098734676','kom el dekka ,alexandria');
insert into blood_bank values('Blood transfusion center','p3','01098734557','tanta,El gharbeya');
insert into blood_bank values('Blood transfusion services','p4','01198734667','Agouza,giza');
insert into blood_bank values('cell safe cord','p5','01123734667','batal ahmed abd el aziz,giza');
insert into blood_bank values('cell safe cord','p6','01098788667','el nasr,alexandria');
insert into blood_bank values('CIC herart & blood vessels center','p7','01228734667','Shebein el kawm , el monfeya');
insert into blood_bank values('Damnhour Regional Blood transfusion center','p8','01225634667','Damanhour ,elbeheria');
insert into blood_bank values('Wael kamal ','p9','01088735557','Zahraa el maadi,cairo');
insert into blood_bank values('El mansoura ','p10','01098734667','mansoura,dakahleya');
insert into blood_bank values('Genome for laboratories supply & blood banks','p11','01115534667','semouha,alexan');
insert into blood_bank values('Isaileya Regional blood transfusion center ','p12','01076673667','Araisheyat,Ismaileya');
insert into blood_bank values('kima lab','p13','01088834667','faisl,giza');
insert into blood_bank values('NBTC','p14','0112734667','Agouza,giza');
insert into blood_bank values('plasma center','p15','01098734667','Dokki,giza');



insert into blood_bag values ( 'b1' , '10' , 'A+' ,'Aman', 'p1' , 'Blood' , '2') ;
insert into blood_bag values ( 'b2' , '10' , 'AB+','Alexandria Regional', 'p2' , 'Plasma' , '2') ;
insert into blood_bag values ( 'b3' , '10' , 'A-' ,'Blood transfusion center', 'p3' , 'Power red' , '2') ;
insert into blood_bag values ( 'b4' , '10' , 'B+' ,'Blood transfusion services', 'p4' , 'Power red' , '2') ;
insert into blood_bag values ( 'b5' , '10' , 'O+' ,'cell safe cord', 'p5' , 'Power red' , '2' );
insert into blood_bag values ( 'b6' , '10' , 'A+' ,'cell safe cord', 'p6' , 'Plasma' , '2' );
insert into blood_bag values ( 'b7' , '10' , 'A-' ,'CIC herart & blood vessels center', 'p7' , 'Blood' , '2'); 
insert into blood_bag values ( 'b8' , '10' , 'O-' ,'Damnhour Regional Blood transfusion center', 'p8' , 'Blood' , '2' );
insert into blood_bag values ( 'b9' , '10' , 'B-' ,'Wael kamal', 'p9' , 'Blood' , '2' );
insert into blood_bag values ( 'b10' , '10' , 'AB-' ,'El mansoura', 'p10' , 'Blood' , '2'  );
insert into blood_bag values ( 'b11' , '10' , 'AB-' ,'Genome for laboratories  ', 'p11' , 'Blood' , '2' );
insert into blood_bag values ( 'b12' , '10' , 'AB+' ,'Isaileya Regional blood transfusion center', 'p12' , 'Blood' , '2' );
insert into blood_bag values ( 'b13' , '10' , 'B+' ,'kima lab', 'p13' , 'Blood' , '2' );
insert into blood_bag values ( 'b14' , '10' , 'B-' ,'NBTC', 'p14' , 'Blood' , '2' );
insert into blood_bag values ( 'b15' , '10' , 'O+' ,'plasma center', 'p15' , 'Plasma' , '2' );



