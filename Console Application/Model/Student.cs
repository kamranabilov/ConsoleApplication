using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Student
    {
        public string Fullname;
        public bool SType;
        public bool isOnline;
        public string GroupNo;

        public Student(string fullname, SType sType, string isOnline1)
        {
            Fullname = fullname;
        }
        public override string ToString()
        {
            string status = SType ? "1. Garanati" : "2. No Garantee";
            return $"Fullname: {Fullname}/nSType: {SType}/nGroup No: {GroupNo}/nStatus: {status}";
        }              
    }
}
