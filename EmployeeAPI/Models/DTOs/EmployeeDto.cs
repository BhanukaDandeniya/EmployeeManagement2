namespace EmployeeAPI.Models.DTOs
{
    public class EmployeeDto
    {
     
        public required string EmpNo { get; set; }
        public required string EmpName { get; set; }
        public required string EmpAddressLine1 { get; set; }
        public string? EmpAddressLine2 { get; set; }
        public string? EmpAddressLine3 { get; set; }
        public DateTime EmpDateOfJoin { get; set; }
        public bool EmpStatus { get; set; }
        public required string EmpImage { get; set; }
    }
}