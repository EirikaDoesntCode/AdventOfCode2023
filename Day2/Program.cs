// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");


string[] Inputs = File.ReadAllLines("Day2Inputs");

// outputStrArray(Inputs);

int InLen = Inputs.Length;
int value = 0;
Bag[] bags = new Bag[InLen];
for(int i = 0; i < InLen; ++i)
{
    string[] splitGames = Inputs[i].Split(':', ';', ',');
    int game = 0;
    int green = 0;
    int blue = 0;
    int red = 0;
    outputStrArray(splitGames);
    for(int j = 0; j < splitGames.Length; ++j)
    {
        if(Regex.IsMatch(splitGames[j], "Game"))
        {
            if(game < int.Parse(Regex.Match(splitGames[j], @"\d+").Value)) 
            {
                game = int. Parse(Regex.Match(splitGames[j], @"\d+").Value);
            }
        }
        if(Regex.IsMatch(splitGames[j], "red"))
        {
            if(red < int.Parse(Regex.Match(splitGames[j], @"\d+").Value)) 
            {
                red = int. Parse(Regex.Match(splitGames[j], @"\d+").Value);
            }        }
        if(Regex.IsMatch(splitGames[j], "blue"))
        {
            if(blue < int.Parse(Regex.Match(splitGames[j], @"\d+").Value)) 
            {
                blue = int. Parse(Regex.Match(splitGames[j], @"\d+").Value);
            }        }
        if(Regex.IsMatch(splitGames[j], "green"))
        {
            if(green < int.Parse(Regex.Match(splitGames[j], @"\d+").Value)) 
            {
                green = int. Parse(Regex.Match(splitGames[j], @"\d+").Value);
            }    
        }
    }

    bags[i].GameID = game;
    bags[i].Green = green;
    bags[i].Blue = blue;
    bags[i].Red = red;

    // if(bags[i].Red <= 12 && bags[i].Green <= 13 && bags[i].Blue <= 14)
    // {
    //     value+=bags[i].GameID;
    // }
    bags[i].Power = red * green * blue;
    value+=bags[i].Power;
    /*

    if found red > known red,    known red = found red, etc for other colours

    bags[i].Red = red; etc for other colours
    */


} 

Console.WriteLine(value);


void outputStrArray(string[] strArrayOfThings)
{
    for(int i = 0; i < strArrayOfThings.Length; ++i)
    {
        Console.WriteLine($"{i+1}. {strArrayOfThings[i]}"); 
    }
} 




struct Bag
{
    public int GameID;
    public int Red;
    public int Blue;
    public int Green;
    public int Power;
}