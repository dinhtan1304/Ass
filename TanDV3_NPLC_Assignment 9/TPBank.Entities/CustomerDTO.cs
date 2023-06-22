using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBank.Entities
{
    public class CustomerDTO
    {
        public Guid CustomerId { get; set; }
        public long CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public CustomerDTO() { }
        public CustomerDTO(Customer customer)
        {
            CustomerId= customer.CustomerId;
            CustomerCode= customer.CustomerCode;
            CustomerName= customer.CustomerName;
            Address= customer.Address;
            Landmark= customer.Landmark;
            City= customer.City;
            Country= customer.Country;
            Mobile= customer.Mobile;
            Username= customer.Username;
            Password= customer.Password;
        }
    }
}
