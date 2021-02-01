using System; 

class MainClass
{
  public static void Main (string[] args)
  { 
    string[] texto = Console.ReadLine().Split(" ");
    int n1 = int.Parse(texto[0]), n2 = int.Parse(texto[1]), n3 = int.Parse(texto[2]);    
    int maiorAB = (n1+n2+(Math.Abs(n1-n2)))/2;    
    if(maiorAB > n3) Console.WriteLine($"{maiorAB} eh o maior");
    else Console.WriteLine($"{n3} eh o maior");

  }
}