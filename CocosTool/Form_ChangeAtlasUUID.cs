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
    public partial class Form_ChangeAtlasUUID : Form
    {
        Dictionary<string, string> dic_atlas_1;
        Dictionary<string, string> dic_atlas_2;
        Dictionary<string, string> dic_uuid_1;

        List<string> lst_atlas_1;
        List<string> lst_atlas_2;
        string uuid_string_2;
        public Form_ChangeAtlasUUID()
        {
            lst_atlas_1 = new();
            lst_atlas_2 = new();
            dic_atlas_1 = new();
            dic_atlas_2 = new();
            dic_uuid_1 = new();
            InitializeComponent();
        }
        private void tb_atlas_1_DragEnter(object sender, DragEventArgs e)
        { if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy; }
        private void tb_atlas_2_DragEnter(object sender, DragEventArgs e)
        { if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy; }
        private void tb_target_DragEnter(object sender, DragEventArgs e)
        { if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy; }
        private void tb_target_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            tb_target.Text = files[0];
        }

        private void tb_atlas_1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string[] tmp = files[0].Split('.');
            if (tmp.Length < 2) return;
            string ext = tmp[tmp.Length - 1].ToLower();
            string file_name = files[0];
            if (!"meta".Equals(ext)) file_name = files[0] + ".meta";
            string data = Util.LoadTextString(file_name);
            if (data == null) return;
            tb_atlas_1.Text = file_name;

            lst_atlas_1.Clear();
            dic_atlas_1.Clear();
            dic_uuid_1.Clear();

            JsonData jd = LitJsonGet.Get(data);
            JsonData sprites = jd["subMetas"];
            foreach (var item in sprites.Keys)
            {
                string name = item;
                JsonData one = sprites[name];
                string uuid_sprite = (string)one["uuid"];
                lst_atlas_1.Add(name);
                dic_atlas_1.Add(name, uuid_sprite);
                dic_uuid_1.Add(uuid_sprite, name);
            }
        }
        private void tb_atlas_2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string[] tmp = files[0].Split('.');
            if (tmp.Length < 2) return;
            string ext = tmp[tmp.Length - 1].ToLower();
            string file_name = files[0];
            if (!"meta".Equals(ext)) file_name = files[0] + ".meta";
            string data = Util.LoadTextString(file_name);
            if (data == null) return;
            tb_atlas_2.Text = file_name;

            lst_atlas_2.Clear();
            dic_atlas_2.Clear();
            JsonData jd = LitJsonGet.Get(data);
            uuid_string_2 = LitJsonGet.String(jd["uuid"]);
            JsonData sprites = jd["subMetas"];
            foreach (var item in sprites.Keys)
            {
                string name = item;
                JsonData one = sprites[name];
                string uuid_sprite = (string)one["uuid"];
                lst_atlas_2.Add(name);
                dic_atlas_2.Add(name, uuid_sprite);
            }
        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            clb_list.Items.Clear();
            for(int i = 0; i < lst_atlas_1.Count; ++i)
            {
                if (dic_atlas_2.ContainsKey(lst_atlas_1[i])) clb_list.Items.Add(lst_atlas_1[i], false);
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_list.Items.Count; ++i) clb_list.SetItemChecked(i, false);
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_list.Items.Count; ++i) clb_list.SetItemChecked(i, true);
        }
        int ReplaceFile(string name,in List<string> lst)
        {
            int ret = 0;
            JsonData arr = LitJsonGet.Get(Util.LoadTextString(name));
            for(int i = 0; i < arr.Count; ++i)
            {
                JsonData one = arr[i];
                if (!"cc.Sprite".Equals(LitJsonGet.String(one["__type__"]))) continue;
                if (one["_spriteFrame"] == null) continue;
                string uuid = LitJsonGet.String(one["_spriteFrame"]["__uuid__"]);
                if (!dic_uuid_1.ContainsKey(uuid)) continue;
                string name_spr = dic_uuid_1[uuid];
                if (!lst.Contains(name_spr)) continue;
                one["_spriteFrame"]["__uuid__"] = dic_atlas_2[name_spr];
                if (one.ContainsKey("_atlas")) one["_atlas"]["__uuid__"] = uuid_string_2;
                ++ret;
            }
            if (ret > 0) Util.SaveTextString(name, arr.ToJson());
            return ret;
        }
        private void btn_change_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_target.Text)) return;
            if (string.IsNullOrEmpty(tb_atlas_1.Text)) return;
            if (string.IsNullOrEmpty(tb_atlas_2.Text)) return;
            List<string> select_sprites = new();

            for (int i = 0; i < clb_list.Items.Count; ++i)
            {
                if (!clb_list.GetItemChecked(i)) continue;
                select_sprites.Add(clb_list.Items[i].ToString());
            }
            if (select_sprites.Count <= 0) return;
            // 씬이나 프리팹의 스프라이트만 수정
            CocosProcess.Search2(tb_target.Text, out List<string> lst_files);
            progressBar1.Maximum = lst_files.Count;
            int num_change = 0;
            for (int i = 0; i < lst_files.Count; ++i)
            {
                progressBar1.Value = i + 1;
                num_change += ReplaceFile(lst_files[i], select_sprites);
            }
            MessageBox.Show(num_change+"개의 스프라이트를 변경했습니다.");
        }
    }
}
