using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealtyModel.Model
{
    public class Credential
    {
        DateTime registrationDate = new DateTime();
        public String Password { get; set; }
        public DateTime RegistrationDate
        {
            get => registrationDate;
            set
            {
                registrationDate = value;
                //OnPropertyChanged();
            }
        }
        [NotMapped]
        public String Token { get; set; }
    }
}
