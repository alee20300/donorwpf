using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using donorwpf.Models;
using donorwpf.Helpers;



namespace donorwpf.Helpers
{
    public class DbCon
    {
        public List<Donor>GeDonors()
        {
            using (IDbConnection conn = new SqlConnection(ConHelper.ConVal("constring")))
            {
                return conn.Query<Donor>("select * from [Donor info]").ToList();

            }

        }
    }
}
