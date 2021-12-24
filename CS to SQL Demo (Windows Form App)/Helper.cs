using System;
using System.Collections.Generic;
using System.Text;

namespace CS_to_SQL_Demo__Windows_Form_App_
{
    public static class Helper
    {
        public static string ConnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
