using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Address
    {
        public string name = "";
        public string surname = "";
        public string street = "";
        public string city = "";
        public string province = "";
        public string zip = "";

        public Address(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public void AddressStamp()
        {
            Console.WriteLine($"Nome: {this.name} | Cognome: {this.surname} | Via: {this.street} | Città: {this.city} | Provincia: {this.province} | Codice ZIP: {this.zip}");
        }
    }
}
