using System.Collections.Generic;
using System.Data;

namespace Natadon.DataAccess.Core
{
    public interface IDataAccess
    {
        void ExecuteQuery(string SqlStatement, List<DataAccessParameter> Params = null);

        DataSet GetDataSet(string SqlStatement, List<DataAccessParameter> Params = null);

        object GetScalar(string SqlStatement, List<DataAccessParameter> Params = null);
    }
}
