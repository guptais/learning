using System;
using System.Collections.Generic;

namespace ConceptPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Method1();

            B b = new B();
            b.Method1();
            b.Method1(10);
            Console.ReadKey();

            //Document[] documents = new Document[2];

            //documents[0] = new Resume();
            //documents[1] = new Report();

            //foreach (Document document in documents)
            //{
            //    foreach (var page in document.Pages)
            //    {
            //       Console.WriteLine("The program");
            //    }
            //}
        }
    }

    public class A
    {
        public void Method1()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public void Method1(int number)
        {
            Console.WriteLine("B {0}", number);
        }
    }

    public abstract class Page
    {
        
    }

    public class Skills : Page { }

    public class Education: Page { }

    public abstract class Document
    {
        List<Page> _pages = new List<Page>();

        public IList<Page> Pages { get; set; }

        public Document()
        {
            this.CreatePages();
        }

        public abstract void CreatePages();
    }

    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new Skills());
            Pages.Add(new Education());
        }
    }

    public class Report : Document
    {
        public override void CreatePages()
        {
            //Pages.Add(new );
        }
    }

}

