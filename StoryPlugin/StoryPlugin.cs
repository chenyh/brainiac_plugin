using System;
using System.Collections.Generic;
using System.Text;
using Brainiac.Design;
using StoryPlugin.Properties;

namespace StoryPlugin
{
    public class StoryPlugin : Plugin
    {
        public StoryPlugin()
        {
            AddResourceManager(Resources.ResourceManager);

            _fileManagers.Add(new FileManagerInfo(typeof(Brainiac.Design.FileManagers.FileManagerXML), "Behavior XML (*.xml)|*.xml", ".xml"));

            _exporters.Add(new ExporterInfo(typeof(Brainiac.Design.Exporters.ExporterCs), "C# Behavior Exporter (Assign Properties)", true, "C#Properties"));
            _exporters.Add(new ExporterInfo(typeof(Brainiac.Design.Exporters.ExporterCsUseParameters), "C# Behavior Exporter (Use Parameters)", true, "C#Parameters"));

            NodeGroup actions = new NodeGroup(Resources.NodeGroupActions, NodeIcon.Action, null);
            _nodeGroups.Add(actions);


            Nodes.ActionSet actionset = new Nodes.ActionSet();
            actionset.AddActions(actions);
        }
    }
}
