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
{
  // DateTime型のデータから、それぞれの構成要素を取得することができます。
  // 以下のプロパティを使用します。
  // Year : 年
  // Month : 月
  // Day : 日
  // Hour : 時間
  // Minute : 分
  // Second : 秒
  // Millisecond : ミリ秒
  // DayOfWeek : 曜日
  // DayOfYear : 1月1日からの経過日数

  DateTime dt = new(1998, 10, 25, 12, 34, 56, 789);

  Console.WriteLine($"dt.Year -> {dt.Year}");

  // >>> コンソール
  // dt.Year -> 1998

  Console.WriteLine($"dt.Month -> {dt.Month}");

  // >>> コンソール
  // dt.Month -> 10

  Console.WriteLine($"dt.Day -> {dt.Day}");

  // >>> コンソール
  // dt.Day -> 25

  Console.WriteLine($"dt.Hour -> {dt.Hour}");

  // >>> コンソール
  // dt.Hour -> 12

  Console.WriteLine($"dt.Minute -> {dt.Minute}");

  // >>> コンソール
  // dt.Minute -> 34

  Console.WriteLine($"dt.Second -> {dt.Second}");

  // >>> コンソール
  // dt.Second -> 56

  Console.WriteLine($"dt.Millisecond -> {dt.Millisecond}");

  // >>> コンソール
  // dt.Millisecond -> 789

  Console.WriteLine($"dt.DayOfWeek -> {dt.DayOfWeek}");

  // >>> コンソール
  // dt.DayOfWeek -> Friday

  Console.WriteLine($"dt.DayOfYear -> {dt.DayOfYear}");

  // >>> コンソール
  // dt.DayOfYear -> 298

  // ===== ===== ===== ===== =====
  // ちなみに、曜日は、以下のように取得することもできます。
  // ===== ===== ===== ===== =====

  Console.WriteLine($"dt.ToString(\"ddd\") -> {dt.ToString("ddd")}");

  // >>> コンソール
  // dt.ToString("ddd") -> Fri

  Console.WriteLine($"dt.ToString(\"dddd\") -> {dt.ToString("dddd")}");

  // >>> コンソール
  // dt.ToString("dddd") -> Friday

  // ===== ===== ===== ===== =====

  // もっと簡単に!

  Console.WriteLine($"dt.ToString(\"ddd\") -> {dt:ddd}");

  // >>> コンソール
  // dt.ToString("ddd") -> Fri

  Console.WriteLine($"dt.ToString(\"dddd\") -> {dt:dddd}");

  // >>> コンソール
  // dt.ToString("dddd") -> Friday

  // ===== ===== ===== ===== =====

  // 僕は金曜日に生まれたらしいです。
  // 華金ですね♪
  // 僕が生まれた時代に華金って言葉があったのかは知りませんが、、、
}
{
  // 日付型の比較
  // DateTime型のデータは、比較演算子を使用して比較することができます。
  // 以下の演算子を使用します。
  // == : 等しい
  // != : 等しくない
  // < : より小さい
  // > : より大きい
  // <= : 以下
  // >= : 以上

  DateTime dt1 = new(1998, 10, 25, 12, 34, 56, 789);
  DateTime dt2 = new(1998, 10, 25, 12, 34, 56, 789);

  Console.WriteLine($"dt1 == dt2 -> {dt1 == dt2}");

  // >>> コンソール
  // dt1 == dt2 -> True

  Console.WriteLine($"dt1 != dt2 -> {dt1 != dt2}");

  // >>> コンソール
  // dt1 != dt2 -> False

  Console.WriteLine($"dt1 < dt2 -> {dt1 < dt2}");

  // >>> コンソール
  // dt1 < dt2 -> False

  Console.WriteLine($"dt1 > dt2 -> {dt1 > dt2}");

  // >>> コンソール
  // dt1 > dt2 -> False

  Console.WriteLine($"dt1 <= dt2 -> {dt1 <= dt2}");

  // >>> コンソール
  // dt1 <= dt2 -> True

  Console.WriteLine($"dt1 >= dt2 -> {dt1 >= dt2}");

  // >>> コンソール
  // dt1 >= dt2 -> True

  // ちなみに、DateTime型のデータは、以下のように比較することもできます。
  // ただし、この方法は、DateTime型のデータを、long型に変換してから比較しているので、
  // あまり推奨されません。

  Console.WriteLine($"dt1.Ticks == dt2.Ticks -> {dt1.Ticks == dt2.Ticks}");

  // >>> コンソール
  // dt1.Ticks == dt2.Ticks -> True

  // ちなみに、Ticksは、1970年1月1日0時0分0秒からの経過時間を100ナノ秒単位で表した値です。
  // つまり、DateTime型のデータをlong型に変換すると、Ticksの値が取得できます。
  // 以下のように、Ticksの値を取得することができます。

  Console.WriteLine($"dt1.Ticks -> {dt1.Ticks}");

  // >>> コンソール
  // dt1.Ticks -> 630449156967890000

  // これを、100ナノ秒単位で表した値に変換すると、以下のようになります。

  Console.WriteLine($"dt1.Ticks / 10000000 -> {dt1.Ticks / 10000000}");

  // >>> コンソール
  // dt1.Ticks / 10000000 -> 63044915696

  // これを、秒単位で表した値に変換すると、以下のようになります。

  Console.WriteLine($"dt1.Ticks / 10000000 / 60 / 60 / 24 -> {dt1.Ticks / 10000000 / 60 / 60 / 24}");

  // >>> コンソール
  // dt1.Ticks / 10000000 / 60 / 60 / 24 -> 729686

  // これを、日単位で表した値に変換すると、以下のようになります。

  Console.WriteLine($"dt1.Ticks / 10000000 / 60 / 60 / 24 / 365 -> {dt1.Ticks / 10000000 / 60 / 60 / 24 / 365}");

  // >>> コンソール
  // dt1.Ticks / 10000000 / 60 / 60 / 24 / 365 -> 1999
}
