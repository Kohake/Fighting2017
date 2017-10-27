using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightingEngine2017;

namespace FightingGame2017
{
    abstract class Action
    {
        CharacterState targetState;
        int priority;
        //List<Condition> conditions;
    }
}
