using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace HeChuanDoanBenh
{
    public partial class QuanLiLuat : Form
    {

        private List<Node> nodeList = new List<Node>();
        private List<Rule> ruleList = new List<Rule>();
        private List<Node> conclusionNodeList = new List<Node>();
        private List<Node> supposeNodeList = new List<Node>();
        private Main  form1;
        public QuanLiLuat(Main form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.CenterToScreen();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            form1.Init();
            this.Close();
        }

        private void QuanLiLuat_Load(object sender, EventArgs e)
        {
            LoadFromFile();
            for (int i = 0; i < nodeList.Count; i++)
            {
                IstNode.Items.Add(nodeList[i]);
            }
            for (int i = 0; i < ruleList.Count; i++)
            {
                Istrules.Items.Add(ruleList[i]);
            }
        }

        private void ShowError(string error)
        {
            MessageBox.Show(this, "Chương trình gặp lỗi: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // Environment.Exit(0);
        }

        

        private void LoadFromFile()
        {
            try
            {
                #region Đọc file nodes.txt vào nodeList
                Stream s = File.OpenRead("nodes.txt");
                StreamReader sr = new StreamReader(s);
                string str = sr.ReadLine();
                while (!string.IsNullOrEmpty(str))
                {
                    Node newNode = new Node();
                    int index = str.IndexOf(" ");
                    string name = str.Substring(0, index);
                    newNode.Name = name;
                    string text = str.Substring(index + 1, str.Length - index - 1);
                    newNode.Text = text;
                    newNode.Value = -1;
                    nodeList.Add(newNode);
                    if (newNode.Name[0] == 'c')
                    {
                        conclusionNodeList.Add(newNode);
                    }
                    else
                    {
                        supposeNodeList.Add(newNode);
                    }
                    str = sr.ReadLine();
                }
                sr.Close();
                s.Close();
                #endregion

                #region Đọc file rules.txt vào ruleList
                s = File.OpenRead("rules.txt");
                sr = new StreamReader(s);
                str = sr.ReadLine();
                while (!string.IsNullOrEmpty(str))
                {
                    Rule newRule = new Rule();
                    int index = str.IndexOf(" ");
                    string name = str.Substring(0, index);
                    newRule.Name = name;
                    string suppose = str.Substring(index + 1, str.IndexOf("=") - index - 1);
                    newRule.Suppose = suppose;
                    string conclusion = str.Substring(str.IndexOf(">") + 1, str.Length - str.IndexOf(">") - 1);
                    newRule.Conclusion = conclusion;
                    ruleList.Add(newRule);
                    str = sr.ReadLine();
                }
                sr.Close();
                s.Close();
                #endregion
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa luật này?", "Xóa luật", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                int selectedIndex = Istrules.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    Rule rule = (Rule)Istrules.SelectedItem;
                    ruleList.Remove(rule);
                    Istrules.Items.Remove(rule);
                    string str = string.Empty;
                    for (int i = 0; i < ruleList.Count; i++)
                    {
                        if (i == ruleList.Count - 1)
                        {
                            str += ruleList[i].Name + " " + ruleList[i].Suppose + "=>" + ruleList[i].Conclusion;
                        }
                        else
                        {
                            str += ruleList[i].Name + " " + ruleList[i].Suppose + "=>" + ruleList[i].Conclusion + Environment.NewLine;
                        }
                    }
                    //ghi vao file
                    StreamWriter sw = new StreamWriter("rules.txt", false, Encoding.Unicode);
                    sw.Write(str);
                    sw.Close();

                    txt_Rulestext.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btn_themnode_Click(object sender, EventArgs e)
        {
            try
            {
                string nodepress = txt_node.Text;
                StreamWriter sw = new StreamWriter("nodes.txt", true, Encoding.Unicode);
                sw.Write(Environment.NewLine + nodepress);
                sw.Close();

                Node node = new Node();
                node.Value = -1;
                node.Name = nodepress.Substring(0, nodepress.IndexOf(' '));
                node.Text = nodepress.Substring(nodepress.IndexOf(' ') + 1, nodepress.Length - nodepress.IndexOf(' ') - 1);
                IstNode.Items.Add(node);
                nodeList.Add(node);
                txt_node.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btn_themrules_Click(object sender, EventArgs e)
        {
            try
            {
                string ruleExpression = txt_rules.Text;
                StreamWriter sw = new StreamWriter("rules.txt", true, Encoding.Unicode);
                sw.Write(Environment.NewLine + ruleExpression);
                sw.Close();

                Rule rule = new Rule();
                rule.Name = ruleExpression.Substring(0, ruleExpression.IndexOf(' '));

                rule.Suppose = ruleExpression.Substring(ruleExpression.IndexOf(' ') + 1, ruleExpression.IndexOf('=') - ruleExpression.IndexOf(' ') - 1);
                rule.Conclusion = ruleExpression.Substring(ruleExpression.IndexOf('>') + 1, ruleExpression.Length - ruleExpression.IndexOf('>') - 1);
                Istrules.Items.Add(rule);
                ruleList.Add(rule);
                txt_rules.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btn_xoanode_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nút này?", "Xóa nút", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                int selectedIndex = IstNode.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    Node node = (Node)IstNode.SelectedItem;
                    nodeList.Remove(node);
                    IstNode.Items.Remove(node);
                    string str = string.Empty;
                    for (int i = 0; i < nodeList.Count; i++)
                    {
                        if (i == nodeList.Count - 1)
                        {
                            str += nodeList[i].Name + " " + nodeList[i].Text;
                        }
                        else
                        {
                            str += nodeList[i].Name + " " + nodeList[i].Text + Environment.NewLine;
                        }
                    }

                    //ghi vao file
                    StreamWriter sw = new StreamWriter("nodes.txt", false, Encoding.Unicode);
                    sw.Write(str);
                    sw.Close();

                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void btn_xoarules_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa luật này?", "Xóa luật", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                int selectedIndex = Istrules.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    Rule rule = (Rule)Istrules.SelectedItem;
                    ruleList.Remove(rule);
                    Istrules.Items.Remove(rule);
                    string str = string.Empty;
                    for (int i = 0; i < ruleList.Count; i++)
                    {
                        if (i == ruleList.Count - 1)
                        {
                            str += ruleList[i].Name + " " + ruleList[i].Suppose + "=>" + ruleList[i].Conclusion;
                        }
                        else
                        {
                            str += ruleList[i].Name + " " + ruleList[i].Suppose + "=>" + ruleList[i].Conclusion + Environment.NewLine;
                        }
                    }
                    //ghi vao file
                    StreamWriter sw = new StreamWriter("rules.txt", false, Encoding.Unicode);
                    sw.Write(str);
                    sw.Close();

                    txt_Rulestext.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        public void Istrules_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = Istrules.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    Rule rule = (Rule)Istrules.SelectedItem;
                    string str = string.Empty;
                    str += "Luật " + rule.Name + ": Triệu chứng: \n " + rule.Suppose + " thì " + rule.Conclusion;
                    //thay cac node name bang node text
                    for (int i = 0; i < nodeList.Count; i++)
                    {
                        str = str.Replace(nodeList[i].Name, nodeList[i].Text.ToLower());
                    }
                    //thay dau & thanh chu va
                    str = str.Replace("&", " và ");
                    //thay dấu | thành chữ hoặc
                    str = str.Replace("|", " hoặc ");
                    //thay dấu ~ thành không phải
                    str = str.Replace("~", " không  ");
                    txt_Rulestext.Text = str;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        public  void benhchuandoan(string str)
        {
            Rule rule = (Rule)Istrules.SelectedItem;
           // string str = string.Empty;
            str = rule.Conclusion;
        }
        
        
        private void btn_xemhuongdan_Click(object sender, EventArgs e)
        {
            XemHuongDan xhd = new XemHuongDan();
            xhd.ShowDialog();
        }

    }
}
