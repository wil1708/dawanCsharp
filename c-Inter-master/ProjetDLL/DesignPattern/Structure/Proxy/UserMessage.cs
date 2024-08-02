using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Structure.Proxy
{
    public class UserMessage : IMessages
    {
        private string Content;

        public UserMessage(string content)
        {
            Content = content;
        }

        public string getContent()
        {
            return Content;
        }
    }
}
