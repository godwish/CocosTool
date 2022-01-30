using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;
using System.Windows.Forms;

public static class CocosProcess
{
    public static void GetUUID(string file_name, ref Dictionary<string, string> dic)
    {
        string str = File.ReadAllText(file_name);
        string[] lines = str.Split("\r\n");
        for (int i = 0; i < lines.Length; ++i)
        { // 36자 - 가 4개
            if (!lines[i].ToLower().Contains("uuid")) continue;
            string[] strs = lines[i].Split('"');
            for (int j = 0; j < strs.Length; ++j)
            {
                if (strs[j].Length != 36) continue;
                if (!dic.ContainsKey(strs[j])) dic.Add(strs[j], file_name);
            }
        }
    }
    public static bool IsContainUUID(string file_name, ref List<string> lst)
    {
        string str = File.ReadAllText(file_name);
        string[] lines = str.Split("\r\n");
        for (int i = 0; i < lines.Length; ++i)
        { // 36자 - 가 4개
            if (!lines[i].ToLower().Contains("uuid")) continue;
            string[] strs = lines[i].Split('"');
            for (int j = 0; j < strs.Length; ++j)
            {
                if (strs[j].Length != 36) continue;
                if (lst.Contains(strs[j])) return true;
            }
        }
        return false;
    }

    public static bool IsContainUUID(string file_name, ref Dictionary<string, string> dic)
    {
        string str = File.ReadAllText(file_name);
        string[] lines = str.Split("\r\n");
        for (int i = 0; i < lines.Length; ++i)
        { // 36자 - 가 4개
            if (!lines[i].ToLower().Contains("uuid")) continue;
            string[] strs = lines[i].Split('"');
            for (int j = 0; j < strs.Length; ++j)
            {
                if (strs[j].Length != 36) continue;
                if (dic.ContainsKey(strs[j])) return true;
            }
        }
        return false;
    }
    public static bool IsContainUUID(string file_name, string uuid)
    {
        string str = File.ReadAllText(file_name);
        string[] lines = str.Split("\r\n");
        for (int i = 0; i < lines.Length; ++i)
        { // 36자 - 가 4개
            if (!lines[i].ToLower().Contains("uuid")) continue;
            string[] strs = lines[i].Split('"');
            for (int j = 0; j < strs.Length; ++j)
            {
                if (strs[j].Length != 36) continue;
                if (uuid.Equals(strs[j])) return true;
            }
        }
        return false;
    }
    public static void Search(string start_folder, out List<string> need_search_files)
    {
        need_search_files = new();
        if (string.IsNullOrEmpty(start_folder)) return;
        List<string> folders = new();
        List<string> add_folders = new();
        add_folders.Add(start_folder);
        folders.Add(start_folder);
        do
        {
            string[] lst_folder = new string[add_folders.Count];
            for (int i = 0; i < lst_folder.Length; ++i) lst_folder[i] = add_folders[i];
            add_folders.Clear();
            for (int i = 0; i < lst_folder.Length; ++i)
            {
                string[] tmp = Directory.GetDirectories(lst_folder[i]);
                for (int j = 0; j < tmp.Length; ++j)
                {
                    add_folders.Add(tmp[j]);
                    folders.Add(tmp[j]);
                }
            }
        } while (add_folders.Count > 0);
        for (int i = 0; i < folders.Count; ++i)
        {
            string[] names = Directory.GetFiles(folders[i], "*.meta");
            for (int j = 0; j < names.Length; ++j) need_search_files.Add(names[j]);

            names = Directory.GetFiles(folders[i], "*.mtl");
            for (int j = 0; j < names.Length; ++j) need_search_files.Add(names[j]);

            names = Directory.GetFiles(folders[i], "*.prefab");
            for (int j = 0; j < names.Length; ++j) need_search_files.Add(names[j]);

            names = Directory.GetFiles(folders[i], "*.fire");
            for (int j = 0; j < names.Length; ++j) need_search_files.Add(names[j]);
        }
        folders.Clear();
        add_folders.Clear();
    }
    public static void Search2(string start_folder, out List<string> need_search_files)
    {
        need_search_files = new();
        if (string.IsNullOrEmpty(start_folder)) return;
        List<string> folders = new();
        List<string> add_folders = new();
        add_folders.Add(start_folder);
        folders.Add(start_folder);
        do
        {
            string[] lst_folder = new string[add_folders.Count];
            for (int i = 0; i < lst_folder.Length; ++i) lst_folder[i] = add_folders[i];
            add_folders.Clear();
            for (int i = 0; i < lst_folder.Length; ++i)
            {
                string[] tmp = Directory.GetDirectories(lst_folder[i]);
                for (int j = 0; j < tmp.Length; ++j)
                {
                    add_folders.Add(tmp[j]);
                    folders.Add(tmp[j]);
                }
            }
        } while (add_folders.Count > 0);
        for (int i = 0; i < folders.Count; ++i)
        {
            string[] names = Directory.GetFiles(folders[i], "*.prefab");
            for (int j = 0; j < names.Length; ++j) need_search_files.Add(names[j]);

            names = Directory.GetFiles(folders[i], "*.fire");
            for (int j = 0; j < names.Length; ++j) need_search_files.Add(names[j]);
        }
        folders.Clear();
        add_folders.Clear();
    }

    public static List<info_tree> FindStartNodex(ref JsonData jd, TreeNode parent)
    {
        List<info_tree> ret = new();
        int idx = 0;
        bool loop = true;
            
        while (loop)
        {
            JsonData one = jd[idx];
            switch ((string)one["__type__"])
            {
                case "cc.SceneAsset": idx = LitJsonGet.Int(one["scene"]["__id__"]); break;
                case "cc.Scene":
                    { // 씬의 경우 최상위 노드가 여러개일 수 있다.
                        JsonData child = one["_children"];
                        for (int i = 0; i < child.Count; ++i)
                            ret.Add(new info_tree { parent = parent, idx = LitJsonGet.Int(child[i]["__id__"]) });
                        return ret;
                    }
                case "cc.Prefab":
                    { // 프리팹은 최상위 노드가 1개다.
                        ret.Add(new info_tree { parent = parent, idx = LitJsonGet.Int(one["data"]["__id__"]) });
                        return ret;
                    }
                default: loop = false; break;
            }
        }
        return ret;
    }
    public static void SearchNInsertNode(ref JsonData jd, ref List<info_tree> lst, int search_idx, TreeNode parent)
    { // 함수로 구지 할 필요는 없어보이는데 차일드 노드들을 앞쪽으로 추가해서 제일 빠르게 꺼내 쓸 수 있게 한다.
        JsonData node = jd[search_idx];
        JsonData child = node["_children"];
        int idx = child.Count - 1;
        for (int i = 0; i < child.Count; ++i, --idx) lst.Insert(0, new info_tree { parent = parent, idx = (int)child[idx]["__id__"] });
    }
}