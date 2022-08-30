using DataModel;
using System.Data.SqlClient;

SqlConnection conn = new();
conn.ConnectionString = @"Data Source=(localdb)\ServidorLocal;Initial Catalog=LOGISTICA_COBRO;";
SqlCommand cmd = new SqlCommand("ConsultaSP", conn);

try
{
    conn.Open();
    List<DatosModel> list = new();
    SqlDataReader Rd = cmd.ExecuteReader();
    if (Rd.HasRows)
    {

        while (Rd.Read())
        {

            var listRequest = new DatosModel();
            listRequest.Id = Rd["Id"].ToString();
            listRequest.Dato1= Rd["Dato1"].ToString();
            listRequest.Dato2= Rd["Dato2"].ToString();
            listRequest.Dato3= Rd["Dato3"].ToString();
            listRequest.Dato4= Rd["Dato4"].ToString();
            listRequest.Dato5= Rd["Dato5"].ToString();
            listRequest.Dato6= Rd["Dato6"].ToString();
            listRequest.Dato7= Rd["Dato7"].ToString();
            list.Add(listRequest);
        }
    }
}
catch (Exception)
{
}
finally
{
    conn.Close();
}