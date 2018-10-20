using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ReadHelper;

namespace ReadHelper
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsFrom_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            TrFromComboBox.Items.AddRange(Translator.Languages.Values.ToArray());
            TrToComboBox.Items.AddRange(Translator.Languages.Values.ToArray());
            TrFromComboBox.SelectedItem = Translator.Languages[Properties.Settings.Default.Translate_from];
            TrToComboBox.SelectedItem = Translator.Languages[Properties.Settings.Default.Translate_to];
            CloseOptionСheckBox.Checked = Properties.Settings.Default.IsNormalClose;
            ShowInTaskManagerCheckBox.Checked = Properties.Settings.Default.IsTaskManager;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Translate_from = Translator.Languages.GetKey(TrFromComboBox.SelectedItem as string);
            var t = Translator.Languages.GetKey(TrFromComboBox.SelectedItem as string);
            Properties.Settings.Default.Translate_to = Translator.Languages.GetKey(TrToComboBox.SelectedItem as string);
            Properties.Settings.Default.IsNormalClose = CloseOptionСheckBox.Checked;
            Properties.Settings.Default.IsTaskManager = ShowInTaskManagerCheckBox.Checked;
            Properties.Settings.Default.Save();
            MessageBox.Show(
                text: "Настройки успешно сохранены",
                caption: "Повезло!",
                icon: MessageBoxIcon.Asterisk,
                buttons: MessageBoxButtons.OK
                );
            var s = Properties.Settings.Default.Translate_from;
        }
    }
}
