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
        static Dictionary<string, List<string>> responses = new Dictionary<string, List<string>>
        {
            { "password", new List<string>
                {
                    "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords.",
                    "A good password should be at least 12 characters long and include a mix of letters, numbers, and symbols.",
                    "Consider using a password manager to help you create and store complex passwords."
                }
            },
            { "scam", new List<string>
                {
                    "Be cautious of unsolicited messages asking for personal information. Always verify the source.",
                    "Scammers often create fake websites that look legitimate. Always check the URL before entering any information.",
                    "If something seems too good to be true, it probably is. Trust your instincts."
                }
            },
            { "privacy", new List<string>
                {
                    "Review your privacy settings on social media to control who can see your information.",
                    "Be mindful of the information you share online. Limit personal details to protect your privacy.",
                    "Consider using a VPN to enhance your online privacy."
                }
            },
            { "phishing", new List<string>
                {
                    "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organizations.",
                    "Look for spelling errors or unusual requests in emails. These can be signs of phishing.",
                    "Never click on links in unsolicited emails. Instead, visit the website directly."
                }
            }
        };

        static string userName;
        static string userInterest;
        static string userSentiment;

        static void Main(string[] args)
        {
            // Play Voice Greeting
            PlayVoiceGreeting();

            // Show ASCII Art
            DisplayAsciiArt();

            // Get User's Name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPlease enter your name: ");
            userName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "Friend";
            }

            //Written Greeting
            Console.WriteLine();
            Console.Write("SecureBot: ");
            TypingEffect("Hello " + userName + ", welcome to your Cybersecurity Awareness Assistant!");
            TypingEffect("I'm here to help you stay safe online. Ask me anything!\n");

            // Conversation loop 
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                string input = Console.ReadLine().ToLower();
                Console.ResetColor();

                if (input.Contains("exit") || input.Contains("quit"))
                {
                    TypingEffect("Stay safe out there, " + userName + "! Goodbye!");
                    break;
                }

                HandleUserInput(input);
            }
        }

        static void HandleUserInput(string input)
        {
            //Input validation for general input
            if (input.Contains("how are you"))
            {
                TypingEffect(@"I'm just a bot, but I'm fully charged and ready to help!");
            }
            else if (input.Contains("your purpose"))
            {
                TypingEffect(@"My purpose is to educate you on how to stay safe online!");
            }
            else if (input.Contains("what can i ask"))
            {
                TypingEffect(@"You can ask about password safety, phishing, scams, and privacy.");
            }
            // User sentiment
            else if (input.Contains("worried") || input.Contains("concerned"))
            {
                userSentiment = "worried";
                TypingEffect("It's completely understandable to feel that way. Scammers can be very convincing. Let me share some tips to help you stay safe.");
            }
            else if (input.Contains("curious"))
            {
                userSentiment = "curious";
                TypingEffect("That's great! Curiosity is key to learning. What would you like to know more about?");
            }
            else if (input.Contains("frustrated"))
            {
                userSentiment = "frustrated";
                TypingEffect("I understand that it can be overwhelming. I'm here to help you with any questions you have.");
            }
            else if (responses.Keys.Any(k => input.Contains(k)))
            {
                foreach (var keyword in responses.Keys)
                {
                    // Input validation + randomized responses
                    if (input.Contains(keyword))
                    {
                        Random rand = new Random();
                        int index = rand.Next(responses[keyword].Count);
                        TypingEffect(responses[keyword][index]);
                        return;
                    }
                }
            }
            else
            {
                TypingEffect("I’m not sure I understand. Can you try rephrasing?");
            }
        }



        static void PlayVoiceGreeting()
        {
            string filePath = "C:\\Users\\samke\\source\\repos\\CyberBot2\\CyberBot2\\bin\\Debug\\Project name (en) v2.wav"; // Path to your WAV file
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
