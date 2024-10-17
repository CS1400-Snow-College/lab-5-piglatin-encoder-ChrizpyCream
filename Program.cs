

Console.Clear();

// greeting and description
Console.WriteLine("Welcome to the Piglatin encoder anything you say will be put into Piglatin and encoded");
Console.WriteLine("Please enter a a couple word or sentences"); //description and greetings 
string phrase = Console.ReadLine();


string[] termArray = phrase.Split(' '); // split phrases into words 
int letterMove = 0;



Random rand = new Random();
int offSet = rand.Next(1,26); // creates a random shift in letter i
char letter = (char)97; // it picks a random number between 1 and 25 and then shifts the letter 'a' by that random amount to get a new letter 
letter = (char)((int)letter + offSet);

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
Console.Write(termArray[i]); 
    letterMove = 0;  // resets the counter for the next word in the orginal statment above.
    
}
Console.WriteLine();

string[] encript = termArray;
for(int f = 0; f<encript.Length; f++)
{
    //takes the char in the string and offests it then prints it back out into the line 
    for(int j = 0; j<encript[f].Length; j++)
    {
        //if the char or letter is a space ignor the space .
        letter = encript[f][j];
        if(" ".Contains(letter))
        {
            letter = encript[f][j];

        }else // randomly offset each letter.
        {
            int letterLoop = letter + offSet;
            while(letterLoop > 122)
            {
                int remain = letterLoop % 122;
                letterLoop = 97 + remain;

            }
            letter = (char)((int)letterLoop);
        }
    }
}