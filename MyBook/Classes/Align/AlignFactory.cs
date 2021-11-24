using MyBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Classes.Align
{
    public enum AlignTypes
    {
        AlignCenter,
        AlignLeft,
        AlignRight
    };

    class AlignFactory
    {
        public static IAlignStrategy GetAlignStrategy(AlignTypes classes)
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.IsClass && t.Namespace == "MyBook.Classes.Align"
                        select t;
            var type = types.ToList().Find(t => t.Name == Enum.GetName(typeof(AlignTypes), classes));
            return (IAlignStrategy)Activator.CreateInstance(type);
        }
    }
}
