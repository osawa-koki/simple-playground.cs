
// コレクションとは複数の値をめとめて扱うためのデータ型です。
// コレクションには以下の種類があります。
// ・ ArrayList
// ・ BitArray
// ・ CaseInsensitiveComparer
// ・ CaseInsensitiveHashCodeProvider
// ・ CollectionBase
// ・ Comparer
// ・ DictionaryBase
// ・ Hashtable
// ・ Queue
// ・ ReadOnlyCollectionBase
// ・ SortedList
// ・ Stack
// ・ StructuralComparisons
// ref : https://learn.microsoft.com/ja-jp/dotnet/api/system.collections?view=net-7.0

// しかしながら、一般的にはジェネリッククラスを使用することが多いため、
// ここではジェネリッククラスについて説明します。
// 以下のジェネリッククラスがあります。
// ・ CollectionExtensions
// ・ Comparer<T>
// ・ Dictionary<TKey,TValue>.KeyCollection
// ・ Dictionary<TKey,TValue>.ValueCollection
// ★ Dictionary<TKey,TValue>
// ・ EqualityComparer<T>
// ★ HashSet<T>
// ・ KeyNotFoundException
// ・ KeyValuePair
// ・ LinkedList<T>
// ・ LinkedListNode<T>
// ★ List<T>
// ・ PriorityQueue<TElement,TPriority>.UnorderedItemsCollection
// ・ PriorityQueue<TElement,TPriority>
// ★ Queue<T>
// ・ ReferenceEqualityComparer
// ・ SortedDictionary<TKey,TValue>.KeyCollection
// ・ SortedDictionary<TKey,TValue>.ValueCollection
// ★ SortedDictionary<TKey,TValue>
// ★ SortedList<TKey,TValue>
// ★ SortedSet<T>
// ★ Stack<T>
//
// ref : https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.generic?view=net-7.0
//
// ★を付けたデータ型を使用する機会が多いです。
// ここでも、それらについて説明します。

