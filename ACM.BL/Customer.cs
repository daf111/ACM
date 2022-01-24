using System;

namespace ACM.BL
{
    public class Customer
    {
        public int Id { get; private set; }

        private string _lastName;
        public string LastName {
            get
            {
                return _lastName;
            }
            set
            {
               _lastName = value;
            }
        }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string FullName {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
