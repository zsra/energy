using Energy.Core.Entities.UserManagement;
using Energy.Core.Interfaces.UserManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Energy.Core.Factories.UserManagement
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
