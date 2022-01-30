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
    public partial class Form_UUID : Form
    {
        //Dictionary<string, string> dic_name;
        List<string> lst_search_files;
        List<string> lst_uuid;

        public Form_UUID()
        {
            InitializeComponent();
            lst_uuid = new();
            lst_search_files = new();
        }
        private void tb_target_folder_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            tb_target_folder.Text = files[0];
        }

        private void tb_target_folder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            lst_search_files.Clear();
            tb_target_folder.Text = "";
            tb_uuid.Text = "";
            lb_result.Items.Clear();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lst_uuid.Clear();
            lb_result.Items.Clear();
            if (string.IsNullOrEmpty(tb_uuid.Text)) return;
            string[] uuids = tb_uuid.Text.Replace("\r","").Split('\n');
            if (uuids.Length <= 0) return;
            lst_uuid = new(uuids);
            CocosProcess.Search(tb_target_folder.Text, out List<string> files);
            pb_protage.Maximum = files.Count;

            for (int i = 0; i < files.Count; ++i)
            {
                pb_protage.Value = i + 1;
                if (!CocosProcess.IsContainUUID(files[i],ref lst_uuid)) continue;
                lb_result.Items.Add(files[i]);
            }
        }
        private void lb_result_DoubleClick(object sender, EventArgs e)
        {
            if (lb_result.SelectedItem == null) return;

            if (lst_uuid == null) return;
            if (lst_uuid.Count <= 0) return;
            string file_name = lb_result.SelectedItem.ToString();
            string[] tmp = file_name.Split('.');
            if (tmp.Length < 2) return;
            string ext = tmp[tmp.Length - 1].ToLower();

            if (!"prefab".Equals(ext) && !"fire".Equals(ext)) return;
            var frm = new Form_Viewer();

            frm.Init(file_name,ref lst_uuid);
            frm.Show();
        }

        private void Form_UUID_Load(object sender, EventArgs e)
        {
            JsonData lng = Common.language["UUID"];
            int cur = 0;
            textBox5.Text = LitJsonGet.String(lng[cur++]);
            textBox4.Text = LitJsonGet.String(lng[cur++]);
            textBox2.Text = LitJsonGet.String(lng[cur++]);
            btn_start.Text = LitJsonGet.String(lng[cur++]);
            btn_reset.Text = LitJsonGet.String(lng[cur++]);
            this.Text = LitJsonGet.String(lng[cur++]);
        }
    }
}
