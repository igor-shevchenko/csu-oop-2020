using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BinaryTreeSet.Tests
{
    [TestClass]
    public class BinaryTreeSetSerializerTests
    {
        [TestMethod]
        public void TestSerializeAndDeserialize()
        {
            var set = new BinaryTreeSet<int>{ 3, 5, 7, 9, 11};
            var name = "some-name";
            var stream = new MemoryStream();

            var storageMock = new Mock<IStorage>();
            storageMock.Setup(s => s.GetWriteStream(name))
                .Returns(stream);
            storageMock.Setup(s => s.GetReadStream(name))
                .Returns(stream);

            var serializer = new BinaryTreeSetSerializer(storageMock.Object);

            serializer.Save(name, set, closeStream:false);
            stream.Position = 0;
            var newSet = serializer.Load<int>(name);

            CollectionAssert.AreEqual(set.ToList(), newSet.ToList());
        }

        [TestMethod]
        public void TestSerialize()
        {
            var set = new BinaryTreeSet<int>{ 3, 5, 7, 9, 11};
            var name = "some-name";
            var stream = new MemoryStream();

            var storageMock = new Mock<IStorage>();
            storageMock.Setup(s => s.GetWriteStream(name))
                .Returns(stream);

            var serializer = new BinaryTreeSetSerializer(storageMock.Object);

            serializer.Save(name, set, closeStream:false);
            stream.Position = 0;

            var serialized = Encoding.ASCII.GetString(stream.ToArray());

            Assert.AreEqual("[3,5,7,9,11]", serialized);
        }

    }
}