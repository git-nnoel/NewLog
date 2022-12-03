using NewLog.Domain.Entities;
using NewLog.Infra.ORACLE.BO.Factory;
using NewLog.NewLog.Infra.Oracle.DAO;
using System.Data;

namespace NewLog.NewLog.Infra.Oracle.BO
{
    internal class LogBO
    {
        #region DAOs

        private OracleDAO _dao;
        private OracleDAO dao
        {
            get
            {
                if (_dao == null)
                {
                    _dao = new OracleDAO();
                }

                return _dao;
            }
        }

        #endregion

        internal Log Select_Log(int Code)
        {
            DataTable dt = dao.Retrieve(Code);

            if ((dt == null) || (dt.Rows.Count != 1))
                return null;

            Log result = LogFactory.Log_Builder(dt.Rows[0]);

            return result;
        }
    }
}
