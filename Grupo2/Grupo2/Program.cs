using System;

namespace Grupo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Laboratorio 2 Ejercicio";
            String resp, sexo, nombre;
            int edad;
            do
            {

                Console.WriteLine("Ingrese su Nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("Ingrese su Edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese su sexo (Hombre=H Y Mujer=M):");
                sexo = Console.ReadLine(); ;
                if (sexo == "H" || sexo == "h")
                    Console.WriteLine("El Sr.{0} ha sido registrado", nombre);
                else if (sexo == "M" || sexo == "m")
                    Console.WriteLine("La Sr. {0} ha sido regisrada", nombre);
                else
                    Console.WriteLine("Dato Incorrecto");
                Console.WriteLine("Desea Continuar (s/n:)");
                resp = Console.ReadLine();
            }
            while (resp != "n" && resp != "N");
            Console.WriteLine("\n");
            Console.WriteLine("--->Programa Finalizado");
            Console.ReadKey();
        }
    }
}
//GRUPO 2

//Realizar un programa que solicite el nommbre de una persona, su edad y su sexo, si el sexo es 
//masculino que muestre en la ventana el mensaje de "El Sr.(nombre) ha sido registrado" y si 
//el sexo es femenino que muestre el mensaje "La Sra.(nombre) ha sido registrada"

