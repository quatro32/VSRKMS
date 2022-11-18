using IndexedDB.Blazor;
using System.Collections.Specialized;
using VSRKMS.Data;

namespace VSRKMS.Models
{
    public class Audit
    {
        private int id { get; set; }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        private int iDSelf { get; set; }
        public int IDSelf
        {
            get
            {
                return iDSelf;
            }
            set
            {
                iDSelf = value;
            }
        }
        private int iDProject { get; set; }
        public int IDProject
        {
            get
            {
                return iDProject;
            }
            set
            {
                iDProject = value;
            }
        }
        private int iDInspector { get; set; }
        public int IDInspector
        {
            get
            {
                return iDInspector;
            }
            set
            {
                iDInspector = value;
            }
        }
        private int auditId { get; set; }
        public int AuditId
        {
            get
            {
                return auditId;
            }
            set
            {
                auditId = value;
            }
        }
        private string date { get; set; }
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        private string timeFrom { get; set; }
        public string TimeFrom
        {
            get
            {
                return timeFrom;
            }
            set
            {
                timeFrom = value;
            }
        }
        private string timeTo { get; set; }
        public string TimeTo
        {
            get
            {
                return timeTo;
            }
            set
            {
                timeTo = value;
            }
        }
        private Project projectEssentials { get; set; }
        public Project ProjectEssentials
        {
            get
            {
                return projectEssentials;
            }
            set
            {
                projectEssentials = value;
            }
        }
        private List<AuditCategory> auditCategories { get; set; }
        public List<AuditCategory> AuditCategories
        {
            get
            {
                return auditCategories;
            }
            set
            {
                auditCategories = value;
            }
        }
        public List<FaultType> FaultTypes { get { return FaultType.FaultTypes; } }

        public EventHandler OnSave;
        public async Task SaveAsync(IIndexedDbFactory dbFactory)
        {
            using (var db = await dbFactory.Create<Database>())
            {
                Audit dbAudit = db.Audits.Single(i => i.Id == Id);
                dbAudit = this;
                await db.SaveChanges();
            }
        }
    }
}
