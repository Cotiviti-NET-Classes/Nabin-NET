namespace Wrokflow;

class Vehical
{
    string name;
    string model;
    string color;
    void Employee() //Default Constructor
    {
        name="Suzuki";
        model=2011;
        color="Blue";
    }
    
    void Employee(string Toyota, string Y2016,string gray)//Parametrized Constructor
    {
        name=Toyota;
        model=Y2016;
        color=gray;

    }
   //Two auto-implemented properties
         public string model{get; private set;}
         public char color { get; set; } = "Red";

    //Read only Property
    public readonly string name {get;}
    //Write Only Property
    public string Name
    {
        set{name =value;}
    }
    //Compile time constant
   const bool engine=true; 

   //Run time
    public readonly double speed=90.5/hr;
    //Enum demo
    enum speed
    {
        low,
        medium,
        high
    }
    public string show (string name, string model)
    {
        this.name=name;
        this.model=model;
        return(name, model);
    }
}


