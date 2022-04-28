public class TPL
{
    string [] names={"Mingmar","Nabin","Nikesh","Lalit", "Rakesh"};
    public void Do()
    {
        Console.WriteLine("Sequential Loop");
        foreach(var name  in names)
        {
            //if (name)
            
            Thread.Sleep(200);
            Console.WriteLine($"{name} has {name.Length} characters.");
        }
        Console.WriteLine("Parallel Loop");
        Parallel.ForEach(names,
         (name)=>
         {
             Thread.Sleep(200);
             Console.WriteLine($"{name} has {name.Length} characters.");
         });
    }
    public void Main(String[]args)
    {
        TPL t=new();
        t.Do();
    }
}

