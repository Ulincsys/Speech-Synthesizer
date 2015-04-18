using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading;

// Before running this code, you must first add the "System.speech" reference.

namespace speaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Speech Synthesizer");
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Welcome to the speech synthesizer");
            while(true)
            {
            Console.Clear();
            Console.WriteLine("Please enter the text you would like synthesized. Type [exit] at any time.");

            string input = Console.ReadLine();
            synth.Speak(input);
                if(input.ToLower() == ("exit"))
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    synth.Speak("Goodbye!");
                    break;
                }
            }
        }
    }
}
