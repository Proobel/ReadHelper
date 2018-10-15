using ClipboardHelper;
using System;
using System.Windows.Forms;

namespace ReadHelper
{
    public partial class ReadHelperForm : Form
    {
        public static Translator Trans = new Translator();

        public ReadHelperForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TrayIcon.Icon = TranslateEye;
            TrayIcon.Visible = false;

            ClipboardMonitor.OnClipboardChange += Clip;
            ClipboardMonitor.Start();
            Trans.OnTranslateChange += () => { label1.BeginInvoke((MethodInvoker)(()=> label1.Text = Trans.TranslatedText));  };

        }

        public static void Clip(ClipboardFormat clipboard, object data)
        {
            Trans.TranslateByYandex(data as string);
        }

        private void ReadHelperForm_Resize(object sender, EventArgs e)
        {

        }
    }
}
