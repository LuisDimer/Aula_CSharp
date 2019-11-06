using System;

class Program
{
    static void Main(string[] args)
    {
        double salario;
        salario = 1514.30;

        int salarioInt;
        salarioInt = (int)salario; //Converte(Casting) o valor de "salario (double) para Int"

        Console.WriteLine("salario: " + salario);
        Console.WriteLine("salario Inteiro: " + salarioInt);

        Console.ReadLine();
    }
}