namespace VSRKMS.Models
{
    public class Fault
    {
        public string Guid { get; set; }
        public FaultType FaultType { get; set; }
        public int Count { get; set; }
    }
}