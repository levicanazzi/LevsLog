using ApiLevsLog.Models;
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

        public static ReadCliente ReadClienteById(Cliente cliente)
        {
            ReadCliente clienteDto = new ReadCliente();

            clienteDto.Id = cliente.Id;
            clienteDto.Nome = cliente.Nome;
            clienteDto.Sobrenome = cliente.Sobrenome;
            clienteDto.Email = cliente.Email;
            clienteDto.DataNascimento = cliente.DataNascimento;
            clienteDto.Logradouro = cliente.Endereco.Logradouro;
            clienteDto.Numero = cliente.Endereco.Numero;
            clienteDto.Cep = cliente.Endereco.Cep;
            clienteDto.Municipio = cliente.Endereco.Municipio;
            clienteDto.Estado = cliente.Endereco.Estado;

            return clienteDto;
        }

        public static UpdateCliente UpdateCliente(Cliente cliente)
        {
            UpdateCliente clienteDto = new UpdateCliente();

            clienteDto.Id = cliente.Id;
            clienteDto.Nome = cliente.Nome;
            clienteDto.Sobrenome = cliente.Sobrenome;
            clienteDto.Logradouro = cliente.Endereco.Logradouro;
            clienteDto.Numero = cliente.Endereco.Numero;
            clienteDto.Cep = cliente.Endereco.Cep;
            clienteDto.Municipio = cliente.Endereco.Municipio;
            clienteDto.Estado = cliente.Endereco.Estado;
            clienteDto.Email = cliente.Email;

            return clienteDto;
        }
    }
}
