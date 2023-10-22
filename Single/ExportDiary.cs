using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleReponsibilityPrinciple
{
    /// <summary>
    /// sao chep ra 1 cuon sach khac
    /// Ban dau chung ta co ham SaveToText trong class DiaryBook
    /// Tach ra class rieng
    /// </summary>
    class ExportDiary
    {
        ErrorManager _errorManager = new ErrorManager();
        public void SaveToText(string fileName ,List<DiaryEntry> diaryEntries)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(fileName))
                {
                    foreach (var s in diaryEntries)
                    {
                        tw.WriteLine($"Date: {s.CreateDate:dd/MM/yyyy}");
                        tw.WriteLine($"Title: {s.Title}");
                        tw.WriteLine($"Content: {s.Content}");

                        if (diaryEntries.IndexOf(s) != diaryEntries.Count - 1)
                        {
                            tw.WriteLine(Environment.NewLine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _errorManager.LogError(ex);
            }
        }

        public void PushToCloud()
        {
            //Do something
        }
    }
}
