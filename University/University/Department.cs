﻿using System;
using System.Collections.Generic;
using System.Text;

namespace University
{
    class Department
    {
        private string departmentName;
        Course[] cources = new Course[10];

        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public void showInfo()
        {
            Console.WriteLine(departmentName);
        }
        public void insertCourse(Course a)
        {
            for (int i = 0; i < 10; i++)
            {
                if (cources[i] == null)
                {
                    cources[i] = a;
                    break;
                }
            }
        }
    }
}
