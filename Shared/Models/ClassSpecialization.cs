using System.Collections.Generic;

#nullable enable

namespace BlazorTalentCalc.Shared.Models
{
    public class ClassSpecialization
    {
        public int Key { get; private set; }
        public string Name { get; private set; }
        public IList<TalentNode> Talents { get; private set; }

        public ClassSpecialization(int key, string name)
        {
            Key = key;
            Name = name;
            Talents = new List<TalentNode>();
        }

        public TalentNode AddTalent(int key, string name, string textFormat, int? requirement = null, string? mana = null, string? range = null, string? cast = null, string? cooldown = null)
        {
            var talent = new TalentNode(key, name, textFormat, this, requirement, mana, range, cast, cooldown);

            Talents.Add(talent);

            return talent;
        }
    }
}
