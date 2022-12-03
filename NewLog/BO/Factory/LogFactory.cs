using NewLog.Domain.Entities;
using System.Data;

namespace NewLog.Infra.ORACLE.BO.Factory
{
    public class LogFactory
    {
        public static Log Log_Builder(DataRow dr)
        {
            int CODIGO_EVENTO = Convert.ToInt32(dr["CODIGO_EVENTO"]);
            int ID_EVENTO = Convert.ToInt32(dr["ID_EVENTO"]);
            int ID_CONTEUDO = Convert.ToInt32(dr["ID_CONTEUDO"]);
            string? DATA_CRIACAO = Convert.ToString(dr["DATA_CRIACAO"]);
            string? USUARIO = Convert.ToString(dr["USUARIO"]);
            string? DESCRICAO = Convert.ToString(dr["DESCRICAO"]);
            string? JUSTIFICATIVA = Convert.ToString(dr["JUSTIFICATIVA"]);

            Log obj = new Log(CODIGO_EVENTO, ID_EVENTO, ID_CONTEUDO, DATA_CRIACAO, USUARIO, DESCRICAO, JUSTIFICATIVA);

            return obj;
        }

        public static List<Log> Log_List_Builder(DataRowCollection dt)
        {
            List<Log> obj = new List<Log>();

            foreach (DataRow DtRow in dt)
            {
                Log var_obj = Log_Builder(DtRow);
                obj.Add(var_obj);
            }

            return obj;
        }
    }
}
