public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What is something that made you smile or feel grateful today?",
        "What challenge did you face today, and how did you respond to it?",
        "What is something you've been avoiding, and what is holding you back?"
    };

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}