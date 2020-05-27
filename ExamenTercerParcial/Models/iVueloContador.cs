using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ExamenTercerParcial.Models
{
    public class iVueloContador : iVueloVisitor
    {
        public double totalkm;
        public double precio;
        public double preciototal;
        public double puntos;
        public double contadorpuntos;

        public iVueloContador()
        {
            totalkm = 1;
            precio = 150;
            preciototal = precio;
            puntos = 0;
            contadorpuntos = 500;
        }

        public void Visitar(UCasual vuelo)
        {
            precio += vuelo.Valor;
            puntos = vuelo.Puntos;
        }
        public void Visitar(UPremium vuelo)
        {
            precio *= vuelo.Valor;
            preciototal += precio;
            puntos = vuelo.Puntos;

        }

        public void Visitar(UAgencia vuelo)
        {
            precio *= vuelo.Valor;
            preciototal += precio;
            puntos = vuelo.Puntos;
        }
    }
}
