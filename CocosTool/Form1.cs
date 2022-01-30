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
    public partial class Form1 : Form
    {
        List<string> lst_search_files;
        Dictionary<string, string> dic_uuid;
        public Form1()
        {
            InitializeComponent();
            dic_uuid = new();
            lst_search_files = new();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pb_protage_Click(object sender, EventArgs e){}

        private void tb_target_folder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void tb_target_folder_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            tb_target_folder.Text = files[0];
        }

        private void lb_search_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void lb_search_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < files.Length; ++i)
            {
                string[] strs = files[i].Split('.');
                if (strs.Length >= 2)
                {
                    string ext = strs[^1];
                    if (ext == "meta")
                    {
                        lb_search.Items.Add(files[i]);
                        lst_search_files.Add(files[i]);
                    }
                }
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            lst_search_files.Clear();
            tb_target_folder.Text = "";
            lb_search.Items.Clear();
            lb_result.Items.Clear();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            lb_result.Items.Clear(); // 기존 결과 지우기
            dic_uuid.Clear();
            // 리스트에 있는 파일중에 uuid 
            for(int i=0;i< lst_search_files.Count; ++i) CocosProcess.GetUUID(lst_search_files[i], ref dic_uuid);
            /*
            if (dic_uuid.ContainsKey("4e504279-047d-42e6-8715-7f3f3df5df38"))
            {

                int a = 1;
            }
            */
            // 비교할 파일들 만들어주기
            CocosProcess.Search(tb_target_folder.Text, out List<string> files);
            pb_protage.Maximum = files.Count;

            for (int i = 0; i < files.Count; ++i)
            {
                pb_protage.Value = i + 1;
                if (!CocosProcess.IsContainUUID(files[i], ref dic_uuid)) continue;
                lb_result.Items.Add(files[i]);
            }
        }

        private void lb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lb_search.SelectedItem.ToString());
        }

        private void lb_result_SelectedIndexChanged(object sender, EventArgs e){ }


        private void lb_result_DoubleClick(object sender, EventArgs e)
        {
            if (lb_result.SelectedItem == null) return;
            string file_name = lb_result.SelectedItem.ToString();
            string[] tmp = file_name.Split('.');
            if (tmp.Length < 2) return;
            string ext = tmp[^1].ToLower();

            if (!"prefab".Equals(ext) && !"fire".Equals(ext)) return;
            var frm = new Form_Viewer();
            frm.Init(file_name, dic_uuid);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonData lng = Common.language["FilesSearch"];
            int cur = 0;
            btn_reset.Text = LitJsonGet.String(lng[cur++]);
            btn_start.Text = LitJsonGet.String(lng[cur++]);
            textBox2.Text = LitJsonGet.String(lng[cur++]);
            textBox4.Text = LitJsonGet.String(lng[cur++]);
            textBox5.Text = LitJsonGet.String(lng[cur++]);
            this.Text = LitJsonGet.String(lng[cur++]);

        }
    }
}
