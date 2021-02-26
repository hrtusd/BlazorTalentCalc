#nullable disable

namespace BlazorTalentCalc.Shared.Data
{
    public class SpecDTO
    {
        public Specialization[] specializations { get; set; }
    }

    public class Specialization
    {
        public int key { get; set; }
        public string name { get; set; }
        public Talent[] talents { get; set; }
    }

    public class Talent
    {
        public int key { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        #nullable enable
        public string? mana { get; set; }
        public string? range { get; set; }
        public string? cast { get; set; }
        public string? cooldown { get; set; }
        public int? requirement { get; set; }
        #nullable restore
        public string[][] ranks { get; set; }
        public int[] position { get; set; }
    }
}
