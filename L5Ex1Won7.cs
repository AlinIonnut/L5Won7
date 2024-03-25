// Ex. 1: Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri de caractere fiind citite de la tastatura

Console.WriteLine("Enter a string: ");
string firstString = Console.ReadLine();

Console.WriteLine("Enter a substring: ");
string subString = Console.ReadLine();

int position = firstString.IndexOf(subString);

if  (position != -1)
{
    Console.WriteLine($"The substring was found in the position: {position}");
}
else
{
    Console.WriteLine("The substring was not found!");
}