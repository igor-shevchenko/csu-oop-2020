using System.IO;

namespace BinaryTreeSet
{
    public interface IStorage
    {
        Stream GetReadStream(string name);
        Stream GetWriteStream(string name);
    }
}