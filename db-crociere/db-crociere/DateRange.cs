using System;

namespace db_crociere
{
    class DateRange
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateRange(DateTime Start, DateTime End) {
            this.StartDate = Start;
            this.EndDate = End;
        }

        public override string ToString()
        {
            return this.StartDate.ToString() + "-" + this.EndDate.ToString();
        }
    }
}
