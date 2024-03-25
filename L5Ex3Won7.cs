// Ex. 3: Scrieti un program care va numara toate aparitiile unui caracter intr-un sir 
//de caractere. Atat caracterul cautat cat si sirul de caractere vor fi citite de la tastatura

Console.Write("Enter a string: ");
string inputString = Console.ReadLine();

Console.Write("Enter the string that you want to find: ");
char searchChar = Console.ReadKey().KeyChar;
Console.WriteLine(); 

int count = 0;
foreach (char c in inputString)
{
    if (c == searchChar)
    {
        count++;
    }
}

Console.WriteLine($"The string '{searchChar}' appear {count} times in the following '{inputString}'.");