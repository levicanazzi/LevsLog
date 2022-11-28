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
                    //Nome = endereco.Cliente.Nome,
                    //Sobrenome = endereco.Cliente.Sobrenome,
                    //Email = endereco.Cliente.Email,
                    //DataNascimento = endereco.Cliente.DataNascimento,
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

            return enderecoDto;
        }

        public static Enderecos UpdateEndereco(UpdateEndereco enderecoDto, Enderecos endereco)
        {
            endereco.Logradouro = enderecoDto.Logradouro;
            endereco.Numero = enderecoDto.Numero;
            endereco.Cep = enderecoDto.Cep;
            endereco.Municipio = enderecoDto.Municipio;
            endereco.Estado = enderecoDto.Estado;

            return endereco;
        }
    }
}
