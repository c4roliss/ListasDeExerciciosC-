using System; 

class MainClass {
  public static void Main (string[] args)
  { 
    double salario, montante, calculo;

    Console.WriteLine("Qual o seu nome?");
    string nome = Console.ReadLine();

    Console.WriteLine("Qual é o seu salário fixo?");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Qual foi o montante?");
    montante = double.Parse(Console.ReadLine());

    calculo = salario + (montante * 0.15);
    Console.WriteLine($"TOTAL = R$ {calculo:0.00}");
  }
}