using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Group
    {
        public string No;
        public static int count;
        public bool isOnline;
        public int Limit;
        public int stuCount;
        public Categories Category;


        public Group(string groupno, string fullname, Categories category)
        {
           object Count = null;
            switch (Category)
            {
                case Categories.Programming:
                    No = $"P-{Count}";
                    break;
                case Categories.Design:
                    No = $"D-{count}";
                    break;
                case Categories.System_administration:
                    No = $"S-{count}";
                    break;

                default:
                    break;
            }
            Category = category;
            //Count++;

            
        }
       

    }
}
