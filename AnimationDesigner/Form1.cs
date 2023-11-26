using System;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;

namespace AnimationDesigner
{
    public partial class Form1 : Form
    {
        int list1Index, list2Index;
        List<Animation> anime;
        Image back;
        public Form1()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            list1Index = 0;
            list2Index = 0;
            anime = new List<Animation>();
            InitializeComponent();
            back = pictureBox1.Image;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, false);
            this.UpdateStyles();
        }
        private void loadAnimation()
        {
            int idx = 0;
            string path = Application.StartupPath + @"..\data\animation\";
            while (File.Exists(path + @"animation_" + idx.ToString() + ".json"))
            {
                string file = @"animation_" + idx.ToString() + ".json";
                string jsonstr = System.IO.File.ReadAllText(path + file);
                Animation tempani = JsonSerializer.Deserialize<Animation>(jsonstr);
                listBox1.Items.Add(idx.ToString().PadLeft(3, '0') + "：" + tempani.name);
                anime.Add(tempani);
                ++idx;
            }
            if (anime.Count == 0)
            {
                MessageBox.Show("未检测到动画数据！");
                Application.Exit();
                return;
            }
        }
        private void drawAnimation(int nowid)
        {
            if (anime[listBox1.SelectedIndex].patterns[nowid] != "blank")
            {
                Bitmap buffer = new Bitmap(300, 300);
                Graphics g = Graphics.FromImage(buffer);
                Image img = Image.FromFile(Application.StartupPath + @"..\graphics\animation\" + anime[listBox1.SelectedIndex].patterns[nowid]);
                g.DrawImage(back, new Rectangle(0, 0, 300, 300));
                g.DrawImage(img, new Rectangle((300 - img.Width) / 2, (300 - img.Height) / 2, img.Width, img.Height));
                pictureBox1.Image = buffer;
                g.Dispose();
            }
            else
                pictureBox1.Image = back;
        }
        private void refreshList1()
        {
            listBox1.Items.Clear();
            int idx = 0;
            foreach (Animation ani in anime)
            {
                listBox1.Items.Add(idx.ToString().PadLeft(3, '0') + "：" + ani.name);
                ++idx;
            }
            listBox1.SelectedIndex = list1Index;
        }
        private void refreshList2()
        {
            listBox2.Items.Clear();
            foreach (string str in anime[listBox1.SelectedIndex].patterns)
                listBox2.Items.Add(str);
            listBox2.SelectedIndex = list2Index;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadAnimation();
            listBox1.SelectedIndex = 0;
            textBox1.Text = anime[0].name;
            label5.Text = anime[0].SEFile;
            label5.Refresh();
            textBox2.Text = anime[0].SETime.ToString();
            listBox2.Items.Clear();
            foreach (string str in anime[0].patterns)
                listBox2.Items.Add(str);

            if (anime[0].patterns.Count > 0)
            {
                listBox2.SelectedIndex = 0;
                Bitmap buffer = new Bitmap(300, 300);
                Graphics g = Graphics.FromImage(buffer);
                Image img = Image.FromFile(Application.StartupPath + @"..\graphics\animation\" + anime[0].patterns[0]);
                g.DrawImage(back, new Rectangle(0, 0, 300, 300));
                g.DrawImage(img, new Rectangle((300 - img.Width) / 2, (300 - img.Height) / 2, img.Width, img.Height));
                pictureBox1.Image = buffer;
                g.Dispose();
            }
            else
            {
                listBox2.ClearSelected();
                pictureBox1.BackgroundImage = back;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            anime[listBox1.SelectedIndex].name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            anime[listBox1.SelectedIndex].SETime = int.Parse(textBox2.Text);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list1Index = listBox1.SelectedIndex;
            textBox1.Text = anime[listBox1.SelectedIndex].name;
            label5.Text = anime[listBox1.SelectedIndex].SEFile;
            label5.Refresh();
            textBox2.Text = anime[listBox1.SelectedIndex].SETime.ToString();
            listBox2.Items.Clear();
            foreach (string str in anime[listBox1.SelectedIndex].patterns)
                listBox2.Items.Add(str);
            listBox2.SelectedIndex = 0;
            list2Index = 0;
            drawAnimation(listBox2.SelectedIndex);
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            list2Index = listBox2.SelectedIndex;
            drawAnimation(listBox2.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //创建对象
            OpenFileDialog ofg = new OpenFileDialog();
            //设置默认打开路径
            ofg.InitialDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath)) + @"\sound";
            //设置打开标题、后缀
            ofg.Title = "请选择导入音频文件";
            ofg.Filter = "wav文件|*.wav|ogg文件|*.ogg|vorbis文件|*.vorbis|flac文件|*.flac";
            string path = "";
            DialogResult s = ofg.ShowDialog();
            if (s == DialogResult.OK)
            {
                //得到打开的文件路径（包括文件名）
                string[] names = ofg.FileName.ToString().Split('\\');
                label5.Text = names[names.Length - 1];
                label5.Refresh();
                anime[listBox1.SelectedIndex].SEFile = label5.Text;
            }
            else if (s == DialogResult.Cancel)
                MessageBox.Show("未选择打开文件！");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            anime[listBox1.SelectedIndex].patterns.Insert(listBox2.SelectedIndex + 1, "blank");
            refreshList2();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (anime[listBox1.SelectedIndex].patterns.Count == 1)
            {
                MessageBox.Show("不允许删除最后一帧");
                return;
            }
            anime[listBox1.SelectedIndex].patterns.RemoveAt(listBox2.SelectedIndex);
            if (list2Index >= anime[listBox1.SelectedIndex].patterns.Count) list2Index = anime[listBox1.SelectedIndex].patterns.Count - 1;
            refreshList2();
            drawAnimation(listBox2.SelectedIndex);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            anime.Add(new Animation("undefined", new List<string> { "blank" }, "undefined", 0));
            refreshList1();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (anime.Count == 1)
            {
                MessageBox.Show("不允许删除最后剩余的动画");
                return;
            }
            anime.RemoveAt(listBox1.SelectedIndex);
            if (list1Index >= anime.Count) list1Index = anime.Count - 1;
            refreshList1();
            refreshList2();
            drawAnimation(listBox2.SelectedIndex);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //创建对象
            OpenFileDialog ofg = new OpenFileDialog();
            //设置默认打开路径
            ofg.InitialDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath)) + @"\graphics\animation";
            //设置打开标题、后缀
            ofg.Title = "请选择导入动画文件";
            ofg.Filter = "png文件|*.png";
            string path = "";
            DialogResult s = ofg.ShowDialog();
            if (s == DialogResult.OK)
            {
                //得到打开的文件路径（包括文件名）
                string[] names = ofg.FileName.ToString().Split('\\');
                anime[listBox1.SelectedIndex].patterns[listBox2.SelectedIndex] = names[names.Length - 1];
                refreshList2();
                drawAnimation(listBox2.SelectedIndex);
            }
            else if (s == DialogResult.Cancel)
                MessageBox.Show("未选择打开文件！");
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            bool banned = false;
            string path = Application.StartupPath + @"..\sound\" + anime[listBox1.SelectedIndex].SEFile;
            IWavePlayer waveOutDevice = new WaveOut();
            WaveStream readerStream = null;
            if (anime[listBox1.SelectedIndex].SEFile.Split('.')[1] == "ogg")
            {
                readerStream = new NAudio.Vorbis.VorbisWaveReader(path);
                waveOutDevice.Init(readerStream);
            }
            else if (anime[listBox1.SelectedIndex].SEFile.Split('.')[1] == "wav")
            {
                readerStream = new WaveFileReader(path);
                waveOutDevice.Init(readerStream);

            }
            else
            {
                banned = true;
                MessageBox.Show("抱歉，C#暂不支持该类型文件的播放，本次播放只能静音");
            }
            for (int i = 0; i < anime[listBox1.SelectedIndex].patterns.Count; ++i)
            {
                drawAnimation(i);
                if (i == anime[listBox1.SelectedIndex].SETime && !banned)
                    waveOutDevice.Play();
                await Task.Delay(64);
            }
            waveOutDevice.Dispose();
            readerStream.Dispose();
            drawAnimation(listBox2.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx = 0;
            string file = Application.StartupPath + @"..\data\animation\";
            foreach (Animation ani in anime)
            {
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    DefaultIgnoreCondition = JsonIgnoreCondition.Never,
                    WriteIndented = true
                };
                string jsonstr = JsonSerializer.Serialize(ani, options);
                System.IO.File.WriteAllText(file + @"animation_" + idx.ToString() + ".json", jsonstr);
                idx++;
            }
            while (File.Exists(file + @"animation_" + idx.ToString() + ".json"))
            {
                System.IO.File.Delete(file + @"animation_" + (idx++).ToString() + ".json");
            }
            MessageBox.Show("保存成功！");
            return;
        }
    }
}

class Animation
{
    public string name { get; set; }
    public string SEFile { get; set; }
    public List<string> patterns { get; set; }
    public int SETime { get; set; }
    public Animation()
    {
        name = "";
        patterns = new List<string>();
        SEFile = "";
        SETime = 0;
    }
    public Animation(string name, List<string> patterns, string SEFile, int SETime)
    {
        this.name = name;
        this.SEFile = SEFile;
        this.patterns = patterns;
        this.SETime = SETime;
    }
}