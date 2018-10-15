using ClipboardHelper;
using System;
using System.Windows.Forms;

namespace ReadHelper
{
    public partial class Form1 : Form
    {
        public static Translator Trans = new Translator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClipboardMonitor.OnClipboardChange += Clip;
            ClipboardMonitor.Start();
            Trans.OnTranslateChange += () => { label1.BeginInvoke((MethodInvoker)(()=> label1.Text = Trans.TranslatedText));  };
        }

        public static void Clip(ClipboardFormat clipboard, object data)
        {
            Trans.TranslateByYandex(data as string);
        }
    }
}
