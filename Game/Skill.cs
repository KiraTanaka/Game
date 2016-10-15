using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Skill
    {
        protected int Id;
        protected string Name;
        protected bool IsActive;
        protected int TimeOfAction;
        protected int Cost;
        protected int RechargeTime;
        public abstract void Apply(Person person);
        protected abstract void Recharge();
        protected abstract void CountdownTimeOfAction();
    }
}
