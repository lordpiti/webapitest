using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace testWebAPI.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string Twitter { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
                    "api/contacts/{0}", this.Id);
            }
            set { }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ManagerId { get; set; }
        public string ManagerName { get; set; }
        public int? Reports { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string CellPhone { get; set; }
        public string OfficePhone { get; set; }
        public string Pic { get; set; }
        public string TwitterId { get; set; }
        public string Blog { get; set; }
    }
}