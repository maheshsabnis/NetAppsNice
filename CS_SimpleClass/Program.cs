// See https://aka.ms/new-console-template for more information



using CS_SimpleClass;
using CS_SimpleClass.AppClasses;

Console.WriteLine("Demo Simple Operation class");

// 1. CReat an instance of the class

SimpleOperations obj = new SimpleOperations();

double x, y;

/* Lets accept data for x and y */

Console.WriteLine("Enter x");
// L.H.S = R.H.S.
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter y");
// L.H.S = R.H.S.
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{x} raised to {y} is = {obj.Popwer(x,y)}");

int a =  6, b =  -2;

Console.WriteLine($"{a} / {b} is = {obj.Division(a,b)}");

//string Name = "Tejas Mahesh Sabnis";
string Name = string.Empty;
Console.WriteLine($"Reverse of {Name} is = {obj.Reverse(Name)}");

string str = $"The James Bond series focuses on James Bond, a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is With a Mind to Kill by Anthony Horowitz, published in May 2022. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny.\r\n\r\nThe character—also known by the code number 007 (pronounced \"double-oh-seven\")—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total at the box office, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion in total (based on box-office grosses, DVD sales and merchandise tie-ins),[1] making James Bond one of the highest-grossing media franchises of all time.";


StringOperations stringOperations = new StringOperations();

Console.WriteLine($"Count of statements {stringOperations.GetStatementCount(str)}");

Console.WriteLine($"Count of words {stringOperations.GetWordCount(str)}");


Console.ReadLine();
