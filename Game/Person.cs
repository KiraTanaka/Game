using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Person
    {
        private int Id;
        private Characteristics baseCharacteristics;
        private Characteristics characteristics;
        private Person selectedPerson;
        internal Characteristics BaseCharacteristics { get; set; }
        internal Characteristics Characteristics { get; set; }
        internal Person SelectedPerson { get; set; }
        List<Skill> LearnedSkills = new List<Skill>();
        List<Skill> AppliedSkills = new List<Skill>();
        void ApplyStill() { }
       /* void Attack() { }       
        void Protection() { }*/
        void Move(double x, double y) { }
        public void AddLearnedSkill(Skill skill) { }
        public void AddAppliedSkill(Skill skill) { }
        public void RemoveAppliedSkill(Skill skill) { }
        public void RemoveLearnedSkill(Skill skill) { }
        public void RemoveAppliedSkillAt(int index) { }
        public void RemoveLearnedSkillAt(int index) { }
    }
}
