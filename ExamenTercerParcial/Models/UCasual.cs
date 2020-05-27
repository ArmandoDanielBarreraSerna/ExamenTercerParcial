using ExamenTercerParcial.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenTercerParcial
{
    public class UCasual : iVuelo
    {
        public float Valor = 0;
        public float Puntos = 0;
        public void Aceptar(iVueloVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
