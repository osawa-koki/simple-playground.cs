using System.Globalization;
using System.Text;

// ここでは文字列に対する処理を学習します。

{
  // 文字列の連結
  string s1 = "Hello";
  string s2 = "World";
  string s3 = s1 + s2;
  Console.WriteLine($"s3: {s3}"); // HelloWorld

  // また、文字列以外のデータを文字列として連結するには、
  // Concat()メソッドを使用します。

  Console.WriteLine($"{string.Concat(s1, 1, 2, 3, s2)}"); // Hello123World

  // 文字から文字列を作成 (C like)
  string s4 = new string(new char[]
  {
    'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!'
  });
  Console.WriteLine(s4); // Hello World!

  string s5 = new string('x', 10);
  Console.WriteLine(s5); // xxxxxxxxxx
}
{
  // 文字列の比較
  // string.Compare()で文字列の大小を比較できます。
  // この方法では大文字と小文字を区別します。
  // 戻り値は、
  // 0: 同じ
  // 正: 左辺の方が大きい
  // 負: 右辺の方が大きい
  // となります。

  Console.WriteLine($"""string.Compare("abc", "abc") : {string.Compare("abc", "abc")}"""); // 0
  Console.WriteLine($"""string.Compare("abc", "ABC") : {string.Compare("abc", "ABC")}"""); // -1
  Console.WriteLine($"""string.Compare("ABC", "abc") : {string.Compare("ABC", "abc")}"""); // 1
  Console.WriteLine($"""string.Compare("abc", "abd") : {string.Compare("abc", "abd")}"""); // -1
  Console.WriteLine($"""string.Compare("abd", "abc") : {string.Compare("abd", "abc")}"""); // 1

  // string.Compare()の第3引数にtrueを指定すると、
  // 大文字と小文字を区別しない比較ができます。
  Console.WriteLine($"""string.Compare("abc", "ABC", true) : {string.Compare("abc", "ABC", true)}"""); // 0
  Console.WriteLine($"""string.Compare("abc", "ABC", false) : {string.Compare("abc", "ABC", false)}"""); // -1
  Console.WriteLine($"""string.Compare("ABC", "abc", false) : {string.Compare("ABC", "abc", false)}"""); // 1

  // string.Compare()の第3引数では、カルチャーを指定することができます。
  // Console.WriteLine($"""string.Compare("abc", "ABC", false, CultureInfo.CurrentCulture) : {string.Compare("abc", "ABC", false, CultureInfo.CurrentCulture)}"""); // 1
  // Console.WriteLine($"""string.Compare("abc", "ABC", false, CultureInfo.CurrentCulture) : {string.Compare("abc", "ABC", false, CultureInfo.CurrentCulture)}"""); // 1
  // 環境に依存するため、コメントアウトしています。

  // 第四引数では以下のオプションを指定して、比較設定を付すことができます。
  // これは、第三引数でカルチャーを指定した場合にのみ使用可能です。
  // ・ CompareOptions.IgnoreCase -> 大文字と小文字を区別しない
  // ・ CompareOptions.IgnoreKanaType -> ひらがなとカタカナを区別しない
  // ・ CompareOptions.IgnoreNonSpace -> 空白を無視する
  // ・ CompareOptions.IgnoreSymbols -> 記号を無視する
  // ・ CompareOptions.IgnoreWidth -> 全角と半角を区別しない
  // ・ CompareOptions.Ordinal -> 現在のカルチャーに基づいて比較する
  // ・ CompareOptions.StringSort -> 文字列をソートする
  // これらのオプションは、以下のように組み合わせることができます。
  // ・ CompareOptions.IgnoreCase | CompareOptions.IgnoreKanaType

  Console.WriteLine($"""string.Compare("abc", "ABC", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase) : {string.Compare("abc", "ABC", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase)}"""); // 0
  Console.WriteLine($"""string.Compare("あいう", "アイウ", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase) : {string.Compare("あいう", "アイウ", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase)}"""); // -1
  Console.WriteLine($"""string.Compare("あいう", "アイウ", CultureInfo.CurrentCulture, CompareOptions.IgnoreKanaType) : {string.Compare("あいう", "アイウ", CultureInfo.CurrentCulture, CompareOptions.IgnoreKanaType)}"""); // 0
  Console.WriteLine($"""string.Compare("ｱｲｳ", "アイウ", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase) : {string.Compare("ｱｲｳ", "アイウ", CultureInfo.CurrentCulture, CompareOptions.IgnoreCase)}"""); // 1
  Console.WriteLine($"""string.Compare("ｱｲｳ", "アイウ", CultureInfo.CurrentCulture, CompareOptions.IgnoreWidth) : {string.Compare("ｱｲｳ", "アイウ", CultureInfo.CurrentCulture, CompareOptions.IgnoreWidth)}"""); // 0

  // string.CompareOrdinal()は、文字列の大小を比較します。
  // ただし、大文字と小文字を区別せずに比較します。
  // また、現在のカルチャーに基づいて比較しません。
  Console.WriteLine($"""string.CompareOrdinal("abc", "ABC") : {string.CompareOrdinal("abc", "ABC")}"""); // 0
  Console.WriteLine($"""string.CompareOrdinal("abc", "abd") : {string.CompareOrdinal("abc", "abd")}"""); // -1
  Console.WriteLine($"""string.CompareOrdinal("abd", "abc") : {string.CompareOrdinal("abd", "abc")}"""); // 1

}
{
  //IsNullOrEmpty()は、文字列がnullまたは空文字列かどうかを判定します。
  Console.WriteLine($"""string.IsNullOrEmpty(null) : {string.IsNullOrEmpty(null)}"""); // True
  Console.WriteLine($"""string.IsNullOrEmpty("") : {string.IsNullOrEmpty("")}"""); // True
  Console.WriteLine($"""string.IsNullOrEmpty(" ") : {string.IsNullOrEmpty(" ")}"""); // False
  Console.WriteLine($"""string.IsNullOrEmpty("abc") : {string.IsNullOrEmpty("abc")}"""); // False

  // IsNullOrWhiteSpace()は、文字列がnullまたは空白文字列かどうかを判定します。
  Console.WriteLine($"""string.IsNullOrWhiteSpace(null) : {string.IsNullOrWhiteSpace(null)}"""); // True
  Console.WriteLine($"""string.IsNullOrWhiteSpace("") : {string.IsNullOrWhiteSpace("")}"""); // True
  Console.WriteLine($"""string.IsNullOrWhiteSpace(" ") : {string.IsNullOrWhiteSpace(" ")}"""); // True
  Console.WriteLine($"""string.IsNullOrWhiteSpace("abc") : {string.IsNullOrWhiteSpace("abc")}"""); // False
  
}
{
  // 文字数チェック
  // 文字列の文字数はlengthプロパティで確認できます。
  // ただし、lengthプロパティは、文字列のバイト数を返すため、
  // 日本語の文字列の場合は、文字数とは異なります。
  Console.WriteLine($"""string.Empty.Length : {string.Empty.Length}"""); // 0
  Console.WriteLine($""".Length : {"".Length}"""); // 0
  Console.WriteLine($""" " ".Length (半角スペース) : {" ".Length}"""); // 1
  Console.WriteLine($""" "　".Length (全角スペース) : {"　".Length}"""); // 1
  Console.WriteLine($""" "	".Length (水平タブ) : {"\t".Length}"""); // 1
  Console.WriteLine($""" "あ".Length : {"あ".Length}"""); // 1
  Console.WriteLine($""" "ｱ".Length : {"ｱ".Length}"""); // 1
  Console.WriteLine($""" "𩹉".Length (サロゲートペア文字) : {"𩹉".Length}"""); // 2

  // サロゲートペア文字が2バイトとして認識されていることが確認できます。
  // 文字コードってすごくめんどくさい、、、(´;ω;｀)

  // サロゲートペア文字にも対応するためには
  // LINQを使用して以下のように書く必要があります。

  Console.WriteLine($""" "ABC".Where(c => !char.IsLowSurrogate(c)).Count() : {"ABC".Where(c => !char.IsLowSurrogate(c)).Count()}"""); // 3
  Console.WriteLine($""" "あいう".Where(c => !char.IsLowSurrogate(c)).Count() : {"あいう".Where(c => !char.IsLowSurrogate(c)).Count()}"""); // 3
  Console.WriteLine($""" "𩹉𩹉𩹉".Where(c => !char.IsLowSurrogate(c)).Count() : {"𩹉𩹉𩹉".Where(c => !char.IsLowSurrogate(c)).Count()}"""); // 3

  // サロゲートペア文字とはJIS第三水準・JIS第四水準に含まれる文字のことです。
  // また、絵文字もサロゲートペア文字です。

  // ちなみに、サロゲートペア文字の文字コードは以下のようになります。
  // 1文字目の文字コードは、0xD800～0xDBFFの範囲になります。
  // 2文字目の文字コードは、0xDC00～0xDFFFの範囲になります。
  // 1文字目の文字コードと2文字目の文字コードを組み合わせることで、
  // サロゲートペア文字の文字コードを取得できます。

}
{
  // 指定した文字が出現する位置を取得するには以下のメソッドを使用します。
  // IndexOf()は、指定した文字が最初に出現する位置を取得します。
  // LastIndexOf()は、指定した文字が最後に出現する位置を取得します。
  // ただし、文字列がnullまたは空文字列の場合は、-1を返します。
  // また、指定した文字が見つからない場合は、-1を返します。

  Console.WriteLine($"""string.Empty.IndexOf('a') : {string.Empty.IndexOf('a')}"""); // -1
  Console.WriteLine($""" "".IndexOf('a') : {"".IndexOf('a')}"""); // -1
  Console.WriteLine($""" "abc".IndexOf('a') : {"abc".IndexOf('a')}"""); // 0
  Console.WriteLine($""" "abc".IndexOf('b') : {"abc".IndexOf('b')}"""); // 1
  Console.WriteLine($""" "abc".IndexOf('c') : {"abc".IndexOf('c')}"""); // 2
  Console.WriteLine($""" "abc".IndexOf('d') : {"abc".IndexOf('d')}"""); // -1

}
{
  // 特殊な文字を扱う際にはエスケープシーケンスを使用する方法と「\u+0000」などのユニコード文字指定をする方法があります。
  // ユニコード文字指定は、文字列の中にユニコード文字を直接記述する方法です。

  Console.WriteLine($""" "abc\u0020def" : {"abc\u0020def"}"""); // abc def

  // 例えば🥺のユニコードは「\U0001f97a」ですので、これを文字列内に記述します。

  Console.WriteLine($""" "🥺" : {"\U0001f97a"}"""); // 🥺

  // また、エスケープシーケンスには以下のものがあります。
  // \t : 水平タブ
  // \n : 改行
  // \r : 復帰
  // \f : 改ページ
  // \v : 垂直タブ
  // \b : バックスペース
  // \a : 警告音
  // \0 : 終端文字
  // \\ : バックスラッシュ
  // \' : シングルクォーテーション
  // \" : ダブルクォーテーション
  
}
{
  // 文字列の一部を抜き出すには、
  // Substring()メソッドを使用します。
  // このメソッドは、指定した位置から指定した長さ分の文字列を抜き出します。
  // ただし、文字列がnullまたは空文字列の場合は、空文字列を返します。
  // また、指定した位置が文字列の長さを超えている場合は、例外が発生します。
  // 一般的にはLengthプロパティを指定して、範囲を超えないようにします。

  Console.WriteLine($""" "abc".Substring(0, "abc".Length) : {"abc".Substring(0, "abc".Length)}"""); // abc
  Console.WriteLine($""" "abc".Substring(1, "abc".Length - 1) : {"abc".Substring(1, "abc".Length - 1)}"""); // bc
  Console.WriteLine($""" "abc".Substring(2, "abc".Length - 2) : {"abc".Substring(2, "abc".Length - 2)}"""); // c

}
{
  // 前後の空白類似文字を削除するには
  // Trim()メソッドを使用します。
  // このメソッドは、文字列の前後の空白類似文字を削除した文字列を返します。
  // ただし、文字列がnullまたは空文字列の場合は、空文字列を返します。

  Console.WriteLine($""" "".Trim() : {"".Trim()}"""); // ""
  Console.WriteLine($""" " ".Trim() : {" ".Trim()}"""); // ""
  Console.WriteLine($""" "　".Trim() : {"　".Trim()}"""); // ""
  Console.WriteLine($""" "a".Trim() : {"a".Trim()}"""); // a
  Console.WriteLine($""" " a".Trim() : {" a".Trim()}"""); // a
  Console.WriteLine($""" "　a".Trim() : {"　a".Trim()}"""); // a
  Console.WriteLine($""" "a ".Trim() : {"a ".Trim()}"""); // a
  Console.WriteLine($""" "a　".Trim() : {"a　".Trim()}"""); // a
  Console.WriteLine($""" " a ".Trim() : {" a ".Trim()}"""); // a
  Console.WriteLine($""" "　a　".Trim() : {"　a　".Trim()}"""); // a

  // 右側だけ、左側だけの空白類似文字を削除するには
  // TrimEnd()メソッド、TrimStart()メソッドを使用します。

  Console.WriteLine($""" "".TrimStart() : {"".TrimStart()}"""); // ""
  Console.WriteLine($""" " ".TrimStart() : {" ".TrimStart()}"""); // ""
  Console.WriteLine($""" "　".TrimStart() : {"　".TrimStart()}"""); // ""
  Console.WriteLine($""" "a".TrimStart() : {"a".TrimStart()}"""); // a
  Console.WriteLine($""" " a".TrimStart() : {" a".TrimStart()}"""); // a
  Console.WriteLine($""" "　a".TrimStart() : {"　a".TrimStart()}"""); // a
  Console.WriteLine($""" "a ".TrimStart() : {"a ".TrimStart()}"""); // a<スペース>
  Console.WriteLine($""" "a　".TrimStart() : {"a　".TrimStart()}"""); // a<全角スペース>
  Console.WriteLine($""" " a ".TrimStart() : {" a ".TrimStart()}"""); // a<スペース>
  Console.WriteLine($""" "　a　".TrimStart() : {"　a　".TrimStart()}"""); // a<全角スペース>

  Console.WriteLine($""" "".TrimEnd() : {"".TrimEnd()}"""); // ""
  Console.WriteLine($""" " ".TrimEnd() : {" ".TrimEnd()}"""); // ""
  Console.WriteLine($""" "　".TrimEnd() : {"　".TrimEnd()}"""); // ""
  Console.WriteLine($""" "a".TrimEnd() : {"a".TrimEnd()}"""); // a
  Console.WriteLine($""" " a".TrimEnd() : {" a".TrimEnd()}"""); // <スペース>a
  Console.WriteLine($""" "　a".TrimEnd() : {"　a".TrimEnd()}"""); // <全角スペース>a
  Console.WriteLine($""" "a ".TrimEnd() : {"a ".TrimEnd()}"""); // a
  Console.WriteLine($""" "a　".TrimEnd() : {"a　".TrimEnd()}"""); // a
  Console.WriteLine($""" " a ".TrimEnd() : {" a ".TrimEnd()}"""); // <スペース>a
  Console.WriteLine($""" "　a　".TrimEnd() : {"　a　".TrimEnd()}"""); // <全角スペース>a
}
{
  // 文字列から指定した位置以降の文字列を削除するには、
  // Remove()メソッドを使用します。

  Console.WriteLine($""" "abc".Remove(0) : {"".Remove(0)}"""); // 
  Console.WriteLine($""" "abc".Remove(1) : {"abc".Remove(1)}"""); // a
  Console.WriteLine($""" "abc".Remove(2) : {"abc".Remove(2)}"""); // ab

}
{
  // 文字列の一部を置換するには、
  // Replace()メソッドを使用します。

  Console.WriteLine($""" "abc".Replace("a", "A") : {"abc".Replace("a", "A")}"""); // Abc
  Console.WriteLine($""" "abc".Replace("b", "B") : {"abc".Replace("b", "B")}"""); // aBc
  Console.WriteLine($""" "abc".Replace("c", "C") : {"abc".Replace("c", "C")}"""); // abC
  Console.WriteLine($""" "abc".Replace("ab", "AB") : {"abc".Replace("ab", "AB")}"""); // ABC
  Console.WriteLine($""" "abc".Replace("bc", "BC") : {"abc".Replace("bc", "BC")}"""); // aBC
  Console.WriteLine($""" "abc".Replace("abc", "ABC") : {"abc".Replace("abc", "ABC")}"""); // ABC

  // また、置換後文字列に空文字を指定することで、
  // 文字列の一部を削除することもできます。

  Console.WriteLine($""" "abc".Replace("a", String.Empty) : {"abc".Replace("a", String.Empty)}"""); // bc
  Console.WriteLine($""" "abc".Replace("b", String.Empty) : {"abc".Replace("b", String.Empty)}"""); // ac
  Console.WriteLine($""" "abc".Replace("c", String.Empty) : {"abc".Replace("c", String.Empty)}"""); // ab
  Console.WriteLine($""" "abc".Replace("ab", String.Empty) : {"abc".Replace("ab", String.Empty)}"""); // c
  Console.WriteLine($""" "abc".Replace("bc", String.Empty) : {"abc".Replace("bc", String.Empty)}"""); // a
  Console.WriteLine($""" "abc".Replace("abc", String.Empty) : {"abc".Replace("abc", String.Empty)}"""); //
  
}
{
  // 文字列と配列を変換するには、
  // Split()メソッドとJoin()メソッドを使用します。

  // Splitメソッドでは指定して区切り文字によって文字列を分割します。
  // 戻り値は分割された文字列の配列です。

  var split = "a,b,c".Split(',');
  Console.WriteLine($""" "a,b,c".Split(',') : {split[0]}, {split[1]}, {split[2]}"""); // a, b, c

  // Joinメソッドでは指定した区切り文字で配列の要素を連結します。
  // 戻り値は連結された文字列です。

  var join = String.Join(",", split);
  Console.WriteLine($""" String.Join(",", split) : {join}"""); // a, b, c

  // また、Splitメソッドの第二引数に分割する回数を指定することができます。

  split = "a,b,c".Split(',', 2);
  Console.WriteLine($""" "a,b,c".Split(',', 2) : {split[0]}, {split[1]}"""); // a, b,c
  
  // 配列については後ほど説明します。
  // ここでは、複数のデータの集合と覚えてください。
  
}
{
  // 次に、文字列のバイトの相互変換を学習します。

  // 文字列からバイトに変換するには、指定したエンコードのGetBytes()メソッドを使用します。
  // 戻り値はバイトの配列です。

  var bytes = Encoding.UTF8.GetBytes("abc");
  Console.WriteLine($""" Encoding.UTF8.GetBytes("abc") : {bytes[0]}, {bytes[1]}, {bytes[2]}"""); // 97, 98, 99

  // バイトから文字列に変換するには、指定したエンコードのGetString()メソッドを使用します。
  // 戻り値は文字列です。

  var str = Encoding.UTF8.GetString(bytes);
  Console.WriteLine($""" Encoding.UTF8.GetString(bytes) : {str}"""); // abc

  // バイト型については後ほど説明します。
}
