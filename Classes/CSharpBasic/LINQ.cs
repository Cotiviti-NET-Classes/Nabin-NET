class LINQ
{
    int[] number={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,45,23,54,17};
    string[] names={"Bishnu","Nabin","Dipesh","Jidesh","Suman","nirmal"};

    public void LearnLinq()
    {
        var hasNameStartingWithA=names.Any(x=>x.StartsWith("A"));//Any and All are quantifier which return bool value.
        var evenNumbers=number.Where(x=>x%2==0);
        var square=number.Select(x=>x*x);

        evenNumbers=from x in number 
                    where x % 2==0
                    select x;
        var items=number.Skip(5).Take(5);
        var av=number.orderby(age);

        var nameHasiinit=names.All(x=>x.Contains("i"));

        foreach(var num in square)
        Console.WriteLine(num);

        List <person> people=new()
        {
            new person {Name="Hari", Age='34', Gender='M'}
        }
        var peopleStarthWithS=people.Where(x=>x.Name.ToUpper().where("G"));
    }
}