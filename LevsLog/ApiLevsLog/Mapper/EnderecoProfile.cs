using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.EnderecoDtos;
using System.Collections.Generic;

namespace ApiLevsLog.Mapper
{
    public class EnderecoProfile
    {
        public static List<ReadEndereco> EnderecosToReadEnderecos(List<Enderecos> enderecos)
        {
            List<ReadEndereco> enderecosDto = new List<ReadEndereco>();

            foreach (var endereco in enderecos)
            {
                enderecosDto.Add(new ReadEndereco()
                {
                    Id = endereco.Id,
                    Nome = endereco.Cliente.Nome,
                    Sobrenome = endereco.Cliente.Sobrenome,
                    Email = endereco.Cliente.Email,
                    DataNascimento = endereco.Cliente.DataNascimento,
                    Logradouro = endereco.Logradouro,
                    Numero = endereco.Numero,
                    Cep = endereco.Cep,
                    Estado = endereco.Estado,
                    Municipio = endereco.Municipio
                });
            }

            return enderecosDto;
        }

        public static ReadEndereco ReadEnderecoById(Enderecos endereco)
        {
            ReadEndereco enderecoDto = new ReadEndereco();

            enderecoDto.Id = endereco.Id;
            enderecoDto.Logradouro = endereco.Logradouro;
            enderecoDto.Numero = endereco.Numero;
            enderecoDto.Cep = endereco.Cep;
            enderecoDto.Municipio = endereco.Municipio;
            enderecoDto.Estado = endereco.Estado;
            enderecoDto.Nome = endereco.Cliente.Nome;
            enderecoDto.Sobrenome = endereco.Cliente.Sobrenome;
            enderecoDto.Email = endereco.Cliente.Email;
            enderecoDto.DataNascimento = endereco.Cliente.DataNascimento;

            return enderecoDto;
        }
    }
}
