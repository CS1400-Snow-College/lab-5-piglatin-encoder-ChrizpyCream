// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Clear();

// greeting and description
Console.WriteLine("Welcome to the Piglatin encoder anything you say will be put into Piglatin and encoded");
Console.WriteLine("Please give me a few words or sentences");
string phrase = Console.ReadLine();

//phrase split into words
string[] wordArray = phrase.Split(' ');
int letterMove = 0;


for(int i = 0; i<wordArray.Length; i++)
{

while(!"aeiou".Contains(wordArray[i][0])) // while the first letter is not a vowel
{
    wordArray[i] = wordArray[i].Substring(1) + wordArray[i][0]; //take the first letter and move it to the back.
    letterMove ++; // checks if the first letter got moved at all
}
    if(letterMove > 0) // if the letter did get move the word started with a consonant 
    {
        wordArray[i] = wordArray[i] + "ay ";
    }else // if it did not then the word started with a vowel
    {
        wordArray[i] = wordArray[i] + "way ";
    }

    letterMove = 0;  //resets the counter for the next word.
    Console.Write($"{wordArray[i]}"); 
}


//So that there is a space
Console.WriteLine();