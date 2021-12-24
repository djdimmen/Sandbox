using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string LastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                return connection.Query<Person>($"SELECT Id, FirstName, LastName, EmailAddress, PhoneNumber FROM dbo.People WHERE LastName = '{ LastName }'").ToList();
            }
        }
    }
}
