using ExamenTercerParcial.Models;
using System;

namespace ExamenTercerParcial
{
    class Program
    {
        static void Main(string[] args)
        {

            var vuelos = new iVuelo[]
            {
                new UAgencia(),
            };

            var organizador = new iVueloOrganizador();
            var contador = new iVueloContador();

            foreach (var vuelo in vuelos)
            {
                vuelo.Aceptar(organizador);
                vuelo.Aceptar(contador);
            }


            Console.Write("Introduce los km recorridos: ");
            var cadena = Console.ReadLine();
            var numero = int.Parse(cadena);
            Console.WriteLine($"Total Kilometros: {numero * contador.totalkm}");
            Console.WriteLine($"Precio Total: {numero * contador.preciototal}");
            Console.WriteLine($"Puntos Premia: {((numero * contador.preciototal) / contador.contadorpuntos) * contador.puntos}");

            Console.ReadKey();
        }
    }
}
