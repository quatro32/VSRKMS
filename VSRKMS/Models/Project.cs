using Microsoft.AspNetCore.Components.Routing;

namespace VSRKMS.Models
{
    public class Project
    {
        public int IDSelf { get; set; }
        public string Name { get; set; }
        public string Cleaner { get; set; }
        public string Constituant { get; set; }
        public Location LocationEssentials { get; set; }
    }
}