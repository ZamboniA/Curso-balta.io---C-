using System;
using System.Globalization;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // var data = new DateTime();
            var data = DateTime.Now;
            // var data = new DateTime(2020, 10, 12, 13, 23, 14);


            // Console.WriteLine(data);
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.Hour);
            // Console.WriteLine(data.Minute);
            // Console.WriteLine(data.Second);

            // var formatData = string.Format("{0:yyyy}", data);
            // var formatData = string.Format("{0:yyyy/MM/dd}", data);
            // var formatData = string.Format("{0:yy}", data);
            // var formatData = string.Format("{0:dd*MM*yyyy}", data);
            // var formatData = string.Format("{0:dd/MM/yyyy}", data);
            // var formatData = string.Format("{0:t}", data);
            // var formatData = string.Format("{0:d}", data);
            // var formatData = string.Format("{0:g}", data);
            // var formatData = string.Format("{0:r}", data);
            // var formatData = string.Format("{0:u}", data);

            // var dia = data.AddDays(12);
            // var mes = data.AddMonths(1);
            // DateTime? data = null;
            // https://balta.io/blog/datetime-csharp-dotnet

            // if (data.Date == DateTime.Now.Date)
            // {
            //     Console.WriteLine("é igual");
            // }


            var br = new CultureInfo("pt-BR");
            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");

            var dateTime = DateTime.UtcNow;

            // Console.WriteLine(data.ToString("G", de));



            // Console.WriteLine(dateTime);
            // Console.WriteLine(dateTime.ToLocalTime());


            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");

            // Console.WriteLine(timezoneAustralia);

            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
            // Console.WriteLine(horaAustralia);

            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // Console.WriteLine(timezones);

            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
            //     Console.WriteLine("-----");
            // }

            // var timeSpan = new TimeSpan();
            // Console.WriteLine(timeSpan);

            // var timeSpanNanoSeg = new TimeSpan(1);
            // Console.WriteLine(timeSpanNanoSeg);

            // var timeDiaHoraSeg = new TimeSpan(15, 12, 5);
            // Console.WriteLine(timeDiaHoraSeg);


            Console.WriteLine(DateTime.DaysInMonth(2020, 2));

            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }

    }
}
