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

  // ===== ===== ===== ===== =====

  // 現在の日付データは以下のように作成できます。

  DateTime dt_7 = DateTime.Now;
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
{
  // TimeSpane型
  // TimeSpan型は、時間を表す型です。
  // TimeSpan型のデータは、以下のように生成することができます。

  TimeSpan ts1 = new(1, 2, 3, 4, 5);

  // この場合、1日2時間3分4秒5ミリ秒を表すTimeSpan型のデータが生成されます。

  Console.WriteLine($"ts1 -> {ts1}");

  // >>> コンソール
  // ts1 -> 1.02:03:04.0050000

  // ===== ===== ===== ===== =====

  // これを使用して2つの日付間の差分を取得しましょう♪

  DateTime dt1 = new(1998, 10, 25, 12, 34, 56, 789);
  DateTime dt2 = DateTime.Now;

  TimeSpan ts_frommybirth = dt2 - dt1;

  Console.WriteLine($"ts2 -> {ts_frommybirth}");

  // >>> コンソール
  // ts2 -> *****

  // ===== ===== ===== ===== =====

  // TimeSpan型は足し算と引き算が可能です。

  TimeSpan ts2 = new(1, 2, 3, 4, 5);
  TimeSpan ts3 = new(2, 3, 4, 5, 6);

  Console.WriteLine($"ts2 + ts3 -> {ts2 + ts3}");

  // >>> コンソール
  // ts2 + ts3 -> 3.05:07:09.0110000

  Console.WriteLine($"ts2 - ts3 -> {ts2 - ts3}");

  // >>> コンソール
  // ts2 - ts3 -> -1.01:01:01.0010000
}
{
  // ある日付データを基に、一定期間前(後)の日付を算出してみましょう♪
  // Add***メソッドを使用します。
  // 負の値を指定することで、「前」を表現できます。
  //
  // メソッドには以下の種類があります。
  // AddYears : 年
  // AddMonths : 月
  // AddDays : 日
  // AddHours : 時
  // AddMinutes : 分
  // AddSeconds : 秒
  // AddMilliseconds : ミリ秒
  // AddTicks : Ticks

  DateTime dt1 = new(1998, 10, 25, 12, 34, 56, 789);

  // 1日前の日付を算出する場合
  DateTime dt2 = dt1.AddDays(-1);

  Console.WriteLine($"dt2 -> {dt2}");

  // >>> コンソール
  // dt2 -> 1998/10/24 12:34:56

  // 1時間後の日付を算出する場合
  DateTime dt3 = dt1.AddHours(1);

  Console.WriteLine($"dt3 -> {dt3}");

  // >>> コンソール
  // dt3 -> 1998/10/25 13:34:56

  // 1分前の日付を算出する場合
  DateTime dt4 = dt1.AddMinutes(-1);

  Console.WriteLine($"dt4 -> {dt4}");

  // >>> コンソール
  // dt4 -> 1998/10/25 12:33:56

  // 1秒後の日付を算出する場合
  DateTime dt5 = dt1.AddSeconds(1);

  Console.WriteLine($"dt5 -> {dt5}");

  // >>> コンソール
  // dt5 -> 1998/10/25 12:34:57

  // 1ミリ秒前の日付を算出する場合
  DateTime dt6 = dt1.AddMilliseconds(-1);

  Console.WriteLine($"dt6 -> {dt6}");

  // >>> コンソール
  // dt6 -> 1998/10/25 12:34:56.7880000
}
{
  // DateTime型とTimeSpan型の演算
  // DateTime型とTimeSpan型は、演算が可能です。

  DateTime dt1 = new(1998, 10, 25, 12, 34, 56, 789);
  TimeSpan ts1 = new(1, 2, 3, 4, 5);

  // DateTime型 + TimeSpan型
  DateTime dt2 = dt1 + ts1;

  Console.WriteLine($"dt2 -> {dt2}");

  // >>> コンソール
  // dt2 -> 1999/10/26 14:38:00.7940000

  // DateTime型 - TimeSpan型
  DateTime dt3 = dt1 - ts1;

  Console.WriteLine($"dt3 -> {dt3}");

  // >>> コンソール
  // dt3 -> 1997/10/24 10:31:52.7840000
}
