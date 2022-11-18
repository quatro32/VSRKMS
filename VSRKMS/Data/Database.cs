using IndexedDB.Blazor;
using Microsoft.JSInterop;
using VSRKMS.Models;

namespace VSRKMS.Data
{
    public class Database : IndexedDb
    {
        public Database(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }
        public IndexedSet<Audit> Audits { get; set; }
    }
}
