#nullable enable

namespace BlazorTalentCalc.Shared.Models
{
    public class TalentRank
    {
        public int Rank { get; private set; }
        public string[] Values { get; private set; }
        public TalentNode Talent { get; private set; }

        public TalentRank(int rank, string[] values, TalentNode talent)
        {
            Rank = rank;
            Values = values;
            Talent = talent;
        }
    }
}
