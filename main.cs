using System;

class Program {

  public static void Main (string[] args) {
    Program calcular = new Program();
    double n1=20;
    double n2=10;
    double resultado;
    resultado=calcular.dividir(n1,n2);
    Console.WriteLine(resultado);

    Console.WriteLine(Math.Pow(2,3));
  }

  public double dividir(double x1, double x2){
  double resultadodivisao;
  resultadodivisao=(x1/x2);
  return resultadodivisao;
  }
  }