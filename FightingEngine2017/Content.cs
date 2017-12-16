using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    public static class Content
    {
        static T Load<T>(string filepath) where T : ContentType, new()
        {
            ContentType ct = new T() as ContentType;
            ct.Load(filepath);

            return (T)ct;
        }
    }
}
