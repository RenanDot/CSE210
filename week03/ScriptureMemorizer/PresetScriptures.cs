using System;
using System.Collections.Generic;

public class PresetScriptures
{

    public PresetScriptures()
    {

    }
    private static List<Scripture> _presetScriptures = new List<Scripture>
    {
        new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
        new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength."),
        new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd, I lack nothing."),
        new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
        new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
        new Scripture(new Reference("Alma", 32, 21), "If ye have faith ye hope for things which are not seen, which are true."),
        new Scripture(new Reference("Ether", 12, 27), "If men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me."),
        new Scripture(new Reference("2 Nephi", 2, 25, 26), "Adam fell that men might be; and men are, that they might have joy. And the Messiah cometh in the fulness of time, that he may redeem the children of men from the fall. And because that they are redeemed from the fall they have become free forever, knowing good from evil; to act for themselves and not to be acted upon, save it be by the punishment of the law at the great and last day, according to the commandments which God hath given."),
        new Scripture(new Reference("Mosiah", 4, 9, 10), "Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend. And again, believe that ye must repent of your sins and forsake them, and humble yourselves before God; and ask in sincerity of heart that he would forgive you; and now, if you believe all these things see that ye do them."),
        new Scripture(new Reference("Alma", 37, 36, 37), "Yea, and cry unto God for all thy support; yea, let all thy doings be unto the Lord, and whithersoever thou goest let it be in the Lord; yea, let all thy thoughts be directed unto the Lord; yea, let the affections of thy heart be placed upon the Lord forever. Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day."),
        new Scripture(new Reference("Helaman", 5, 12, 13),"And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall. And it came to pass that these were the words which Helaman taught to his sons; yea, he did teach them many things which are not written, and also many things which are written.")
    };

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_presetScriptures.Count);
        return _presetScriptures[index];
    }
}