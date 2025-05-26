# CyberBot 2.0

# Overview
The Cybersecurity Awareness Assistant is a user-friendly C# console chatbot created to help users stay safe online. It provides helpful tips on password management, identifying phishing scams, and safe browsing practices.

# Features
Voice greeting on startup (WAV file required)
ASCII art logo for visual introduction
Personalized greeting and user interaction
Typing effect for dynamic responses
Looping conversation system
Random selection predefined responses for better engagement
Remembers information shared by the user to refer back to later
Sentiment Detection for keywords such as “worried” and “curious”.
Error handling for unknown inputs and preventing crashes
Exit chatbot using phrases like `exit`, `quit`, or `thank you`

# Prerequisites
Windows PC (for ‘.wav’ file support via ‘System.Media.SoundPlayer’)
A C# IDE such as Visual Studio or Visual Studio Code
.NET SDK 5.0 or later

# Running the Application
Clone the repository
Open the Project. Launch the solution using your preferred development environment (e.g., Visual Studio).
Build the Application. In Visual Studio, go to Build > Build Solution to compile the code and restore any dependencies.
Run the Chatbot. Start the application by pressing F5 or run it through the terminal with: “dotnet run”

# Using the Chatbot
When prompted, enter your name to personalize greeting and the interaction.
You can then ask the chatbot questions like:
•	“How are you?”
•	“What’s your purpose?”
•	“What can I ask?”
Other than the questions above, it is important that the questions contain the keywords “password/s’, “phishing”, “safe browsing” and “link/s”.
You can also mention their interests to help the personalize responses and the overall experience.
Type “exit/quit/thank you” then press the Enter key after the goodbye message to exit the chatbot.


