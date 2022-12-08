using VSRKMS.Models.Interfaces;

namespace VSRKMS.Models
{
    public class RoomElement : IElement
    {
        public string Guid { get; set; }
        public string Name { get; set; }
        public int ElementId { get; set; }
        public List<Fault> Faults { get; set; }
    }
}
