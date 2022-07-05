// See https://aka.ms/new-console-template for more information

using csharp_lista_indirizzi;

StreamReader indirizzi = File.OpenText("C:/Users/Stefano/source/repos/csharp-lista-indirizzi/addresses.csv");

string openLine = indirizzi.ReadLine();

List<Address> addressesList = new List<Address>();
List<string> stringFatteMale = new List<string>();

while (!indirizzi.EndOfStream)
{
    string line = indirizzi.ReadLine();
    Console.WriteLine(line);
    string[] breakLine = line.Split(",");
    try
    {

        if(breakLine.Length == 6)
        {
            string nome = breakLine[0];
            string cognome = breakLine[1];
            string strada = breakLine[2];
            string citta = breakLine[3];
            string provincia = breakLine[4];
            string zip = breakLine[5];

            bool good = false;

            for(int i = 0; i < breakLine.Length; i++)
            {
                if (breakLine[i] == "")
                {
                    good = false;
                    stringFatteMale.Add(line);
                    break;
                }
                else
                {
                    good = true;
                }
            }

            if (good == true)
            {
                Address nuovo = new Address(nome, cognome, strada, citta, provincia, zip);
                addressesList.Add(nuovo);
            }
            
        }
        else
        {
            stringFatteMale.Add(line);
        }


    }
    catch (IndexOutOfRangeException)
    {
        stringFatteMale.Add(line);
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