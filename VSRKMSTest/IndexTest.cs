using Blazored.SessionStorage;
using IndexedDB.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VSRKMS.Data;
using VSRKMS.Models;
using VSRKMS.Pages;

namespace VSRKMSTest
{
    public class IndexTest : TestContext
    {
        //    [Fact]
        //    public async void CheckDatabaseFilledAfterClickOnAudit()
        //    {
        //        using (var ctx = new TestContext())
        //        {
        //            //add indexeddb factory singleton for databse storage
        //            ctx.Services.AddSingleton<IIndexedDbFactory, IndexedDbFactory>();
        //            //add sessionstorage
        //            ctx.Services.AddBlazoredSessionStorage();

        //            ctx.JSInterop.Mode = JSRuntimeMode.Loose;

        //            //get db factory from index
        //            IIndexedDbFactory factory = ctx.Services.GetService<IIndexedDbFactory>();
        //            //create component to test
        //            var cut = ctx.RenderComponent<VSRKMS.Pages.Index>();

        //            //create db instance to test insertion of data into database
        //            using (var db = await factory.Create<Database>())
        //            {
        //                int CountBeforeClickingRow = db.Audits.Count;
        //                //get first row in table
        //                cut.FindAll("tbody tr").First().Click();

        //                int CountAfterClickingRow = db.Audits.Count;
        //                var qq = "";
        //            }
        //        }
        //    }

        [Fact]
        public async void ShowSpinnerWhenListIsNotFilledAndHasSearchedForAudits()
        {
            using (var ctx = new TestContext())
            {
                //add indexeddb factory singleton for databse storage
                ctx.Services.AddSingleton<IIndexedDbFactory, IndexedDbFactory>();
                //add sessionstorage
                ctx.Services.AddBlazoredSessionStorage();
                //create component under testing
                var cut = ctx.RenderComponent<VSRKMS.Pages.Index>();



                var methods = typeof(VSRKMS.Pages.Index).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Select(i => i.Name);


                FieldInfo fi = typeof(VSRKMS.Pages.Index).GetField("auditPreviews", BindingFlags.NonPublic | BindingFlags.Instance);
                var value = fi.GetValue(cut.Instance);


                var text1 = cut.Find("h2").TextContent;






                cut.WaitForAssertion(() => fi.SetValue(cut.Instance, new List<AuditPreview>()));

                var value1 = fi.GetValue(cut.Instance);

                var text2 = cut.Find("h2").TextContent;

                var qq = "";
            }
        }
    }
}
