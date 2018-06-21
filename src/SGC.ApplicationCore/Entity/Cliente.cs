using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.ApplicationCore.Entity
{
    public class Cliente
    {
        //construtor
        public Cliente()
        {

        }

        //propriedades
        public int ClienteId { get; private set; }

        public string Nome { get; private set; }

        public string CPF { get; private set; }
        
    }
}
