using VSRKMS.Models.Interfaces;

namespace VSRKMS.Models
{
    public class Element : IElement
    {
        public string Name { get; set; }
        public string Remark { get; set; }
        public int ElementId { get; set; }
        public int VsrCategoryId { get; set; }
    }
}