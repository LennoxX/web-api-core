﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Aluno
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public Aluno()
        {
        }

        public Aluno(int id, string nome, string sobrenome, string telefone)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }


    }
}
