using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace HeChuanDoanBenh
{
    public partial class Main : Form
    {
        private int first = 0;
        private Node parentNode = null;
        private List<Node> nodeList = new List<Node>();
        private List<Rule> ruleList = new List<Rule>();
        private List<Node> supposeNodeList = new List<Node>();
        private List<Node> conclusionNodeList = new List<Node>();
        private List<Node> knownNodeList = new List<Node>();
        private List<Node> tempNodeList = new List<Node>();
        private List<Road> roadList = new List<Road>();
        List<Image> listImage = new List<Image>();

        private delegate void UpdateTextBoxDeletegate(string str);
        private delegate void UpdateControlsDelegate();
        private Thread processThread = null;
        private object objLock = new object();
        private bool isHasAnswer = false;

        private List<Road> roadListTemp = new List<Road>();
        public Main()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void ShowError(string error)
        {
            MessageBox.Show(this, "Chương trình gặp lỗi: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // Environment.Exit(0);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Application.Exit();
            Environment.Exit(0);
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtin f2 = new Thongtin();
            f2.ShowDialog();
        }

        private void btn_quanliluat_Click(object sender, EventArgs e)
        {
            QuanLiLuat ql = new QuanLiLuat(this);
            ql.ShowDialog();
        }
        public void Init()
        {
            try
            {
                first = 0;
                parentNode = null;
                nodeList = new List<Node>();
                ruleList = new List<Rule>();
                supposeNodeList = new List<Node>();
                conclusionNodeList = new List<Node>();
                knownNodeList = new List<Node>();
                tempNodeList = new List<Node>();
                roadListTemp = roadList;
                roadList = new List<Road>();
                processThread = null;
                objLock = new object();
                isHasAnswer = false;
                this.Invoke(new UpdateControlsDelegate(UpdateControls));
                LoadFromFile();
                processThread = new Thread(new ThreadStart(Process));
                processThread.Start();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
        private void UpdateControls()
        {
            rdb_co.Checked = true;
        }

        private void UpdateTextBox(string str)
        {
            txt_cauhoi.Text = str;
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
        private void Process()
        {
            try
            {
                //Voi moi ket luan c, ta duyet qua no
                for (int i = conclusionNodeList.Count - 1; i >= 0; i--)
                {

                    parentNode = conclusionNodeList[i];
                    for (int j = 0; j < ruleList.Count; j++)
                    {
                        // Cho no vao tap dang xet
                        tempNodeList.Add(conclusionNodeList[i]);
                        // Sau do ta di tim luat sinh ra ket luan tren va cho vao tap Vet(roadList)
                        ProcessNode(conclusionNodeList[i], j);
                        // Kiem tra xem node nay co value = 1 chua
                        if (conclusionNodeList[i].Value == 1)
                        {
                            string str = "Theo kết quả chuẩn đoán, " + conclusionNodeList[i].Text.ToLower();
                            Ketqua kqua = new Ketqua(str);
                            kqua.ShowDialog();
                            isHasAnswer = true;
                            break;
                        }

                    }
                    if (isHasAnswer)
                    {
                        break;
                    }

                }
                if (isHasAnswer == false)
                {
                    string str = "Không khớp luật nào trong cơ sở tri thức!";
                    Ketqua kqua = new Ketqua(str);
                    kqua.ShowDialog();
                }
                Init();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ProcessNode(Node node, int level)
        {
            try
            {
                Road road = SearchRule(node, level);
                if (road == null)
                {
                    return;
                }
                this.first++;
                bool isExist = false;
                for (int i = 0; i < roadList.Count; i++)
                {
                    if (roadList[i].Node.Name.Equals(road.Node.Name))
                    {
                        isExist = true;
                    }
                }
                if (isExist == false)
                {
                    roadList.Add(road);
                }

                // H ta di xet luat vua tim duoc de cho cac node vao tap dang xet
                tempNodeList.Remove(road.Node);
                ProcessRule(road);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ShowWhy()
        {
            try
            {
                string str = string.Empty;
                for (int i = roadListTemp.Count - 1; i >= 0; i--)
                {
                    if (roadListTemp[i].Node.Value == 1)
                    {
                        str += "Theo kết quả khảo sát" + /* roadListTemp[i].Rule.Name */" nếu bạn bị các triệu chứng sau: " + Environment.NewLine + "  " + roadListTemp[i].Rule.Suppose + Environment.NewLine + "Kết Quả Chuẩn Đoán: " + roadListTemp[i].Node.Text + Environment.NewLine + Environment.NewLine;
                    }
                }
                //thay cac node name bang node text
                for (int i = 0; i < nodeList.Count; i++)
                {
                    str = str.Replace(nodeList[i].Name, nodeList[i].Text.ToLower());
                }
                //thay dau & thanh chu va
                str = str.Replace("&", " , ");
                //thay dấu | thành chữ hoặc
                str = str.Replace("|", " hoặc ");
                //thay dấu ~ thành không phải
                str = str.Replace("~", " không ");

                if (!string.IsNullOrEmpty(str))
                {
                    Ketqua kqua = new Ketqua(str);
                    kqua.ShowDialog();
                }
                else
                {
                    Ketqua kqua = new Ketqua("Bạn chưa chưa trả lời các câu hỏi nên chương trình không thể giải thích cho bạn được.");
                    kqua.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            cbb_luachon.Enabled = false;
            txt_cauhoi.Text = null;
            txt_cauhoi.Enabled = false;
            btn_tieptheo.Enabled = false;
            btn_giaithich.Enabled = false;
            rdb_co.Enabled = false;
            rdb_khong.Enabled = false;
            btn_lamlai.Enabled = false;
            btn_xemhinh.Enabled = false;
            btn_chuatri.Enabled = false;
            txt_chuatri.Enabled = false;
           
        }

        private int GetNodeValue(Node node)
        {
            try
            {
                // phai lay ve ket qua cua node nay la: 1 hoac 0
                lock (objLock)
                {
                    UpdateTextBoxDeletegate updateTextBoxDeleteGate = new UpdateTextBoxDeletegate(UpdateTextBox);
                    txt_cauhoi.Invoke(updateTextBoxDeleteGate, node.Text);
                    txt_cauhoi.Text = node.Text;
                    Monitor.Pulse(objLock);
                    Monitor.Wait(objLock);
                }
                if (rdb_co.Checked)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
            return 0;
        }

        private Road SearchRule(Node node, int level)
        {
            try
            {
                string conclusionName = node.Name;
                Road road = new Road();
                // Ta tim luat chua ket luan conclusion vua lay ra ben tren
                for (int i = level; i < ruleList.Count; i++)
                {
                    Rule rule = ruleList[i];
                    string str = rule.Conclusion;
                    if (conclusionName.Equals(str))
                    {
                        road.Node = node;
                        road.Rule = rule;
                        return road;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
            return null;
        }

        private void ProcessRule(Road road)
        {
            try
            {
                // Ta di xet luat cua road và add cac node o ve trai cua luat vao tap tempNodeList
                Rule rule = road.Rule;
                string suppose = rule.Suppose;
                string[] supposes = suppose.Split('&', '|', '~');
                for (int i = 0; i < supposes.Length; i++)
                {
                    for (int j = 0; j < nodeList.Count; j++)
                    {
                        if (nodeList[j].Name.Equals(supposes[i]))
                        {
                            if (nodeList[j].Value == -1)
                            {
                                tempNodeList.Add(nodeList[j]);
                            }

                        }
                    }
                }
                // Ngoai nhiem vu add ra, ta con phai kiem tra xem ve trai cua luat co phai toan la e khong. neu toan la e thi chay ham Ap dung luat
                for (int i = 0; i < tempNodeList.Count; i++)
                {
                    Node node = tempNodeList[i];
                    if (node.Name[0].Equals('e'))
                    {
                        if (node.Value == -1)
                        {
                            int value = GetNodeValue(node);
                            node.Value = value;
                        }
                    }
                    else
                    {
                        ProcessNode(node, 0);
                    }
                }
                road.Node.Value = CalculateConclusionValue(road);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private int CalculateConclusionValue(Road road)
        {
            try
            {
                string suppose = road.Rule.Suppose;
                for (int i = 0; i < nodeList.Count; i++)
                {
                    suppose = suppose.Replace(nodeList[i].Name, nodeList[i].Value.ToString());
                }
                StringBuilder sb = new StringBuilder(suppose);
                //xu ly dau ~
                for (int i = 0; i < sb.Length - 1; i++)
                {
                    if (sb[i].Equals('~') && sb[i + 1].Equals('0'))
                    {
                        sb[i + 1] = '1';
                    }
                    else
                        if (sb[i].Equals('~') && sb[i + 1].Equals('1'))
                        {
                            sb[i + 1] = '0';
                        }
                }
                sb = sb.Replace("~", "");

                //xu ly dau & |
                while (sb.Length != 1)
                {
                    if (sb[1].Equals('&'))
                    {
                        if (sb[0].Equals('1') && sb[2].Equals('1'))
                        {
                            sb.Replace("1&1", "1");
                        }
                        else
                        {
                            sb.Replace(sb[0].ToString() + sb[1].ToString() + sb[2].ToString(), "0");
                        }
                    }
                    else//chac chan la dau |
                    {
                        if (sb[0].Equals('0') && sb[2].Equals('0'))
                        {
                            sb.Replace("0|0", "0");
                        }
                        else
                        {
                            sb.Replace(sb[0].ToString() + sb[1].ToString() + sb[2].ToString(), "1");
                        }
                    }
                }
                return Int32.Parse(sb.ToString());
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
            return 0;
        }

        private void btn_lamlai_Click(object sender, EventArgs e)
        {
            knownNodeList.Clear();
            nodeList.Clear();
            ruleList.Clear();
            supposeNodeList.Clear();
            conclusionNodeList.Clear();
            tempNodeList.Clear();
            roadList.Clear();
            roadListTemp.Clear();
            Init();
            txt_cauhoi.Enabled = true;
            txt_cauhoi.Text = "";
            rdb_khong.Checked = false;
            rdb_co.Checked = true;
            btn_giaithich.Enabled = true;
            cbb_luachon.SelectedItem = cbb_luachon.Items[0];
            txt_chuatri.Text = null;
            //btn_batdau.Enabled = true;
            
        }

        private void btn_giaithich_Click(object sender, EventArgs e)
        {
            ShowWhy();

        }

        private void btn_tieptheo_Click(object sender, EventArgs e)
        {
            lock(objLock)
            {
                Monitor.Pulse(objLock);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        int number = 0;
        private void hinhanh()
        {
            string source = Application.StartupPath.ToString();
            listImage.Add(Image.FromFile(source + "Image\\C:\\5.jpg"));
        }
        public void xuatmanhinh(int index)
        {
            hinhanh();
            pictureBox1.Image = listImage[index];
        }
        public void layanh(int value)
        {
            number = value;
        }
        private void btn_xemhinh_Click(object sender, EventArgs e)
        {
            
            if(cbb_luachon.SelectedItem == cbb_luachon.Items[1])
            {
                xuatmanhinh(number);
                
            }
            
        }

     
        private void btn_chuatri_Click(object sender, EventArgs e)
        {

            if (cbb_luachon.SelectedItem == cbb_luachon.Items[0])
            {
                MessageBox.Show("Bạn chưa chọn tên bệnh để phòng ngừa và chữa trị", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_chuatri.Text = null;
            }
            if(cbb_luachon.SelectedItem == cbb_luachon.Items[1])
            {
                string str1 = Environment.NewLine + "   Hiện tại vẫn chưa có vắc xin ngừa bệnh sốt phát ban. Do đó, cách tốt nhất để trẻ không bị bệnh là tránh tiếp xúc với một em bé đang bị hoặc có nguy cơ bị.";
                string str2 = Environment.NewLine + "   Còn nếu như bé nhà mình có những dấu hiệu trên, hãy cho trẻ ở nhà, tránh tiếp xúc với trẻ khác mà lây bệnh trên diện rộng." + Environment.NewLine + "    Dù đã có kháng thể chống bệnh lần thứ 2, nhưng khi trong nhà có người bị bệnh này, cả nhà nên thường xuyên rửa chân tay thật kĩ để tránh lây lan.";
                string str3 = Environment.NewLine + "   Nên cho trẻ ăn thức ăn lỏng, giàu dinh dưỡng, dễ tiêu hóa như cháo, súp, sữa… Trẻ ăn uống quá khó khăn phụ huynh nên chia nhỏ bữa ăn để giúp trẻ nhận đủ chất dinh dưỡng cần thiết";
                txt_chuatri.Text = "   Cách chữa bệnh sốt phát ban:" + str1 + str2 + str3;
            }
            if (cbb_luachon.SelectedItem == cbb_luachon.Items[2])
            {
                string str1 = Environment.NewLine + "   Cho trẻ uống thật nhiều nước, Làm thông thoáng mũi cho bé để bé dễ chịu hơn và dễ ăn, ngủ hơn.";
                string str0 = Environment.NewLine + "   Đối với những trẻ lớn hơn thì bạn có thể sử dụng phương pháp máy xông mũi";
                string str2 = Environment.NewLine + "   Dấu hiệu nguy hiểm cần đưa trẻ đến bác sĩ như: ";
                string str3 = Environment.NewLine + "     - Móng tay hoặc môi chuyển thành màu xanh. ";
                string str4 = Environment.NewLine + "     - Không thở được, sốt cao, nước mũi chảy ra trở nên đặc và có màu vàng.";
                txt_chuatri.Text = "  Cách chữa bệnh cảm lạnh: " + str1 + str0 + str2 + str3 + str4; 
            }
            if(cbb_luachon.SelectedItem == cbb_luachon.Items[3])
            {
                string str1 = Environment.NewLine + "   Ăn uống đủ chất: Bạn hãy tăng cường các loại rau, củ, quả, đặc biệt là tỏi và các chế phẩm từ tỏi, cùng một số loại thực phẩm như lúa, lúa mì, quả óc chó… có chứa khoáng chất Selenium,vitamin C…";
                string str2 = Environment.NewLine + "   Uống nhiều nước: Theo lời khuyên của các chuyên gia, khi bị cúm bạn nên uống nhiều nước (nước lọc, nước hoa quả, cháo, súp...), đặc biệt là nước ấm.";
                string str3 = Environment.NewLine + "   Rửa tay thường xuyên: Khi bạn bị ốm, chức năng của hệ miễn dịch bị suy yếu nghiêm trọng vì thế việc này giúp ngăn ngừa các virut mới xâm nhập vào cơ thể.";
                string str4 = Environment.NewLine + "   Súc miệng nước muối: Súc miệng bằng nước muối vài lần mỗi ngày có thể giúp điều trị viêm họng cũng như ngăn ngừa nhiễm trùng phát sinh. ";
                string str5 = Environment.NewLine + "   Bổ sung vitamin C: Hãy bổ sung vitamin C cho cơ thể càng nhiều càng tốt những khi hệ miễn dịch bị suy yếu.";
                string str6 = Environment.NewLine + "   Xông hơi chữa cúm: Những dụng cụ giữ độ ẩm cho không khí là công cụ tuyệt vời mỗi khi bạn bị cảm cúm bởi vì virus không thể hoạt động trong môi trường ẩm.";
                string str7 = Environment.NewLine + "   Ăn tỏi: Có thể tỏi không phải là một gia vị hấp dẫn bạn nhưng nó lại là thực phẩm trị cảm cúm rất hiệu quả.";
                txt_chuatri.Text = "  Cách chữa bệnh cảm cúm: " + str1 + str2 + str3 + str4 + str5 + str6 + str7;
            }
            if (cbb_luachon.SelectedItem == cbb_luachon.Items[4])
            {
                string str1 = Environment.NewLine + "   Để phòng bệnh, cần tiêm phòng vắc xin sởi cho trẻ. Tiêm mũi 1 khi trẻ tròn 9 tháng tuổi và mũi 2 trong chiến dịch tiêm nhắc lại.";
                string str2 = Environment.NewLine + "   Nên cách ly trẻ mắc sở ít nhất 4 ngày sau khi phát ban.";
                string str3 = Environment.NewLine + "   Bệnh nhi phải được ở nơi thoáng mát, ăn uống đầy đủ, vệ sinh sạch sẽ, không nên kiêng khem quá mức gây tình trạng thiếu các vi chất.";
                string str4 = Environment.NewLine + "   Khi chưa có biến chứng, không nên cho trẻ dùng kháng sinh. Cần đưa trẻ đi khám, việc điều trị chủ yếu là khắc phục triệu chứng như uống thuốc hạ sốt, vệ sinh toàn thân, răng miệng, mắt (nhỏ mắt thường xuyên bằng nước muối sinh lý, lục vi tố (chloramphenicol) 0,1%).";
                string str5 = Environment.NewLine + "   Trẻ phải được ăn đầy đủ thực phẩm dễ tiêu, giàu dinh dưỡng, uống đủ nước.";
                string str6 = Environment.NewLine + "   Khi có biến chứng, có thể dùng kháng sinh theo chỉ dẫn của thầy thuốc, bổ sung vitamin A để tránh khô giác mạc.";
                string str7 = Environment.NewLine + "   Không dùng kích tố thận thượng tuyến bì chất (corticoid).";
                txt_chuatri.Text = "  Cách chữa bệnh sởi:" + str1 + str2 + str3 + str4 + str5 + str6 + str7;
            }

        }

        private void btn_batdau_Click(object sender, EventArgs e)
        {
            knownNodeList.Clear();
            nodeList.Clear();
            ruleList.Clear();
            supposeNodeList.Clear();
            conclusionNodeList.Clear();
            tempNodeList.Clear();
            roadList.Clear();
            roadListTemp.Clear();
            Init();
            txt_cauhoi.Text = "";
            cbb_luachon.SelectedItem = cbb_luachon.Items[0];
            cbb_luachon.Enabled = true;
            txt_cauhoi.Enabled = true;
            btn_batdau.Enabled = false;
            btn_lamlai.Enabled = true;
            btn_tieptheo.Enabled = true;
            btn_xemhinh.Enabled = true;
            btn_giaithich.Enabled = true;
            rdb_co.Enabled = true;
            rdb_khong.Enabled = true;
            btn_chuatri.Enabled = true;
            txt_chuatri.Enabled = true;
            
           
        }

        private void txt_cauhoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_huongdan_Click(object sender, EventArgs e)
        {
            huongdan hd = new huongdan();
            hd.ShowDialog();
        }



        public int tenbenh { get; set; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
