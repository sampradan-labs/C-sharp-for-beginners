using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface ISql
    {
        string GetSelectQuerySyntax();
        string GetInsertQuerySyntax();
        string GetUpdateQuerySyntax();
        string GetDeleteQuerySyntax();
    }

    public class MsSQLServer : ISql
    {
        public string GetDeleteQuerySyntax()
        {
            return "delete from <tableName>";
        }

        public string GetInsertQuerySyntax()
        {
            return "insert into <tableName> ([cols...]), VALUES (...)";
        }

        public string GetSelectQuerySyntax()
        {
            return "select [col1,col2,...] from <tableName> WHERE <conditions>";
        }

        public string GetUpdateQuerySyntax()
        {
            return "update <tableName> SET <col> = <value> ,... WHERE <conditions>";
        }
    }

    public class Oracle : ISql
    {
        public string GetDeleteQuerySyntax()
        {
            return "FROM <tableName> DELETE <conditions>";
        }

        public string GetInsertQuerySyntax()
        {
            return "INTO <tableName> INSERT <col1=value,col2=value,...>";
        }

        public string GetSelectQuerySyntax()
        {
            return "FROM <tableName> WHERE <conditions>, SELECT <cols>";
        }

        public string GetUpdateQuerySyntax()
        {
            return "SET <col> = <value> ,... WHERE <conditions> IN <tableName>";
        }
    }
}
