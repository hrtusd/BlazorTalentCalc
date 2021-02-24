using System.Collections.Generic;

#nullable enable

namespace BlazorTalentCalc.Shared.Models
{
    public class TalentNode
    {
        public int Key { get; private set; }
        public string Name { get; private set; }
        public string TextFormat { get; private set; }
        public TalentNode? Requirement { get; private set; }
        public IList<TalentRank> Ranks { get; private set; }
        public TalentClass Class { get; private set; }

        private int ranksCtr;

        public TalentNode(int key, string name, string textFormat, TalentClass talentClass, TalentNode? requirement = null)
        {
            Key = key;
            Name = name;
            TextFormat = textFormat;
            Class = talentClass;
            Requirement = requirement;

            Ranks = new List<TalentRank>();

            ranksCtr = 0;
        }

        public TalentNode AddRank(params string []values)
        {
            var rank = new TalentRank()
            {
                Rank = ++ranksCtr,
                Talent = this,
                Values = values
            };

            Ranks.Add(rank);

            return this;
        }
    }
}
