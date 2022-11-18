using System.Linq.Expressions;

namespace VSRKMS.Models
{
    public class Room
    {
        public string Number { get; set; }
        public string RoomFunction { get; set; }
        public int AUCount { get; set; }
        public string Guid { get; set; }
        public List<RoomElement> RoomElements { get; set; }
    }
}