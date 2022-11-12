using System.Globalization;


{
  // 日付型の作成

  DateTime dt_1 = new(1998, 10, 25);
  Console.WriteLine($"new DateTime(1998, 10, 25) -> {dt_1}");

  // >>> コンソール
  // new DateTime(1998, 10, 25) -> 1998/10/25 0:00:00

  DateTime dt_2 = new(1998, 10, 25, 12, 34, 56);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56) -> {dt_2}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56) -> 1998/10/25 12:34:56

  DateTime dt_3 = new(1998, 10, 25, 12, 34, 56, 789);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56, 789) -> {dt_3}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56, 789) -> 1998/10/25 12:34:56.789

  DateTime dt_4 = new(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Local);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Local) -> {dt_4}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Local) -> 1998/10/25 12:34:56.789

  DateTime dt_5 = new(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Utc);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Utc) -> {dt_5}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Utc) -> 1998/10/25 12:34:56.789

  DateTime dt_6 = new(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Unspecified);
  Console.WriteLine($"new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Unspecified) -> {dt_6}");

  // >>> コンソール
  // new DateTime(1998, 10, 25, 12, 34, 56, 789, DateTimeKind.Unspecified) -> 1998/10/25 12:34:56.789
}
{
  // 日付型へのパース

  DateTime dt_1 = DateTime.Parse("1998/10/25");
  Console.WriteLine($"DateTime.Parse(\"1998/10/25\") -> {dt_1}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25") -> 1998/10/25 0:00:00

  DateTime dt_2 = DateTime.Parse("1998/10/25 12:34:56");
  Console.WriteLine($"DateTime.Parse(\"1998/10/25 12:34:56\") -> {dt_2}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25 12:34:56") -> 1998/10/25 12:34:56

  DateTime dt_3 = DateTime.Parse("1998/10/25 12:34:56.789");
  Console.WriteLine($"DateTime.Parse(\"1998/10/25 12:34:56.789\") -> {dt_3}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25 12:34:56.789") -> 1998/10/25 12:34:56.789

  DateTime dt_4 = DateTime.Parse("1998/10/25 12:34:56.789 +09:00");
  Console.WriteLine($"DateTime.Parse(\"1998/10/25 12:34:56.789 +09:00\") -> {dt_4}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25 12:34:56.789 +09:00") -> 1998/10/25 12:34:56.789

  DateTime dt_5 = DateTime.Parse("1998/10/25 12:34:56.789 +09:00", null, DateTimeStyles.AssumeUniversal);
  Console.WriteLine($"DateTime.Parse(\"1998/10/25 12:34:56.789 +09:00\", null, DateTimeStyles.AssumeUniversal) -> {dt_5}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25 12:34:56.789 +09:00", null) -> 1998/10/25 12:34:56.789
}
{
  // コンストラクタの第二引数に対象となるタイムゾーンを指定することもできます。

  DateTime dt_1 = DateTime.Parse("1998/10/25", new CultureInfo("ja-JP"));
  Console.WriteLine($"DateTime.Parse(\"1998/10/25\", new CultureInfo(\"ja-JP\")) -> {dt_1}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25", new CultureInfo("ja-JP")) -> 1998/10/25 0:00:00

  DateTime dt_2 = DateTime.Parse("1998/10/25 12:34:56", new CultureInfo("ja-JP"));
  Console.WriteLine($"DateTime.Parse(\"1998/10/25 12:34:56\", new CultureInfo(\"ja-JP\")) -> {dt_2}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25 12:34:56", new CultureInfo("ja-JP")) -> 1998/10/25 12:34:56

  DateTime dt_3 = DateTime.Parse("1998/10/25 12:34:56.789", new CultureInfo("ja-JP"));
  Console.WriteLine($"DateTime.Parse(\"1998/10/25 12:34:56.789\", new CultureInfo(\"ja-JP\")) -> {dt_3}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25 12:34:56.789", new CultureInfo("ja-JP")) -> 1998/10/25 12:34:56.789

  DateTime dt_4 = DateTime.Parse("1998/10/25 12:34:56.789 +09:00", new CultureInfo("ja-JP"));
  Console.WriteLine($"DateTime.Parse(\"1998/10/25 12:34:56.789 +09:00\", new CultureInfo(\"ja-JP\")) -> {dt_4}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25 12:34:56.789 +09:00", new CultureInfo("ja-JP")) -> 1998/10/25 12:34:56.789

  DateTime dt_5 = DateTime.Parse("1998/10/25 12:34:56.789 +09:00", new CultureInfo("ja-JP"), DateTimeStyles.AssumeUniversal);
  Console.WriteLine($"DateTime.Parse(\"1998/10/25 12:34:56.789 +09:00\", new CultureInfo(\"ja-JP\"), DateTimeStyles.AssumeUniversal) -> {dt_5}");

  // >>> コンソール
  // DateTime.Parse("1998/10/25 12:34:56.789 +09:00", new CultureInfo("ja-JP"), DateTimeStyles.AssumeUniversal) -> 1998/10/25 12:34:56.789
}
{
  // TryParseを使用したパースをすることで、パース成功失敗の判断をすることができます。
  // パースに成功した場合は、パース結果を返し、失敗した場合は、DateTime.MinValueを返します。

  DateTime dt_1;
  if (DateTime.TryParse("1998/10/25", out dt_1))
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25\", out dt_1) -> {dt_1}");
  }
  else
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25\", out dt_1) -> {dt_1}");
  }

  // >>> コンソール
  // DateTime.TryParse("1998/10/25", out dt_1) -> 1998/10/25 0:00:00

  DateTime dt_2;
  if (DateTime.TryParse("1998/10/25 12:34:56", out dt_2))
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25 12:34:56\", out dt_2) -> {dt_2}");
  }
  else
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25 12:34:56\", out dt_2) -> {dt_2}");
  }

  // >>> コンソール
  // DateTime.TryParse("1998/10/25 12:34:56", out dt_2) -> 1998/10/25 12:34:56

  DateTime dt_3;
  if (DateTime.TryParse("1998/10/25 12:34:56.789", out dt_3))
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25 12:34:56.789\", out dt_3) -> {dt_3}");
  }
  else
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25 12:34:56.789\", out dt_3) -> {dt_3}");
  }

  // >>> コンソール
  // DateTime.TryParse("1998/10/25 12:34:56.789", out dt_3) -> 1998/10/25 12:34:56.789

  DateTime dt_4;
  if (DateTime.TryParse("1998/10/25 12:34:56.789 +09:00", out dt_4))
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25 12:34:56.789 +09:00\", out dt_4) -> {dt_4}");
  }
  else
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25 12:34:56.789 +09:00\", out dt_4) -> {dt_4}");
  }

  // >>> コンソール
  // DateTime.TryParse("1998/10/25 12:34:56.789 +09:00", out dt_4) -> 1998/10/25 12:34:56.789

  DateTime dt_5;
  if (DateTime.TryParse("1998/10/25 12:34:56.789 +09:00", out dt_5))
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25 12:34:56.789 +09:00\", out dt_5) -> {dt_5}");
  }
  else
  {
    Console.WriteLine($"DateTime.TryParse(\"1998/10/25 12:34:56.789 +09:00\", out dt_5) -> {dt_5}");
  }

  // >>> コンソール
  // DateTime.TryParse("1998/10/25 12:34:56.789 +09:00", out dt_5) -> 1998/10/25 12:34:56.789

  DateTime dt_6;
  if (DateTime.TryParse("Hello World", out dt_6))
  {
    Console.WriteLine($"DateTime.TryParse(\"Hello World\", out dt_6) -> {dt_6}");
  }
  else
  {
    Console.WriteLine($"[failed] DateTime.TryParse(\"Hello World\", out dt_6) -> {dt_6}");
  }

  // >>> コンソール
  // DateTime.TryParse("[failed] Hello World", out dt_6) -> 0001/01/01 0:00:00
}
{
  // 日付型を文字列に変換するには、ToStringメソッドを使用します。
  // ToStringメソッドは、オーバーロードされているため、引数を指定することで、変換するフォーマットを指定することができます。
  // ToStringメソッドの引数では、以下のようなフォーマットを指定することができます。
  // y : 年
  // M : 月
  // d : 日
  // H : 時
  // m : 分
  // s : 秒
  // f : ミリ秒
  // t : 時刻の区切り文字
  // z : タイムゾーン

  DateTime dt = new(1998, 10, 25, 12, 34, 56, 789);

  Console.WriteLine($"dt.ToString(\"yyyy/MM/dd HH:mm:ss.fff\") -> {dt.ToString("yyyy/MM/dd HH:mm:ss.fff")}");

  // >>> コンソール
  // dt.ToString("yyyy/MM/dd HH:mm:ss.fff") -> 1998/10/25 12:34:56.789

  Console.WriteLine($"dt.ToString(\"yyyy/MM/dd HH:mm:ss.fff zzz\") -> {dt.ToString("yyyy/MM/dd HH:mm:ss.fff zzz")}");

  // >>> コンソール
  // dt.ToString("yyyy/MM/dd HH:mm:ss.fff zzz") -> 1998/10/25 12:34:56.789 +09:00

  Console.WriteLine($"dt.ToString(\"yyyy-MM-dd HH:mm:ss.fff\") -> {dt.ToString("yyyy-MM-dd HH:mm:ss.fff")}");

  // >>> コンソール
  // dt.ToString("yyy-/MM-dd HH:mm:ss.fff") -> 1998-10-25 12:34:56.789

  // ===== ===== ===== ===== =====
  // ちなみに、省略記法が使えます。
  // ===== ===== ===== ===== =====

  Console.WriteLine($"dt.ToString(\"yyyy/MM/dd HH:mm:ss.fff\") -> {dt:yyyy/MM/dd HH:mm:ss.fff}");

  // >>> コンソール
  // dt.ToString("yyyy/MM/dd HH:mm:ss.fff") -> 1998/10/25 12:34:56.789
}
