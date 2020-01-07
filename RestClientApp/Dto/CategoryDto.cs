using System.Collections.Generic;

namespace RestClientApp.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsStanding { get; set; }
        public HashSet<AdmissionDto> Admissions { get; set; }
    }
}