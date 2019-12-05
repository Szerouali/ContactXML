using System;
using System.Collections.Generic;
using System.Text;

namespace ContactXML
{

    [Serializable()]
    public class Contact
    {
        private string name;
        private string number;
        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }

        public Contact() { }

        public Contact(string name, string number){
            this.name = name;
            this.number = number;
        }

        public override string ToString()
        {
            return this.name+":" + this.number;
        }



    }
}
