using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    public class Component
    {
        private GameObject thisObject = null;
        public GameObject ThisObject
        {
            get
            {
                return thisObject;
            }
            set
            {
                if (thisObject == null)
                    thisObject = value;
            }
        }
    }
}
