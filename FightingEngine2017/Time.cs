using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML;
using SFML.System;

namespace FightingEngine2017
{
    public static class Time
    {
        public static float realTimeSinceStartup = 0.0f;

        public static void TickTock()
        {
            realTimeSinceStartup = time.ElapsedTime.AsMilliseconds();
        }
#if SFML_RENDERER
        static Clock time;
#else

#endif
    }
}
