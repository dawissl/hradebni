using System;
using System.Collections.Generic;
using System.Threading;

class MorseCodePlayer
{  


    public static void PlayMorseCode(string morseCode)
    {
        foreach (char symbol in morseCode)
        {
            if (symbol == '.')
            {
                PlayDot();
            }
            else if (symbol == '-')
            {
                PlayDash();
            }
            else if (symbol == ' ')
            {
                // Krátká pauza mezi písmeny
                Thread.Sleep(100);
            }
        }
    }

    private static void PlayDot()
    {
        // Přehrávání krátkého tónu pro tečku
        // Připoj reproduktor nebo vytvoř jiný zvukový výstup podle potřeby
        Console.Beep(1000, 200);
    }

    private static void PlayDash()
    {
        // Přehrávání dlouhého tónu pro čárku
        Console.Beep(1000, 400);
    }

    static void Main()
    {
        Console.WriteLine("Zadej text pro převod do morseovky:");
        string inputText = Console.ReadLine();

        string morseCode = TextToMorseCode(inputText);
        Console.WriteLine($"Morseova abeceda: {morseCode}");

        PlayMorseCode(morseCode);
    }


    private static Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>()
    {
        {'A', ".-"}, {'B', "-..."}, {'C', "-.-."},
        {'D', "-.."}, {'E', "."}, {'F', "..-."},
        {'G', "--."}, {'H', "...."}, {'I', ".."},
        {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
        {'M', "--"}, {'N', "-."}, {'O', "---"},
        {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."},
        {'S', "..."}, {'T', "-"}, {'U', "..-"},
        {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
        {'Y', "-.--"}, {'Z', "--.."},
        {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
        {'4', "....-"}, {'5', "....."}, {'6', "-...."},
        {'7', "--..."}, {'8', "---.."}, {'9', "----."},
        {'0', "-----"}, {' ', "/"} // Pro oddělení slov v morseovce
    };

    public static string TextToMorseCode(string text)
    {
        text = text.ToUpper();
        string morseCode = "";

        foreach (char character in text)
        {
            if (morseCodeDictionary.ContainsKey(character))
            {
                morseCode += morseCodeDictionary[character] + " ";
            }
            else
            {
                morseCode += " ";
            }
        }

        return morseCode.Trim();
    }
}
