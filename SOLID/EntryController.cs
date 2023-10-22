using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleReponsibilityPrinciple
{
    /// <summary>
    /// ban dau hai phuong thuc add va remove trong BinaryBook,tach nho thanh class rieng
    /// </summary>
    class EntryController
    {
        ErrorManager _errorManager = new ErrorManager();

        public void AddDiary(DiaryEntry diaryEntry,List<DiaryEntry> diaryEntries)
        {
            try
            {
                diaryEntries.Add(diaryEntry);
            }
            catch(Exception ex)
            {
                _errorManager.LogError(ex);
            }
        }

        public void RemoveDiary(DiaryEntry diaryEntry,List<DiaryEntry> diaryEntries) 
        {
            try
            {
                diaryEntries.Remove(diaryEntry);
            }
            catch (Exception ex)
            {
                _errorManager.LogError(ex);
            }
        }
    }
}
