namespace Domain
{
    /*
    * Models and Entities are basically the same thing.
    An entity is something we are going to use and store in our database.
    The class name "Activity" relates to a table in a database and each of these properties
    relates to a column with the same name to that table.
    **/
    public class Activity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
        public Boolean IsCancelled { get; set; }
        public ICollection<ActivityAttendee> Attendees { get; set; } = new List<ActivityAttendee>();
    }
}