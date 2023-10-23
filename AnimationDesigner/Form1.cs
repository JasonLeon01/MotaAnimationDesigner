using System.Text;

namespace AnimationDesigner
{
    public partial class Form1 : Form
    {
        int playTime;
        List<List<Animation>> anime;
        public Form1()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            playTime = 0;
            anime = new List<List<Animation>>();
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, false);
            this.UpdateStyles();
        }
    }
}

class Animation
{
    public string animationName, SEFile;
    public List <string> animationPatterns;
    public int SETime;
    public Animation()
    {
        animationName = "";
        animationPatterns = new List<string>();
        SEFile = "";
        SETime = 0;
    }
    public Animation(string animationName, List<string> animationPatterns, string SEFile, int SETime)
    {
        this.animationName = animationName;
        this.SEFile = SEFile;
        this.animationPatterns = animationPatterns;
        this.SETime = SETime;
    }
}