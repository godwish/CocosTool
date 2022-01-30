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
    public partial class Form_SwitchAtlasUUID : Form
    {
        string str_1, str_2;
        public Form_SwitchAtlasUUID(){
            str_1 = null;
            str_2 = null;
            InitializeComponent();
        }

        private void tb_atlas_1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void tb_atlas_2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void tb_atlas_1_DragDrop(object sender, DragEventArgs e)
        {
            str_1 = null;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string[] tmp = files[0].Split('.');
            if (tmp.Length < 2) return;
            string ext = tmp[tmp.Length - 1].ToLower();
            string file_name = files[0];
            if (!"meta".Equals(ext)) file_name = files[0] + ".meta";
            string data = Util.LoadTextString(file_name);
            if (data == null) return;
            str_1 = data;
            tb_atlas_1.Text = file_name;
        }
        private void tb_atlas_2_DragDrop(object sender, DragEventArgs e)
        {
            str_2 = null;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string[] tmp = files[0].Split('.');
            if (tmp.Length < 2) return;
            string ext = tmp[tmp.Length - 1].ToLower();
            string file_name = files[0];
            if (!"meta".Equals(ext)) file_name = files[0] + ".meta";
            string data = Util.LoadTextString(file_name);
            if (data == null) return;
            str_2 = data;
            tb_atlas_2.Text = file_name;
        }

        private void textBox2_TextChanged(object sender, EventArgs e){ }

        private void textBox1_TextChanged(object sender, EventArgs e){ }

        private void tb_atlas_2_TextChanged(object sender, EventArgs e){ }

        private void tb_atlas_1_TextChanged(object sender, EventArgs e){ }

        private void Form_SwitchAtlasUUID_Load(object sender, EventArgs e)
        {
            JsonData lng = Common.language["SwitchAtlasUUID"];
            int cur = 0;
            textBox1.Text = LitJsonGet.String(lng[cur++]);
            textBox2.Text = LitJsonGet.String(lng[cur++]);
            btn_switch.Text = LitJsonGet.String(lng[cur++]);
            this.Text = LitJsonGet.String(lng[cur++]);

        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            if (str_1 == null || str_2 == null) return;
            JsonData jd_1 = LitJsonGet.Get(str_1);
            JsonData jd_2 = LitJsonGet.Get(str_2);
            if (jd_1 == null || jd_2 == null) return;
            string uuid;
            string tid_1, tid_2;

            tid_1 = LitJsonGet.String((string)jd_1["rawTextureUuid"]);
            tid_2 = LitJsonGet.String((string)jd_2["rawTextureUuid"]);

            jd_1["rawTextureUuid"] = tid_2;
            jd_2["rawTextureUuid"] = tid_1;
            uuid = LitJsonGet.String((string)jd_1["uuid"]);
            jd_1["uuid"] = jd_2["uuid"];
            jd_2["uuid"] = uuid;

            JsonData sub_1 = jd_1["subMetas"];
            JsonData sub_2 = jd_2["subMetas"];
            int num_switch = 0;
            foreach (var key in sub_1.Keys)
            {
                if (sub_2.ContainsKey(key))
                { // 같은 네이밍이 있다면 스위칭 해준다.
                    ++num_switch;
                    JsonData one_1 = sub_1[key];
                    JsonData one_2 = sub_2[key];
                    uuid = LitJsonGet.String((string)one_1["uuid"]);
                    one_1["uuid"] = one_2["uuid"];
                    one_2["uuid"] = uuid;
                }
            }
            foreach (var key in sub_1.Keys) sub_1[key]["rawTextureUuid"] = tid_2;
            foreach (var key in sub_2.Keys) sub_2[key]["rawTextureUuid"] = tid_1;

            Util.SaveTextString(tb_atlas_1.Text,jd_1.ToJson());
            Util.SaveTextString(tb_atlas_2.Text, jd_2.ToJson());
            MessageBox.Show(LitJsonGet.String(Common.language["SwitchAtlasUUID"][4]).Replace("@1@", num_switch.ToString()));
        }
    }
}
