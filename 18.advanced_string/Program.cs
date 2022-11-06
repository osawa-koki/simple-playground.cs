using System.Globalization;

// ここでは文字列に対する処理を学習します。

{
  // 文字列の連結
  string s1 = "Hello";
  string s2 = "World";
  string s3 = s1 + s2;
  Console.WriteLine($"s3: {s3}"); // HelloWorld

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


