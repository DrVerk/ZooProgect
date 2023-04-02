using System.Collections;

namespace ZooSistemLibrary
{
    public interface IAnimalsadd
    {
        string name { get; }
        string Age { get; }
        IEnumerable animalsAges { set; } 
        string TipeOfAnimal { get; }  
        IEnumerable typeofenemyadd { set; }
        
    }
}
