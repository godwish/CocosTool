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
    public partial class Form_Particle3dFinder : Form
    {
        JsonData prefab;
        List<info_node> lst_node;
        Dictionary<int, int> dic_node_to_lst;
        public Form_Particle3dFinder()
        {
            InitializeComponent();
            lst_node = new();
            dic_node_to_lst = new();
            prefab = null;
        }
        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            for (int i = 0; i < lst_node.Count; ++i) lst_node[i].Close();
            lst_node.Clear();
            dic_node_to_lst.Clear();
            treeView1.Nodes.Clear();

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string name = files[0];
            string str_prefab = Util.LoadTextString(name);
            if (string.IsNullOrEmpty(str_prefab)) return;
            prefab = LitJsonGet.Get(str_prefab);
            if (prefab == null) return;

            List<info_tree> lst_search = CocosProcess.FindStartNodex(ref prefab, null);
            do
            {
                if (lst_search.Count > 0)
                {
                    TreeNode parent = lst_search[0].parent;
                    TreeNode tree;
                    int idx = lst_search[0].idx;
                    lst_search.RemoveAt(0);
                    string name_node = (string)prefab[idx]["_name"];
                    // component중에 파티클3d가 있는지 보자
                    JsonData components = prefab[idx]["_components"];
                    bool is_particle_3d = false;
                    for(int i = 0; i < components.Count; ++i)
                    {
                        int idx_component = LitJsonGet.Int(components[i]["__id__"]);
                        JsonData comp = prefab[idx_component];
                        if (((string)comp["__type__"]).Equals("cc.ParticleSystem3D")) is_particle_3d = true;
                    }
                    if (is_particle_3d) name_node = name_node + LitJsonGet.String(Common.language["Particle3dFinder"][1]);
                    if (parent == null) tree = treeView1.Nodes.Add(name_node);
                    else tree = parent.Nodes.Add(name_node);
                    CocosProcess.SearchNInsertNode(ref prefab, ref lst_search, idx, tree);
                }
            } while (lst_search.Count > 0);
            treeView1.ExpandAll();
            treeView1.Nodes[0].EnsureVisible();
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form_Particle3dFinder_Load(object sender, EventArgs e)
        {
            this.Text = LitJsonGet.String(Common.language["Particle3dFinder"][0]);
        }
    }
}
