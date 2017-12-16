using System;
using System.Xml;

namespace FightingEngine2017
{
    // TODO: Make this class actually do good stuff!
    class XmlFile : ContentType
    {
        protected XmlDocument xmlDocument;

        public override void Load(string filepath)
        {
            xmlDocument = new XmlDocument();
            xmlDocument.Load(filepath);
        }
    }
}
