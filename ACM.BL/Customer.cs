using System;
using System.Collections.Generic;

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

        public Customer()
        {
            
        }

        public Customer(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }

    }
}
