using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LitJson;

namespace CocosTool
{
    public partial class Form_Viewer : Form
    {
        
        public Form_Viewer()
        {
            InitializeComponent();
        }
        public void Init(string name,ref List<string> lst_uuid)
        {
            treeView1.Nodes.Clear();

            string str_prefab = Util.LoadTextString(name);
            if (string.IsNullOrEmpty(str_prefab)) return;
            JsonData prefab = LitJsonGet.Get(str_prefab);
            if (prefab == null) return;

            List<info_tree> lst_search = CocosProcess.FindStartNodex(ref prefab, null);
            StringBuilder sb = new();
            do
            {
                if (lst_search.Count > 0)
                {
                    TreeNode parent = lst_search[0].parent;
                    TreeNode tree;
                    int idx = lst_search[0].idx;
                    lst_search.RemoveAt(0);
                    string name_node = (string)prefab[idx]["_name"];
                    if( !prefab[idx].ContainsKey("_components")) continue;
                    JsonData components = prefab[idx]["_components"];
                    sb.Clear();
                    bool is_first = true;
                    for (int i = 0; i < components.Count; ++i)
                    {
                        int idx_component = LitJsonGet.Int(components[i]["__id__"]);
                        JsonData one = prefab[idx_component];

                        if (!"cc.Sprite".Equals(LitJsonGet.String(one["__type__"]))) continue;
                        if (one["_spriteFrame"] != null)
                        {
                            string uuid = LitJsonGet.String(one["_spriteFrame"]["__uuid__"]);
                            if (lst_uuid.Contains(uuid))
                            {
                                if (is_first) is_first = false;
                                else sb.Append(',');
                                sb.Append("sprite");
                                //sb.Append(dic_uuid[uuid]);

                            }
                        }
                        else if (one["_atlas"] != null)
                        {
                            string uuid = LitJsonGet.String(one["_atlas"]["__uuid__"]);
                            if (lst_uuid.Contains(uuid))
                            {
                                if (is_first) is_first = false;
                                else sb.Append(',');
                                sb.Append("atlas");
                                //sb.Append(dic_uuid[uuid]);
                            }
                        }
                    }
                    if (sb.Length > 0) name_node = name_node + " <---------------- " + sb.ToString();
                    if (parent == null) tree = treeView1.Nodes.Add(name_node);
                    else tree = parent.Nodes.Add(name_node);
                    CocosProcess.SearchNInsertNode(ref prefab, ref lst_search, idx, tree);
                }
            } while (lst_search.Count > 0);
            treeView1.ExpandAll();
            treeView1.Nodes[0].EnsureVisible();
        }
        public void Init(string name,Dictionary<string, string> dic_uuid)
        {
            treeView1.Nodes.Clear();

            string str_prefab = Util.LoadTextString(name);
            if (string.IsNullOrEmpty(str_prefab)) return;
            JsonData prefab = LitJsonGet.Get(str_prefab);
            if (prefab == null) return;

            List<info_tree> lst_search = CocosProcess.FindStartNodex(ref prefab, null);
            StringBuilder sb = new();
            do
            {
                if (lst_search.Count > 0)
                {
                    TreeNode parent = lst_search[0].parent;
                    TreeNode tree;
                    int idx = lst_search[0].idx;
                    lst_search.RemoveAt(0);
                    string name_node = (string)prefab[idx]["_name"];
                    JsonData components = prefab[idx]["_components"];
                    sb.Clear();
                    bool is_first = true;
                    for (int i = 0; i < components.Count; ++i)
                    {
                        int idx_component = LitJsonGet.Int(components[i]["__id__"]);
                        JsonData one = prefab[idx_component];

                        if (!"cc.Sprite".Equals(LitJsonGet.String(one["__type__"]))) continue;
                        if (one["_spriteFrame"] != null)
                        {
                            string uuid = LitJsonGet.String(one["_spriteFrame"]["__uuid__"]);
                            if (dic_uuid.ContainsKey(uuid))
                            {
                                if (is_first) is_first = false;
                                else sb.Append(',');
                                sb.Append("sprite");
                                //sb.Append(dic_uuid[uuid]);

                            }
                        }
                        else if (one["_atlas"] != null)
                        {
                            string uuid = LitJsonGet.String(one["_atlas"]["__uuid__"]);
                            if (dic_uuid.ContainsKey(uuid))
                            {
                                if (is_first) is_first = false;
                                else sb.Append(',');
                                sb.Append("atlas");
                                //sb.Append(dic_uuid[uuid]);
                            }
                        }
                    }
                    if (sb.Length > 0) name_node = name_node + " <---------------- " + sb.ToString();
                    if (parent == null) tree = treeView1.Nodes.Add(name_node);
                    else tree = parent.Nodes.Add(name_node);
                    CocosProcess.SearchNInsertNode(ref prefab, ref lst_search, idx, tree);
                }
            } while (lst_search.Count > 0);
            treeView1.ExpandAll();
            treeView1.Nodes[0].EnsureVisible();
        }
        public void Init(string name, string uuid_spr,string uuid_atlas)
        {
            treeView1.Nodes.Clear();

            string str_prefab = Util.LoadTextString(name);
            if (string.IsNullOrEmpty(str_prefab)) return;
            JsonData prefab = LitJsonGet.Get(str_prefab);
            if (prefab == null) return;

            List<info_tree> lst_search = CocosProcess.FindStartNodex(ref prefab, null);
            StringBuilder sb = new();
            do
            {
                if (lst_search.Count > 0)
                {
                    TreeNode parent = lst_search[0].parent;
                    TreeNode tree;
                    int idx = lst_search[0].idx;
                    lst_search.RemoveAt(0);
                    string name_node = (string)prefab[idx]["_name"];
                    JsonData components = prefab[idx]["_components"];
                    sb.Clear();
                    bool is_first = true;
                    for (int i = 0; i < components.Count; ++i)
                    {
                        int idx_component = LitJsonGet.Int(components[i]["__id__"]);
                        JsonData one = prefab[idx_component];

                        if (!"cc.Sprite".Equals(LitJsonGet.String(one["__type__"]))) continue;
                        if (one["_spriteFrame"] != null)
                        {
                            string uuid = LitJsonGet.String(one["_spriteFrame"]["__uuid__"]);
                            if (uuid_spr.Equals(uuid))
                            {
                                if (is_first) is_first = false;
                                else sb.Append(',');
                                sb.Append("sprite");

                            }
                        }
                        else if (one["_atlas"] != null)
                        {
                            string uuid = LitJsonGet.String(one["_atlas"]["__uuid__"]);
                            if (uuid_atlas.Equals(uuid))
                            {
                                if (is_first) is_first = false;
                                else sb.Append(',');
                                sb.Append("atlas");
                            }
                        }
                    }
                    if (sb.Length > 0) name_node = name_node + " <---------------- " + sb.ToString();
                    if (parent == null) tree = treeView1.Nodes.Add(name_node);
                    else tree = parent.Nodes.Add(name_node);
                    CocosProcess.SearchNInsertNode(ref prefab, ref lst_search, idx, tree);
                }
            } while (lst_search.Count > 0);
            treeView1.ExpandAll();
            treeView1.Nodes[0].EnsureVisible();
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e){}
        private void treeView1_DragEnter(object sender, DragEventArgs e){}
        private void Form_Viewer_Load(object sender, EventArgs e){}
    }
}
