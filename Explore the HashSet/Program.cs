List<string> ListOfNames= new List<string>();
HashSet<string> HashsetListOfName= new HashSet<string>();

ListOfNames.Add("Anna");
ListOfNames.Add("Claudia");
ListOfNames.Add("Marco");
ListOfNames.Add("Luca");
ListOfNames.Add("anna");
ListOfNames.Add("luca");
ListOfNames.Add("Marco");

Console.WriteLine("sto stampando i nomi della lista:");

foreach(string name in ListOfNames)
{
    Console.WriteLine(name);
}

Console.WriteLine("\nsto aggiungendo i nomi della ListOfNames all'HashsetListOfName, per vedere cosa accade");

foreach (string names in ListOfNames)
{
    HashsetListOfName.Add(names);
}

Console.WriteLine("\nsto stampando i nomi dell'HashsetListOfName");

foreach (string names in HashsetListOfName)
{
    Console.WriteLine(names);
}




