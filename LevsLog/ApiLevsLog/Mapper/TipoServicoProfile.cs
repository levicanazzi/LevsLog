using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.TipoServico;
using System.Collections.Generic;

namespace ApiLevsLog.Mapper
{
    public class TipoServicoProfile
    {
        public static List<ReadTipoServico> ReadingTipoServicos(List<TipoServico> tipoServicos)
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
    }
}
