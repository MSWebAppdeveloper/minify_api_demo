using EzzyBillApiDemo.Models;

namespace EzzyBillApiDemo.Data
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Customers.Any())
                return; // already seeded

            var customers = new List<Customer>
            {
                new() { FullName = "John Anderson", Email = "john.anderson@example.com", Phone = "2025550141", City = "New York" },
                new() { FullName = "Emily Johnson", Email = "emily.johnson@example.com", Phone = "4155550198", City = "San Francisco" },
                new() { FullName = "Michael Davis", Email = "michael.davis@example.com", Phone = "3125550123", City = "Chicago" },
                new() { FullName = "Sarah Miller", Email = "sarah.miller@example.com", Phone = "2135550102", City = "Los Angeles" },
                new() { FullName = "David Wilson", Email = "david.wilson@example.com", Phone = "3055550187", City = "Miami" },
                new() { FullName = "Ashley Moore", Email = "ashley.moore@example.com", Phone = "6175550176", City = "Boston" },
                new() { FullName = "Chris Taylor", Email = "chris.taylor@example.com", Phone = "2145550133", City = "Dallas" },
                new() { FullName = "Jessica Thomas", Email = "jessica.thomas@example.com", Phone = "7025550165", City = "Las Vegas" },
                new() { FullName = "Daniel Martinez", Email = "daniel.martinez@example.com", Phone = "5125550112", City = "Austin" },
                new() { FullName = "Amanda Lee", Email = "amanda.lee@example.com", Phone = "4045550144", City = "Atlanta" },
                new() { FullName = "Brian White", Email = "brian.white@example.com", Phone = "6025550199", City = "Phoenix" },
                new() { FullName = "Rachel Hall", Email = "rachel.hall@example.com", Phone = "2065550155", City = "Seattle" }
            };
            context.Customers.AddRange(customers);
            context.SaveChanges();
        }
    }
}
