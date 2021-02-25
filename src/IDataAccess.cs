using System.Collections.Generic;
using System.Data;

namespace Natadon.DataAccess.Core
{
    public interface IDataAccess
    {
        /// <summary>
        /// Executes the passed SQL statement on the server.  
        /// </summary>
        /// <param name="SqlStatement">The SQL statement to run on the server</param>
        /// <param name="Params">Optional list of parameters</param>
        void ExecuteQuery(string SqlStatement, List<DataAccessParameter> Params = null);

        /// <summary>
        /// Returns a System.Data.DataSet result of the query run on the server
        /// </summary>
        /// <param name="SqlStatement">The SQL statement to run on the server</param>
        /// <param name="Params">Optional list of parameters</param>
        /// <returns>The result set as a System.Data.DataSet</returns>
        DataSet GetDataSet(string SqlStatement, List<DataAccessParameter> Params = null);

        /// <summary>
        /// Returns the value in the first column of the first row of the query
        /// </summary>
        /// <param name="SqlStatement">The SQL statement to run on the server</param>
        /// <param name="Params">Optional list of parameters</param>
        /// <returns>Object from the first cell of the first row from the query</returns>
        object GetScalar(string SqlStatement, List<DataAccessParameter> Params = null);
    }
}
