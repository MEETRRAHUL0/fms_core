using System;
using System.Data.SqlClient;
using System.Text;
using FMS_Core.Models.EFModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace FMS_Core.Controllers
{
    public class TestController : Controller
    {
        public IConfiguration Configuration { get; }
        public TestController (IConfiguration configuration)
        {
            Configuration = configuration;
        }

    public string Index()
        {
            StringBuilder res = new StringBuilder();
            try
            {
               
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "fms.database.windows.net";
                builder.UserID = "fms";
                builder.Password = "Password@123";
                builder.InitialCatalog = "FMSCore";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    res.Append("\nQuery data example:");
                    res.Append("\n=========================================\n");

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT TOP 20 * from tbl_GST");
                    //sb.Append("FROM [SalesLT].[ProductCategory] pc ");
                    //sb.Append("JOIN [SalesLT].[Product] p ");
                    //sb.Append("ON pc.productcategoryid = p.productcategoryid;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                res.Append("\n" +string.Format(  "{0} {1}", reader.GetInt32(0), reader.GetDecimal(1)));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                res.Append(e.ToString());
            }

            return res.ToString();
        }

        public string Test()
        {
            StringBuilder res = new StringBuilder();
            try
            {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "fms.database.windows.net";
                builder.UserID = "fms";
                builder.Password = "Password@123";
                builder.InitialCatalog = "FMSCore";

                using (SqlConnection connection = new SqlConnection(Configuration.GetConnectionString("DefaultConnection")))
                {
                    res.Append("\n" + Configuration.GetConnectionString("DefaultConnection"));
                    res.Append("\nQuery data example:");
                    res.Append("\n=========================================\n");

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT TOP 20 * from tbl_GST");
                    //sb.Append("FROM [SalesLT].[ProductCategory] pc ");
                    //sb.Append("JOIN [SalesLT].[Product] p ");
                    //sb.Append("ON pc.productcategoryid = p.productcategoryid;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                res.Append("\n" + string.Format("{0} {1}", reader.GetInt32(0), reader.GetDecimal(1)));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                res.Append(e.ToString());
            }

            return res.ToString();
        }
    }
}