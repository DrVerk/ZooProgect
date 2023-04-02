using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ZooSistemLibrary
{
   public interface IView
    {
        IEnumerable<IAnimals> Views { get; set; }
        IAnimals animal { get;}
    }

}
