namespace coreApp.Models
{
    public class Product:BaseEntity
    {
        public string name { get; set; }
        public string price { get; set; }
        public decimal quentity { get; set; }
    }
}