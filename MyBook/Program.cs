﻿using MyBook.Classes;
using MyBook.Classes.Printable;
using MyBook.Interfaces;

namespace MyBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book noapteBuna = new Book("Noapte buna, copii!");
            Author rpGheo = new Author("Radu Pavel Gheo");
            noapteBuna.AddAuthor(rpGheo);
            Section cap1 = new Section("Capitolul 1");
            Section cap11 = new Section("Capitolul 1.1");
            Section cap111 = new Section("Capitolul 1.1.1");
            Section cap1111 = new Section("Subchapter 1.1.1.1");
            noapteBuna.Add(new Paragraph("Multumesc celor care ..."));
            cap1 = (Section)noapteBuna.Add(cap1); // cap1 = Clone
            cap1.Add(new Paragraph("Moto capitol"));
            cap11 = (Section)cap1.Add(cap11); // cap11 = Clone
            cap11.Add(new Paragraph("Text from subchapter 1.1"));
            cap111 = (Section)cap11.Add(cap111); // cap111 = Clone
            cap111.Add(new Paragraph("Text from subchapter 1.1.1"));
            cap1111 = (Section)cap111.Add(cap1111); // cap1111 = Clone
            cap1111.Add(new Image("Image subchapter 1.1.1.1"));
            noapteBuna.Print();
        }
    }
}
