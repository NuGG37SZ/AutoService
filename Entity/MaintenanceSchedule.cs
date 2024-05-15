using System;


namespace AutoService.Entity
{
    public class MaintenanceSchedule
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public DateTime LastServiceDate { get; set; }
        public DateTime NextServiceDate { get; set; }
        public string ServiceType { get; set; }
        public string Notes { get; set; }
    }
}
