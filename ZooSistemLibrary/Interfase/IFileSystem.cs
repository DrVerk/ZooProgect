using System.Collections;

namespace ZooSistemLibrary
{
    public interface IFileSystem
    {
        string FileName { get; set; }
        string FileType { get; }
        string FileAction { get; }
        IEnumerable FileTypeObject { set; }
        IEnumerable FileActionObject { set; }
    }
}