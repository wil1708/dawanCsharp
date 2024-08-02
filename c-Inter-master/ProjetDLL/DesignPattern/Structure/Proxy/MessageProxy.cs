using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Structure.Proxy
{
    public class MessageProxy : IMessages
    {
        //cette classe joue le rôle d'une classe intermédiaire pour contrôler/relayer les messages

        private IMessages proxifiedMessage;

        public MessageProxy(IMessages proxifiedMessage)
        {
            this.proxifiedMessage = proxifiedMessage;
        }

        public string getContent()
        {
            string initialContent = proxifiedMessage.getContent();

            //faire des traitement sur le message original
            string finalContent = initialContent.ToUpper();

            return finalContent;
        }

    }
}
