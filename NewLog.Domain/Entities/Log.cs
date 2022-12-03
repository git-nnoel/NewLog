using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLog.Domain.Entities
{
    public class Log
    {
        public int codigo_evento;
        public int id_evento;
        public int id_conteudo;
        public string? data_criacao;
        public string? usuario;
        public string? descricao;
        public string? justificativa;
        public Log(int codigo_evento, int id_evento, int id_conteudo, string? data_criacao, string? usuario, string? descricao, string? justificativa)
        {
            this.codigo_evento = codigo_evento;
            this.id_evento = id_evento;
            this.id_conteudo = id_conteudo;
            this.data_criacao = data_criacao;
            this.usuario = usuario;
            this.descricao = descricao;
            this.justificativa = justificativa;
        }
    }
}
