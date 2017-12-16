using FightingEngine2017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame2017
{
    class CharacterStateMapping : Component
    {
        Type idle = typeof(IdleState);
        Type crouch = typeof(IdleState);
        Type dash = typeof(IdleState);
        Type jumpStart = typeof(IdleState);
        Type hitStun = typeof(IdleState);
        Type blockStun = typeof(IdleState);
        Type knockdown = typeof(IdleState);
    }
}
