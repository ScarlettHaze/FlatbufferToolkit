using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatbufferToolkit.UI.Nodes;

public static class TreeViewExtensions
{
    public static void AddNodesToTree(this TreeView tree, TreeNode nodes)
    {
        if (tree.InvokeRequired)
        {
            tree.Invoke(new Action(() =>
            {
                tree.Nodes.Add(nodes);
            }));
        }
        else
        {
            tree.Nodes.Add(nodes);
        }
    }
}