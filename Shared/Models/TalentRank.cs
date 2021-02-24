namespace BlazorTalentCalc.Shared.Models
{
    public class TalentRank
    {
        public int Rank { get; set; }
        public string[] Values { get; set; }
        public TalentNode Talent { get; set; }
    }
}
