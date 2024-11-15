public class PromptGenerator
{
    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "If I had one thing I could do over today, what would it be?",
            "What was the best part of my day?",
            "Who was the most interesting person I interacted with today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?"
        };

        Random rnd = new Random();
        int index = rnd.Next(prompts.Count);
        string _prompt = prompts[index];

        return _prompt;
    }
}