using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Department cse = new Department("CSE");
            Course ba = new Course("Bangla", "1");
            Course m = new Course(" Math", "2");
            Course e = new Course("English", "3");
            cse.insertCourse(ba);
            cse.insertCourse(m);
            cse.insertCourse(e);
            Section a = new Section("A", "9.30");
            Section b = new Section("B", "11.30");
            ba.insertSection(a);
            ba.insertSection(b);
            Teacher T = new Teacher("ooo", "1234", 10);
            T.insertSection(a);
            a.teachername = T;
            T.insertSection(b);
            b.teachername = T;
            ba.showSection();
            T.showSection();

        }
    }
}
