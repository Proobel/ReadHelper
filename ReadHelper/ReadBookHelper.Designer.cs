﻿namespace ReadHelper
{
    partial class ReadBookHelper
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TranslatedTextLabel = new System.Windows.Forms.Label();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // TranslatedTextLabel
            // 
            this.TranslatedTextLabel.AutoSize = true;
            this.TranslatedTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TranslatedTextLabel.Location = new System.Drawing.Point(88, 9);
            this.TranslatedTextLabel.Name = "TranslatedTextLabel";
            this.TranslatedTextLabel.Size = new System.Drawing.Size(185, 46);
            this.TranslatedTextLabel.TabIndex = 0;
            this.TranslatedTextLabel.Text = "Translate";
            // 
            // TrayIcon
            // 
            this.TrayIcon.Text = "Proobel Book Helper";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // ReadBookHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 348);
            this.Controls.Add(this.TranslatedTextLabel);
            this.Name = "ReadBookHelper";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.ReadBookHelper_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TranslatedTextLabel;
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}

