// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Student s=new Student();  //"Student"() is optional and every class have defult constructor.
s.name="Hari";
s.semester="2th";
s.mobileNumber="9860887799";


Student s1=new()  
{
name="Hari",
semester="1th",
mobileNumber="0123456789"
};

Student s2=new Student("Shyam","3th", "7766554433"); //parameterized constructors