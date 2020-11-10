﻿using System;


namespace Loc.DTO
{
    public class Clientes
    {
        public int CodCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public DateTime DtNascimento { get; set; }
        public string  Cep { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Clientes()
        {

        }

    }
}
