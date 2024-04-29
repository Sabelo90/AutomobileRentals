namespace AutomobileRentals_EntityFramework.Models
{
    public class booking
    {
        public int bok_id { get; set; }
        public int bok_ref_person { get; set; }
        public int bok_ref_vehicle { get; set; }
        public DateTime bok_startdate { get; set; }
        public DateTime Bok_enddate { get; set; }
        public decimal bok_totalprice { get; set; }
        public bool bok_isconfirmed { get; set; }

        //Navigation Properties
        public virtual person bok_ref_personNavigation { get; set; }
        public virtual vehicle bok_ref_vehicleNavigation { get; set; }
    }

}
