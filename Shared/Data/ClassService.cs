﻿using BlazorTalentCalc.Shared.Models;
using System.Collections.Generic;

namespace BlazorTalentCalc.Shared.Data
{
    public class ClassService
    {
        public IList<TalentClass> GetTalentClasses()
        {
            var classes = new List<TalentClass>()
            {
                new TalentClass(1, "Death Knight"),
                new TalentClass(2, "Demon Hunter"),
                new TalentClass(3, "Druid"),
                new TalentClass(4, "Hunter"),
                new TalentClass(5, "Mage"),
                new TalentClass(6, "Monk"),
                new TalentClass(7, "Paladin"),
                new TalentClass(8, "Priest"),
                new TalentClass(9, "Rogue"),
                new TalentClass(10, "Shaman"),
                new TalentClass(11, "Warlock"),
                new TalentClass(12, "Warrior")
            };

            return classes;
        }

        public IList<TalentNode> GetTalentNodes(TalentClass talentClass)
        {
            if (talentClass.Talents.Count == 0)
            {
                switch (talentClass.Key)
                {
                    case 3:
                        talentClass.AddTalent("Nature's Grasp", "While active, get rekt.")
                            .AddRank("");

                        talentClass.AddTalent("Starlight Wrath", "Reduces cast time of Wrath by {0} sec.")
                            .AddRank("0.1")
                            .AddRank("0.2")
                            .AddRank("0.3")
                            .AddRank("0.4")
                            .AddRank("0.5");
                        break;
                }
            }

            return talentClass.Talents;
        }
    }
}