using booking_backend.Model;

namespace booking_backend.DTO
{
    public class ResourceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Resource ToDomain()
        {
            return new Resource()
            {
                Id = Id,
                Name = Name,
                Quantity = Quantity
            };
        }
    }
}
