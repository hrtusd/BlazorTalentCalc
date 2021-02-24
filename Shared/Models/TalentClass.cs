using System.Collections.Generic;

#nullable enable

namespace BlazorTalentCalc.Shared.Models
{
    public class TalentClass
    {
        public int Key { get; private set; }
        public string Name { get; private set; }
        public IList<TalentNode> Talents { get; private set; }

        private int idx;

        public TalentClass(int key, string name)
        {
            Key = key;
            Name = name;
            Talents = new List<TalentNode>();

            idx = 0;
        }

        public TalentNode AddTalent(string name, string textFormat, TalentNode? requirement = null)
        {
            var talent = new TalentNode(idx++, name, textFormat, this, requirement);

            Talents.Add(talent);

            return talent;
        }
    }
}
