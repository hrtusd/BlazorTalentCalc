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

        public IList<ClassSpecialization> GetClassSpecializations(TalentClass talentClass)
        {
            if (talentClass.Specializations.Count == 0)
            {
                switch (talentClass.Key)
                {
                    case 3:
                        talentClass.AddSpecialization("Balance")
                            .AddTalent("Starlight Wrath", "Reduces cast time of Wrath by {0} sec.")
                                .AddRank("0.1")
                                .AddRank("0.2")
                                .AddRank("0.3")
                                .AddRank("0.4")
                                .AddRank("0.5")
                                .SetPosition(0, 0)
                            .AddTalent("Nature's Grasp", "While active, get rekt.")
                                .AddRank("")
                                .SetPosition(0, 1)
                            .AddTalent("Starlight Wrath 2", "Reduces cast time of Wrath by {0} sec.")
                                .AddRank("0.1")
                                .AddRank("0.2")
                                .AddRank("0.3")
                                .AddRank("0.4")
                                .AddRank("0.5")
                                .SetPosition(0, 2)
                            .AddTalent("Improved Moonfire", "Increases the damage and critical strike chance of your Moonfire spell by {0}%.")
                                .AddRank("5")
                                .AddRank("10")
                                .SetPosition(1, 2)
                            .AddTalent("Insect swarm", "DoT fuck.")
                                .AddRank()
                                .SetPosition(2, 2);

                        talentClass.AddSpecialization("Feral")
                            .AddTalent("Ferocity", "PH {0}")
                                .AddRank("1")
                                .AddRank("2")
                                .AddRank("3")
                                .AddRank("4")
                                .AddRank("5")
                                .SetPosition(0, 1)
                            .AddTalent("Brutal Impact", "Stun duration by {0} sec.")
                                .AddRank("0.5")
                                .AddRank("1")
                                .SetPosition(1, 1);

                        talentClass.AddSpecialization("Restoration")
                            .AddTalent("Improved Mark of the Wild", "PH {0}")
                                .AddRank("1")
                                .AddRank("2")
                                .AddRank("3")
                                .AddRank("4")
                                .AddRank("5")
                                .SetPosition(0, 1)
                            .AddTalent("Furor", "Stun duration by {0} sec.")
                                .AddRank("1")
                                .AddRank("2")
                                .AddRank("3")
                                .AddRank("4")
                                .AddRank("5")
                                .SetPosition(0, 2);
                        break;
                }
            }

            return talentClass.Specializations;
        }
    }
}
