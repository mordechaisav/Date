using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp5.Reposetory
{
    internal class Reposentory : IReposetory<Model>
    {
        string path;
        XDocument document;

        public Reposentory(string path)
        {
            this.path = path;
            if (!File.Exists(path))
            {
                new XDocument(new XElement("Queries"
                    )).Save(path);
            }
            document = XDocument.Load(path);

        }
        public Model Add(Model model)
        {
            document.Root.Add(ToXml(model));
            document.Root.Save(path);
            return model;
        }
        private XElement ToXml(Model model)
        {
            return new XElement("Query",
                new XElement("Day", model.Day),
                new XElement("DayMonth", model.DayMonth),
                new XElement("Month", model.Month),
                new XElement("Year", model.Year),
                new XElement("Result",model.Result)
            );
        }
    }
}
