using System.Collections.Generic;
namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()           //first call the cunstructor with no parameter
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)         //first call the cunstructor that takes id parameter
        {
            //this.Id = id;
            this.Name = name;
        }

    }
}
