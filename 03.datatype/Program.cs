// ここでは、データ型について学習します。
// データ型とは、そのデータがどのようなデータかを示すものです。
// データ型には、整数型、浮動小数点型、文字型、論理型などがあります。
// それぞれのデータ型には、そのデータ型に対応するデータを扱うための変数があります。
// 詳しいデータ型についての説明は公式ドキュメントを参照してください。
// ref: https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/built-in-types
//
// また、データ型には、値型と参照型があります。
// 値型は、そのデータを直接格納するデータ型です。
// 参照型は、そのデータを格納するメモリのアドレスを格納するデータ型です。
// これらの違いについては、後ほど学習します。

// では、それぞれのデータ型の変数を宣言してみましょう。

int _int;
float _float;
double _double;
char _char;
bool _bool;
string _string;

// それぞれの変数に、値を代入してみましょう。

_int = 1;
_float = 1.0f;
_double = 1.0;
_char = 'a';
_bool = true;
_string = "Hello World";

// それぞれの変数の値を表示してみましょう。

Console.WriteLine(_int);
Console.WriteLine(_float);
Console.WriteLine(_double);
Console.WriteLine(_char);
Console.WriteLine(_bool);
Console.WriteLine(_string);

// >>> 実行結果
// 1
// 1
// 1
// a
// True
// Hello World