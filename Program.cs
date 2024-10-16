

Console.Clear();

// greeting and description
Console.WriteLine("Welcome to the Piglatin encoder anything you say will be put into Piglatin and encoded");
Console.WriteLine("Please enter a a couple word or sentences"); //description and greetings 
string phrase = Console.ReadLine();


string[] termArray = phrase.Split(' '); // split phrases into words 
int letterMove = 0;


for(int i = 0; i<termArray.Length; i++)
{

while(!"aeiou".Contains(termArray[i][0]))
{
    termArray[i] = termArray[i].Substring(1) + termArray[i][0]; // takes the first letter and move it to the back of the word.
    letterMove ++; //  makes sure the first letter moved 
}
    if(letterMove > 0) // if the first letter didnt move the word, the word started with a consonant 
    {
        termArray[i] = termArray[i] + "ay ";
    }else // if not then the word started with a vowel
    {
        termArray[i] = termArray[i] + "way ";
    }

    letterMove = 0;  // resets the counter for the next word in the orginak statment above.
    Console.Write($"{termArray[i]}"); 
}