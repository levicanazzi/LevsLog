﻿using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.ClienteDtos;
using System.Collections.Generic;

namespace ApiLevsLog.Mapper
{
    public static class ClienteProfile
    {
        public static List<ReadCliente> ClientesToReadClientes(List<Cliente> clientes)
        {
            List<ReadCliente> clientesDto = new List<ReadCliente>();

            foreach (var cliente in clientes)
            {
                clientesDto.Add(new ReadCliente()
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Sobrenome = cliente.Sobrenome,
                    Email = cliente.Email,
                    DataNascimento = cliente.DataNascimento,
                    Logradouro = cliente.Endereco.Logradouro,
                    Numero = cliente.Endereco.Numero,
                    Cep = cliente.Endereco.Cep,
                    Estado = cliente.Endereco.Estado,
                    Municipio = cliente.Endereco.Municipio
                });
            }

            return clientesDto;
        }
    }
}
