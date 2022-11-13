using System.Collections.Generic;

// ここではLINQについて学習します。
// LINQは、データソースからデータを取得するためのクエリ言語です。
// コレクションなどのIEnumerableを実装しているオブジェクトに対して使用できます。

{
// ここでは、LINQの基本的な使い方を学習します。
// まずは、LINQを使用するためのusingディレクティブを記述します。
// using System.Linq;
// ここでは自動インポート機能を使用しているため、明示的なインポートは不要ですが、
// 自動インポート機能をオフにしている場合にはusingディレクティブを使用して明示的にインポートしてください。

// クエリ式は、from句、where句、select句、order by句、group by句、join句などがあります。
// これらの句を組み合わせて、LINQのクエリを記述します。

// LINQには、以下のメソッドが用意されています。
// ・ Select : データを変換する
// ・ Where : 条件に合致するデータを抽出する
// ・ OrderBy : データをソートする
// ・ GroupBy : データをグループ化する
// ・ Join : 2つのデータを結合する
// ・ Distinct : 重複するデータを除外する
// ・ Skip : 先頭から指定した数だけデータを除外する
// ・ SkipWhile : データの先頭から指定した条件を満たすデータを除去する
// ・ Take : 先頭から指定した数だけデータを取得する
// ・ TakeWhile : データの先頭から指定した条件を満たすデータを取得する
// ・ Zip : 2つのデータを結合する
// ・ Count : データの数を取得する
// ・ Sum : データの合計を取得する
// ・ Average : データの平均を取得する
// ・ Max : データの最大値を取得する
// ・ Min : データの最小値を取得する
// ・ Any : 条件に合ったデータが存在するかどうかを判定する
// ・ All : 全てのデータ型条件を満たしているか判定する
// ・ First : 条件に合致する最初のデータを取得する
// ・ FirstOrDefault : 条件に合致する最初のデータを取得する。条件に合致するデータが存在しない場合は、デフォルト値を取得する
// ・ Single : 条件に合致するデータを1つだけ取得する
// ・ SingleOrDefault : 条件に合致するデータを1つだけ取得する。条件に合致するデータが存在しない場合は、デフォルト値を取得する
// ・ Last : 条件に合致する最後のデータを取得する
// ・ LastOrDefault : 条件に合致する最後のデータを取得する。条件に合致するデータが存在しない場合は、デフォルト値を取得する
// ・ ElementAt : 指定したインデックスのデータを取得する
// ・ ElementAtOrDefault : 指定したインデックスのデータを取得する。指定したインデックスのデータが存在しない場合は、デフォルト値を取得する
// ・ Concat : 2つのデータを連結する
// ・ Union : 2つのデータを連結する。重複するデータは除外する
// ・ Intersect : 2つのデータの共通部分を取得する
// ・ Except : 2つのデータの差分を取得する
// ・ Reverse : データを逆順にする
// ・ SequenceEqual : 2つのデータが同じかどうかを取得する
// ・ DefaultIfEmpty : データが存在しない場合に、デフォルト値を取得する
// ・ OfType : 指定した型のデータを取得する
// ・ Cast : 指定した型にキャストする
// ・ ToArray : データを配列に変換する
// ・ ToList : データをリストに変換する
// ・ ToDictionary : データをディクショナリに変換する
// ・ ToLookup : データをルックアップに変換する
// ・ AsEnumerable : データを列挙可能なデータに変換する
// ・ AsQueryable : データをクエリ可能なデータに変換する
// ・ AsParallel : データを並列処理可能なデータに変換する
//
// これらのメソッドは、拡張メソッドとして用意されています。
// これらのメソッドは、IEnumerable<T>やIQueryable<T>などのインターフェイスに定義されているメソッドです。
// これらのメソッドは、拡張メソッドとして用意されているため、
// これらのメソッドを呼び出すためには、using System.Linq;を記述する必要があります。
//
// これらのメソッドは、LINQと呼ばれるクエリ構文を使用して記述することもできます。
// これらのメソッドは、LINQ to Objectsと呼ばれるクエリ構文を使用して記述することもできます。
// これらのメソッドは、LINQ to SQLと呼ばれるクエリ構文を使用して記述することもできます。
// これらのメソッドは、LINQ to XMLと呼ばれるクエリ構文を使用して記述することもできます。
//
// ref : https://learn.microsoft.com/ja-jp/dotnet/api/system.linq.enumerable?view=net-7.0
}
{
  // Select
  // ・ データを変換する

  // Selectメソッドは、データを変換するメソッドです。
  // Selectメソッドは、データを変換するために、データを引数に取るデリゲートを指定します。
  // Selectメソッドは、データを変換するために、デリゲートを指定します。
  // Selectメソッドは、データを変換するために、ラムダ式を指定します。

  // ラムダ式とは簡単な関数のことだと認識してください。
  // 例えば、引数2つの和を返すラムダは以下のようになります。
  // (x, y) => x + y
  // これを関数で書くと以下のようになります。
  // function(x, y) {
  //   return x + y;
  // }
  // これをメソッドで書くと以下のようになります。
  // public int Add(int x, int y) {
  //   return x + y;
  // }
  // これをデリゲートで書くと以下のようになります。
  // delegate int Add(int x, int y);
  // ラムダ式で書くと非常に簡単に書けることが分かりますね。

  // では、さっそくSelect文を使用して、配列全ての要素を2倍にしてみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Selectメソッドを使用して、配列全ての要素を2倍にします。
  // Selectメソッドは、データを変換するために、デリゲートを指定します。
  // この場合、デリゲートは、x => x * 2となります。

  var array_select = array.Select(x => x * 2);

  Console.WriteLine($"array.Select(x => x * 2) -> {string.Join(", ", array_select)}");

  // >>> 実行結果
  // array.Select(x => x * 2) -> 2, 4, 6, 8, 10
}
{
  // Where
  // ・ 条件に合致するデータを取得する

  // Whereメソッドは、条件に合致するデータを取得するメソッドです。
  // Whereメソッドは、条件に合致するデータを取得するために、データを引数に取るデリゲートを指定します。
  // 指定したデリゲートは真偽値を返す必要があります。

  // では、さっそくWhere文を使用して、配列全ての要素から偶数のみを取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Whereメソッドを使用して、配列全ての要素から偶数のみを取得します。
  // Whereメソッドは、条件に合致するデータを取得するために、デリゲートを指定します。
  // この場合、デリゲートは、x => x % 2 == 0となります。

  var array_where = array.Where(x => x % 2 == 0);

  Console.WriteLine($"array.Where(x => x % 2 == 0) -> {string.Join(", ", array_where)}");

  // >>> 実行結果
  // array.Where(x => x % 2 == 0) -> 2, 4
}
{
  // OrderBy
  // ・ データをソートする

  // OrderByメソッドは、データをソートするメソッドです。
  // OrderByメソッドは、データをソートするために、データを引数に取るデリゲートを指定します。
  // 指定したデリゲートは、ソートの基準となる値を返す必要があります。

  // では、さっそくOrderBy文を使用して、配列全ての要素を昇順にソートしてみましょう。

  // まずは、配列を用意します。
  var array_asc = new[] { 1, 2, 3, 4, 5 };

  // 次に、OrderByメソッドを使用して、配列全ての要素を昇順にソートします。
  // OrderByメソッドは、データをソートするために、デリゲートを指定します。
  // この場合、デリゲートは、x => xとなります。

  var array_orderby = array_asc.OrderBy(x => x);

  Console.WriteLine($"array_asc.OrderBy(x => x) -> {string.Join(", ", array_orderby)}");

  // >>> 実行結果
  // array.OrderBy(x => x) -> 1, 2, 3, 4, 5

  // では、さっそくOrderBy文を使用して、配列全ての要素を降順にソートしてみましょう。

  // まずは、配列を用意します。
  var array_desc = new[] { 1, 2, 3, 4, 5 };

  // 次に、OrderByメソッドを使用して、配列全ての要素を降順にソートします。
  // OrderByメソッドは、データをソートするために、デリゲートを指定します。
  // この場合、デリゲートは、x => -xとなります。

  var array_orderby_desc = array_desc.OrderBy(x => -x);

  Console.WriteLine($"array_desc.OrderBy(x => -x) -> {string.Join(", ", array_orderby_desc)}");

  // >>> 実行結果
  // array_desc.OrderBy(x => -x) -> 5, 4, 3, 2, 1

  // ===== ===== ===== ===== =====

  // また、降順に並び替えるために、専用のOrderByDescendingメソッドを使用することもできます。

  Console.WriteLine($"array_desc.OrderByDescending(x => x) -> {string.Join(", ", array_desc.OrderByDescending(x => x))}");
}
{
  // GroupBy
  // ・ データをグループ化する

  // GroupByメソッドは、データをグループ化するメソッドです。
  // GroupByメソッドは、データをグループ化するために、データを引数に取るデリゲートを指定します。
  // 指定したデリゲートは、グループ化の基準となる値を返す必要があります。

  // では、さっそくGroupBy文を使用して、配列全ての要素を偶数と奇数にグループ化してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、GroupByメソッドを使用して、配列全ての要素を偶数と奇数にグループ化します。
  // GroupByメソッドは、データをグループ化するために、デリゲートを指定します。
  // この場合、デリゲートは、x => x % 2 == 0となります。

  var array_groupby = array.GroupBy(x => x % 2 == 0);

  // GroupByメソッドは、グループ化されたデータを返します。
  // そのため、グループ化されたデータを取得するためには、ForEachメソッドを使用します。

  array_groupby.ToList().ForEach(x =>
  {
    Console.WriteLine($"array.GroupBy(x => x % 2 == 0) -> {string.Join(", ", x)}");
  });

  // >>> 実行結果
  // array.GroupBy(x => x % 2 == 0) -> 1, 3, 5
  // array.GroupBy(x => x % 2 == 0) -> 2, 4
}
{
  // Join
  // ・ データを結合する

  // Joinメソッドは、データを結合するメソッドです。
  // Joinメソッドは、データを結合するために、データを引数に取るデリゲートを指定します。
  // 指定したデリゲートは、結合の基準となる値を返す必要があります。

  // TODO
}
{
  // Distinct
  // ・ データの重複を除去する

  // Distinctメソッドは、データの重複を除去するメソッドです。

  // では、さっそくDistinct文を使用して、配列全ての要素の重複を除去してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

  // 次に、Distinctメソッドを使用して、配列全ての要素の重複を除去します。
  var array_distinct = array.Distinct();

  Console.WriteLine($"array.Distinct() -> {string.Join(", ", array_distinct)}");

  // >>> 実行結果
  // array.Distinct() -> 1, 2, 3, 4, 5
}
{
  // Skip
  // ・ データの先頭から指定した数だけデータを除去する

  // Skipメソッドは、データの先頭から指定した数だけデータを除去するメソッドです。
  
}
{
  // Take
  // ・ データの先頭から指定した数だけデータを取得する

  // Takeメソッドは、データの先頭から指定した数だけデータを取得するメソッドです。
}
{
  // SkipWhile
  // ・ データの先頭から指定した条件を満たすデータを除去する

  // SkipWhileメソッドは、データの先頭から指定した条件を満たすデータを除去するメソッドです。
}
{
  // TakeWhile
  // ・ データの先頭から指定した条件を満たすデータを取得する

  // TakeWhileメソッドは、データの先頭から指定した条件を満たすデータを取得するメソッドです。
}
{
  // Zip
  // ・ データを結合する

  // Zipメソッドは、データを結合するメソッドです。
}
{
  // Count
  // ・ データの数を取得する

  // Countメソッドは、データの数を取得するメソッドです。

  // では、さっそくCount文を使用して、配列全ての要素の数を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Countメソッドを使用して、配列全ての要素の数を取得します。
  var array_count = array.Count();

  Console.WriteLine($"array.Count() -> {array_count}");

  // >>> 実行結果
  // array.Count() -> 5
}
{
  // Sum
  // ・ データの合計を取得する

  // Sumメソッドは、データの合計を取得するメソッドです。

  // では、さっそくSum文を使用して、配列全ての要素の合計を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Sumメソッドを使用して、配列全ての要素の合計を取得します。
  var array_sum = array.Sum();

  Console.WriteLine($"array.Sum() -> {array_sum}");

  // >>> 実行結果
  // array.Sum() -> 15
}
{
  // Average
  // ・ データの平均を取得する

  // Averageメソッドは、データの平均を取得するメソッドです。

  // では、さっそくAverage文を使用して、配列全ての要素の平均を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Averageメソッドを使用して、配列全ての要素の平均を取得します。
  var array_average = array.Average();

  Console.WriteLine($"array.Average() -> {array_average}");

  // >>> 実行結果
  // array.Average() -> 3
}
{
  // Max
  // ・ データの最大値を取得する

  // Maxメソッドは、データの最大値を取得するメソッドです。

  // では、さっそくMax文を使用して、配列全ての要素の最大値を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Maxメソッドを使用して、配列全ての要素の最大値を取得します。
  var array_max = array.Max();

  Console.WriteLine($"array.Max() -> {array_max}");

  // >>> 実行結果
  // array.Max() -> 5
}
{
  // Min
  // ・ データの最小値を取得する

  // Minメソッドは、データの最小値を取得するメソッドです。

  // では、さっそくMin文を使用して、配列全ての要素の最小値を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Minメソッドを使用して、配列全ての要素の最小値を取得します。
  var array_min = array.Min();

  Console.WriteLine($"array.Min() -> {array_min}");

  // >>> 実行結果
  // array.Min() -> 1
}
{
  // Any
  // ・ 条件に合ったデータが存在するかどうかを判定する

  // Anyメソッドは、条件に合ったデータが存在するかどうかを取得するメソッドです。

  // では、さっそくAny文を使用して、条件に合ったデータが存在するかどうかを取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Anyメソッドを使用して、配列全ての要素が存在するかどうかを取得します。
  var array_any = array.Any(x => x == 3);

  Console.WriteLine($"array.Any(x => x == 3) -> {array_any}");

  // >>> 実行結果
  // array.Any(x => x == 3) -> True

  // また、Anyメソッドは、配列の要素が存在しない場合に、Falseを返します。
  var array_any2 = array.Any(x => x == 6);

  Console.WriteLine($"array.Any(x => x == 6) -> {array_any2}");

  // >>> 実行結果
  // array.Any(x => x == 6) -> False
}
{
  // All
  // ・ 全てのデータ型条件を満たしているか判定する

  // Allメソッドは、全てのデータ型条件を満たしているか判定するメソッドです。

  // では、さっそくAll文を使用して、全てのデータ型条件を満たしているか判定してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Allメソッドを使用して、配列全ての要素が条件を満たしているか判定します。
  var array_all = array.All(x => x > 0);

  Console.WriteLine($"array.All(x => x > 0) -> {array_all}");

  // >>> 実行結果
  // array.All(x => x > 0) -> True

  // また、Allメソッドは、配列の要素が条件を満たしていない場合に、Falseを返します。
  var array_all2 = array.All(x => x > 3);

  Console.WriteLine($"array.All(x => x > 3) -> {array_all2}");

  // >>> 実行結果
  // array.All(x => x > 3) -> False
}
{
  // Contains
  // ・ データが指定した値を含むかどうかを取得する

  // Containsメソッドは、データが指定した値を含むかどうかを取得するメソッドです。

  // では、さっそくContains文を使用して、データが指定した値を含むかどうかを取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Containsメソッドを使用して、配列全ての要素が指定した値を含むかどうかを取得します。
  var array_contains = array.Contains(3);

  Console.WriteLine($"array.Contains(3) -> {array_contains}");

  // >>> 実行結果
  // array.Contains(3) -> True

  // また、Containsメソッドは、配列の要素が指定した値を含まない場合に、Falseを返します。
  var array_contains2 = array.Contains(6);

  Console.WriteLine($"array.Contains(6) -> {array_contains2}");

  // >>> 実行結果
  // array.Contains(6) -> False
}
{
  // First
  // ・ データの先頭の値を取得する

  // Firstメソッドは、データの先頭の値を取得するメソッドです。

  // では、さっそくFirst文を使用して、データの先頭の値を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Firstメソッドを使用して、配列の先頭の値を取得します。
  var array_first = array.First();

  Console.WriteLine($"array.First() -> {array_first}");

  // >>> 実行結果
  // array.First() -> 1

  // また、Firstメソッドは、配列の要素が存在しない場合に、例外を発生させます。
  // 配列の要素が存在しない場合を考慮する場合には、FirstOrDefaultメソッドを使用します。
}
{
  // FirstOrDefault
  // ・ データの先頭の値を取得する（データが存在しない場合は、デフォルト値を取得する）

  // FirstOrDefaultメソッドは、データの先頭の値を取得する（データが存在しない場合は、デフォルト値を取得する）メソッドです。

  // では、さっそくFirstOrDefault文を使用して、データの先頭の値を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、FirstOrDefaultメソッドを使用して、配列の先頭の値を取得します。
  var array_first = array.FirstOrDefault();

  Console.WriteLine($"array.FirstOrDefault() -> {array_first}");

  // >>> 実行結果
  // array.FirstOrDefault() -> 1

  // また、FirstOrDefaultメソッドは、配列の要素が存在しない場合に、デフォルト値を返します。
  var array_first2 = new int[0].FirstOrDefault();

  Console.WriteLine($"new int[0].FirstOrDefault() -> {array_first2}");

  // >>> 実行結果
  // new int[0].FirstOrDefault() -> 0
}
{
  // Last
  // ・ データの末尾の値を取得する

  // Lastメソッドは、データの末尾の値を取得するメソッドです。

  // では、さっそくLast文を使用して、データの末尾の値を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Lastメソッドを使用して、配列の末尾の値を取得します。
  var array_last = array.Last();

  Console.WriteLine($"array.Last() -> {array_last}");

  // >>> 実行結果
  // array.Last() -> 5

  // また、Lastメソッドは、配列の要素が存在しない場合に、例外を発生させます。
  // 配列の要素が存在しない場合を考慮する場合には、LastOrDefaultメソッドを使用します。
}
{
  // LastOrDefault
  // ・ データの末尾の値を取得する（データが存在しない場合は、デフォルト値を取得する）

  // LastOrDefaultメソッドは、データの末尾の値を取得する（データが存在しない場合は、デフォルト値を取得する）メソッドです。

  // では、さっそくLastOrDefault文を使用して、データの末尾の値を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、LastOrDefaultメソッドを使用して、配列の末尾の値を取得します。
  var array_last = array.LastOrDefault();

  Console.WriteLine($"array.LastOrDefault() -> {array_last}");

  // >>> 実行結果
  // array.LastOrDefault() -> 5

  // また、LastOrDefaultメソッドは、配列の要素が存在しない場合に、デフォルト値を返します。
  var array_last2 = new int[0].LastOrDefault();

  Console.WriteLine($"new int[0].LastOrDefault() -> {array_last2}");

  // >>> 実行結果
  // new int[0].LastOrDefault() -> 0
}
{
  // Single
  // ・ データの値を取得する

  // Singleメソッドは、指定した条件に合うデータを取得するメソッドです。
  // ただし、Singleメソッドは、条件に合うデータが複数存在する場合に、例外を発生させます。

  // では、さっそくSingle文を使用して、データの値を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、Singleメソッドを使用して、配列の値を取得します。
  var array_single = array.Single(x => x == 3);

  Console.WriteLine($"array.Single() -> {array_single}");

  // >>> 実行結果
  // array.Single() -> 3

  // また、Singleメソッドは、条件に合うデータが複数存在する場合に、例外を発生させます。
  // 例えば、x => x % 2 == 0のように、条件に合うデータが複数存在する場合には、例外を発生させます。

  // 例外を発生させない場合には、SingleOrDefaultメソッドを使用します。
}
{
  // SingleOrDefault
  // ・ データの値を取得する（データが存在しない場合は、デフォルト値を取得する）

  // SingleOrDefaultメソッドは、データの値を取得する（データが存在しない場合は、デフォルト値を取得する）メソッドです。

  // では、さっそくSingleOrDefault文を使用して、データの値を取得してみましょう。

  // まずは、配列を用意します。
  var array = new[] { 1, 2, 3, 4, 5 };

  // 次に、SingleOrDefaultメソッドを使用して、配列の値を取得します。
  var array_single = array.SingleOrDefault(x => x == 3);

  Console.WriteLine($"array.SingleOrDefault() -> {array_single}");

  // >>> 実行結果
  // array.SingleOrDefault() -> 3

  //また、SingleOrDefaultメソッドは、条件に合うデータが存在しない場合に、デフォルト値を返します。
  var array_single2 = array.SingleOrDefault(x => x == 10);

  Console.WriteLine($"array.SingleOrDefault() -> {array_single2}");

  // >>> 実行結果
  // array.SingleOrDefault() -> 0
}
{
  // ElementAt
  // ・ データの指定したインデックスの値を取得する

  // ElementAtメソッドは、データの指定したインデックスの値を取得するメソッドです。
}
{
  // Union
  // ・ データの重複を除去して結合する

  // Unionメソッドは、データの重複を除去して結合するメソッドです。
}
{
  // Intersect
  // ・ データの重複を除去して共通のデータを取得する

  // Intersectメソッドは、データの重複を除去して共通のデータを取得するメソッドです。
}
{
  // Except
  // ・ データの重複を除去して指定したデータを除去する

  // Exceptメソッドは、データの重複を除去して指定したデータを除去するメソッドです。
}
{
  // Concat
  // ・ データを結合する

  // Concatメソッドは、データを結合するメソッドです。
}
