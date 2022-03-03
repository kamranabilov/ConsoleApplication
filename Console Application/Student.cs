using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Student
    {
        public string GroupNo;
        public string Fullname;        
        public string Garantee;

        public Student(string groupno, string fullname,string garantee)
        {
            GroupNo = groupno;
            Fullname = fullname;            
            Garantee = garantee;
        }
    }
}
