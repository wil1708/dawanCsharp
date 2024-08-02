using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.SingleResponsability.Good
{
   public  class ContactDAO
    {
        public void Save(Contact c)
        {
            SqlConnection cnx = Connexion.getConnexion();
            try
            {
                
                string sql = "INSERT INTO contact(name) VALUES('" + c.Name + "')";
                SqlCommand cmd = new SqlCommand(sql, cnx);
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw ex;
            }
            finally
            {
                cnx.Close();
            }
            
        }
    }
}
