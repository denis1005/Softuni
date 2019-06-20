using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4._Date_Modifier
{
   public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;

        public DateModifier(DateTime firstDate, DateTime secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }

        public DateTime FirstDate
        {
            get => this.firstDate;
            set => this.firstDate = value;
        }

        public DateTime SecondDate
        {
            get => this.secondDate;
            set => this.secondDate = value;
        }

        public int DateDifferenceInDays()
        {
            int difference = Math.Abs((firstDate - secondDate).Days);
            return difference;
        }
    }
}
