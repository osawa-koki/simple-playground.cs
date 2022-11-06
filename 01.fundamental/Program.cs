
// ここではC#の基礎を学習します。
// C#ではバージョン9.0からトップレベルステートメントが使用できるようになりました。 (ref: https://learn.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-9#top-level-statements)
// トップレベルステートメントを使用すると、プログラムのエントリーポイントとなるMainメソッドを定義する必要がなくなります。
//
// 従来は「Hello World」プログラムを作成する際に、以下のようにMainメソッドを定義する必要がありました。
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World!");
//     }
// }
//
// しかし、C#9.0からは以下のようにトップレベルステートメントを使用することで、Mainメソッドを定義する必要がなくなりました。
// 以下のように1行で実現できます。
//
// Console.WriteLine("Hello World!");
//
// ここでは原則として「Program.cs」をプログラムのエントリポイントとし、
// トップレベルステートメントを使用してプログラムを作成していきます。


// 最初にコンソール画面に文字を出力してみましょう♪
// 以下のように「Console.WriteLine」メソッドを使用して、コンソール画面に文字を出力することができます。
// このメソッドは、引数に指定した文字列をコンソール画面に出力します。
// 以下のように「"Hello World!"」という文字列を出力してみましょう。

Console.WriteLine("Hello World!");
// >>> Hello World!
