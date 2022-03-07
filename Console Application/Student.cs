using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Application
{
    class Student
    {        
        public string Fullname { get; set; }
        public SType SType { get; set; }
        public bool IsOnline { get; set; }
        public string Groupno { get; }

        public Student(string groupno, string fullname, SType sType, bool isOnline)
        {
            Groupno = groupno;
            Fullname = fullname;
            SType = sType;
            IsOnline = isOnline;
        }       

        public override string ToString()
        {
            string isGarantee = (int)SType == 1 ? "Garanati" : "NoGarantee";
            string isOnline = IsOnline ? "Online" : "Ofline";

            return ($"Fullname: {Fullname}/nGaranteetip: {isGarantee}/nSType: {SType}/nisOnline: {isOnline}");            
        }
    }
}
