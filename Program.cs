using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Demonstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            var scale = new Dictionary<string, int>();
            scale.Add("A", 440);
            scale.Add("B_", 466);
            scale.Add("B", 494);
            scale.Add("C", 523);
            scale.Add("C#", 554);
            scale.Add("D", 587);
            scale.Add("D#", 622);
            scale.Add("E", 659);
            scale.Add("F", 698);
            scale.Add("F#", 740);
            scale.Add("G", 784);
            scale.Add("A_", 831);
            scale.Add("A#", 880);
            scale.Add("Z", 0); // gap

            var song = new string[]
                {
                    "A", "B", "C", "D", "E", "F"
                };

            const int noteDurationMilliseconds = 250;

            foreach (var s in song)
            {
                if (scale[s] != 0)
                {
                    PlayTone(scale[s], noteDurationMilliseconds);
                }
                else
                {
                    // Skip over this note
                    Thread.Sleep(noteDurationMilliseconds);
                }
            }
        }

        private static void PlayTone(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
        }
    }
}
