using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    //пример конкретного скилла
    class IncreaseHitPoint : Skill
    {
        private int IncreaseHitPoints;
        public override void Apply(Person person) { }
        protected override void Recharge() { }
        protected override void CountdownTimeOfAction() { }
    }
}
