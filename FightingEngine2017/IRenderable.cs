﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    public interface IRenderable
    {
        void OnRender(RenderContext renderContext);
    }
}
