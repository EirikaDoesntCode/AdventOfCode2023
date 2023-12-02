// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//read all lines into str array
// for each item, read from start until number, then read from end until number,
// make a string on number1 number 2
// parse string
// add to overall value

using System.Text.RegularExpressions;
using System.Linq;

// loopWords(Console.ReadLine());
// Console.ReadLine();

string[] contentsOfFile = File.ReadAllLines("DayOneInputs");
outputStrArray(contentsOfFile);
int value = 0;
for(int i = 0; i < contentsOfFile.Length-1; ++i)
{
    string temp = contentsOfFile[i];
    Console.WriteLine(temp);
    temp = loopWords(temp);
    Console.WriteLine(temp);
    string[] test = Regex.Split(temp, @"[a-z]");
    test = test.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    Console.WriteLine(i + ":   ");
    outputStrArray(test);
    int lastIndex = test.Length-1;
    int lastIndexOfLastIndex = test[lastIndex].Length-1;
    string tempValue = $"{test[0][0]}{test[lastIndex][lastIndexOfLastIndex]}";
    Console.WriteLine(tempValue);
    value+=int.Parse(tempValue);
}

Console.WriteLine("Value:"+value);




void outputStrArray(string[] strArrayOfThings)
{
    for(int i = 0; i < strArrayOfThings.Length; ++i)
    {
        Console.WriteLine($"{i+1}. {strArrayOfThings[i]}"); 
    }
} 

string wordsToNumbers(string input)
{
    string output = input;
    output = Regex.Replace(output, $"one", "o1ne");
    output = Regex.Replace(output, $"two", "t2wo");
    output = Regex.Replace(output, $"three", "t3hree");
    output = Regex.Replace(output, $"four", "f4our");
    output = Regex.Replace(output, $"five", "f5ive");
    output = Regex.Replace(output, $"six", "s6ix");
    output = Regex.Replace(output, $"seven", "s7even");
    output = Regex.Replace(output, $"eight", "e8ight");
    output = Regex.Replace(output, $"nine", "n9ine");
    return output;
}


string loopWords (string input)
{
    string test = "";
    for(int i = 0; i < input.Length; ++i)
    {
        test = $"{test}{input[i]}";
        test = wordsToNumbers(test);
        // Console.WriteLine(test);
    }
    return test;
}


