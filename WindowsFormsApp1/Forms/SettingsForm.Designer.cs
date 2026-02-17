namespace WindowsFormsApp1.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.ActivecheckBox = new System.Windows.Forms.CheckBox();
            this.Okbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TimetextBox = new System.Windows.Forms.TextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.SoundcheckBox = new System.Windows.Forms.CheckBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время";
            // 
            // ActivecheckBox
            // 
            this.ActivecheckBox.AutoSize = true;
            this.ActivecheckBox.Location = new System.Drawing.Point(12, 82);
            this.ActivecheckBox.Name = "ActivecheckBox";
            this.ActivecheckBox.Size = new System.Drawing.Size(70, 17);
            this.ActivecheckBox.TabIndex = 1;
            this.ActivecheckBox.Text = "Включен";
            this.ActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(274, 78);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 23);
            this.Okbutton.TabIndex = 2;
            this.Okbutton.Text = "OK";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сообщение";
            // 
            // TimetextBox
            // 
            this.TimetextBox.Location = new System.Drawing.Point(83, 6);
            this.TimetextBox.Name = "TimetextBox";
            this.TimetextBox.Size = new System.Drawing.Size(100, 20);
            this.TimetextBox.TabIndex = 4;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(83, 45);
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(266, 20);
            this.MessagetextBox.TabIndex = 5;
            // 
            // SoundcheckBox
            // 
            this.SoundcheckBox.AutoSize = true;
            this.SoundcheckBox.Location = new System.Drawing.Point(88, 82);
            this.SoundcheckBox.Name = "SoundcheckBox";
            this.SoundcheckBox.Size = new System.Drawing.Size(50, 17);
            this.SoundcheckBox.TabIndex = 6;
            this.SoundcheckBox.Text = "Звук";
            this.SoundcheckBox.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(184, 78);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 113);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.SoundcheckBox);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.TimetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.ActivecheckBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ActivecheckBox;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimetextBox;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.CheckBox SoundcheckBox;
        private System.Windows.Forms.Button Cancelbutton;
    }
}