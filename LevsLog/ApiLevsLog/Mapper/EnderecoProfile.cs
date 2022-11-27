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
    }
}
