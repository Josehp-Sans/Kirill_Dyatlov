namespace WindowsFormsApp1
{
    partial class HelloForm
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
            this.HelloButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SettingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSeconds = new System.Windows.Forms.Label();
            this.StartTimerButton = new System.Windows.Forms.Button();
            this.StopSecondButton = new System.Windows.Forms.Button();
            this.ResetSecondButton = new System.Windows.Forms.Button();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HelloButton
            // 
            this.HelloButton.Location = new System.Drawing.Point(23, 111);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(377, 34);
            this.HelloButton.TabIndex = 1;
            this.HelloButton.Text = "Инфо";
            this.HelloButton.UseVisualStyleBackColor = true;
            this.HelloButton.Click += new System.EventHandler(this.HelloButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(20, 13);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(380, 84);
            this.TimerLabel.TabIndex = 4;
            this.TimerLabel.Text = "00:00:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(23, 151);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(377, 34);
            this.SettingButton.TabIndex = 5;
            this.SettingButton.Text = "Настройки";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(23, 191);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(377, 34);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelSeconds
            // 
            this.labelSeconds.BackColor = System.Drawing.SystemColors.Control;
            this.labelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeconds.Location = new System.Drawing.Point(416, 13);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(380, 84);
            this.labelSeconds.TabIndex = 7;
            this.labelSeconds.Text = "00:00:00";
            this.labelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartTimerButton
            // 
            this.StartTimerButton.Location = new System.Drawing.Point(424, 111);
            this.StartTimerButton.Name = "StartTimerButton";
            this.StartTimerButton.Size = new System.Drawing.Size(372, 34);
            this.StartTimerButton.TabIndex = 8;
            this.StartTimerButton.Text = "Запустить";
            this.StartTimerButton.UseVisualStyleBackColor = true;
            this.StartTimerButton.Click += new System.EventHandler(this.StartTimerButton_Click);
            // 
            // StopSecondButton
            // 
            this.StopSecondButton.Location = new System.Drawing.Point(424, 151);
            this.StopSecondButton.Name = "StopSecondButton";
            this.StopSecondButton.Size = new System.Drawing.Size(372, 34);
            this.StopSecondButton.TabIndex = 9;
            this.StopSecondButton.Text = "Остановить";
            this.StopSecondButton.UseVisualStyleBackColor = true;
            this.StopSecondButton.Click += new System.EventHandler(this.StopSecondButton_Click);
            // 
            // ResetSecondButton
            // 
            this.ResetSecondButton.Location = new System.Drawing.Point(424, 191);
            this.ResetSecondButton.Name = "ResetSecondButton";
            this.ResetSecondButton.Size = new System.Drawing.Size(372, 34);
            this.ResetSecondButton.TabIndex = 10;
            this.ResetSecondButton.Text = "Сброс";
            this.ResetSecondButton.UseVisualStyleBackColor = true;
            this.ResetSecondButton.Click += new System.EventHandler(this.ResetSecondButton_Click);
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 1000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 254);
            this.Controls.Add(this.ResetSecondButton);
            this.Controls.Add(this.StopSecondButton);
            this.Controls.Add(this.StartTimerButton);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.HelloButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelloForm";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.HelloForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Button StartTimerButton;
        private System.Windows.Forms.Button StopSecondButton;
        private System.Windows.Forms.Button ResetSecondButton;
        private System.Windows.Forms.Timer timerSeconds;
    }
}

