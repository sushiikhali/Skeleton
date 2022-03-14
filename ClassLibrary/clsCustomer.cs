using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string Name { get; set; }

        public string Valid(string nName)
        {
            if(nName.Length<1)
            {
                return "Description cannot be blank";
            }
            if(nName.Length > 50)
            {
                 return "Description cannot be more than 50 characters";
            }
            else
            {
                return "";
            }
           
        }
    }
}