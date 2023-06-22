using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using TPBank.BusinessLogicLayer;
using TPBank.Entities;

namespace TPBank.Presentation
{
    public class ManagerCustomer : IManagerCustomer
    {

        private ICustomerBusinessLogicLayer _businessLogicLayer;
        //static CustomerDTO customerDTO = new CustomerDTO();

        public ManagerCustomer(ICustomerBusinessLogicLayer? businessLogicLayer = null)
        {
            this._businessLogicLayer = businessLogicLayer ?? new CustomerBusinessLogicLayer();
        }
        /// <summary>
        /// add mới một customer
        /// </summary>
        /// <param name="customer"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddCustomer()
        {
            CustomerDTO customerDTO = new CustomerDTO();
            Console.WriteLine("---:::--- Add New Customer ---:::---");
            bool check = false;
            while (check == false)
            {
                try
                {
                    //create an object of customer
                    Console.Write("Customer Code: ");
                    customerDTO.CustomerCode = long.Parse(Console.ReadLine());

                    Console.Write("Customer Name: ");
                    customerDTO.CustomerName = Console.ReadLine();

                    Console.Write("Address: ");
                    customerDTO.Address = Console.ReadLine();

                    Console.Write("Landmark: ");
                    customerDTO.Landmark = Console.ReadLine();

                    Console.Write("City: ");
                    customerDTO.City = Console.ReadLine();

                    Console.Write("Country: ");
                    customerDTO.Country = Console.ReadLine();

                    Console.Write("Mobile: ");
                    customerDTO.Mobile = Console.ReadLine();

                    Console.Write("Username: ");
                    customerDTO.Username = Console.ReadLine();

                    Console.Write("Password: ");
                    customerDTO.Password = Console.ReadLine();

                    //Create BLL object



                    List<CustomerDTO> matchingCustomers = _businessLogicLayer.GetCustomersByCondition(x => x.CustomerCode == customerDTO.CustomerCode);
                    if (matchingCustomers.Equals(customerDTO.CustomerCode))
                    {
                        Console.WriteLine("Customer Not Added, Id already exits");
                    }
                    else
                    {
                        Console.WriteLine("Customer Add Success");
                        Guid newGuid = _businessLogicLayer.AddCustomer(customerDTO);
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    check = false;
                }
            }

        }
        /// <summary>
        /// tìm customer theo điều kiện
        /// </summary>
        /// <param name="customer"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void FindCustomer()
        {

            int option;
            bool check = false;
            while (true)
            {
                do
                {
                    Console.WriteLine("---:::--- Find Customer Menu ---:::---");
                    Console.WriteLine("1.  Find By UserName.");
                    Console.WriteLine("2.  Find By Address.");
                    Console.WriteLine("3.  Find By City.");
                    Console.WriteLine("4.  Find By Mobile.");
                    Console.WriteLine("5.  Exit\n");
                    Console.Write("Enter Option: ");
                    check = int.TryParse(Console.ReadLine(), out option);
                    if (check == false || option < 1 || option > 6)
                    {
                        Console.WriteLine("Invalid option! Please try again!");
                    }
                } while (check == false || option < 1 || option > 5);
                switch (option)
                {
                    case 1:
                        FindByUserName();
                        break;
                    case 2:
                        FindByAddress();
                        break;
                    case 3:
                        FindByCity();
                        break;
                    case 4:
                        FindByMobile();
                        break;
                    default:
                        return;
                }
            }
        }
        /// <summary>
        /// tim customer theo mobile
        /// </summary>
        private void FindByMobile()
        {
            List<CustomerDTO> customerDTOs = _businessLogicLayer.GetCustomers();
            Console.Write("Enter Mobile you want search: ");
            string customerMobile = Console.ReadLine();
            List<CustomerDTO> customerToSearch = customerDTOs.Where(x => x.Mobile.Contains(customerMobile)).OrderBy(x => x.Mobile).ToList();
            if (customerToSearch.Any())
            {
                Console.WriteLine("Search results: \n");
                Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                    "CustomerCode", "CustomerName", "Address", "Landmark", "City", "Country", "Mobile", "Username", "Password"));
                foreach (var item in customerToSearch)
                {
                    Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                        item.CustomerCode, item.CustomerName, item.Address, item.Landmark, item.City, item.Country, item.Mobile, item.Username, item.Password));
                }
            }
            else
            {
                Console.WriteLine("Don't Find Customer!");
            }
        }
        /// <summary>
        /// tim customer theo city
        /// </summary>
        private void FindByCity()
        {
            List<CustomerDTO> customerDTOs = _businessLogicLayer.GetCustomers();
            Console.Write("Enter City you want search: ");
            string customerCity = Console.ReadLine();
            List<CustomerDTO> customerToSearch = customerDTOs.Where(x => x.City.ToLower().Contains(customerCity)).OrderBy(x => x.City).ToList();
            if (customerToSearch.Any())
            {
                Console.WriteLine("Search results: \n");
                Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                    "CustomerCode", "CustomerName", "Address", "Landmark", "City", "Country", "Mobile", "Username", "Password"));
                foreach (var item in customerToSearch)
                {
                    Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                        item.CustomerCode, item.CustomerName, item.Address, item.Landmark, item.City, item.Country, item.Mobile, item.Username, item.Password));
                }
            }
            else
            {
                Console.WriteLine("Don't Find Customer!");
            }
        }
        /// <summary>
        /// tim customer theo address
        /// </summary>
        private void FindByAddress()
        {
            List<CustomerDTO> customcerDTOs = _businessLogicLayer.GetCustomers();
            Console.Write("Enter Address you want search: ");
            string customerAddress = Console.ReadLine();
            List<CustomerDTO> customerToSearch = customcerDTOs.Where(x => x.Address.ToLower().Contains(customerAddress)).OrderBy(x => x.Address).ToList();
            if (customerToSearch.Any())
            {
                Console.WriteLine("Search results: \n");
                Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                    "CustomerCode", "CustomerName", "Address", "Landmark", "City", "Country", "Mobile", "Username", "Password"));
                foreach (var item in customerToSearch)
                {
                    Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                        item.CustomerCode, item.CustomerName, item.Address, item.Landmark, item.City, item.Country, item.Mobile, item.Username, item.Password));
                }
            }
            else
            {
                Console.WriteLine("Don't Find Customer!");
            }
        }
        /// <summary>
        /// tim customer theo username
        /// </summary>
        private void FindByUserName()
        {
            List<CustomerDTO> customerDTOs = _businessLogicLayer.GetCustomers();
            Console.Write("Enter UserName you want search: ");
            string customerName = Console.ReadLine();
            List<CustomerDTO> customerToSearch = customerDTOs.Where(x => x.Username.ToLower().Contains(customerName)).OrderBy(x => x.Username).ToList();
            if (customerToSearch.Any())
            {
                Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                "CustomerCode", "CustomerName", "Address", "Landmark", "City", "Country", "Mobile", "Username", "Password"));
                foreach (var item in customerToSearch)
                {
                    Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                        item.CustomerCode, item.CustomerName, item.Address, item.Landmark, item.City, item.Country, item.Mobile, item.Username, item.Password));
                }
            }
            else
            {
                Console.WriteLine("Don't Find Customer!");
            }
        }

        /// <summary>
        /// lấy tất cả danh sách của customer
        /// </summary>
        /// <param name="customer"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void GetAllExistingCustomer()
        {
            var customerDTOs = _businessLogicLayer.GetCustomers();
            Console.WriteLine("\n");
            Console.WriteLine("---:::--- Display All Customer ---:::---");
            Console.WriteLine("\n");
            Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                "CustomerCode", "CustomerName", "Address", "Landmark", "City", "Country", "Mobile", "Username", "Password"));
            foreach (var item in customerDTOs)
            {
                Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                    item.CustomerCode, item.CustomerName, item.Address, item.Landmark, item.City, item.Country, item.Mobile, item.Username, item.Password));
            }

        }
        /// <summary>
        /// phần login để vào main menu
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <exception cref="NotImplementedException"></exception>
        public bool LoginScreen()
        {
            string username, password;
            Console.WriteLine("---:::--- Login Screen ---:::---");
            do
            {
                username = Validate.GetStringInput("Username: ");
                password = Validate.GetStringInput("Password: ");
                if (username != "system" || password != "manager")
                {
                    Console.WriteLine("Username or password is isvalid. Please try again!");
                }
            } while (username != "system" || password != "manager");
            return true;
        }
        /// <summary>
        /// xóa 1 customer theo id được chọn
        /// </summary>
        /// <param name="customerId"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void RemoveCustomer()
        {
            try
            {
                List<CustomerDTO> customerDTOs = _businessLogicLayer.GetCustomers();
                Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                            "CustomerCode", "CustomerName", "Address", "Landmark", "City", "Country", "Mobile", "Username", "Password"));
                foreach (var item in customerDTOs)
                {
                    Console.WriteLine(string.Format("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}",
                        item.CustomerCode, item.CustomerName, item.Address, item.Landmark, item.City, item.Country, item.Mobile, item.Username, item.Password));
                }
                Console.Write("Enter Customer Code you want delete: ");
                long customerCode = long.Parse(Console.ReadLine());
                CustomerDTO customerToRemove = customerDTOs.Find(x => x.CustomerCode == customerCode);
                if (customerToRemove != null)
                {
                    Console.WriteLine("Customer has been deleted");
                    _businessLogicLayer.DeleteCustomer(customerToRemove.CustomerId);
                }
                else
                {
                    Console.WriteLine("Customer does not exist");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// update dữ liệu của customer theo id đc chọn
        /// </summary>
        /// <param name="customerId"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void UpdateCustomer()
        {
            try
            {
                List<CustomerDTO> customerDTOs = _businessLogicLayer.GetCustomers();              
                Console.WriteLine("---:::--- UPDATE CUSTOMER ---:::---");
                Console.WriteLine("\n");
                Console.Write("Enter the customer code: ");
                long customerCode = long.Parse(Console.ReadLine());
                CustomerDTO customerToUpdate = customerDTOs.Find(x => x.CustomerCode == customerCode);
                var defual = customerDTOs.Select(x => new
                {                  
                    Address= x.Address,
                    Landmark = x.Landmark,
                    City = x.City,
                    Country = x.Country,                   
                });


                if (customerToUpdate != null)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"You select {customerToUpdate.CustomerName} has: " +
                    $"\nCustomerName: {customerToUpdate.CustomerName}" +
                    $"\nAddress: {customerToUpdate.Address}" +
                    $"\nLandmark: {customerToUpdate.Landmark}" +
                    $"\nCity: {customerToUpdate.City}" +
                    $"\nCountry: {customerToUpdate.Country}" +
                    $"\nMobile: {customerToUpdate.Mobile}" +
                    $"\nUsername: {customerToUpdate.Username}" +
                    $"\nPassword: {customerToUpdate.Password}");
                    Console.WriteLine("\n");
                    Console.WriteLine("---> Input information of customer you want update: ");

                    Console.Write("Customer Name: ");
                    customerToUpdate.CustomerName = Console.ReadLine();

                    Console.Write("Address: ");
                    string address = Console.ReadLine();
                    if (address != null)
                    {
                        customerToUpdate.Address = address;
                    }

                    Console.Write("Landmark: ");
                    string landMark = Console.ReadLine();
                    if (landMark !=null)
                    {
                        customerToUpdate.Landmark = landMark;
                    }                  

                    Console.Write("City: ");
                    string city = Console.ReadLine();
                    if (city != null)
                    {
                        customerToUpdate.City = city;
                    }
                   
                    Console.Write("Country: ");
                    string country = Console.ReadLine();
                    if (country != null)
                    {
                        customerToUpdate.Country = country;
                    }
                    
                    Console.Write("Mobile: ");
                    customerToUpdate.Mobile = Console.ReadLine();
                    
                    Console.Write("Username: ");
                    customerToUpdate.Username = Console.ReadLine();

                    
                    Console.Write("Password: ");
                    customerToUpdate.Password = Console.ReadLine();

                    bool isUpdate = _businessLogicLayer.UpdateCustomer(customerToUpdate);
                    if (isUpdate)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Customer has been Updated");
                        Console.WriteLine($"\nCustomerName: {customerToUpdate.CustomerName}" +
                                            $"\nAddress: {customerToUpdate.Address}" +
                                            $"\nLandmark: {customerToUpdate.Landmark}" +
                                            $"\nCity: {customerToUpdate.City}" +
                                            $"\nCountry: {customerToUpdate.Country}" +
                                            $"\nMobile: {customerToUpdate.Mobile}" +
                                            $"\nUsername: {customerToUpdate.Username}" +
                                            $"\nPassword: {customerToUpdate.Password}");
                    }
                }
                else
                {
                    Console.WriteLine("Customer does not exist");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
