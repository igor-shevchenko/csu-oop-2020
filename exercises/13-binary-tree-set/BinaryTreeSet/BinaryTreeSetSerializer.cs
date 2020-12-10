using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace BinaryTreeSet
{
    public class BinaryTreeSetSerializer
    {
        private IStorage storage;

        public BinaryTreeSetSerializer(IStorage storage)
        {
            this.storage = storage;
        }

        public void Save<T>(string name, BinaryTreeSet<T> set, bool closeStream=true) where T : IComparable
        {
            var ser = new DataContractJsonSerializer(typeof(BinaryTreeSet<T>));
            Stream stream = storage.GetWriteStream(name);
            ser.WriteObject(stream, set);

            if (closeStream)
                stream.Close();
        }

        public BinaryTreeSet<T> Load<T>(string name, bool closeStream=true) where T : IComparable
        {
            var ser = new DataContractJsonSerializer(typeof(BinaryTreeSet<T>));
            Stream stream = storage.GetReadStream(name);
            var result = (BinaryTreeSet<T>)ser.ReadObject(stream);

            if (closeStream)
                stream.Close();

            return result;
        }
    }
}