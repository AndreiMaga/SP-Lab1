﻿using System;

namespace MyBook.Interfaces
{
    public interface IPrintable : ICloneable
    {
        void Accept(IVisitor visitor);

        void Print();

        void Render();

        /// <summary>
        /// Clones the printable, adds it to the list and returns the clone
        /// </summary>
        /// <param name="printable"></param>
        /// <returns></returns>
        IPrintable Add(IPrintable printable);
        void Remove(IPrintable printable);
        IPrintable Get(int index);
    }
}
