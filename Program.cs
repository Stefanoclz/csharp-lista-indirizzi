// See https://aka.ms/new-console-template for more information

using csharp_lista_indirizzi;

StreamReader indirizzi = File.OpenText("C:/Users/Stefano/source/repos/csharp-lista-indirizzi/addresses.csv");

string openLine = indirizzi.ReadLine();

List<Address> addressesList = new List<Address>();

while (!indirizzi.EndOfStream)
{
    string line = indirizzi.ReadLine();
    Console.WriteLine(line);
    string[] breakLine = line.Split(",");

    string nome = breakLine[0];
    string cognome = breakLine[1];
    string strada = breakLine[2];
    string citta = breakLine[3];
    string provincia = breakLine[4];
    string zip = breakLine[5];

    Address nuovo = new Address(nome, cognome, strada, citta, provincia, zip);

    addressesList.Add(nuovo);
}