using VSRKMS.Models;

namespace VSRKMS.Data
{
    public class Current
    {
        private static Current _instance;

        private Current() { }

        public static Current Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Current();

                return _instance;
            }
        }

        public Audit Audit { get; set; }
        public AuditCategory AuditCategory { get; set; }
        public RoomElement RoomElement { get; set; }
        public Room Room { get; set; }
    }
}