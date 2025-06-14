using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Annalyzing YouTube Videos\n");

        Video video1 = new Video("Light Ring LR100 - Review", "John Doe", 515,
            new List<Comment>
            {
                new Comment("Alice", "Great video!"),
                new Comment("Bob", "Very informative, thank for your video."),
                new Comment("Charlie", "I didn't like it. I have brought the product and it was not what I expected."),
                new Comment("Robbie 101", "I love this product!"),
            });

        Video video2 = new Video("Phone Holder PH250 - Unboxing", "Jane Smith", 624,
            new List<Comment>
            {
                new Comment("Dave", "Awesome unboxing!"),
                new Comment("Eve", "Can't wait to get mine!"),
                new Comment("Frank", "This is the best holder I've ever used!"),
                new Comment("Grace", "I had a bad experience with this product."),
            });

        Video video3 = new Video("Wireless Earbuds WE300 - Review", "Alice Johnson", 780,
            new List<Comment>
            {
                new Comment("Hank", "These earbuds are amazing!"),
                new Comment("Ivy", "I had some issues with the battery life."),
                new Comment("Jack", "Great sound quality!"),
                new Comment("Kathy", "Not worth the price."),
            });

        Video video4 = new Video("Smartwatch SW400 - Review", "Bob Brown", 724,
            new List<Comment>
            {
                new Comment("Liam", "This smartwatch is fantastic!"),
                new Comment("Mia", "I love the features!"),
                new Comment("Noah", "Battery life could be better."),
                new Comment("Olivia", "Great value for money!"),
            });

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        int count = 1;

        foreach (var video in videos)
        {
            Console.WriteLine($"Video {count++}:");
            Console.WriteLine("-------------------------");
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}