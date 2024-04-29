namespace AutomobileRentals_EntityFramework.Models
{
    public partial class person
    {
        public int per_id { get; set; }
        public string per_username { get; set; }
        public string per_email { get; set; }
        public string per_passwordhash { get; set; }
        public string per_idno { get; set; }

        public virtual ICollection<booking> personBookings { get; set; } = new List<booking>();

    }
}
