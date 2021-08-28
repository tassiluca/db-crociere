using System;

namespace db_crociere
{
    class DateRange
    {
        private const string SEPARATOR = " - ";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateRange(DateTime Start, DateTime End) {
            this.StartDate = Start;
            this.EndDate = End;
        }

        public string ToStringDate() 
        {
            var startDate = StartDate.Day + "/" + StartDate.Month + "/" + StartDate.Year;
            var endDate = EndDate.Day + "/" + EndDate.Month + "/" + EndDate.Year;
            return startDate + SEPARATOR + endDate;
        }

        public override string ToString()
        {
            return this.StartDate + SEPARATOR + this.EndDate;
        }
    }
}
