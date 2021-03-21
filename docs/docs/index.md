# Natadon.DataAccess.Core

DataAccess.Core is the base component of a larger data access library framework.  This library acts as the interface for all the other, database specific implementations.

This library has one interface [IDataAccess](IDataAccess.md), and one class [DataAccessParameter](DataAccessParameter.md).  The interface defines the methods that can be called to retrieve data from a database and the data access parameter is a generic implementation of a database parameter.  More information can be found on the class documentation pages.