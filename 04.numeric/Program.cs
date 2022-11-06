// ここでは数値に対する演算について学習します。
// 他の言語とほとんど同じです。
// ただし、C#では、整数の割り算は整数同士の割り算になります。
// 例えば、3/2の結果は1になります。
// これは、C#の整数型は整数同士の割り算の結果も整数になるためです。
// これを回避するには、少なくとも一方を少数型にキャストする必要があります。
// 例えば、3.0/2の結果は1.5になります。
// また、C#では、整数型の変数に少数を代入することはできません。
// 例えば、int a = 1.5;とすると、コンパイルエラーになります。
// これは、C#の整数型は整数しか扱えないためです。
// これを回避するには、少なくとも一方を少数型にキャストする必要があります。
// 例えば、int a = (int)1.5;とすると、aには1が代入されます。

// では、基本的な演算を行いましょう♪

Console.WriteLine(1 + 2); // 3
Console.WriteLine(1 - 2); // -1
Console.WriteLine(1 * 2); // 2
Console.WriteLine(5 / 2); // 2

// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
// ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
// ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

// 次に文字列を整数に変換する処理について学びます。

// これは、int.Parse()メソッドを使います。
// 例えば、int.Parse("1")とすると、1が返ってきます。
// また、int.Parse("1.5")とすると、コンパイルエラーになります。
// これは、int.Parse()メソッドは整数しか扱えないためです。
// これを回避するには、少なくとも一方を少数型にキャストする必要があります。

// では、文字列を整数に変換する処理を行いましょう♪

Console.WriteLine(int.Parse("1")); // 1
// Console.WriteLine(int.Parse("1.5")); // コンパイルエラー

// しかしながら、対象となる文字列が必ずしも変数に変換できるとは限りません。
// 例えば、int.Parse("a")とすると、コンパイルエラーになります。
// これを回避するためには、int.TryParse()メソッドを使います。
// この関数は第一引数に対象となる文字列を指定し、第二引数で変換結果を受け取ります。
// また、戻り値として変換に成功したかどうかをbool型で返します。
//
// 引数・戻り値については後ほど説明しますが、ここでも簡単に説明します。
// 引数とは、関数に渡す値のことです。
// 例えば、int.Parse("a")とすると、"a"がint.Parse()メソッドの第一引数になります。
// また、int.TryParse("a", out int result)とすると、"a"がint.TryParse()メソッドの第一引数になります。
// また、out int resultは、int.TryParse()メソッドの第二引数になります。
// 戻り値とは、関数が返す値のことです。
// 例えば、int.Parse("a")とすると、int.Parse()メソッドはint型を返します。
// また、int.TryParse("a", out int result)とすると、int.TryParse()メソッドはbool型を返します。
//
// 前回は、文字列が整数に変換できると仮定して変換を行ったので、そのまま変換結果を戻り値として使うことができました。
// しかしながら、変換に成功するか分からない場合には、変換に成功したかと変換後の値を受け取る必要があります。
// そのため、int.TryParse()メソッドは、変換に成功したかどうかをbool型で返し、変換後の値を第二引数で受け取るようになっています。
// 関数の引数として渡した値を変更することは原則としてできませんが、outキーワードを付けることでできるようになります。
//
// では、実際にint.TryParse()メソッドを使ってみましょう♪
// int.TryParse("a", out int result)とすると、resultには0が代入されます。
// また、int.TryParse("1", out int result)とすると、resultには1が代入されます。

// 結果を保存するための変数を宣言。
int result_int;

Console.WriteLine(int.TryParse("a", out result_int)); // False
Console.WriteLine(result_int); // 0

Console.WriteLine(int.TryParse("1", out result_int)); // True
Console.WriteLine(result_int); // 1

Console.WriteLine(int.TryParse("1.5", out result_int)); // False
Console.WriteLine(result_int); // 0

Console.WriteLine(int.TryParse("999", out result_int)); // True
Console.WriteLine(result_int); // 999

// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
// ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
// ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

// 浮動小数点数型に変換するためにはfloat.Parse()メソッドを使います。
// また、float.TryParse()メソッドを使うことで、変換に成功したかどうかをbool型で返すことができます。
// 整数型と同様です。

// 結果を保存するための変数を宣言。
float result_float;

Console.WriteLine(float.TryParse("a", out result_float)); // False
Console.WriteLine(result_float); // 0

Console.WriteLine(float.TryParse("1", out result_float)); // True
Console.WriteLine(result_float); // 1

Console.WriteLine(float.TryParse("1.5", out result_float)); // True
Console.WriteLine(result_float); // 1.5

Console.WriteLine(float.TryParse("999", out result_float)); // True
Console.WriteLine(result_float); // 999
