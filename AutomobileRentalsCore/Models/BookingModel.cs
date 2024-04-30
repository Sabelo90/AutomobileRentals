using AutomobileRentals_EntityFramework.Models;

namespace AutomobileRentalsCore.Models
{
    public class BookingModel
    {
        public int bok_id { get; set; }
        public int bok_ref_person { get; set; }
        public int bok_ref_vehicle { get; set; }
        public DateTime bok_startdate { get; set; }
        public DateTime bok_enddate { get; set; }
        public decimal bok_totalprice { get; set; }
        public bool bok_isconfirmed { get; set; }

        public BookingModel() { }

        public BookingModel(BookingModel model)
        {
            bok_id = model.bok_id;
            bok_isconfirmed = model.bok_isconfirmed;
            bok_ref_person = model.bok_ref_person;
            bok_ref_vehicle = model.bok_ref_vehicle;
            bok_startdate = model.bok_startdate;
            bok_totalprice = model.bok_totalprice;
            bok_enddate = model.bok_enddate;
            bok_isconfirmed = model.bok_isconfirmed;
        }

        public BookingModel(booking model)
        {
            bok_id = model.bok_id;
            bok_isconfirmed = model.bok_isconfirmed;
            bok_ref_person = model.bok_ref_person;
            bok_ref_vehicle = model.bok_ref_vehicle;
            bok_startdate = model.bok_startdate;
            bok_totalprice = model.bok_totalprice;
            bok_enddate = model.bok_enddate;
            bok_isconfirmed = model.bok_isconfirmed;
        }

        public booking ToEntity()
        {
            return new booking()
            {
                bok_id = bok_id,
                bok_isconfirmed = bok_isconfirmed,
                bok_ref_person = bok_ref_person,
                bok_ref_vehicle = bok_ref_vehicle,
                bok_startdate = bok_startdate,
                bok_totalprice = bok_totalprice,
                bok_enddate = bok_enddate
            };
        }
    }
}
