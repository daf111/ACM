using System;

namespace ACM.BL
{
    public class Customer
    {
        public static int InstanceCounter { get; set; }

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
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
    }
}
