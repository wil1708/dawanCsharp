using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Comportement.Memento
{
    public class History
    {
        public List<EditeurState> States { get; set; }

        public History()
        {
            States = new List<EditeurState>();
        }

        public void Push(EditeurState state)
        {
            States.Add(state); //insertion à la fin de la list
        }

        public EditeurState Pop()
        {
            //Restaurer le dernier état sauvegardé
            var lastState = States.Last();
            States.Remove(lastState);
            return lastState;
        }
    }
}
