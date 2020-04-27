using Hashtable;
using Xunit;

namespace HashtableTests
{
    public class UnitTest1
    {
        //tables can be instantiated
        [Fact]
        public void CanCreate()
        {
            HashTable testTable = new HashTable();

            Assert.IsType<HashTable>(testTable);
        }

        //hash method produces a predictable value
        [Fact]
        public void CanHashString()
        {
            HashTable testTable = new HashTable();
            string testString = "test";

            Assert.Equal(192, testTable.GetHash(testString));
        }

        //kvp can be added to empty bucket
        [Fact]
        public void CanAddValueToEmpty()
        {
            HashTable testTable = new HashTable();
            testTable.Add("testKey", "testValue");

            //breaks here if no LL is created
            var x = testTable.Buckets[445];

            //breaks here if no node is added to LL
            var y = testTable.Buckets[445].First;

            Assert.Equal("testValue", testTable.Buckets[445].First.Value.Value);
        }

        //kvp can be added to existing bucket
        [Fact]
        public void CanAddCollidingValues()
        {
            HashTable testTable = new HashTable();
            testTable.Add("testKey", "testValue");
            testTable.Add("tystKee", "tustValee");

            //ready to type some periods?
            Assert.Equal("tustValee", testTable.Buckets[445].First.Next.Value.Value);
        }

        //key can be searched
        [Fact]
        public void CanFindKVP()
        {
            HashTable testTable = new HashTable();
            testTable.Add("testKey", "testValue");

            Assert.Equal("testValue", testTable.Find("testKey"));
        }

        //collisioned key can be searched
        [Fact]
        public void CanFindCollidedKVP()
        {
            HashTable testTable = new HashTable();
            testTable.Add("testKey", "testValue");
            testTable.Add("tystKee", "tustValee");

            Assert.Equal("tustValee", testTable.Find("tystKee"));
        }

        //doesnt find value that doesnt exist
        [Fact]
        public void DoesntFindNonexistentValue()
        {
            HashTable testTable = new HashTable();
            testTable.Add("testKey", "testValue");

            Assert.Null(testTable.Find("goo"));
        }

        //can detect value
        [Fact]
        public void CanDetectKVP()
        {
            HashTable testTable = new HashTable();
            testTable.Add("testKey", "testValue");

            Assert.True(testTable.Contains("testKey"));
        }

        //doesnt detect value that doesnt exist
        [Fact]
        public void DoesntDetectNonexistentValue()
        {
            HashTable testTable = new HashTable();
            testTable.Add("testKey", "testValue");

            Assert.False(testTable.Contains("goo"));
        }
    }
}
