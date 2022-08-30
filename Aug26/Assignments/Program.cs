using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    //public struct Student
    //{
    //    public int Id;
    //    public string Name;
    //    public int Fees;

    //    public void SetStudent(int id, string name, int fees)
    //    {
    //        Id = id;
    //        Name = name;
    //        Fees = fees;
    //    }

    //    public void PrintStudent()
    //    {
    //        Console.WriteLine("Student details:");
    //        Console.WriteLine("\tID     : " + Id);
    //        Console.WriteLine("\tName   : " + Name);
    //        Console.WriteLine("\tFees   : " + Fees);
    //        Console.WriteLine("\n");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student[] S = { new Student(), new Student() };

    //        S[0].SetStudent(101, "Rohit", 5000);
    //        S[1].SetStudent(102, "Virat", 8000);

    //        S[0].PrintStudent();
    //        S[1].PrintStudent();
    //    }
    //}

    //q2
    //class _8__CreatingObjectAsArray
    //{
    //    static int i;
    //    static void Main(string[] args)
    //    {
    //        students[] s = new students[5];
    //        s[0] = new students();
    //        s[1] = new students();
    //        s[2] = new students();
    //        s[3] = new students();
    //        s[4] = new students();

    //        Console.WriteLine(s.Length);
    //        for (i = 0; i < s.Length; i++)
    //            s[i].getvals();

    //        for (i = 0; i < s.Length; i++)
    //            s[i].display();

    //        Console.ReadLine();
    //    }
    //}
    //class students
    //{
    //    private int rno, marks;
    //    private string sname;
    //    public void getvals()
    //    {
    //        Console.WriteLine("enter roll no of student...");
    //        rno = int.Parse(Console.ReadLine());
    //        Console.WriteLine("enter name of student...");
    //        sname = Console.ReadLine();
    //        Console.WriteLine("enter marks of student...");
    //        marks = int.Parse(Console.ReadLine());
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine("roll no = " + rno + "stu name = " + sname + "marks = " + marks);
    //    }
    //}
    //q3
    //class ListOfObjectsDemo
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Object> objlist = new List<Object>();
    //        emplist.Add(new Objrct { ObjID = 1, ObjName = "Pen" });


    //        try
    //        {


    //            Object obj1 = new Object();
    //            obj1.ObjID = 2;
    //            obj1.ObjName = "Pencil";
    //          
    //        
    //            objlist.Add(obj1);
    //        }
    //        catch (Exception ex)
    //        {

    //            Console.WriteLine(ex.Message);
    //        }
    //        foreach (var item in objlist)
    //        {
    //            Console.WriteLine(item.ObjID);
    //            Console.WriteLine(item.ObjName);
    //           
    //        }


    //        Console.ReadLine();
    //    }
    //}

    //q4
    class Demo
    {
        static void Main()
        {
            string[] students = { "Adel", "David", "Tom" };
            LinkedList<string> list = new LinkedList<string>(students);
            foreach (var stu in list)
            {
                Console.WriteLine(stu);
            }
     
            var newNode = list.AddLast("Brad");
        
            list.AddFirst("Akhil");
            list.AddBefore(newNode, "Abi");
            list.AddAfter(newNode, "Nithin");
            LinkedListNode<String> temp = list.Find("Tom");


            Console.WriteLine("LinkedList after operations...");
            foreach (var stu in list)
            {
                Console.WriteLine(stu);
            }
        }
        

    }
}