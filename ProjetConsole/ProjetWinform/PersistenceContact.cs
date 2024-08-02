using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWinform
{
    class PersistenceContact : IPersistenceContact
    {
        SqlConnection cnx;
        public void AddContact(Contact c)
        {
            try
            {
                cnx = Connexion.getConnexion();
                //Créer la commande sql
                string sql = "INSERT INTO contact VALUES ('" + c.Id + "' , '" + c.Nom + " ' , '" + c.Prenom + "' , ' " + c.Email + "' , ' " + c.Telephone + "' )";

                //un objet SqlCommand
                SqlCommand cmd = new SqlCommand(sql, cnx);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnx.Close();
            }






        }
    }
}
