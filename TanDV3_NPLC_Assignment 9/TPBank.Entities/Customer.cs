namespace TPBank.Entities
{
    public class Customer
    {
        private Guid customerId;

        public Guid CustomerId
        {
            get { return customerId; }
            set 
            {
                if (value.IsValidCustomerId())
                {
                    throw new Exception("CustomerId is null");
                }
                customerId = value;
            }
        }

        private long customerCode;

        public long CustomerCode
        {
            get { return customerCode; }
            set 
            {
                if (!value.IsVaidCustomerCode())
                {
                    throw new Exception("CustomerCode is less than 0");
                }
                customerCode = value;
            
            }
        }

        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set 
            {
                if (!value.IsVaidCustomerName())
                {
                    throw new Exception("CustomerName is null or greater than 40 character");
                }
                customerName = value; 
            
            }
        }

        public string Address { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set 
            {
                if (!value.IsValidPhone())
                {
                    throw new Exception("Mobile is greater than 10 digit number");
                }
                mobile = value; 
            }
        }

        public string Username { get; set; }
        public string Password { get; set; }
        
        public Customer() { }

        public Customer(Guid customerId, long customerCode, string customerName, string address, string landmark, string city, string country, string mobile, string username, string password)
        {
            CustomerId = customerId;
            CustomerCode = customerCode;
            CustomerName = customerName;
            Address = address;
            Landmark = landmark;
            City = city;
            Country = country;
            Mobile = mobile;
            Username = username;
            Password = password;
        }

        public string DisplayCustomer()
        {
            return $"CustomerID: {CustomerId},CustomerCode: {CustomerCode}, CustomerName: {CustomerName}, Address: {Address}, Landmark: {Landmark}, City: {City}, Country: {Country}, Mobile: {Mobile}, UserName: {Username}, Password: {Password}";
        }
    }
}