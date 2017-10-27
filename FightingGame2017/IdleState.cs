using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame2017
{
    class IdleState : CharacterState
    {
        public override string Name { get { return "Idle State"; } }

        protected override void Start()
        {
            // Clear hurtboxes.
            // Set hurtbox.
        }

    }
}
