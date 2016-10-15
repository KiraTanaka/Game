using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Game
{
    struct Characteristics
    {
        internal Point Location { get; set; }
        internal double MovementSpeed { get; set; }
        internal int HitPoints { get; set; }
        internal int Mana { get; set; }
        internal double SpeedOfReganerationOfMana { get; set; }
        internal double SpeedOfRegenerationOfHitPoints { get; set; }
       /* internal int AttackPower { get; set; }
        internal int Protection { get; set; }*/
    }
}
