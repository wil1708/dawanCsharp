using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Structure.Adapter
{
    [DataContract]
    public class Contact
    {
        //  pour ignorer un champs pendant la sérialisation :
        //1- Mettre annotation [DataContract] sur la classe
        //2- ne pas mettre l'annotation [DataMember] sur le champs qu'on souhaite ignorer

        //[DataMember]
        public int Id { get; set; }

       [DataMember]
        public string Name { get; set; }
    }
}
