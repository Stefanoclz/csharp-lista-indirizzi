// See https://aka.ms/new-console-template for more information

using csharp_lista_indirizzi;

StreamReader indirizzi = File.OpenText("C:/Users/Stefano/source/repos/csharp-lista-indirizzi/addresses.csv");

string openLine = indirizzi.ReadLine();

List<Address> addressesList = new List<Address>();
List<string> stringFatteMale = new List<string>();

while (!indirizzi.EndOfStream)
{
    try
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
        
        for(int i = 0; i <= breakLine.Length; i++)
        {
            string test = breakLine[i];
            if (test.Length == 0 || test == " ")
            {
                string badLine = indirizzi.ReadLine();
                stringFatteMale.Add(badLine);
            }
            else
            {
                Address nuovo = new Address(nome, cognome, strada, citta, provincia, zip);

                addressesList.Add(nuovo);
                break;
            }
        }


        
    }
    catch (IndexOutOfRangeException)
    {
        string badLine = indirizzi.ReadLine();
        stringFatteMale.Add(badLine);
    }
}

Console.WriteLine("*****************************");
Console.WriteLine("Indirizzi Giusti:");
Console.WriteLine();

foreach (Address address in addressesList)
{
    address.AddressStamp();
}

Console.WriteLine("*****************************");
Console.WriteLine("Indirizzi Sbagliati:");
Console.WriteLine();

foreach (string badString in stringFatteMale)
{
    Console.WriteLine(badString);
}