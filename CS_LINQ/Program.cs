// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo LINQ");

List<string> Characters = new List<string>() 
{
   "James Bond", "Ethan Hunt","Indiaia Jones", "Jack Reacher", "Jason Bourn", "Shrikant"
};

//foreach (string str in Characters)
//{
//    if (str.Length > 10 && str.StartsWith('J'))
//    {
//        Console.WriteLine(str);
//    }
//}

// 1. Declarative Queries using extension methods

var result_1 = Characters.Where(character=>character.Length>10 && character.StartsWith('J'));

PrintResult(result_1);

Console.WriteLine();
var result_2 = Characters.OrderByDescending(c => c.Length);
PrintResult(result_2);

// 2. Imperative
Console.WriteLine();

var result_3 = from c in Characters
               where c.Length > 10 && c.StartsWith('J')
               select c;
PrintResult(result_3);
Console.WriteLine(  );
var result_4 = from c in Characters
               orderby c.Length descending
               select c;

PrintResult(result_4);


Console.ReadLine();

static void PrintResult(IEnumerable<string> records)
{
    foreach (var record in records)
    {
        Console.WriteLine(record);
    }
}