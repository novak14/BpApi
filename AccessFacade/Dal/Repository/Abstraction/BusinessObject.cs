using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Dal.Repository.Abstraction
{
    public interface BusinessObject
    {
        string Select();
        string Insert();
        string Update();
        string Delete();
    }
}
