namespace EventEase.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public int RegisteredCount { get; set; }

        public string FormattedDate => Date.ToString("dddd, dd 'de' MMMM 'de' yyyy 'a las' HH:mm");
        public string ShortDay => Date.Day.ToString("00");
        public string ShortMonth => Date.ToString("MMM").ToUpper();
        public string ShortYear => Date.Year.ToString();
        public int AvailableSpots => Capacity - RegisteredCount;
        public bool IsAvailable => AvailableSpots > 0;
        public double OccupancyPercentage => (double)RegisteredCount / Capacity * 100;
    }
}
