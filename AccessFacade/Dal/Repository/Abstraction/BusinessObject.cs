using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Dal.Repository.Abstraction
{
    public interface BusinessObject
    {
        void Select();
        void Insert(string FirstName, string LastName, string Address, int FkOneToTestId);
        void Update(string FirstName, int id);
        void Delete();
    }
}
