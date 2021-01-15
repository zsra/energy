using Energy.Core.Entities.UserManagement;
using Energy.Core.Interfaces.UserManagement;

namespace Energy.Core.Extensionss.Factories
{
    public enum UserType
    {
        Staff,
        Customer
    }

    public class UserFactory
    {
        public IUser GetUser( UserType userType ) => userType switch
        {
            UserType.Staff => new Staff(),
            UserType.Customer => new Customer(),
            _ => throw new System.NotImplementedException(),
        };
    }
}
