using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Xml;

namespace AlbanianXrm.SolutionPackager.Automation
{
    [Cmdlet("Format", "SolutionComponent")]
    public class FormatSolutionComponentCmdlet : Cmdlet
    {
        [Parameter(ValueFromPipeline = true)]
        public string Target { get; set; }

        protected override void ProcessRecord()
        {
            XmlDocument xmlDocument = new XmlDocument();
            using (var file = File.OpenText(Target))
            {
                xmlDocument.Load(file);
            }
            var importExportXml = xmlDocument.SelectSingleNode("ImportExportXml");
            if (importExportXml == null)
            {
                WriteWarning("ImportExportXml Node not found");
                return;
            }
            var solutionManifest = importExportXml.SelectSingleNode("SolutionManifest");
            var missingDependencies = solutionManifest.SelectSingleNode("MissingDependencies");

            var tempMissingDependencies = missingDependencies.ChildNodes.Cast<XmlNode>().OrderBy(x => x.SelectSingleNode("Required").Attributes["key"]?.Value)
                                                             .ThenBy(x => x.SelectSingleNode("Required").Attributes["type"]?.Value)
                                                             .ThenBy(x => x.SelectSingleNode("Dependent").Attributes["key"]?.Value)
                                                             .ThenBy(x => x.SelectSingleNode("Dependent").Attributes["type"]?.Value)
                                                             .ThenBy(x => x.SelectSingleNode("Required").Attributes["schemaName"]?.Value ?? "")
                                                             .ThenBy(x => x.SelectSingleNode("Dependent").Attributes["schemaName"]?.Value ?? "")
                                                             .ThenBy(x => x.SelectSingleNode("Required").Attributes["id"]?.Value ?? "")
                                                             .ThenBy(x => x.SelectSingleNode("Dependent").Attributes["id"]?.Value ?? "").ToList();

            missingDependencies.RemoveAll();

            foreach (var missingDependency in tempMissingDependencies)
            {
                missingDependencies.AppendChild(missingDependency);
            }

            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                NewLineOnAttributes = true
            };

            using (XmlWriter writer = XmlWriter.Create(Target, settings))
            {
                xmlDocument.WriteTo(writer);
            }

        }
    }
}
