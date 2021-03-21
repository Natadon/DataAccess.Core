# IDataAccess

IDataAccess is an interface that exposes simple functions that can be called against a database, these methods include:

ExecuteQuery
GetDataSet
GetScalar

---

## ExecuteQuery

The ExecuteQuery method is used to execute the passed SQL statement(s) against the database. 

### Parameters

| Name          | Description
|---            |---
| SqlStatement  | A string containing the SQL you want to run against the server
| Params        | (optional) A `List<DataAccessParameters>` that contains any parameters required for the query

### Examples

#### Basic Example
```
var str = "SELECT * FROM MyTable"

IDataAccess da = new Natadon.MySqlDataAccess("ServerName", "DatabaseName", "UserName", "Password");

da.ExecuteQuery(str);
```

#### Basic Example with Parameters

```
var str = "SELECT * FROM MyTable WHERE ID = @ID"

IDataAccess da = new Natadon.MySqlDataAccess("ServerName", "DatabaseName", "UserName", "Password");

List<DataAccessParameters> parameters = new List<DataAccessParameters>()
{
    new DataAccessParameter("ID", 42)
};

da.ExecuteQuery(str, parameters);
```