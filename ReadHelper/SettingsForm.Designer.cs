namespace ReadHelper
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.TranslateTab = new System.Windows.Forms.TabPage();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TrToComboBox = new System.Windows.Forms.ComboBox();
            this.TranslateToLabel = new System.Windows.Forms.Label();
            this.TrFromComboBox = new System.Windows.Forms.ComboBox();
            this.TranslateFromLabel = new System.Windows.Forms.Label();
            this.TabMenu.SuspendLayout();
            this.TranslateTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.GeneralTab);
            this.TabMenu.Controls.Add(this.TranslateTab);
            this.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMenu.Location = new System.Drawing.Point(0, 0);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(422, 299);
            this.TabMenu.TabIndex = 0;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTab.Size = new System.Drawing.Size(414, 273);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "Общие";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // TranslateTab
            // 
            this.TranslateTab.Controls.Add(this.SaveButton);
            this.TranslateTab.Controls.Add(this.TrToComboBox);
            this.TranslateTab.Controls.Add(this.TranslateToLabel);
            this.TranslateTab.Controls.Add(this.TrFromComboBox);
            this.TranslateTab.Controls.Add(this.TranslateFromLabel);
            this.TranslateTab.Location = new System.Drawing.Point(4, 22);
            this.TranslateTab.Name = "TranslateTab";
            this.TranslateTab.Padding = new System.Windows.Forms.Padding(3);
            this.TranslateTab.Size = new System.Drawing.Size(414, 273);
            this.TranslateTab.TabIndex = 1;
            this.TranslateTab.Text = "Перевод";
            this.TranslateTab.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(331, 244);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TrToComboBox
            // 
            this.TrToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrToComboBox.FormattingEnabled = true;
            this.TrToComboBox.Location = new System.Drawing.Point(13, 69);
            this.TrToComboBox.Name = "TrToComboBox";
            this.TrToComboBox.Size = new System.Drawing.Size(121, 21);
            this.TrToComboBox.TabIndex = 3;
            // 
            // TranslateToLabel
            // 
            this.TranslateToLabel.AutoSize = true;
            this.TranslateToLabel.Location = new System.Drawing.Point(10, 52);
            this.TranslateToLabel.Name = "TranslateToLabel";
            this.TranslateToLabel.Size = new System.Drawing.Size(86, 13);
            this.TranslateToLabel.TabIndex = 2;
            this.TranslateToLabel.Text = "Переводить на:";
            // 
            // TrFromComboBox
            // 
            this.TrFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrFromComboBox.FormattingEnabled = true;
            this.TrFromComboBox.Location = new System.Drawing.Point(10, 24);
            this.TrFromComboBox.Name = "TrFromComboBox";
            this.TrFromComboBox.Size = new System.Drawing.Size(121, 21);
            this.TrFromComboBox.TabIndex = 1;
            // 
            // TranslateFromLabel
            // 
            this.TranslateFromLabel.AutoSize = true;
            this.TranslateFromLabel.Location = new System.Drawing.Point(7, 7);
            this.TranslateFromLabel.Name = "TranslateFromLabel";
            this.TranslateFromLabel.Size = new System.Drawing.Size(83, 13);
            this.TranslateFromLabel.TabIndex = 0;
            this.TranslateFromLabel.Text = "Переводить с :";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 299);
            this.Controls.Add(this.TabMenu);
            this.Name = "SettingsForm";
            this.Text = "SettingsFrom";
            this.Load += new System.EventHandler(this.SettingsFrom_Load);
            this.TabMenu.ResumeLayout(false);
            this.TranslateTab.ResumeLayout(false);
            this.TranslateTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TabPage TranslateTab;
        private System.Windows.Forms.ComboBox TrToComboBox;
        private System.Windows.Forms.Label TranslateToLabel;
        private System.Windows.Forms.ComboBox TrFromComboBox;
        private System.Windows.Forms.Label TranslateFromLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}