﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoSA
{
    class Pessoa
    {
        private string nome;
        private string email;
        private int idade;
        //Método construtor
        public Pessoa()
        {

        }

        public void imprimirValores()
        {
            //imprimindo
        }
        public int calculaIdade(int idade)
        {
            return this.idade = idade + 1;
        }
    }
}
