using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }

        [Display(Name ="Date of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.EmailAddress)]
        //[EmailAddress]
        public string EmailAddress { get; set;}

        [MinLength(3,ErrorMessage = "longueur minimale 3 caractères")]
        [MaxLength(25,ErrorMessage = "longueur maximale 25 caractères")]
        public string FirstName { get; set;}
        public string LastName { get; set; }

        [RegularExpression(@"^[0-9]{8}$")]
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        //public bool CheckProfile(string first_name,string last_name)
        //{
        //    return first_name == FirstName && last_name == LastName;
        //}
        
        public bool CheckProfile(string first_name, string last_name,string mail = null)
        {
            if ( mail !=null )
            {
                return first_name == FirstName && last_name == LastName && mail == EmailAddress;
            }
            else
            {
                return first_name == FirstName && last_name == LastName ;
            }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("i'm Passenger !");
        }
    }
}
