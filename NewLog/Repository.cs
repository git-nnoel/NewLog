using NewLog.Domain.Entities;
using NewLog.NewLog.Infra.Oracle.BO;
using System.Net.Mail;

namespace NewLog.Infra.ORACLE
{
    internal class Repository
    {
        #region BOs

        private LogBO? _logBO;
        private LogBO logBO
        {
            get
            {
                if (_logBO == null)
                {
                    _logBO = new LogBO();
                }

                return _logBO;
            }
        }

        #endregion

        #region IRepository Members

        #region Log
        public Log Select(int Code)
        {
            return logBO.Select_Log(Code);
        }

        #endregion

        #endregion

        public Repository()
        {
        }
    }
}
