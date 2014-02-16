using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;

namespace TimetableComparator
{
    class TimetableComparator
    {
        private readonly string[] days = new string[]  {"пн","вт","ср","чт","пт","сб"};
        private string fileName1, fileName2;
        public TimetableComparator(string file1,string file2)
        {
            fileName1 = file1;
            fileName2 = file2;
        }

        public void Compare(string weekNumber,string subgroup1,string subgroup2)
        {
            Microsoft.Office.Interop.Excel.Application excObj1 = null;
            Microsoft.Office.Interop.Excel.Workbook workBookObj1 = null;
            Microsoft.Office.Interop.Excel.Worksheet workSheetObj1;
            Microsoft.Office.Interop.Excel.Application excObj2 = null;
            Microsoft.Office.Interop.Excel.Workbook workBookObj2 = null;
            Microsoft.Office.Interop.Excel.Worksheet workSheetObj2;
            try
            {
                excObj1 = new Microsoft.Office.Interop.Excel.Application();
                workBookObj1 = excObj1.Workbooks.Open(fileName1);
                workSheetObj1 = excObj1.ActiveSheet;
                excObj2 = new Microsoft.Office.Interop.Excel.Application();
                workBookObj2 = excObj2.Workbooks.Open(fileName2);
                workSheetObj2 = excObj2.ActiveSheet;
                int row1 = 4,row2 = 4;
                string begin1,begin2,end1,end2;
                foreach (string day in days)
                {
                    begin1 = GetTime(workSheetObj1, ref row1, day, weekNumber, subgroup1, true);
                    end1 = GetTime(workSheetObj1, ref row1, day, weekNumber, subgroup1, false);
                    begin2 = GetTime(workSheetObj2, ref row2, day, weekNumber, subgroup2, true);
                    end2 = GetTime(workSheetObj2, ref row2, day, weekNumber, subgroup1, false);
                }
            }
            finally
            {
                workBookObj1.Close();
                excObj1.Quit();
                workBookObj2.Close();
                excObj2.Quit();
            }
        }

        private string GetTime(Microsoft.Office.Interop.Excel.Worksheet workSheetObj, ref int currRow,string currDay, string week, string subgroup,bool isBegin)
        {
            Microsoft.Office.Interop.Excel.Range range = null;
            string result = "";
            while (Array.IndexOf(days, workSheetObj.get_Range("a" + currRow).Value.ToString()) < Array.IndexOf(days, currDay))
                ++currRow;
            if (isBegin)
            {
                range = workSheetObj.get_Range("a" + currRow);
                while (range.Value != null && range.Value.ToString() == currDay)
                {                    
                    if((workSheetObj.get_Range("b" + currRow).Value.ToString().Contains(week) || workSheetObj.get_Range("b" + currRow).Value.ToString() == "") && (workSheetObj.get_Range("d" + currRow).Value.ToString() == subgroup || workSheetObj.get_Range("d" + currRow).Value.ToString() == ""))
                    {
                        result = workSheetObj.get_Range("c" + currRow).Value.ToString().Split('-')[0];
                        break;
                    }
                    ++currRow;
                    range = workSheetObj.get_Range("a" + currRow);
                }
            }
            else
            {
                string prevValue = "";
                range = workSheetObj.get_Range("a" + currRow);
                while (range.Value != null && range.Value.ToString() == currDay)
                {
                    if ((workSheetObj.get_Range("b" + currRow).Value.ToString().Contains(week) || workSheetObj.get_Range("b" + currRow).Value.ToString() == "") && (workSheetObj.get_Range("d" + currRow).Value.ToString() == subgroup || workSheetObj.get_Range("d" + currRow).Value.ToString() == ""))
                        prevValue = workSheetObj.get_Range("c" + currRow).Value.ToString();//.Split('-')[1];
                    ++currRow;
                    range = workSheetObj.get_Range("a" + currRow);
                }
                result = prevValue;
            }
            return result;
        }
    }
}
