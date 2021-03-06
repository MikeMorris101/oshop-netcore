namespace Oshop.API.Dtos
{
    public class ShippingDto
    {
        public string Id { get; set; }
        public string ShippingName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string  City { get; set; }
        public string State { get; set; }
        public string UserId { get; set; }
        public bool IsPreferred { get; set; }
    }
}