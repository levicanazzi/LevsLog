using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.TipoServico;
using System.Collections.Generic;

namespace ApiLevsLog.Mapper
{
    public class TipoServicoProfile
    {
        public static List<ReadTipoServico> ReadTipoServicos(List<TipoServico> tipoServicos)
        {
            List<ReadTipoServico> tipoServicosDto = new List<ReadTipoServico>();

            foreach (var tipoServico in tipoServicos)
            {
                tipoServicosDto.Add(new ReadTipoServico()
                {
                    Id = tipoServico.Id,
                    Servico = tipoServico.Servico
                });
            }
            return tipoServicosDto;
        }

        public static ReadTipoServico ReadTipoServicoById(TipoServico tipoServico)
        {
            ReadTipoServico tipoServicosDto = new ReadTipoServico()
            {
                Id = tipoServico.Id,
                Servico = tipoServico.Servico
            };

            return tipoServicosDto;
        }

        public static TipoServico AddTipoServico(AddTipoServico tipoServicoDto)
        {
            TipoServico tipoServico = new TipoServico()
            {
                Id = tipoServicoDto.Id,
                Servico = tipoServicoDto.Servico
            };

            return tipoServico;
        }
    }
}
