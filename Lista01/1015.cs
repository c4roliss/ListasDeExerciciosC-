using System; 

class MainClass
{
  public static void Main (string[] args)
  { 
    double xa,xb,ya,yb;

    string[] vet1 = Console.ReadLine().Split(' ');
    xa = double.Parse(vet1[0]); 
    xb = double.Parse(vet1[1]);
    string[] vet2 = Console.ReadLine().Split(' ');
    ya = double.Parse(vet2[0]);
    yb = double.Parse(vet2[1]);
  }
}