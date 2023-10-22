using System;

namespace SingleReponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            DiaryBook diaryBook = new DiaryBook();

            var allEntries = diaryBook.GetDiaryBook();

            EntryController entryController = new EntryController();

            entryController.AddDiary(new DiaryEntry
            {
                Id = Guid.NewGuid(),
                CreateDate = DateTime.Now,
                Title = "Today is the shit day",
                Content = "I made a lot of bugs in project so sad."
            },allEntries) ;

            entryController.AddDiary(new DiaryEntry
            {
                Id = Guid.NewGuid(),
                CreateDate = DateTime.Now,
                Title = "I crushed a lady",
                Content = "I crushed a lady and she is a tester who found bugs for me every day",
            },allEntries);

            

            foreach (var s in allEntries)
            {
                Console.WriteLine($"Date: {s.CreateDate:dd/MM/yyyy}");
                Console.WriteLine($"Title: {s.Title}");
                Console.WriteLine($"Content: {s.Content}");

                if (allEntries.IndexOf(s) != allEntries.Count - 1)
                {
                    Console.WriteLine(Environment.NewLine);
                }
            }

            ExportDiary export = new ExportDiary();
            var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            export.SaveToText("myDiary_" + Timestamp + ".txt", allEntries);//luu ra file
        }
    }
}