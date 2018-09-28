using System;
using System.Collections.Generic;
using System.Text;

namespace AccessFacade.Dal.Entities
{
    public class UserTest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int FkOneToTestId { get; set; }
    }
}
