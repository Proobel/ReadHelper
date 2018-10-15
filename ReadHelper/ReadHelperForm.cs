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
            TrayIcon.Icon = Properties.Resources.BookIcon;
            //TrayIcon.Visible = false;
            WindowState = FormWindowState.Minimized;

            ClipboardMonitor.OnClipboardChange += Clip;
            ClipboardMonitor.Start();
            Trans.OnTranslateChange += () => { TranslatedTextLabel.BeginInvoke((MethodInvoker)(()=> TranslatedTextLabel.Text = Trans.TranslatedText));  };
        }

        public static void Clip(ClipboardFormat clipboard, object data)
        {
            Trans.TranslateByYandex(data as string);
        }

        private void ReadHelperForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                TrayIcon.Visible = true;
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TrayIcon.Visible = false;
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }
    }
}
