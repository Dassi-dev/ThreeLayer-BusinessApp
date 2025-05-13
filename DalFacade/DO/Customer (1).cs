using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Customer  //פרטי הלקוח
     (int ID,//תעודת זהות
     string? customerName,//שם הלקוח
     string? address,//כתובת
     string? phone //טלפון
     )
    {
        public Customer() : this(0, null, null, null)
        {

        }
        public Customer(Customer c)
        {
            this.ID = c.ID;
            this.customerName = c.customerName;
            this.address = c.address;
            this.phone = c.phone;

        }
    }

}
