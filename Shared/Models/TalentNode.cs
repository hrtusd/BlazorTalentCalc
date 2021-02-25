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
        public TalentPosition Position { get; private set; }
        public ClassSpecialization Specialization { get; private set; }

        private int ranksCtr;

        public TalentNode(int key, string name, string textFormat, ClassSpecialization classSpecialization, TalentNode? requirement = null)
        {
            Key = key;
            Name = name;
            TextFormat = textFormat;
            Specialization = classSpecialization;
            Requirement = requirement;

            Ranks = new List<TalentRank>();
            Position = new TalentPosition(-1, -1);

            ranksCtr = 0;
        }

        public TalentNode AddRank(params string []values)
        {
            var rank = new TalentRank(++ranksCtr, values, this);

            Ranks.Add(rank);

            return this;
        }

        public ClassSpecialization SetPosition(int row, int column)
        {
            Position = new TalentPosition(row, column);

            return Specialization;
        }
    }
}
