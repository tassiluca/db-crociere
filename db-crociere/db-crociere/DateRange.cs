using System;

namespace db_crociere
{
    class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public DateRange(DateTime Start, DateTime End) {
            this.Start = Start;
            this.End = End;
        }

        public override string ToString()
        {
            return this.Start.ToString() + " - " + this.End.ToString();
        }
    }
}