{
  // 最初に純粋な配列について説明します。
  // 配列は、同じ型の値を連続したメモリ領域に格納するデータ型です。

  // 以下のように宣言します。
  int[] array = new int[3];

  // 以下のように初期化します。
  array[0] = 1;
  array[1] = 2;
  array[2] = 3;

  // 以下のように要素を取得します。
  Console.WriteLine(array[0]); // 1
  Console.WriteLine(array[1]); // 2
  Console.WriteLine(array[2]); // 3

  // 以下のように要素を変更します。
  array[0] = 4;
  array[1] = 5;
  array[2] = 6;

  // 宣言と初期化を同時に行うこともできます。
  int[] array2 = new int[3] { 1, 2, 3 };

  // 配列をループするにはforeachを使用します。
  foreach (var item in array)
  {
    Console.WriteLine(item);
  }

  // >>> 実行結果
  // 4
  // 5
  // 6

  // 配列の要素数を取得するにはLengthプロパティを使用します。

  Console.WriteLine(array.Length); // 3
}
{
  // List
  // Listは、配列のように同じ型の値を連続したメモリ領域に格納するデータ型です。
  // しかし、配列と異なり、要素数を変更することができます。

  // 以下のように宣言します。
  List<int> list = new List<int>();

  // 以下のように初期化します。
  list.Add(1);
  list.Add(2);
  list.Add(3);

  // 以下のように要素を取得します。
  Console.WriteLine(list[0]); // 1
  Console.WriteLine(list[1]); // 2
  Console.WriteLine(list[2]); // 3

  // 以下のように要素を変更します。
  list[0] = 4;
  list[1] = 5;
  list[2] = 6;

  // 宣言と初期化を同時に行うこともできます。
  List<int> list2 = new List<int> { 1, 2, 3 };

  // Listをループするにはforeachを使用します。
  foreach (var item in list)
  {
    Console.WriteLine(item);
  }

  // >>> 実行結果
  // 4
  // 5
  // 6

  // また、Listには以下のメソッドがあります。
  // ・ Add : 要素を追加します。
  // ・ AddRange : 複数の要素を追加します。
  // ・ All : 全ての要素が指定した条件を満たしているか判定します。
  // ・ Any : いずれかの要素が指定した条件を満たしているか判定します。
  // ・ Clear : 要素をすべて削除します。
  // ・ Contains : 指定した要素が含まれているかどうかを返します。
  // ・ CopyTo : 要素を配列にコピーします。
  // ・ Exists : 条件に一致する要素が含まれているかどうかを返します。
  // ・ Find : 条件に一致する要素を返します。
  // ・ FindAll : 条件に一致する要素をすべて返します。
  // ・ FindIndex : 条件に一致する要素のインデックスを返します。
  // ・ FindLast : 条件に一致する最後の要素を返します。
  // ・ FindLastIndex : 条件に一致する最後の要素のインデックスを返します。
  // ・ ForEach : 要素をすべて処理します。
  // ・ GetRange : 指定した範囲の要素を返します。
  // ・ IndexOf : 指定した要素のインデックスを返します。
  // ・ Insert : 指定したインデックスに要素を挿入します。
  // ・ InsertRange : 指定したインデックスに複数の要素を挿入します。
  // ・ LastIndexOf : 指定した要素の最後のインデックスを返します。
  // ・ Remove : 指定した要素を削除します。
  // ・ RemoveAll : 条件に一致する要素をすべて削除します。
  // ・ RemoveAt : 指定したインデックスの要素を削除します。
  // ・ RemoveRange : 指定した範囲の要素を削除します。
  // ・ Reverse : 要素を逆順にします。
  // ・ Sort : 要素をソートします。
  // ・ ToArray : 配列に変換します。
  // ・ TrimExcess : 不要なメモリを解放します。
  // ・ TrueForAll : 条件に一致する要素がすべて含まれているかどうかを返します。

  // また、リスト型の変数にリスト型のデータを格納する際には、省略記法が使用可能です。

  List<int> list3 = new() { 1, 2, 3 };
}
{
  // Dictionary
  // Dictionaryは、キーと値のペアを格納するデータ型です。

  // 以下のように宣言します。
  Dictionary<string, int> dictionary = new Dictionary<string, int>();

  // 以下のように初期化します。
  dictionary.Add("one", 1);
  dictionary.Add("two", 2);
  dictionary.Add("three", 3);

  // 以下のように要素を取得します。
  Console.WriteLine(dictionary["one"]); // 1
  Console.WriteLine(dictionary["two"]); // 2
  Console.WriteLine(dictionary["three"]); // 3

  // 以下のように要素を変更します。
  dictionary["one"] = 4;
  dictionary["two"] = 5;
  dictionary["three"] = 6;

  // 宣言と初期化を同時に行うこともできます。
  Dictionary<string, int> dictionary2 = new Dictionary<string, int>
  {
    { "one", 1 },
    { "two", 2 },
    { "three", 3 },
  };

  // Dictionaryをループするにはforeachを使用します。
  foreach (var item in dictionary)
  {
    Console.WriteLine(item.Key + " : " + item.Value);
  }

  // >>> 実行結果
  // one : 4
  // two : 5
  // three : 6

  dictionary.All(x => x.Key == "one"); // false

  // また、Dictionaryには以下のメソッドがあります。
  // ・ Add : 要素を追加します。
  // ・ All : 全ての要素が指定した条件を満たしているか判定します。
  // ・ Any : いずれかの要素が指定した条件を満たしているか判定します。
  // ・ Clear : 要素をすべて削除します。
  // ・ ContainsKey : 指定したキーが含まれているかどうかを返します。
  // ・ ContainsValue : 指定した値が含まれているかどうかを返します。
  // ・ CopyTo : 要素を配列にコピーします。
  // ・ Remove : 指定した要素を削除します。

  // また、Dictionary型の変数にDictionary型のデータを格納する際には、省略記法が使用可能です。

  Dictionary<string, int> dictionary3 = new()
  {
    { "one", 1 },
    { "two", 2 },
    { "three", 3 },
  };
}
{
  // Queue
  // Queueは、先入れ先出しのデータ型です。

  // 以下のように宣言します。
  Queue<int> queue = new Queue<int>();

  // 以下のように初期化します。
  queue.Enqueue(1);
  queue.Enqueue(2);
  queue.Enqueue(3);

  // 以下のように要素を取得します。
  Console.WriteLine(queue.Dequeue()); // 1
  Console.WriteLine(queue.Dequeue()); // 2
  Console.WriteLine(queue.Dequeue()); // 3

  // 宣言と初期化を同時に行うこともできます。
  Queue<int> queue2 = new Queue<int>(new int[] { 1, 2, 3 });

  // Queueをループするにはforeachを使用します。
  foreach (var item in queue)
  {
    Console.WriteLine(item);
  }

  // >>> 実行結果
  // 1
  // 2
  // 3

  // 変数のデータ型と代入するデータ型が同じである場合には、省略記法が使用可能です。
  Queue<int> queue3 = new(new int[] { 1, 2, 3 });
}
{
  // Stack
  // Stackは、後入れ先出しのデータ型です。

  // 以下のように宣言します。
  Stack<int> stack = new Stack<int>();

  // 以下のように初期化します。
  stack.Push(1);
  stack.Push(2);
  stack.Push(3);

  // 以下のように要素を取得します。
  Console.WriteLine(stack.Pop()); // 3
  Console.WriteLine(stack.Pop()); // 2
  Console.WriteLine(stack.Pop()); // 1

  // 宣言と初期化を同時に行うこともできます。
  Stack<int> stack2 = new Stack<int>(new int[] { 1, 2, 3 });

  // Stackをループするにはforeachを使用します。
  foreach (var item in stack2)
  {
    Console.WriteLine(item);
  }

  // >>> 実行結果
  // 3
  // 2
  // 1

  // 変数のデータ型と代入するデータ型が同じである場合には、省略記法が使用可能です。
  Stack<int> stack3 = new(new int[] { 1, 2, 3 });
}
{
  // HashSet
  // HashSetは、重複を許さないデータ型です。

  // 以下のように宣言します。
  HashSet<int> hashSet = new HashSet<int>();

  // 以下のように初期化します。
  hashSet.Add(1);
  hashSet.Add(2);
  hashSet.Add(3);

  // 重複するデータを格納できません。
  hashSet.Add(1);
  // 「1」「2」「3」が格納されていて、重複する「1」は新たに格納されません。

  // 宣言と初期化を同時に行うこともできます。
  HashSet<int> hashSet2 = new HashSet<int>(new int[] { 1, 2, 3 });

  // HashSetをループするにはforeachを使用します。
  foreach (var item in hashSet)
  {
    Console.WriteLine(item);
  }

  // >>> 実行結果
  // 1
  // 2
  // 3

  // 変数のデータ型と代入するデータ型が同じである場合には、省略記法が使用可能です。
  HashSet<int> hashSet3 = new(new int[] { 1, 2, 3 });
}
{
  // SortedSet // TODO
}
{
  // SortedList // TODO
}
{
  // SortedDictionary // TODO
}
