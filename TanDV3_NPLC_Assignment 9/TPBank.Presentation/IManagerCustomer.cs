using TPBank.BusinessLogicLayer;
using TPBank.Entities;
namespace TPBank.Presentation
{
    public interface IManagerCustomer
    {
        public void AddCustomer();
        public void GetAllExistingCustomer();
        public void FindCustomer();
        public void UpdateCustomer();
        public void RemoveCustomer();
        public bool LoginScreen();
    }
}
