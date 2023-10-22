using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleReponsibilityPrinciple
{
    class ErrorManager
    {
        //tach rieng log loi ra class moi de co the su dung o nhieu noi
        public void LogError(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}, Stack Trace: {ex.StackTrace}");
        }
    }
}
