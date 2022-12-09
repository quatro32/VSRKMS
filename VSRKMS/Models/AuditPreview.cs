namespace VSRKMS.Models
{
    public class AuditPreview
    {
        public string AuditDate { get; set; }
        public bool Closed { get; set; }
        public string CreatedOn { get; set; }
        public int Id { get; set; }
        public string Location { get; set; }
        public string Organization { get; set; }
        public string Project { get; set; }
        public string UpdatedOn { get; set; }
        public bool IsLocallyStored { get; set; }
        public string IsLocallyStoredText
        {
            get { return IsLocallyStored ? "✓" : "╳"; }
        }
    }
}
