using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> commentList1 =
        [
            new Comment("Spencer","Thanks for the help."),
            new Comment("Tyler","very informative"),
            new Comment("Bob","Nice video!"),
        ];
        Video video1 = new Video("How to convert a string into an int in C#", "Trevor", 257, commentList1);

        List<Comment> commentList2 = 
        [
            new Comment("Ronald","Ill have to take the grandkids to one of these places."),
            new Comment("Bill","Just got back from the third one the kids loved it!"),
            new Comment("Skylar","Time to make plans!"),
            new Comment("lily","looks fun"),    
        ];
        Video video2 = new Video("Top 10 Family Vacation Spots", "Bobby", 2354, commentList2);

        List<Comment> commentList3 =
        [
            new Comment("Kimberly","looks like a good time."),
            new Comment("Dustin","My family also loves that ride"),
            new Comment("Bella","That food looks tasty."),
        ];
        Video video3 = new Video("Disneyland Vlog, Day 3", "VacationFamily", 8546, commentList3);

        void displayVideo(Video video)
        {
            List<string> list = video.GetDisplayText();
            Console.WriteLine($"Title: {list[0]}");
            Console.WriteLine($"Author: {list[1]}");
            Console.WriteLine($"Length: {list[2]}");
            Console.WriteLine($"Number of Comments: {list[3]}");
            Console.WriteLine("");
            Console.WriteLine("Comments: ");

            int index = 4;
            int num = int.Parse(list[3]);
            for(int i = 0 ; i < num; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"{list[index]}:");
                index += 1;
                Console.WriteLine(list[index]);
                index += 1;
            }
            Console.WriteLine("");
        }
        
        displayVideo(video1);
        displayVideo(video2);
        displayVideo(video3);
    }
}