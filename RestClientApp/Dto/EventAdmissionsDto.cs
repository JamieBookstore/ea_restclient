using System;
using System.Collections.Generic;
using System.Text;

namespace RestClientApp.Dto
{
    public class EventAdmissionsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<CategoryDto> Categories { get; set; }
}
}
