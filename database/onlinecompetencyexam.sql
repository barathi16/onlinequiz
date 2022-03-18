create table register
(
registerid int identity,
username varchar(50)  primary key,
firstname varchar(50),
lastname varchar(50),
pwd varchar(20),
confirmpwd varchar(20),
dob date,
email varchar(50),
gender bit,
phone varchar(20),
nationality varchar(20)
)
select * from register
drop table register
create table loginadmin
(
adminid int identity (1,1)primary key,
adminname varchar(50),
adminpwd varchar(10)
)
create  table loginuser
(
userid int identity (1,1)primary key,
username varchar(50) Foreign key references register(username),
userpwd varchar(10),
)

create table report
(
username varchar(50),
userid int,
sourceid int,
coursename varchar(30),
levels varchar(30),
totalmarks int,
statuss varchar(30)
)
create table displayquestion(
 courseid int ,
 levels nvarchar(50),
 Qid int not null identity(1,1) primary key,
 Question nvarchar(300),
 Option1 nvarchar(300),
 Option2 nvarchar(300),
 Option3 nvarchar(300),
 Option4 nvarchar(300),
 Correctans nvarchar(300)
 )
 select *from displayquestion
 insert into displayquestion values(1,1,'what is java?','object lang','programming lang','structed lang','virtual lang','object lang')
 insert into displayquestion values(1,1,'Number of primitive data types in Java are?',6,7,8,9,8)
 insert into displayquestion values(1,1,'Automatic type conversion is possible in which of the possible cases?','byte to int','int to long','long to int','short to int','int to long')
 insert into displayquestion values(1,1,'arrays in java are','object references','objects','primitive','none','objects')
 insert into displayquestion values(1,1,'compareTo() returns','True','False','int','none','True')
  insert into displayquestion values(1,1,'Total constructor string class have',3,7,13,20,13)
  insert into displayquestion values(1,1,'output of Math.floor(3.6)','3','4','5','6','3')
  insert into displayquestion values(1,1,'Modifier which can be used for constructor','public','protected','private','static','static')
  insert into displayquestion values(1,1,'Implicit return type of constructor','no return type',' A class object ','void ','none','A class object')
  insert into displayquestion values(1,1,'what is runnable','abstract class','interface','class','method','interface')

  insert into displayquestion values(1,2,' Which component is used to compile, debug and execute the java programs?','JRE','JIT','JDK','JVM','JDK')
 insert into displayquestion values(1,2,'Which one of the following is not a Java feature?','Object-oriented','Use of pointers','Portable','Dynamic and Extensible','Use of pointers')
  insert into displayquestion values(1,2,'Which of these cannot be used for a variable name in Java?','identifier & keyword','identifier',' keyword','None','keyword')
  insert into displayquestion values(1,2,' What is the extension of java code files?','js','txt','class','java','java')
 insert into displayquestion values(1,2,'Which of the following is not an OOPS concept in Java?','Polymorphism','Inheritance','Compilation',' Encapsulation','Compilation')
  insert into displayquestion values(1,2,' What is the extension of compiled java classes?','txt','js','class','java','class')
 insert into displayquestion values(1,2,'Which of these are selection statements in Java?','break','continue','for()','if()','if()')
  insert into displayquestion values(1,2,'Which of the below is not a Java Profiler?',' JProfiler','Eclipse Profiler','JVM',' JConsole',' JVM')
 insert into displayquestion values(1,2,' Which of these packages contains the exception Stack Overflow in Java?','java.io','java.system','java.lang',' java.util','java.lang')
  insert into displayquestion values(1,2,' Which of these keywords are used for the block to be examined for exceptions?','check','throw','catch',' try',' try')
  insert into displayquestion values(1,2,'Which one of the following is not an access modifier?','Protected',' Void',' Public','Private',' Void')
  
 insert into displayquestion values(1,3,'Which class provides system independent server side implementation?','Server','ServerReader','Socket','ServerSocket','ServerSocket')
   insert into displayquestion values(1,3,' Which of these keywords can be used to prevent Method overriding?','static','constant',' protected',' final','final')
   insert into displayquestion values(1,3,' Which of these is supported by method overriding in Java?',' Abstraction',' Encapsulation','Polymorphism','None','Polymorphism')
   insert into displayquestion values(1,3,'Which of these packages contain all the Java’s built in exceptions?','java.io','java.util',' java.lang','java.net',' java.lang')
   insert into displayquestion values(1,3,'Which of these class is used to create user defined exception?','java.lang','Exception','RunTime','System','Exception')
  insert into displayquestion values(1,3,'Which of these class provides various types of rounding functions?','Math',' Process',' System',' Object',' Math')
  insert into displayquestion values(1,3,'Which of function return absolute value of a variable?','abs()','absolute()',' absolutevariable()',' none','abs()')
 insert into displayquestion values(1,3,' Which of these is a process of writing the state of an object to a byte stream?','Serialization','Externalization','File Filtering','None','Serialization')
   insert into displayquestion values(1,3,' Which of these process occur automatically by the java runtime system?','Serialization',' Garbage collection',' File Filtering','All of above','Serialization')
   insert into displayquestion values(1,3,'Which of these interface extends DataOutput interface?','Serializable','Externalization',' ObjectOutput',' ObjectInput','ObjectOutput')
 
 select * from displayquestion where courseid=2
  insert into displayquestion values(2,1,'What does HTML stands for?','Hypertext Machine language','Hypertext and links markup language','Hypertext Markup Language','Hightext machine language','Hypertext Markup Language')
 insert into displayquestion values(2,1,'How is document type initialized in HTML5.?','</DOCTYPE HTML>','</DOCTYPE>','<!DOCTYPE HTML>','</DOCTYPE html>','<!DOCTYPE HTML>')
 insert into displayquestion values(2,1,'Which of the following HTML Elements is used for making any text bold ?','<p>','<i>','<li>','<b>','<b>')
 insert into displayquestion values(2,1,'Which of the following HTML element is used for creating an unordered list?','<ui>','<i>','<em>','<ul>','<ul>')
  insert into displayquestion values(2,1,'Which of the following characters indicate closing of a tag?','\','/','//','!','/')
 insert into displayquestion values(2,1,'What is the font-size of the h1 heading tag?','3.5 em','2.17 em','2 em','1.5 em','2 em')
 insert into displayquestion values(2,1,'How many heading tags are there in HTML5?',2,3,5,6,6)
 insert into displayquestion values(2,1,'How many attributes are there in HTML5?',2,4,1,5,2)
 insert into displayquestion values(2,1,'Which of the following attributes is used to add link to any element?','link','ref','href','newref','href')
 insert into displayquestion values(2,1,'What is the purpose of using div tags in HTML?','For creating Different styles','For creating different sections','For adding headings.','For adding titles','For creating different sections')

 insert into displayquestion values(2,2,'Which of the following tags is used to make a portion of text italic in HTML?','<italic>','<style= “i”>','<i>','<style=“italic”>','<i>')
insert into displayquestion values(2,2,'Which of the following tags is used to add a line-break in HTML?','<br>','<break>','</break>','</br>','<br>')
insert into displayquestion values(2,2,'Which of the following attributes is used to open an hyperlink in new tab?','tab','href','target','ref','target')
insert into displayquestion values(2,2,'Which of the following is the correct way to add background color in HTML?','<body color = “green”>','<body bg-color = “green”>','<body style = “background-color=green”>','<body style = “background-color: green;”>','<body style = “background-color: green;”>')
insert into displayquestion values(2,2,'Which among the following is correct HTML code for making a checkbox?','<checkbox>','<input type="checkbox">','<check>','<input type="check">','<input type="checkbox">')
insert into displayquestion values(2,2,'Which tag is used for creating a drop-down selection list?','<select>','<option>','<dropdown>','<list>','<option>')
insert into displayquestion values(2,2,'Which tag is used to add an header in HTML5 table?','<theader>','<h1>','<th>','<header>','<th>')
insert into displayquestion values(2,2,'Which of the following elements can be used in HTML to create a table?','<table> , <tbody> , <trow>','<table> , <tb> , <trow>','<table> , <tbody> , <tr>','All of the above','<table> , <tbody> , <tr>')
insert into displayquestion values(2,2,'Fundamental HTML Block is known as','HTML Body','HTML Tag','HTML Attribute','HTML Element','HTML Tag')
insert into displayquestion values(2,2,'Apart from <b> tag, what other tag makes text bold ?','<fat>','<strong>','<black>','<emp>','<strong>')

 
insert into displayquestion values(2,3,'Who is Known as the father of World Wide Web (WWW)?','Robert Cailliau','Tim Thompson','Charles Darwin','Tim Berners-Lee','Tim Berners-Lee')
 insert into displayquestion values(2,3,'What should be the first tag in any HTML document?','<head>','<title>','<html>','<document>','<html>')
insert into displayquestion values(2,3,'How can you make a bulleted list with numbers?','<dl>','<ol>','<list>','<ul>','<ul>')
insert into displayquestion values(2,3,'What tag is used to display a picture in a HTML page?','picture','image','img','src','img')
insert into displayquestion values(2,3,'HTML web pages can be read and rendered by','Compiler','Server','Web Browser','Interpreter','Web Browser')
insert into displayquestion values(2,3,'Which of the following is not a browser ?','Microsofts Bing','Netscape Navigator','Mozilla Firefox','Opera','Microsofts Bing')
insert into displayquestion values(2,3,'Which HTML tag produces the biggest heading?','<h7>','<h9>','<h4>','<h1>','<h1>')
 insert into displayquestion values(2,3,'HTML tags are surrounded by which type of brackets','Curly','Round','Squart','Angle','Angle')
insert into displayquestion values(2,3,'Tags and texts that are not directly displayed on the page are written in _____ section.','<head>','<title>','<body>','<html>','<head>')
insert into displayquestion values(2,3,'The year in which HTML was first proposed _______.',1990,1980,2000,1995,1990)
