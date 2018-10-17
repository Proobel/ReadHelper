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
            TrFromComboBox.SelectedItem = Properties.Settings.Default.Translate_from;
            TrToComboBox.SelectedItem = Properties.Settings.Default.Translate_to;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Translate_from = TrFromComboBox.SelectedText;
            Properties.Settings.Default.Translate_to = TrToComboBox.SelectedText;
            Properties.Settings.Default.Save();
        }
    }
}
