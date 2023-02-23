
using System.Collections;

namespace ZooSistemLibrary.Interfase
{
    public interface IAnimalsadd
    {
        string name { get; }
        string Age { get; }
        string TipeOfAnimal { get; }
        IEnumerable typeofenemyadd { set; }
        IEnumerable animalsAges { set; }    
    }
}
