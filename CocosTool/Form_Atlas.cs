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
    public partial class Form_Atlas : Form
    {
        List<string> lst_search_files;
        Dictionary<string, string> dic_name;
        string uuid_atlas;
        public Form_Atlas()
        {
            InitializeComponent();
            dic_name = new();
            lst_search_files = new();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lst_search_files.Clear();
            tb_target_folder.Text = "";
            tb_atlas.Text = "";
            lb_search.Items.Clear();
            lb_result.Items.Clear();
        }
        private void tb_atlas_DragLeave(object sender, EventArgs e) { }


        private void tb_target_folder_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            tb_target_folder.Text = files[0];
        }

        private void tb_target_folder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        

        private void tb_atlas_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void tb_atlas_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            // meta 파일 아니면 meta 붙여준다.
            string[] tmp = files[0].Split('.');
            if (tmp.Length < 2) return;
            string ext = tmp[tmp.Length - 1].ToLower();
            string file_name = files[0];
            if (!"meta".Equals(ext)) file_name = files[0] + ".meta";
            string data = Util.LoadTextString(file_name);
            if (data == null) return;
            JsonData jd = LitJsonGet.Get(data);
            if (!jd.ContainsKey("subMetas")) return;
            uuid_atlas = LitJsonGet.String(jd["uuid"]);
            tb_atlas.Text = file_name; // 파일이 있으면 정해준다.

            dic_name.Clear();
            JsonData images = jd["subMetas"];
            foreach (var item in images.Keys)
            {
                string name = item;
                JsonData one = images[name];
                string uuid = (string)one["uuid"];
                dic_name.Add(name, uuid);
                lb_search.Items.Add(name);
            }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (lb_search.SelectedItem == null) return;
            lb_result.Items.Clear(); // 기존 결과 지우기

            string uuid = dic_name[(string)lb_search.SelectedItem];

            CocosProcess.Search(tb_target_folder.Text, out List<string> files);
            pb_protage.Maximum = files.Count;

            for (int i = 0; i < files.Count; ++i)
            {
                pb_protage.Value = i + 1;
                if (!CocosProcess.IsContainUUID(files[i], uuid)) continue;
                lb_result.Items.Add(files[i]);
            }
        }

        private void lb_result_DoubleClick(object sender, EventArgs e)
        {
            if (lb_result.SelectedItem == null) return;
            string file_name = lb_result.SelectedItem.ToString();
            string[] tmp = file_name.Split('.');
            if (tmp.Length < 2) return;
            string ext = tmp[tmp.Length - 1].ToLower();

            if (!"prefab".Equals(ext) && !"fire".Equals(ext)) return;
            var frm = new Form_Viewer();
            frm.Init(file_name, dic_name[lb_search.SelectedItem.ToString()], uuid_atlas);
            frm.Show();
        }
    }
}
