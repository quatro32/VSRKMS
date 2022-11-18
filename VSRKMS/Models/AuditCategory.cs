namespace VSRKMS.Models
{
    public class AuditCategory
    {
        public int IDSelf { get; set; }
        public int IDCategory { get; set; }
        public string CategoryName { get; set; }
        public int ColorRGB { get; set; }
        public bool IsDone { get; set; }
        public int AQL { get; set; }
        public int MaxErrorsOnAudit { get; set; }
        public int Pen { get; set; }
        public int MinRoomsOnAudit { get; set; }
        public int RandomSize { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Room> SpareRooms { get; set; }
        public List<AuditResult> AuditResults { get; set; }
        public List<Element> VsrInventoryCategoryElements { get; set; }
    }
}