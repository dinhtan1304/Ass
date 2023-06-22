using Moq;
using NPLC_Assignment12.Exercise3;

namespace Exercise1_VideoService
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        [Test]
        public void DeleteEmployee_WhenCalled_DeleteTheEmployeeFromDb()
        {
            var storage = new Mock<IEmployStorage>();
            var controller = new Employee(storage.Object);

            controller.DeleteEmployee(1);
            storage.Verify(s => s.DeleteEmployee(1));
        }
    }
}
