using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetDLL.DesignPattern.Comportement.ChainOfResponsability.ComplaintRequest;

namespace ProjetDLL.DesignPattern.Comportement.ChainOfResponsability
{
    public class Teacher : StaffMember
    {
        public Teacher(string name, StaffMember successor) : base(name, successor)
        {
        }

        public override void handleComplaint(ComplaintRequest request)
        {
            if (request.ComplaintType == 1)
            {
                Console.WriteLine("Traitée par le Teacher........");
                request.State = ComplaintState.CLOSED;
            }
            else if(Successor != null)
            {
                Console.WriteLine("Le Teacher à remonter la plainte à son succésseur pédagogique.....");
                Successor.handleComplaint(request);
            }
        }
    }
}
