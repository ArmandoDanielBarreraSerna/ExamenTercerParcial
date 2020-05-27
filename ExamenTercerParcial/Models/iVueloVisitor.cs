using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenTercerParcial.Models
{
    public interface iVueloVisitor
    {
        void Visitar(UCasual vuelo);
        void Visitar(UPremium vuelo);
        void Visitar(UAgencia vuelo);

    }
}
