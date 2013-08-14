using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSynth1
{
	class Program
	{
		static void Main(string[] args)
		{

			SpeechSynthesizer speaker = new SpeechSynthesizer();
			speaker.SetOutputToDefaultAudioDevice();
			string speak = "Welcome";

			while (speak != "quit")
			{
				speaker.Speak(speak);
				speak = Console.ReadLine();
			}

		}
	}
}
