namespace Natadon.DataAccess.Core
{
    public class DataAccessParameter
    {
        /// <summary>
        /// The name of the parameter in your SQL Query
        /// </summary>
        public string ParameterName { get; set; }


        /// <summary>
        /// The value of the parameter in the query.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Creates a new instance of DataAccesParameter with the supplied values
        /// </summary>
        /// <param name="Name">The parameter name</param>
        /// <param name="Val">The Value of the parameter</param>
        public DataAccessParameter(string Name, object Val)
        {
            ParameterName = Name;
            Value = Val;
        }

        public DataAccessParameter()
        {
            ParameterName = "";
            Value = null;
        }
    }
}
