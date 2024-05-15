

namespace AutoService.Entity
{
    public class Inventory
    {
        public int Id { get; set; }
        public string PartName { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Supplier { get; set; }
        public string Notes { get; set; }
    }
}
