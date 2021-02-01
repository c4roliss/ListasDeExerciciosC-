using System; 

class MainClass {
  public static void Main (string[] args)
  { 
    double salario, montante, calculo;

   
    string nome = Console.ReadLine();

    
    salario = double.Parse(Console.ReadLine());

    
    montante = double.Parse(Console.ReadLine());

    calculo = salario + (montante * 0.15);
    Console.WriteLine($"TOTAL = R$ {calculo:0.00}");
  }
}