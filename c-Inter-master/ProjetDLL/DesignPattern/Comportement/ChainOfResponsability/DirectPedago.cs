using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetDLL.DesignPattern.Comportement.ChainOfResponsability.ComplaintRequest;

namespace ProjetDLL.DesignPattern.Comportement.ChainOfResponsability
{
    public class DirectPedago : StaffMember
    {
        public DirectPedago(string name, StaffMember successor) : base(name, successor)
        {
        }

        public override void handleComplaint(ComplaintRequest request)
        {
            if (request.ComplaintType == 2)
            {
                Console.WriteLine("Traitée par le Directeur Pédagogique....");
                request.State = ComplaintState.CLOSED;

            }else if(Successor != null)
            {
                Console.WriteLine("Le directeur Pedago à remonter la plainte à son Directeur......");
                Successor.handleComplaint(request);
            }
        }
    }
}
