using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberBot2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Play Voice Greeting
            PlayVoiceGreeting();

            //Show ASCII Art
            DisplayAsciiArt();

            //Get User's Name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPlease enter your name: ");
            string userName = Console.ReadLine();
            Console.ResetColor();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "Friend";
            }

            //Written Greeting
            Console.WriteLine();
            Console.Write("SecureBot: ");
            TypingEffect("Hello " + userName + ", welcome to your Cybersecurity Awareness Assistant!");
            TypingEffect("I'm here to help you stay safe online. Ask me anything!\n");

            //Conversation Loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                string input = Console.ReadLine().ToLower();
                Console.ResetColor();

                if (input.Contains("how are you"))
                    TypingEffect("I'm just a bot, but I'm fully charged and ready to help!");
                else if (input.Contains("your purpose"))
                    TypingEffect("My purpose is to educate you on how to stay safe online!");
                else if (input.Contains("what can i ask"))
                    TypingEffect("You can ask about password safety, phishing, and safe browsing.");
                else if (input.Contains("password"))
                    TypingEffect(@"Safe Password Practices: Use at least 12 characters combining letters, numbers and symbols. 
                    - Avoid using personal information like birthdays or names.
                    - Use a password manager to keep track of your passwords safely.
                ");
                else if (input.Contains("phishing"))
                    TypingEffect(@" Phishing Scams:  Phishing is a method cybercriminal use Sto trick you into giving up personal information.
                    - Be cautious of emails that ask for sensitive information.
                    - Check emil addresses carefully - small changes can be suspecious.
                    - Don't click on suspecious links or download unknown attachments.
                ");
                else if (input.Contains("safe browsing"))
                    TypingEffect("Tip: Use HTTPS websites and avoid clicking on suspicious ads or popups.");
                else if (input.Contains("thank you"))
                {
                    TypingEffect("You're welcome! Stay safe out there, " + userName + "! Goodbye!");
                    break;
                }
                else if (input.Contains("exit") || input.Contains("quit"))
                {
                    TypingEffect("Stay safe out there, " + userName + "! Goodbye!");
                    break;
                }
                else
                    TypingEffect("I didn’t quite understand that. Could you rephrase?");
            }
        }

        static void PlayVoiceGreeting()
        {
            string filePath = "C:\\Users\\samke\\source\\repos\\CyberBot\\CyberBot\\bin\\Debug\\Project name (en) v2.wav"; // Path to your WAV file
            using (SoundPlayer player = new SoundPlayer(filePath))
            {
                try
                {
                    player.Load();
                    player.PlaySync();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("⚠️ Unable to play the voice greeting. Check the WAV file path.");
                    Console.ResetColor();
                }
            }
        }

        static void TypingEffect(string text, int delay = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
 _____ _____ _____ _   _______ ___________  _____ _____ 
/  ___|  ___/  __ \ | | | ___ \  ___| ___ \|  _  |_   _|
\ `--.| |__ | /  \/ | | | |_/ / |__ | |_/ /| | | | | |  
 `--. \  __|| |   | | | |    /|  __|| ___ \| | | | | |  
/\__/ / |___| \__/\ |_| | |\ \| |___| |_/ /\ \_/ / | |  
\____/\____/ \____/\___/\_| \_\____/\____/  \___/  \_/  
                                                        
        YOUR CYBERSECURITY AWARENESS ASSISTANT
        Stay safe. Stay smart.
        ");
            Console.ResetColor();
        }
    }
}
