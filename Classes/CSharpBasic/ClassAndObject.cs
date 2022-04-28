class Student

{
    public Student()
    {

    }
    public Student(string name, string sem, string mobileNumber)
    {
        this.name=name;
        this.semester=sem;
        this.mobileNumber=mobileNumber;
    }
    public string name;
    public string semester;
    public string mobileNumber;

    void Enroll(string sem)
    {
        Console.WriteLine($"{name} enroll on {sem}."); // string interpolation-> Dynamic
    }

}

class SeniorStudent : Student  //Inheritance superclass to subclass
{
    public string electiveSubject;

    void EnrollInertnProgram(string company)
    {
        Console.WriteLine($"{name} is interned on {company}.");
    }
}
class alumni : SeniorStudent, Student //Multiple inheritance is not supported by c#.