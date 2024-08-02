using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetDLL.DesignPattern.Comportement.ChainOfResponsability.ComplaintRequest;

namespace ProjetDLL.DesignPattern.Comportement.ChainOfResponsability
{
    public class Directeurs : StaffMember
    {
        public Directeurs(string name, StaffMember successor) : base(name, successor)
        {
        }

        public override void handleComplaint(ComplaintRequest request)
        {
            Console.WriteLine("Taritée par le Directeur....");
            request.State = ComplaintState.CLOSED;
        }
    }
}
