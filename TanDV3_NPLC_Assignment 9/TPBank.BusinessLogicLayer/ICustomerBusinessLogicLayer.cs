using TPBank.Entities;

namespace TPBank.BusinessLogicLayer
{
    public interface ICustomerBusinessLogicLayer
    {
        List<CustomerDTO> GetCustomers();
        List<CustomerDTO> GetCustomersByCondition(Func<CustomerDTO, bool> predicate);
        Guid AddCustomer(CustomerDTO customerDTO);

        bool UpdateCustomer(CustomerDTO customerDTO);
        bool DeleteCustomer(Guid customerId);
    }
}
