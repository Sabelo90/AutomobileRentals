using AutomobileRentals_EntityFramework.Models;

namespace AutomobileRentalsCore.Models
{
    public class PersonModel
    {
        public int per_id { get; set; }
        public string per_username { get; set; }
        public string per_email { get; set; }
        public string per_passwordhash { get; set; }
        public string per_idno { get; set; }

        public PersonModel() { }

        public PersonModel(PersonModel model)
        {
            per_id = model.per_id;
            per_username = model.per_username;
            per_email = model.per_email;
            per_passwordhash = model.per_passwordhash;
            per_idno = model.per_idno;
        }
        public PersonModel(person model)
        {
            per_id = model.per_id;
            per_username = model.per_username;
            per_email = model.per_email;
            per_passwordhash = model.per_passwordhash;
            per_idno = model.per_idno;
        }

        public person ToEntity()
        {
            return new person()
            {
                per_id = per_id,
                per_username = per_username,
                per_email = per_email,
                per_passwordhash = per_passwordhash,
                per_idno = per_idno
            };
        }
    }
}

