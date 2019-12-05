using System;
using System.Collections.Generic;

namespace ContactXML
{
    class Program
    {
        static String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/contacts.xml";

        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("joe", "0710319877"));
            contacts.Add(new Contact("Ali", "0610319877"));

            WriteXML(contacts);
            ReadXML();

            Console.ReadKey(true);

        }

        public static void WriteXML(List<Contact> myLists)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Serialization.XmlSerializer(typeof(List<Contact>));
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, myLists);
            file.Close();

        }
        public static void ReadXML() {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(List<Contact>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            List<Contact> contacts = (List<Contact>)reader.Deserialize(file);
            file.Close();

            foreach(Contact c in contacts)
            {
                Console.WriteLine(c);
            }


        }
    } 
}
