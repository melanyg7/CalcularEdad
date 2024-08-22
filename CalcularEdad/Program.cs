using System;
using System.ComponentModel.Design;
class CalcularEdad 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al programa de calculo de Edad Jas Jas");
        Console.WriteLine("Ingrese su Nombre Completo:");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su Edad:");
        int Edad = Convert.ToInt32(Console.ReadLine());


        string Meses;
        double Dias = 0;
        double Horas = 0;

        double meses = Edad * 12;
        double dias = Edad *365;
        double horas = Edad *24;

        Console.WriteLine($"holis {Nombre}, tu edad en meses es: {meses} meses");
        Console.WriteLine($"holis {Nombre}, tu edad en días es: {dias} días");
        Console.WriteLine($"holis {Nombre}, tu edad en días es: {horas} horas");






    }
}
