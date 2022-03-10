using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Text;
using Console_Application.Enum;


namespace Console_Application
{
    class Group
    {
        public static int count = 1;
        public string No;
        public Enum.Categories Category;
        public bool IsOnline;
        public int Limit = 0;
        public List<Student> Students;        
        public Group(Enum.Categories category, bool isonline)
        {
            IsOnline = isonline;
            count++;
            Students = new List<Student>();  
            
            switch (category)
            {
                case Enum.Categories.Programming:
                    No = $"P-{count}";
                    break;
                case Enum.Categories.Design:
                    No = $"D-{count}";
                    break;
                case Enum.Categories.System_administration:
                    No = $"S-{count}";
                    break;
                default:
                    break;
            }
            Category = category;
            count++;                                    
        }
        public override string ToString()
        {
            string status = IsOnline ? "3.isonline" : "4. Offline";
            return $"Group No: {No}/nCategories: {Category}";
        }                             
    }
}
