using System;
using System.Collections.Generic;
using System.Text;

namespace University
{
    class Section
    {
        private string sectionName;
        private string sectionTime;
        public Teacher teachername;

        public Section(string sectionName, string sectionTime)
        {
            this.sectionName = sectionName;
            this.sectionTime = sectionTime;
        }

        public void showInfo()
        {
            Console.WriteLine("Section name's: " + sectionName);
            Console.WriteLine("Section time at " + sectionTime);
            teachername.showInfo();
        }

    }
}

