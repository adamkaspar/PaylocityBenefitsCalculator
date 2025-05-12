namespace Api.Common.Infrastructure
{
    public class PaycheckSettings
    {
        public int NumberOfPaychecksPerYear { get; set; }

        public int DependentBaseCost { get; set; }

        public int DependentAdditionalCost { get; set; }

        public int DependentAgeLimit { get; set; }

        public int EmployeeBaseCost { get; set; }

        public int EmployeeYearLimit { get; set; }

        public decimal EmployeeAdditionalCost { get; set; }
    }
}
