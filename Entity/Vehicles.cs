﻿

namespace AutoService.Entity
{
    public class Vehicles
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Vin { get; set; }
        public string Notes { get; set; }
    }
}
