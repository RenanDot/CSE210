using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> happyPrompts = new List<string>
    {
        "What is something that made you feel truly alive today?",
        "Who are with you when something good happened with you today? And what was it?",
        "What is something simple that brought you joy today?",
        "Describe a happy memory from today that still makes you smile.",
        "What part of your day would you relive if you could?"
    };

    public List<string> sadPrompts = new List<string>
    {
        "What do you wish someone would say to you right now?",
        "When do you feel most alone—and what helps?",
        "What is been hurting lately that you have not talked about?",
        "What are you grieving, even if it feels small?",
        "How can you be gentle with yourself today?"
    };

    public List<string> angryPrompts = new List<string>
    {
        "What made you feel disrespected or unheard?",
        "What is one thing you wish others understood about how you are feeling?",
        "Is there a boundary you need to set—or reset?",
        "How do you usually respond to frustration? Is that serving you?",
        "What would it look like to let go of what is making you angry?"
    };

    public List<string> anxiousPrompts = new List<string>
    {
        "What is something small you can do today to reduce stress?",
        "What thoughts have been running on repeat in your head?",
        "What would calm look like if you could create it?",
        "What is a reminder or affirmation you need right now?",
        "When was the last time you felt truly at peace? What helped?"
    };

    public List<string> hopefulPrompts = new List<string>
    {
        "What are you working toward that excites you?",
        "What is a challenge you have overcome recently?",
        "If everything goes right, where could you be in a year?",
        "What dream feels possible today that did not yesterday?",
        "Who is someone you admire—and what qualities do you share?"
    };

    public string GetRandomPrompt(string moodChoice)
    {
        List<string> prompts = new List<string>();

        switch (moodChoice)
        {
            case "1": // Happy
                prompts = happyPrompts;
                break;
            case "2": // Sad
                prompts = sadPrompts;
                break;
            case "3": // Angry
                prompts = angryPrompts;
                break;
            case "4": // Anxious
                prompts = anxiousPrompts;
                break;
            case "5": // Hopeful
                prompts = hopefulPrompts;
                break;
            default:
                Console.WriteLine("Invalid mood choice. Defaulting to happy prompts.");
                prompts = happyPrompts;
                break;
        }

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    
}