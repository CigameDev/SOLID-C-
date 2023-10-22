using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleReponsibilityPrinciple
{
    class DiaryBook
    {
        private List<DiaryEntry> diaryEntries = new List<DiaryEntry>();
        public List<DiaryEntry> GetDiaryBook()
        {
            return diaryEntries;
        }
        //cuon sach gio chi co 1 nhiem vu duy nhat la lay cuon sach ra thoi
    }
}
