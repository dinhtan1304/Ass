using System.Linq;
using TPBank.DataAccessLayer;
using TPBank.Entities;

namespace TPBank.BusinessLogicLayer
{
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {
        private readonly ICustomerDataAccesslayer _customerDAL;
        public CustomerBusinessLogicLayer(ICustomerDataAccesslayer customerDAL=null)
        {
            this._customerDAL = customerDAL ?? new CustomerDataAccesslayer();
        }
        /// <summary>
        /// add thông tin của 1 customer mới
        /// </summary>
        /// <param name="customerDTO"></param>
        /// <returns></returns>
        public Guid AddCustomer(CustomerDTO customerDTO)
        {
            try
            {
                if (!customerDTO.CustomerName.IsVaidCustomerName())
                {
                    Console.WriteLine("Customer Name is null or more than 40 characters!");
                    return Guid.Empty;
                }
                if (!customerDTO.Mobile.IsValidPhone() || !customerDTO.Mobile.IsValidUniqueMobile(_customerDAL.GetCustomers()))
                {
                    Console.WriteLine("mobile is == 10 digit! or not unique!");
                    return Guid.Empty;
                }

                var customer = new Customer
                {
                    CustomerId = Guid.NewGuid(),
                    CustomerCode = customerDTO.CustomerCode,
                    CustomerName = customerDTO.CustomerName,
                    Address = customerDTO.Address,
                    City = customerDTO.City,
                    Country = customerDTO.Country,
                    Landmark = customerDTO.Landmark,
                    Mobile = customerDTO.Mobile,
                    Username = customerDTO.Username,
                    Password = customerDTO.Password,
                };
                _customerDAL.AddCustomer(customer);
                return customer.CustomerId;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return Guid.Empty;
        }
        /// <summary>
        /// xóa 1 customer theo id đã chọn
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public bool DeleteCustomer(Guid customerId)
        {
            try
            {
                var customer = _customerDAL.GetCustomers();
                var result = customer.FirstOrDefault(x=> x.CustomerId== customerId);
                if (result != null)
                {
                    _customerDAL.DeleteCustomer(customerId);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dont delete this customer" + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return false;   
        }
        /// <summary>
        /// lấy thông tin tất cả customer
        /// </summary>
        /// <returns></returns>
        public List<CustomerDTO> GetCustomers()
        {
            try
            {
                var result =_customerDAL.GetCustomers();
                if (result.Count==0)
                {
                    return null;
                }
                var customerDTO = result.Select(x => new CustomerDTO(x));
                return customerDTO.ToList();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("==>"+ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return null;
        }
        /// <summary>
        /// lấy thông tin customer theo điều kiện
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<CustomerDTO> GetCustomersByCondition(Func<CustomerDTO, bool> predicate)
        {
            var customers = _customerDAL.GetCustomers();
            var result = customers.Select(x => new CustomerDTO(x)).Where(predicate).ToList();
            return result.ToList();
        }
        /// <summary>
        /// update thông tin customer đã tồn tại
        /// </summary>
        /// <param name="customerDTO"></param>
        /// <returns></returns>
        public bool UpdateCustomer(CustomerDTO customerDTO)
        {
            var customer = _customerDAL.GetCustomers();
            var result = customer.FirstOrDefault(x => x.CustomerId == customerDTO.CustomerId);
            if (result == null)
            {
                return false;
            }
            result.CustomerName = customerDTO.CustomerName;
            result.Address = customerDTO.Address;
            result.City = customerDTO.City;
            result.Country = customerDTO.Country;
            result.Landmark = customerDTO.Landmark;
            result.Mobile = customerDTO.Mobile;
            result.Username = customerDTO.Username;
            result.Password = customerDTO.Password;
            return true;
        }
    }
}
