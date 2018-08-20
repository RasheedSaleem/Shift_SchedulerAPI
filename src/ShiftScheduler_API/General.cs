using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftScheduler_API
{
    public static class General
    {
        public static List<DateTime> GetScheduleDate(int NoOfBuissnessDays)
        {
            List<DateTime> ddlistDates = new List<DateTime>();
            DateTime today = DateTime.Today;
            int currentDayOfWeek = (int)today.DayOfWeek;
            DateTime sunday = today.AddDays(-currentDayOfWeek);
            DateTime monday = sunday.AddDays(1);
            if (currentDayOfWeek == 0)
            {
                monday = monday.AddDays(-7);
            }
           // var dates = Enumerable.Range(0, 12).Select(days => monday.AddDays(days)).ToList();
            int i = 0;
            while (i < NoOfBuissnessDays)
            {
                if (!(monday.DayOfWeek == DayOfWeek.Saturday || monday.DayOfWeek == DayOfWeek.Sunday))
                {
                    i++;
                    ddlistDates.Add(monday);
                }
                monday = monday.AddDays(1);
            }
            return ddlistDates;
        }
    }
}
