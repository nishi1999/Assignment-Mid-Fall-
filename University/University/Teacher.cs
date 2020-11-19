using System;
using System.Collections.Generic;
using System.Text;

namespace University
{
    class Teacher
    {
        public string tName;
        private string tId;
        private double totalHour;
        Section[] sections = new Section[10];

        public Teacher(string tName, string tId, double totalHour)
        {
            this.tName = tName;
            this.tId = tId;
            this.totalHour = totalHour;
        }
        public void insertSection(Section a)
        {
            for (int i = 0; i < 10; i++)
            {
                if (sections[i] == null)
                {
                    if (totalHour < 21)
                    {
                        sections[i] = a;
                        totalHour = totalHour + 3;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Cannot take the section");
                    }
                }
            }
        }
        public void showInfo()
        {
            Console.WriteLine("Teacher name's " + tName);
            Console.WriteLine("Teacher id " + tId);
        }

        public void showSection()
        {
            for (int i = 0; i < 10; i++)
            {
                if (sections[i] != null)
                {
                    sections[i].showInfo();

                }
                else
                {
                    break;
                }
            }
        }
    }
}
