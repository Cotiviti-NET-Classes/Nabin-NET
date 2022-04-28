namespace CSVReader;
class Player
{
    public static void Main(string[] args)
    {
        string[] RawData = File.ReadLines(@"C:\Users\nabin.kandel\OneDrive - Cotiviti\Desktop\players.txt");

        foreach(var game in RawData)
        {
            var data=game.Split(",");
            player.Add(new Player()
            {
                ID=data[0],
                Name=data[1],
                Sex=data[2],
                Age=data[3],
                Height=data[4],
                Weight=data[5],
                Team=data[6],
                NOC=data[7],
                Games=data[8],
                Year=data[9],
                Season=data[10],
                City=data[11],
                Sport=data[12],
                Event=data[13],
                Medal=data[14]
                });
            
        }
        var NepaliPeople = player.Where(x => x.NOC.Contains("NEP"));
        foreach (var Nepali in NepaliPeople)
            Console.WriteLine(Nepali.Name);

        var ChinesePlayer = player.Where(x => x.NOC.Contains("CHN"));
        var gold = ChinesePlayer.Where(x => x.Medal.Contains("GOLD"));
        foreach (var CG in gold)
        {
            Console.WriteLine(CG.Name);
        }

        var USAPlayer=player.Where(x=>x.NOC.Contains("USA"));
        var USAOrder=USAPlayer.OrderBy(x=>x.Sport);
        foreach(var USAP in USAOrder)
        {
            Console.WriteLine(USAP.Name+" , "+USAP.Sport);
        }

        //var Medal=player.GroupBy(x=>x.NOC).Select(group)
    }
    
}
