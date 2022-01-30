using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 자료형들을 여기에 정의 하도록 하자

public class info_node
{
    public string name;
    public int idx;
    public int[] child;
    public int[] components;
    public void Close()
    {
        name = null;
        child = null;
        components = null;
    }
}
public class info_tree
{
    public TreeNode parent;
    public int idx;
}
public class info_same_name_sprite
{
    public string uuid_find;
    public string uuid_replace;
    public void Close()
    {
        uuid_find = null;
        uuid_replace = null;
    }
}
public class info_uuid_sprite
{
    public string uuid_texture;
    public string uuid_sprite;
    public void Close()
    {
        uuid_texture = null;
        uuid_sprite = null;
    }
}