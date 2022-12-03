using ApiLevsLog.Data;
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

        public static Cliente UpdateClientes(UpdateCliente clienteDto, Cliente cliente)
        {

            cliente.Nome = clienteDto.Nome;
            cliente.Sobrenome = clienteDto.Sobrenome;
            cliente.Email = clienteDto.Email;
            cliente.Endereco.Logradouro = clienteDto.Logradouro;
            cliente.Endereco.Numero = clienteDto.Numero;
            cliente.Endereco.Cep = clienteDto.Cep;
            cliente.Endereco.Municipio = clienteDto.Municipio;
            cliente.Endereco.Estado = clienteDto.Estado;

            return cliente;
        }
        public static Cliente AddClientes(AddCliente clienteDto)
        {

            Enderecos endereco = new Enderecos()
            {
                Logradouro = clienteDto.Logradouro,
                Numero = clienteDto.Numero,
                Cep = clienteDto.Cep,
                Municipio = clienteDto.Municipio,
                Estado = clienteDto.Estado
            };

            Cliente cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                DataNascimento = clienteDto.DataNascimento,
                Email = clienteDto.Email,
                Endereco = endereco
            };

            return cliente;
        }
    }
}
