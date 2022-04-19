public class FileIO
{
    public void ReadFile()
    {
         var fileContent = File.ReadAllText("Path to read file");

         FileInfo fi=new("");
    }
    public void ReadFolder()
    {
        var fileContent = Directory.CreateDirectory("Path to file");
        DirectoryInfo di=new("");
    }
}
