namespace VSRKMS.Models
{
    public class FaultType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<FaultType> FaultTypes
        {
            get
            {
                List<FaultType> items = new List<FaultType>();
                items.Add(new FaultType() { Id = 1, Name = "Licht stof" });
                items.Add(new FaultType() { Id = 2, Name = "Stof, methode" });
                items.Add(new FaultType() { Id = 3, Name = "Dicht stof" });
                items.Add(new FaultType() { Id = 4, Name = "Vuil, vlek- en vingertasten" });
                items.Add(new FaultType() { Id = 5, Name = "Vuil, methode" });
                items.Add(new FaultType() { Id = 6, Name = "Aanslag" });
                items.Add(new FaultType() { Id = 7, Name = "Diversen" });
                items.Add(new FaultType() { Id = 8, Name = "Materiaal" });
                return items;
            }
        }
    }
}
