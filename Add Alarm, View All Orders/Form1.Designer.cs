namespace MIS_122_Stuff
{
    partial class Form1
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
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            System.Windows.Forms.DateTimePicker dateTimePicker2;
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SetAlarmButton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = global::MIS_122_Stuff.Properties.Resources.addalarm_logo;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 49);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(362, 107);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(20);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Location = new System.Drawing.Point(134, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Order Number";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.Location = new System.Drawing.Point(134, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Order Number";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(134, 204);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePicker2.Location = new System.Drawing.Point(134, 249);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dateTimePicker2.RightToLeftLayout = true;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new System.Drawing.Size(124, 20);
            dateTimePicker2.TabIndex = 5;
            // 
            // SetAlarmButton
            // 
            this.SetAlarmButton.BackColor = System.Drawing.Color.Tomato;
            this.SetAlarmButton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAlarmButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SetAlarmButton.Location = new System.Drawing.Point(12, 326);
            this.SetAlarmButton.Name = "SetAlarmButton";
            this.SetAlarmButton.Size = new System.Drawing.Size(135, 40);
            this.SetAlarmButton.TabIndex = 6;
            this.SetAlarmButton.Text = "Set Alarm";
            this.SetAlarmButton.UseVisualStyleBackColor = false;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Tomato;
            this.backbutton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backbutton.Location = new System.Drawing.Point(153, 326);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(135, 40);
            this.backbutton.TabIndex = 7;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            // 
            // SkipButton
            // 
            this.SkipButton.BackColor = System.Drawing.Color.Tomato;
            this.SkipButton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkipButton.Location = new System.Drawing.Point(294, 326);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(135, 40);
            this.SkipButton.TabIndex = 8;
            this.SkipButton.Text = "Skip";
            this.SkipButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(623, 378);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.SetAlarmButton);
            this.Controls.Add(dateTimePicker2);
            this.Controls.Add(dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Primebeef Co. Monitoring System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SetAlarmButton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button SkipButton;
    }
}

