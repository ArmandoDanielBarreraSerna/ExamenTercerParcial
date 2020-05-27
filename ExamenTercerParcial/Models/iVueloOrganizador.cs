using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenTercerParcial.Models
{
    class iVueloOrganizador : iVueloVisitor
    {
        public List<UCasual> Casual;

        public List<UPremium> Premium;

        public List<UAgencia> Agencia;

        public iVueloOrganizador()
        {
            Casual = new List<UCasual>();
            Premium = new List<UPremium>();
            Agencia = new List<UAgencia>();
        }
        public void Visitar(UCasual vuelo)
        {
            Casual.Add(vuelo);
        }

        public void Visitar(UPremium vuelo)
        {
            Premium.Add(vuelo); 
        }

        public void Visitar(UAgencia vuelo)
        {
            Agencia.Add(vuelo);
        }
    }
}
