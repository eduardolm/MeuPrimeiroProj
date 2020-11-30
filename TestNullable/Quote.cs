using System;

namespace TestNullable
{
    public class Quote
    {
        
        public long Id { get; set; }
        public int Episode { get; set; }
        public string EpisodeName { get; set; }
        public string Segment { get; set; }
        public string Type { get; set; }
        public string Actor { get; set; }
        public string Character { get; set; }
        public string Detail { get; set; }
        public DateTime? RecordDate { get; set; }
        public string Series { get; set; }
        public DateTime? TransmissionDate { get; set; }
    }
}