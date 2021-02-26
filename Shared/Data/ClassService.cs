using BlazorTalentCalc.Shared.Models;
using System.Collections.Generic;

namespace BlazorTalentCalc.Shared.Data
{
    public class ClassService
    {
        public IList<TalentClass> GetTalentClasses()
        {
            var classes = new List<TalentClass>()
            {
                //new TalentClass(1, "Death Knight"),
                //new TalentClass(2, "Demon Hunter"),
                new TalentClass(3, "Druid"),
                new TalentClass(4, "Hunter"),
                new TalentClass(5, "Mage"),
                //new TalentClass(6, "Monk"),
                new TalentClass(7, "Paladin"),
                new TalentClass(8, "Priest"),
                new TalentClass(9, "Rogue"),
                new TalentClass(10, "Shaman"),
                new TalentClass(11, "Warlock"),
                new TalentClass(12, "Warrior")
            };

            return classes;
        }

        public IList<ClassSpecialization> GetClassSpecializations(TalentClass talentClass, SpecDTO data)
        {
            if (talentClass.Specializations.Count == 0)
            {
                foreach (var specialization in data.specializations)
                {
                    var spec = talentClass.AddSpecialization(specialization.key, specialization.name);

                    foreach (var node in specialization.talents)
                    {
                        var talentNode = spec.AddTalent(node.key, node.name, node.text, node.requirement, node.mana, node.range, node.cast, node.cooldown);

                        foreach (var rank in node.ranks)
                        {
                            talentNode.AddRank(rank);
                        }

                        talentNode.SetPosition(node.position[0], node.position[1]);
                    }
                }
            }

            return talentClass.Specializations;
        }
    }
}
