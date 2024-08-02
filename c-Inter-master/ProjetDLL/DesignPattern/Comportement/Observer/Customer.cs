using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Comportement.Observer
{
    public class Customer : IObserver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void Update(ISubjet obj)
        {
            //ProductItem p = (ProductItem)obj;
            //string body = "Bonjour, \n le prix du produit à été modifié: " + p.Price;

            //MailMessage msg = new MailMessage("noreply@dawan.fr", Email, "Changement du prix du produit " + p.Description, body);

            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.UseDefaultCredentials = true;
            //smtp.Credentials = new NetworkCredential("phrad.sainha@gmail.com", "1234dawan");
            //smtp.EnableSsl = true;
            //smtp.Send(msg);
        }
    }
}
