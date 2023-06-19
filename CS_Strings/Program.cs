// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string someText = "C# is the a great programming language";

string fname = "James";
string mname = "Andrew";
string lname = "Bond";

/* Traditional concatention*/
string fullName = fname + " " + mname + " " + lname; // 5 String objects

Console.WriteLine("Full Name = " + fullName);

/* String Interpolation: a approach of building an 'immutable' string object that will be enhanced with new string data */

string completeName = $"{fname} {mname} {lname}"; // a single string object

Console.WriteLine($"With Interpolation Full Name = {completeName}");

/* String CLass Porperties and Methods */

Console.WriteLine($"Length of {someText} is = {someText.Length}");

Console.WriteLine($"First index of 'a' in {someText} is {someText.IndexOf('a')} and Last index of 'a' is {someText.LastIndexOf('a')} ");

Console.WriteLine($"{someText.Contains("th")}");

var result = someText.Concat(" by Microsoft");

string finalResult = string.Empty; /* Allocated in Memory with Length as 0 */

foreach (char c in result)
{
    finalResult += c;
}

Console.WriteLine(finalResult);

/*Number of white spaces in the string */
int whiteSpacesCounter = 0;
foreach (char c in finalResult)
{
    if (Char.IsWhiteSpace(c))
    { 
        whiteSpacesCounter++;
    }
}

Console.WriteLine($"Count of white spaces in {finalResult} is = {whiteSpacesCounter}");
 
Console.ReadLine();