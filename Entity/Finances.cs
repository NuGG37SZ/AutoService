using System;

namespace AutoService.Entity
{
    public class Finances
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
    }
}
