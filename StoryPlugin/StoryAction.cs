using System;
using System.Collections.Generic;
using System.Text;
using Brainiac.Design.Attributes;
using StoryPlugin.Properties;
using StoryPlugin;
using Brainiac.Design;
using Brainiac.Design.Attributes;
using Brainiac.Design.Nodes;


namespace StoryPlugin
{
    class StoryAction : Action
    {
        protected ConnectorMultiple _finishChildren;

        protected string _node_type = "Action";
        [DesignerString("NodeType", "", "CategoryExt", DesignerProperty.DisplayMode.NoDisplay, 0, DesignerProperty.DesignerFlags.ReadOnly)]
        public string NodeType
        {
            get { return _node_type; }
            set { _node_type = value; }
        }



        protected string _action_type = "";
        [DesignerString("ActionType", "", "CategoryExt", DesignerProperty.DisplayMode.NoDisplay, 0, DesignerProperty.DesignerFlags.ReadOnly)]
        public string ActionType
        {
            get { return _action_type; }
            set { _action_type = value; }
        }

        public StoryAction (string label, string description): base(label, description) {
            _finishChildren = new ConnectorMultiple(_children, string.Empty, "Finish", 1, 50);
        }
    }
}
