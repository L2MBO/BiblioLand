using System;

namespace Biblio.Classes.Validation
{
    internal class TimeValidation
    {
        private static string GetRussianNounForm(int number, string form1, string form2, string form3)
        {
            number = Math.Abs(number) % 100;
            int num1 = number % 10;

            if (number > 10 && number < 20)
                return form3;
            if (num1 > 1 && num1 < 5)
                return form2;
            if (num1 == 1)
                return form1;

            return form3;
        }

        public static string FormatTimeAgo(TimeSpan timeDifference)
        {
            if (timeDifference.TotalSeconds < 60)
            {
                return "только что";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                int minutes = (int)timeDifference.TotalMinutes;
                return $"{minutes} {GetRussianNounForm(minutes, "минуту", "минуты", "минут")} назад";
            }
            else if (timeDifference.TotalHours < 24)
            {
                int hours = (int)timeDifference.TotalHours;
                return $"{hours} {GetRussianNounForm(hours, "час", "часа", "часов")} назад";
            }
            else
            {
                int days = (int)timeDifference.TotalDays;
                return $"{days} {GetRussianNounForm(days, "день", "дня", "дней")} назад";
            }
        }
    }
}
