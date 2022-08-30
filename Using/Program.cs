using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Using
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\ServidorLocal;Initial Catalog=LOGISTICA_COBRO;";
            using (SqlConnection connection = new(connectionString))
            {
                using (SqlCommand cmd = new("ConsultaSP", connection))
                {
                    List<Model> list = new();
                    connection.Open();
                    SqlDataReader Rd = cmd.ExecuteReader();

                }
            }
        }
    }
}
