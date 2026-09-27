using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace playAround
{
    public partial class TreeView : Form
    {
        public TreeView()
        {
            InitializeComponent();
        }

        //دالة وظيفتها تشيك اذا في زر تم اختياره وترجع لنا محتوى التاغ
        // التاغ الخاص بكل زر خليته اسم الصور عشان اقدر استفيد منه بعدين في تغير الاميج في التري فيو
        //اذا لم يتم اختيار اي زر بترجع فراغ بمعنى انه ماتم تحديد نوع الملف وبيعطي رسالة خطا
        private string IsTypeSelected()
        {
            if (rbFloder.Checked)
            {
                return rbFloder.Tag.ToString();
            }
            else if (rbFile.Checked)
            {
                return rbFile.Tag.ToString();
            }
            else if (rbPdf.Checked)
            {
                return rbPdf.Tag.ToString();
            }
            else if (rbWord.Checked)
            {
                return rbWord.Tag.ToString();
            }
            else if (rbExcel.Checked)
            {
                return rbExcel.Tag.ToString();
            }
            else if (rbImage.Checked)
            {
                return rbImage.Tag.ToString();
            }
            else if (rbVideo.Checked)
            {
                return rbVideo.Tag.ToString();
            }
            else if (rbMusic.Checked)
            {
                return rbMusic.Tag.ToString();
            }
            else
            {
                MessageBox.Show("Please select a type first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fileType = IsTypeSelected();
            if (fileType != "")
            {
                fileType += ".png";
                treeView1.Nodes[0].Nodes.Add(fileType, tbName.Text, fileType, fileType);

            }
        }

        //دالة لاضافة نود جديده تحت النودز المختارة 
        private void AddNewNode(TreeNodeCollection tree, string fileType)
        {
                foreach (TreeNode item in tree)
                {
                    if (item.Checked)
                    {
                    // فائدة الشرط ذا انه مايتم اضافة ملفات فرعية الا لو كان مجلد او الروت 
                    // لان بالمنطق لو كانت النود المختارة مثلا صورة فلا يمكن اضافة شي فرعي بداخلها
                        if (item.ImageKey == "folder.png" || item.ImageKey == "pc.png")
                        {
                            item.Nodes.Add(fileType, tbName.Text, fileType , fileType);
                    }else
                        {
                        MessageBox.Show("Destination must be a folder to contain other items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                }
                 AddNewNode(item.Nodes, fileType);

                }
        }
        // دالة لحذف النود المحددة
        private void DeleteSelectedNode(TreeNodeCollection tree)
        {
            for (int i = tree.Count - 1; i >= 0; i--)
            {
                TreeNode item = tree[i];

                DeleteSelectedNode(item.Nodes);
                // فائدة الشق الثاني من الشرط هو منع حذف الروت والي هو ال
                //pc
                if (item.Checked && item.Parent != null)
                {
                    tree.RemoveAt(i);
                }
            }
        }

        //Add to Selected
        private void button2_Click(object sender, EventArgs e)
        {
            string fileType = IsTypeSelected();
            if (fileType!="") {
                fileType += ".png";
                AddNewNode(treeView1.Nodes, fileType);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        //Delete Selected Nodes
        private void button5_Click(object sender, EventArgs e)
        {
            DeleteSelectedNode(treeView1.Nodes);
        }

   

        //دالة تجلب الباث للعنصر المحدد
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblPath.Text = "Path: " + treeView1.SelectedNode.FullPath;

        }

        //دالة تبحث عن نود باسمها وتظهر لنا اول نود تطابق البحث
        private bool FindNodeByName(TreeNodeCollection tree, string nodeName)
        {
            foreach (TreeNode item in tree)
            {
                if (item.Text == nodeName)
                {
                    item.Checked = true;
                    item.EnsureVisible(); // لو كل المجلدات مغلقة بتنفتح لين النود الي تم البحث عنها
                    return true;
                }

                if (FindNodeByName(item.Nodes, nodeName))
                {
                    return true;
                }
                
            }
            return false;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //ذا الحدث عشان لما اضغط انتر على التكست بوكس حق البحث ننادي دالة البحث 
            //عشان تعرف الخصائص الخاصة ب e 
            //يمديك تكتبه ثم تكتب دوت وبتظهر كل الخصائص مع شرح فايدتها ومن ذي الحركة عرفت فايدة ال
            //KeyCode وانها ترجع لنا الزر الي تم نقره بالضبط هل هو انتر او سبيس او غيره
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; //توقف صوت النظام المزعج 

                if (!FindNodeByName(treeView1.Nodes, textBox1.Text))
                {
                    MessageBox.Show("Oops! We couldn't find what you're looking for.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }


    }
}
