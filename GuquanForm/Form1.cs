using GuquanJisuan;

namespace GuquanForm
{
    public partial class GuquanJisuanForm : Form
    {

        GufenChuli gfcl = new GufenChuli();

        public GuquanJisuanForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaoLiuXiaoShuComboBox.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                BaoLiuXiaoShuComboBox.Items.Add(i.ToString());
            }
            BaoLiuXiaoShuComboBox.Text = "12";
        }

        private void GetCsvFileBtn_Click(object sender, EventArgs e)
        {
            JsItemcomboBox.SelectedIndex = -1;
            JsItemcomboBox.Items.Clear();
            gfcl.GetItemList().Clear();
            string FilePath = "";

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePath = ofd.FileName;
                GetCsvFiletextBox.Text = FilePath;
                gfcl.CsvAddToItem(FilePath);


                JsItemcomboBox.Items.AddRange(gfcl.GetItemListNameStr());
            }

        }

        private void JsStarBtn_Click(object sender, EventArgs e)
        {
            if (JsItemcomboBox.Text == "")
            {
                MessageBox.Show("请先选择要计算的对象");
            } else
            {
                string gfStr;

                if (JsZhongJiancheckBox.Checked)
                {
                    GuquanBiTextBox.Text = "股东\t占比\t备注\r\n";
                    gfStr = gfcl.GetGuFenBiAll(JsItemcomboBox.Text, int.Parse(BaoLiuXiaoShuComboBox.Text));
                } else
                {
                    GuquanBiTextBox.Text = "股东\t占比\r\n";
                    gfStr = gfcl.GetGuFenBiAllZiranren(JsItemcomboBox.Text, int.Parse(BaoLiuXiaoShuComboBox.Text));
                }
                GuquanBiTextBox.Text += gfStr.Replace(',', '\t');

            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (GuquanBiTextBox.Text != "")
            {
                Clipboard.SetText(GuquanBiTextBox.Text);

            }
        }
    }
}