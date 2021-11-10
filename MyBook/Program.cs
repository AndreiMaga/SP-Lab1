using MyBook.Classes;
using MyBook.Classes.Printable;
using MyBook.Interfaces;
using System;

namespace MyBook
{
    class Program
    {

        static void Main(string[] args)
        {
            long startTime = DateTime.Now.Millisecond;
            ImageProxy img1 = new ImageProxy("Pamela Anderson");
            ImageProxy img2 = new ImageProxy("Kim Kardashian");
            ImageProxy img3 = new ImageProxy("Kirby Griffin");
            Section playboyS1 = new Section("Front Cover");
            playboyS1.Add(img1);
            Section playboyS2 = new Section("Summer Girls");
            playboyS2.Add(img2);
            playboyS2.Add(img3);
            Book playboy = new Book("Playboy");
            playboy.Add(playboyS1);
            playboy.Add(playboyS2);
            long endTime = DateTime.Now.Millisecond;
            Console.WriteLine("Creation of the content took " + (endTime -
            startTime) + " milliseconds");
            startTime = DateTime.Now.Millisecond;
            playboyS1.Print();
            endTime = DateTime.Now.Millisecond;
            Console.WriteLine("Printing of the section 1 took " + (endTime -
            startTime) + " milliseconds");
            startTime = DateTime.Now.Millisecond;
            playboyS1.Print();
            endTime = DateTime.Now.Millisecond;
            Console.WriteLine("Printing again the section 1 took " + (endTime -
            startTime) + " milliseconds");
        }
    }
}
