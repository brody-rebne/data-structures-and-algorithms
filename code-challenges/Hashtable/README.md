# Trees

### Code

https://github.com/brody-rebne/data-structures-and-algorithms/tree/master/code-challenges/Hashtable/Hashtable

### Challenge

Implement a Hashtable with the following methods:

1. `Add()`: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.

1. `Find()`: takes in the key and returns the value from the table.

1. `Contains()`: takes in the key and returns a boolean, indicating if the key exists in the table already.

1. `GetHash()`: takes in an arbitrary key and returns an index in the collection.

### Approach and Efficiency

1. `HashTable` - Table is built off an array of linked lists. This allows for O(1) lookup for buckets. Though additional complexity is spent searching the linked list of a bucket, the additional structure allows for colliding values to be stored without much more complexity. The linked lists themselves contain nodes whose values are typed to a custom class which holds the key/value pair.

1. `GetHash()` - *O(n) n=char length of string / O(1)* - The hashing method applies a simple hashing technique. Add all the character codes together, and multiply by a large-ish prime. Then, modulo that number by the length of the table array to find a suitable index.

1. `Add()` - *O(1) (ignoring minimal GetHash() complexity) / O(1)* - Hashes the key to find the index to add to. If no linked list exists at that index, it creates one. Then it adds a new node to the end of the linked list via `AddLast()`, which has an O(1) complexity on doubly linked lists.

1. `Find()` - *O(n) n=number of values with same hash key / O(1)* - Hashes the input to find the key's index. If that index contains a linked list, it searches the linked list for a kvp with that key. If it finds one, it returns that kvp's value. Returns null in all other cases.

1. `Contains()` - *O(n) n=number of values with same hash key / O(1)* - Performs the same basic steps as above, except it returns `true` instead of the value when the key is found. Since all collisioned values must be checked before confirming a false return, it maintains an O(n) complexity. Given this, I had it use the functionality of the `Find()` method and return a bool based on its return.

### API

`HashTable()` - Creates a new hashtable of default size 1024.

`HashTable.Add(string key, string value)` - Adds a new key value pair (from the given values) to the hash table. Returns `void`.

`HashTable.Find(string key)` - Finds the value associated with the given key. Returns the `string` of the value.

`HashTable.Contains(string key)` - Checks if the hash table contains a key value pair with the given key. Returns `true` if the key is found, `false` if it is not.'

`HashTable.GetHash(string str)` - Gets the bucket index for the given str by hashing it. Returns the `int` index.

### Changelog

1.0: Initial version