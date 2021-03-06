﻿using ClipboardHelper;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ReadHelper
{
    public partial class ReadBookHelper : Form
    {
        public static Translator Trans = new Translator();

        public ReadBookHelper()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Translate_from == "")
            {
                Properties.Settings.Default.Translate_from = "en";
                Properties.Settings.Default.Translate_to = "ru";
                Properties.Settings.Default.Save();
            }
            TrayIcon.Icon = Properties.Resources.BookIcon;
            WindowState = FormWindowState.Minimized;
            Icon = Properties.Resources.BookIcon;
            ClipboardMonitor.OnClipboardChange += Clip;
            ClipboardMonitor.Start();
            Trans.OnTranslateChange += () => { TranslatedText.BeginInvoke((MethodInvoker)(()=> TranslatedText.Text = Trans.TranslatedText));  };
            Trans.OnTranslateChange += () =>
             {
                 TrayIcon.BalloonTipTitle = "Перевод скопированного текста";
                 TrayIcon.BalloonTipText = Trans.TranslatedText;
                 TrayIcon.ShowBalloonTip(100);
             };
        }

        public static void Clip(ClipboardFormat clipboard, object data)
        {
           Trans.TranslateByYandex(data as string, Properties.Settings.Default.Translate_from, Properties.Settings.Default.Translate_to);
        }

        private void ReadBookHelper_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = Properties.Settings.Default.IsTaskManager ? true : false;
                TrayIcon.Visible = true;
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TrayIcon.Visible = false;
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void ReadBookHelper_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Properties.Settings.Default.IsNormalClose && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                ShowInTaskbar = Properties.Settings.Default.IsTaskManager ? true : false;
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
