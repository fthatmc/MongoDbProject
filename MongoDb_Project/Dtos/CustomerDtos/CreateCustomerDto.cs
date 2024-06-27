using MongoDb_Project.Entities;

namespace MongoDb_Project.Dtos.CustomerDtos
{
    public class CreateCustomerDto
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }
    }
}
