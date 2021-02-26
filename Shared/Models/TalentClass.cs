using System.Collections.Generic;

#nullable enable

namespace BlazorTalentCalc.Shared.Models
{
    public class TalentClass
    {
        public int Key { get; private set; }
        public string Name { get; private set; }
        public IList<ClassSpecialization> Specializations { get; private set; }

        public TalentClass(int key, string name)
        {
            Key = key;
            Name = name;
            Specializations = new List<ClassSpecialization>();
        }

        public ClassSpecialization AddSpecialization(int key, string name)
        {
            var specialization = new ClassSpecialization(key, name);

            Specializations.Add(specialization);

            return specialization;
        }
    }
}
