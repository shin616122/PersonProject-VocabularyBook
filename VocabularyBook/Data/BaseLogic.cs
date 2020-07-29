using System;
using System.IO;
using System.Windows.Forms;

namespace VocabularyBook
{
    public abstract class BaseLogic
    {
        //public const string EXCEL_FILEPATH = @"D:\Personal\VocabularyBook\List.xlsx";
        public static string EXCEL_FILEPATH = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\List.xlsx";
    }
}
