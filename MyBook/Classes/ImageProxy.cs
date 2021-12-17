using MyBook.Classes.Printable;
using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Classes
{
    public class ImageProxy: IPrintable, IPicture
    {
        Image Image { get; set; }
        readonly string url;

        public ImageProxy(string url)
        {
            this.url = url;
        }

        public object Clone()
        {
            return new ImageProxy(url) { Image = Image };
        }

        public void Print()
        {
            LoadImage();

            Image.Print();
        }

        private void LoadImage()
        {
            if (Image == null)
            {
                Image = new Image(url);
            }
        }

        public void Remove(IPrintable printable)
        {
            throw new NotImplementedException();
        }
        public IPrintable Get(int index)
        {
            throw new NotImplementedException();
        }
        public IPrintable Add(IPrintable printable)
        {
            throw new NotImplementedException();
        }

        public void Accept(IVisitor visitor)
        {
            LoadImage();
            ((IPrintable)Image).Accept(visitor);
        }

        public void Render()
        {
            LoadImage();
            ((IPrintable)Image).Render();
        }
    }
}
