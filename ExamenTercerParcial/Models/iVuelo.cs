using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenTercerParcial.Models
{
    public interface iVuelo
    {
        void Aceptar(iVueloVisitor visitor);
    }
}
