// ここでは、文字列型について学びます。
// C#ではstring型として扱います。

// まずは、string型の変数を宣言してみましょう。
string _string;

// 次に、string型の変数に値を代入してみましょう。
_string = "Hello World";

// それぞれの変数の値を表示してみましょう。
Console.WriteLine(_string);

// >>> 実行結果
// Hello World

// また、string型の変数には、文字列を連結することができます。
// 例えば、以下のように記述すると、"Hello"と"World"という文字列を連結して表示します。
Console.WriteLine("Hello" + "World");

// >>> 実行結果
// HelloWorld

// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
// ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
// ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

// 次に文字列補完について学びます。
// 文字列補完とは、文字列の中に変数の値を埋め込むことです。
// 例えば、以下のように記述すると、"Hello World"という文字列の中に、変数_stringの値を埋め込みます。
Console.WriteLine($"Hello {_string}");

// >>> 実行結果
// Hello Hello World

// また、文字列補完では、変数の値だけでなく、計算結果を埋め込むこともできます。
// 例えば、以下のように記述すると、"Hello World"という文字列の中に、変数_stringの値と、変数_intの値を足した計算結果を埋め込みます。
var _int = 1;
Console.WriteLine($"Hello {_string} {_int + 1}");

// >>> 実行結果
// Hello Hello World 2

// また、文字列補完では、変数の値だけでなく、メソッドの戻り値を埋め込むこともできます。
// 例えば、以下のように記述すると、"Hello World"という文字列の中に、メソッドGetHelloWorldの戻り値を埋め込みます。
string GetHelloWorld()
{
  return "Hello World";
}
Console.WriteLine($"Hello {GetHelloWorld()}");

// >>> 実行結果
// Hello Hello World

// メソッドについては後ほど説明しますが、何らかの処理の集合体です。

// 文字列補完機能が搭載される前までは、以下のように記述していました。
Console.WriteLine("Hello " + _string);

// 少しダサいですね、、、
// もしくは、フォーマット関数を使用して以下のように記述することもできました。

// 例えば、以下のように記述すると、"Hello World"という文字列の中に、変数_stringの値を埋め込みます。
Console.WriteLine(string.Format("Hello {0}", _string));

// >>> 実行結果
// Hello Hello World

// また、以下のように記述すると、"Hello World"という文字列の中に、変数_stringの値と、変数_intの値を足した計算結果を埋め込みます。
Console.WriteLine(string.Format("Hello {0} {1}", _string, _int + 1));

// >>> 実行結果
// Hello Hello World 2

// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
// ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
// ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆
// ☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★

// 次に文字列型へのデータの変換について学習します。
// ToStringメソッドを使用することで、文字列型に変換することができます。

Console.WriteLine(111 + 222);
Console.WriteLine(111.ToString() + 222.ToString());

// >>> 実行結果
// 333
// 111222
