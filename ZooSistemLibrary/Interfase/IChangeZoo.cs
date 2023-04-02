using System.Collections;

namespace ZooSistemLibrary.Interfase
{
    public interface IChangeZoo
    {
        string NameAnimal { get; set; }
        string Age { get; set; }
        string TipeOfAnimal { get; set; }
        IEnumerable animalsAges { set; }
        IEnumerable animalsType { set; }
    }
}
