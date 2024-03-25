// Ex. 2: Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom.

Console.Write("Enter a string: ");
string inputString = Console.ReadLine();
bool IsPalindrome(string str)
{

    char[] charArray = str.ToLower().ToCharArray();
    int left = 0;
    int right = charArray.Length - 1;


    while (left < right)
    {
        if (!char.IsLetterOrDigit(charArray[left]))
        {
            left++;
        }
        else if (!char.IsLetterOrDigit(charArray[right]))
        {
            right--;
        }
        else if (charArray[left] != charArray[right])
        {
            return false;
        }
        else
        {
            left++;
            right--;
        }
    }
    return true;
}


if (IsPalindrome(inputString))
{
    Console.WriteLine("The string is a palindrome.");
}
else
{
    Console.WriteLine("The string is not a palindrome.");
}