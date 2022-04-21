namespace FileHandlingDemo;
class FileHandling
   {
       public static void Main()
       {
         int i,alp, digit, splch;
         i=alp=digit=splch=0;
           string path = File.ReadAllText("C:/Users/nkand/Desktop/File.txt");
  
        while(i<path.Length)
        {
        if((path[i]>='a' && path[i]<='z')|| (path[i]>='A' && path[i]<='Z'))
        {
            alp++;
        }
        else if(path[i]>='0' && path[i]<='9')
        {
            digit++;
        }
        else
        {
            splch++;
      }

       i++;
    }
            int specialChars = System.Text.RegularExpressions.Regex.Matches(path, "[~!@#$%^&*()_+{}:\"<>?';,]").Count;
            Console.WriteLine($"Total No. of Special Chacter: {specialChars}");   
            int vowel=System.Text.RegularExpressions.Regex.Matches(path.ToLower(),"[aeiou]").Count;


           Console.WriteLine(path); // it ll display ur file on console

           Console.WriteLine($"1. The total number of character is:{path.Length}."); // show character

           Console.WriteLine($"###. The total line is: {path.Split('\r').Length}.");   //total line

           Console.WriteLine($"2. The total number of word is {path.Split(' ').Length}."); // total word

           Console.WriteLine($"3. The total number of sentence is {path.Split('.').Length} ."); // total sentence
           //Console.WriteLine($"5. The total number of vowel is {alp}"); 
           //Console.WriteLine($"5. The total number of vowel is {digit}");

           Console.WriteLine($"4. The total number of vowel is {vowel} .");//total vowel

           Console.WriteLine($"5. The total number of special character with whitespace is {splch} .");//total special character
            Console.WriteLine($"5. Total No. of Special Chacter without whitespace: {specialChars}"); 

       }

   }
##OUTPUT
1. The total number of character is:44728.
###. The total line is: 796.
2. The total number of word is 7884.
3. The total number of sentence is 597 .
4. The total number of vowel is 12933 .
5. The total number of special character with whitespace is 10886 .
5. Total No. of Special Chacter without whitespace: 664
