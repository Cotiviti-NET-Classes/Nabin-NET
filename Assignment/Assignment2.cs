namespace Assignment
{
    class Employee //Base Class 1 without instantiation.
    {
      public void display()
        {
            Console.WriteLine("Employee");
        }
    }
   public class Teacher: Employee, Isubject
    {
        public string Teacher_ID;
        public void display()
        {
            Console.WriteLine("Computer Science");// Method Overriding
        }
    }
    class Department //Base class 2
    {
        public string dep_ID;
        public string dep_name;
        public void show()
        {
            Console.WriteLine("Department");
        }
    } 
    class Finamce : Department,Isubject ,Iclass
    {
        public string audit;
        public string fund;
        public void show()
        {
            Console.WriteLine("Finance");
        }
    } 

    class Inventory : Department, Iclass
    {
        public string inv_ID;
        public void show()
        {
            Console.WriteLine("Inventory");
        }
    }
    interface Isubject
    {
        void display();
    }
    interface Iclass
    {
       void display();
    }
    class TeachingSubject: Teacher
    {
        public void displays()
        {
            Console.WriteLine("TeachingSubject");
        }
    }

}