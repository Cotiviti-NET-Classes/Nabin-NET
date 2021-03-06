class person
{
    ctor//Shortcut for create constructor
    int age;// Internal AM is used for the project
    public string name; //Access Modify public,  private, protected and internal
       //Constraints
    public const bool IsLivingThings=true;//Complied time constraint

    public readonly bool IsLivingThings1=true;//Run time
    static void SayHello()// use static when object dosen't depends with others.
    {
        Console.Write("Hello!");
    }
}

class A
{
    person p;
    void Test()
    {
        p.name="Sarita";
        Console.WriteLine(p.name);
        var x = person.IsLivingThings;//Static and constraint are always access using class name.
    }
}


//Old Method full syntax
class Employee
{
     public string Name
     {
         get
         {
             return Name;
         }
         set
         {
             if(value != null && value != " ")
             {
                 Name=value;
             }

         }
     }
     //New method Auto implemented  properties
     public string Name1{get; set;}
     public char Gender { get; set; } ='M'; //Default value instalization
}

class x
{
    public virtual void Greet(string name)
    {
        Console.WriteLine($"Hi,{name}");
    }
}
class Y : x
{
    public override void Greet(string name)
    {
        base.Greet(name);// We can call base class i.e Hi ...name.
        Console.WriteLine($"Hello, {name}");
    }
}
   


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


