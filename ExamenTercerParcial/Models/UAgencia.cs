using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenTercerParcial.Models
{
    public class UAgencia : iVuelo
    {

        public double Valor = -0.15;
        public double Puntos = 50;
        public void Aceptar(iVueloVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
