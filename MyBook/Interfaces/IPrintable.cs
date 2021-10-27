namespace MyBook.Interfaces
{
    public interface IPrintable
    {
        void Print();

        void Add(IPrintable printable);
        void Remove(IPrintable printable);
        IPrintable Get(int index);
    }
}
