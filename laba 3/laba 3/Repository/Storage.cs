using System;


namespace Practice2.Repository
{
    public static class Storage
    {
        public static ClientStorage ClientStorage { get; } = new ClientStorage();
        public static OrderStorage OrderStorage { get; } = new OrderStorage();
        public static EmployeeStorage EmployeeStorage { get; } = new EmployeeStorage();
        public static Making_an_orderStorage Making_an_orderStorage { get; } = new Making_an_orderStorage();
        public static DeliveryStorage DeliveryStorage { get; } = new DeliveryStorage();
        public static ProductStorage ProductStorage { get; } = new ProductStorage();
        public static TestStorage TestStorage { get; } = new TestStorage();
    }
}
