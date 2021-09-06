using System;

namespace db_crociere
{
    class DateRange
    {
        private const string SEPARATOR = " - ";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal NavCode { get; set; }
        public DateRange(DateTime Start, DateTime End) {
            this.StartDate = Start;
            this.EndDate = End;
        }

        public string ToStringDate() 
        {
            var startDate = StartDate.ToString("dd/MM/yy");
            var endDate = EndDate.ToString("dd/MM/yy");
            return startDate + SEPARATOR + endDate;
        }

        public override string ToString()
        {
            return "codNav: " + NavCode + "Period:" + this.StartDate + SEPARATOR + this.EndDate;
        }
    }
}
