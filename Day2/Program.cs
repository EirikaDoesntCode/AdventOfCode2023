// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] Inputs = File.ReadAllLines("Day2Inputs");

// outputStrArray(Inputs);

int InLen = Inputs.Length;
int value = 0;
Bag[] bags = new Bag[InLen];
for(int i = 0; i < InLen; ++i)
{
    string[] splitGames = Inputs[i].Split(':', ';');
    outputStrArray(splitGames);
    


} 




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
}