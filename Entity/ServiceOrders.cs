using System;

namespace AutoService.Entity
{
    public class ServiceOrders
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int VehicleId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ServiceType { get; set; }
        public string Status { get; set; }
        public float EstimatedCost { get; set; }
        public string Notes { get; set; }
    }
}
