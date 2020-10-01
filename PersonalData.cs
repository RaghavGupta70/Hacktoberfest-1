using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A class holding personal data for a person
    /// </summary>
    public class PersonalData
    {
        #region Fields

        
        string firstName="";
        string middleName="";
        string lastName="";
        string city="";
        string streetAddress="";
        string state="";
        string postalCode="";
        string country="";
        string phoneNumber="";

        #endregion

        #region Properties

        /// <summary>
        /// Gets the person's first name
        /// </summary>
        public string FirstName
        {
            get 
            {
               
                return firstName;
            }
        }

        /// <summary>
        /// Gets the person's middle name
        /// </summary>
        public string MiddleName
        {
            get
            {
                
                return middleName;
            }
        }

        /// <summary>
        /// Gets the person's last name
        /// </summary>
        public string LastName
        {
            get
            {
               
                return lastName;
            }
        }

        /// <summary>
        /// Gets the person's street address
        /// </summary>
        public string StreetAddress
        {
            get
            {
               
                return streetAddress;
            }
        }

        /// <summary>
        /// Gets the person's city or town
        /// </summary>
        public string City
        {
            get
            {
                
                return city;
            }
        }

        /// <summary>
        /// Gets the person's state or province
        /// </summary>
        public string State
        {
            get
            {
                
                return state;
            }
        }

        /// <summary>
        /// Gets the person's postal code
        /// </summary>
        public string PostalCode
        {
            get
            {
                
                return postalCode;
            }
        }

        /// <summary>
        /// Gets the person's country
        /// </summary>
        public string Country
        {
            get
            {
                
                return country;
            }
        }

        /// <summary>
        /// Gets the person's phone number (digits only, no 
        /// parentheses, spaces, or dashes)
        /// </summary>
        public string PhoneNumber
        {
            get
            {
               
                return phoneNumber;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// Reads personal data from a file. If the file
        /// read fails, the object contains an empty string for all
        /// the personal data
        /// </summary>
        /// <param name="fileName">name of file holding personal data</param>
        public PersonalData(string fileName)
        {
            // your code can assume we know the order in which the
            // values appear in the string; it's the same order as
            // they're listed for the properties above. We could do 
            // something more complicated with the names and values, 
            // but that's not necessary here

            // IMPORTANT: The mono compiler the automated grader uses
            // does NOT support the string Split method. You have to 
            // use the IndexOf method to find comma locations and the
            // Substring method to chop off the front of the string
            // after you extract each value to extract and save the
            // personal data

            StreamReader input=null;
            try
            {
             
                input = File.OpenText(fileName);
                int i = 0;
                string sample="";
                sample = input.ReadLine();
                

                i = sample.IndexOf(',');
                firstName = sample.Substring(0, i);

                i++;
                sample = sample.Substring(i);
                i = sample.IndexOf(',');
                middleName = sample.Substring(0, i);


                i++;
                sample = sample.Substring(i);
                i = sample.IndexOf(',');
                lastName = sample.Substring(0, i);

                i++;
                sample = sample.Substring(i);
                i = sample.IndexOf(',');
                streetAddress = sample.Substring(0, i);

                i++;
                sample = sample.Substring(i);
                i = sample.IndexOf(',');
                city = sample.Substring(0, i);

                i++;
                sample = sample.Substring(i);
                i = sample.IndexOf(',');
                state = sample.Substring(0, i);

                i++;
                sample = sample.Substring(i);
                i = sample.IndexOf(',');
                postalCode = sample.Substring(0, i);

                i++;
                sample = sample.Substring(i);
                i = sample.IndexOf(',');
                country= sample.Substring(0, i);

                i++;
                sample = sample.Substring(i);
                phoneNumber = sample;



            }

            catch(Exception e)
            {
                
            }

            finally
            {
                if(input==null)
                {
                    firstName = "";
                    middleName = "";
                    lastName = "";
                    streetAddress = "";
                    city = "";
                    state = "";
                    postalCode = "";
                    country = "";
                    phoneNumber = "";

                }

                else
                {
                    //close the file input.Do amendments here. 
                }
                
            }
        }

        #endregion
    }
}
