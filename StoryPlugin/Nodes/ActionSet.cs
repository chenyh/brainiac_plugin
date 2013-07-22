
using System;
using System.Collections.Generic;
using System.Text;
using Brainiac.Design.Attributes;
using StoryPlugin.Properties;
using StoryPlugin;
using Brainiac.Design;

namespace StoryPlugin.Nodes
{
    
	class ActionCHAR_JUMP_TO : StoryAction {
		
	protected int _id = 1;
 	[DesignerInteger("id", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 0, 9999999, 1, "Meters")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }


	protected int _ex = 10;
 	[DesignerInteger("ex", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 0, 9999999, 1, "Meters")]
        public int ex
        {
            get { return _ex; }
            set { _ex = value; }
        }


	protected int _ey = 10;
 	[DesignerInteger("ey", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 1, 9999999, 1, "Meters")]
        public int ey
        {
            get { return _ey; }
            set { _ey = value; }
        }


                protected override void CloneProperties(Brainiac.Design.Nodes.Node newnode)
                {
                    base.CloneProperties(newnode);
                    ActionCHAR_JUMP_TO node = (ActionCHAR_JUMP_TO)newnode;
		    node._id = _id;
node._ex = _ex;
node._ey = _ey;

                }
		public ActionCHAR_JUMP_TO()
			: base("½ÇÉ«ÌøÔ¾" , "")
		{
			_action_type = "char_jump_to";
		}
	}

	

    class ActionSet
    {
        public void AddActions(NodeGroup actions) {
            // actions.Items.Add(typeof(Nodes.ActionCharPlayAction));
	    actions.Items.Add(typeof(Nodes.ActionCHAR_JUMP_TO));

        }
    }
}

