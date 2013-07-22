
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
			: base("角色跳跃" , "")
		{
			_action_type = "char_jump_to";
		}
	}


	class ActionENTER_SCENE : StoryAction {
		
	protected int _scene_id = 1001;
 	[DesignerInteger("scene_id", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 0, 9999999, 1, "Meters")]
        public int scene_id
        {
            get { return _scene_id; }
            set { _scene_id = value; }
        }


	protected int _map_id = 1001;
 	[DesignerInteger("map_id", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 0, 9999999, 1, "Meters")]
        public int map_id
        {
            get { return _map_id; }
            set { _map_id = value; }
        }


	protected int _x = 10;
 	[DesignerInteger("x", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 0, 9999999, 1, "Meters")]
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }


	protected int _y = 10;
 	[DesignerInteger("y", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 1, 9999999, 1, "Meters")]
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }


                protected override void CloneProperties(Brainiac.Design.Nodes.Node newnode)
                {
                    base.CloneProperties(newnode);
                    ActionENTER_SCENE node = (ActionENTER_SCENE)newnode;
		    node._scene_id = _scene_id;
node._map_id = _map_id;
node._x = _x;
node._y = _y;

                }
		public ActionENTER_SCENE()
			: base("创建场景" , "")
		{
			_action_type = "enter_scene";
		}
	}


	class ActionCREATE_CHAR : StoryAction {
		
	protected int _id = 1;
 	[DesignerInteger("id", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 0, 9999999, 1, "Meters")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }


	protected int _res_id = 10012;
 	[DesignerInteger("res_id", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 0, 9999999, 1, "Meters")]
        public int res_id
        {
            get { return _res_id; }
            set { _res_id = value; }
        }


	protected int _icon = 10012;
 	[DesignerInteger("icon", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 0, 9999999, 1, "Meters")]
        public int icon
        {
            get { return _icon; }
            set { _icon = value; }
        }


        protected string _name = "王二小";
        [DesignerString("name", "", "CategoryBasic", DesignerProperty.DisplayMode.NoDisplay, 0, DesignerProperty.DesignerFlags.NoFlags)]       
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }


	protected int _x = 10;
 	[DesignerInteger("x", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 0, 9999999, 1, "Meters")]
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }


	protected int _y = 10;
 	[DesignerInteger("y", "", "CategoryBasic", DesignerProperty.DisplayMode.List, 0, DesignerProperty.DesignerFlags.NoFlags, 1, 9999999, 1, "Meters")]
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }


                protected override void CloneProperties(Brainiac.Design.Nodes.Node newnode)
                {
                    base.CloneProperties(newnode);
                    ActionCREATE_CHAR node = (ActionCREATE_CHAR)newnode;
		    node._id = _id;
node._res_id = _res_id;
node._icon = _icon;
node._name = _name;
node._x = _x;
node._y = _y;

                }
		public ActionCREATE_CHAR()
			: base("创建角色" , "")
		{
			_action_type = "create_char";
		}
	}


	class ActionCHAR_WALK_TO : StoryAction {
		
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
                    ActionCHAR_WALK_TO node = (ActionCHAR_WALK_TO)newnode;
		    node._id = _id;
node._ex = _ex;
node._ey = _ey;

                }
		public ActionCHAR_WALK_TO()
			: base("角色移动" , "")
		{
			_action_type = "char_walk_to";
		}
	}

	

    class ActionSet
    {
        public void AddActions(NodeGroup actions) {
            // actions.Items.Add(typeof(Nodes.ActionCharPlayAction));
	    actions.Items.Add(typeof(Nodes.ActionCHAR_JUMP_TO));
actions.Items.Add(typeof(Nodes.ActionENTER_SCENE));
actions.Items.Add(typeof(Nodes.ActionCREATE_CHAR));
actions.Items.Add(typeof(Nodes.ActionCHAR_WALK_TO));

        }
    }
}

