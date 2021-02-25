using System.Collections.Generic;

namespace BlazorTalentCalc.Shared.Models
{
    public class TalentBuild
    {
        public TalentClass Class { get; set; }
        public IList<TalentRank> Ranks { get; set; }
        public IList<BuildStep> Steps { get; set; }
    }
}
