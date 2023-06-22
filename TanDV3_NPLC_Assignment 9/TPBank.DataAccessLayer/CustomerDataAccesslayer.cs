using TPBank.Entities;

namespace TPBank.DataAccessLayer
{
    public class CustomerDataAccesslayer : ICustomerDataAccesslayer
    {
        private List<Customer> _customerList;
        /// <summary>
        /// add các dữ liệu cho list
        /// </summary>
        public CustomerDataAccesslayer()
        {
            _customerList = new List<Customer>()
            {
                new Customer()
                {
                    CustomerId=Guid.NewGuid(),CustomerCode=1,CustomerName="Dinh Van Tan",Address="Ninh Binh",City="Ha Noi",
                    Country="Viet Nam",Landmark="FA",Mobile="0987654321",Username="TanDV",Password="123"
                },
                new Customer()
                {
                    CustomerId=Guid.NewGuid(),CustomerCode=2,CustomerName="Tran Van Tuan",Address="Nam Dinh",City="Ha Noi",
                    Country="Viet Nam",Landmark="FA",Mobile="0987654321",Username="TuanTV",Password="123"
                },
                 new Customer()
                {
                    CustomerId=Guid.NewGuid(),CustomerCode=3,CustomerName="Tran Huy Anh",Address="Thai Ngyen",City="Ha Noi",
                    Country="Viet Nam",Landmark="FA",Mobile="0987654321",Username="AnhTH",Password="123"
                }
            };
        }
        /// <summary>
        /// add new các customerr
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public Guid AddCustomer(Customer customer)
        {
            Customer entity = new Customer();
            entity.CustomerCode = customer.CustomerCode;
            entity.CustomerId = Guid.NewGuid();
            entity.CustomerName = customer.CustomerName;
            entity.Address = customer.Address;
            entity.City = customer.City;
            entity.Country = customer.Country;
            entity.Landmark = customer.Landmark;
            entity.Mobile = customer.Mobile;
            entity.Username = customer.Username;
            entity.Password = customer.Password;
            _customerList.Add(entity);
            return entity.CustomerId;
        }
        /// <summary>
        /// xóa customer theo id được chọn
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public bool DeleteCustomer(Guid customerId)
        {
            var customer = _customerList.FirstOrDefault(x => x.CustomerId == customerId);
            if (customer != null)
            {
                _customerList.Remove(customer);
                return true;
            }
            return false;

        }
        /// <summary>
        /// lấy tất cả các customer đã có
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers()
        {
            return _customerList;
        }
        /// <summary>
        /// lấy danh sách customer theeo điều kiện
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<Customer> GetCustomersByCondition(Func<Customer, bool> predicate)
        {
            return _customerList.Where(predicate).ToList();
        }
        /// <summary>
        /// update dữ liệu cho customer theo id đc chọn
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool UpdateCustomer(Customer customer)
        {
            var customers = _customerList.FirstOrDefault(x => x.CustomerId == customer.CustomerId);
            if (customers == null)
            {
                return false;
            }
            customers.CustomerName = customer.CustomerName;
            customers.Address = customer.Address;
            customers.City = customer.City;
            customers.Country = customer.Country;
            customers.Landmark = customer.Landmark;
            customers.Mobile = customer.Mobile;
            customers.Username = customer.Username;
            customers.Password = customer.Password;
            return true;
        }
    }
}
