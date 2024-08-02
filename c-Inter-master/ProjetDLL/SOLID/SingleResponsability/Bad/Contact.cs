using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.SingleResponsability.Bad
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Contact(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Contact()
        {
        }

        public void Save(Contact c)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.Open();
            string sql = "INSERT INTO contact(name) VALUES('" + c.Name + "')";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }

    //Responsabiltés de la classe Contact:
    //Création d'objet
    //Gestion de la connexion
    //Gestion de la persistence des objets de type Contact
}
