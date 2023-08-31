using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPruebaAnidadas
{
    public class Employee
    {
        private int _id;
        private string _firstname;
        private string _lastname;
        

        // PUBLIC PROPERTIES
        [Display(Name =" ID NUMBER",Description =" ENTRE AN INTEGER BETWEEN 0 AND 99999")]
        [Range(0,99999)]

        public int Id
        {
            get 
            {
                return _id; 
            }
            set 
            {
                Validator.ValidateProperty
                    (value, new ValidationContext(this, null, null)
                    { MemberName = "id number" });
                _id = value; 
            }
        }
        [Display(Name =" NAME")]
        [Required(ErrorMessage =" FIRST NAME IS REQUIRED")]
        
        public string Firstname
        {
            get 
            { 
                return _firstname; 
            }
            set 
            {
                Validator.ValidateProperty
                    (value, new ValidationContext(this, null, null)
                    { MemberName = "FIRST NAME" });
                _firstname = value; 
            }
        }
        [Required(ErrorMessage =" LAST NAME IS REQUIRED")]
        [RegularExpression("@^[a-zA-Z''-']{1,20}$")]
        public string Lastname
        {
            get
            { 
                return _lastname; 
            }
            set 
            {

                Validator.ValidateProperty
                    (value, new ValidationContext(this, null, null)
                    { MemberName = " LAST NAME" });
                _lastname = value; 
            }        
        }

    }
}
