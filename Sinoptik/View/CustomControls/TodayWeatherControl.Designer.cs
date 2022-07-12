namespace Sinoptik.View.CustomControls
{
    partial class TodayWeatherControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tempL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.hourControl7 = new Sinoptik.View.CustomControls.HourControl();
            this.hourControl8 = new Sinoptik.View.CustomControls.HourControl();
            this.hourControl5 = new Sinoptik.View.CustomControls.HourControl();
            this.hourControl6 = new Sinoptik.View.CustomControls.HourControl();
            this.hourControl3 = new Sinoptik.View.CustomControls.HourControl();
            this.hourControl4 = new Sinoptik.View.CustomControls.HourControl();
            this.hourControl1 = new Sinoptik.View.CustomControls.HourControl();
            this.hourControl2 = new Sinoptik.View.CustomControls.HourControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempL
            // 
            this.tempL.Location = new System.Drawing.Point(5, 127);
            this.tempL.Name = "tempL";
            this.tempL.Size = new System.Drawing.Size(90, 18);
            this.tempL.TabIndex = 0;
            this.tempL.Text = "Температура";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "чувствуется как";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Давление мм";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Влажность %";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ветер м/с";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вероятность осадков %";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(91, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ночь";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.hourControl1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.hourControl2);
            this.panel1.Location = new System.Drawing.Point(114, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 273);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.hourControl3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.hourControl4);
            this.panel2.Location = new System.Drawing.Point(351, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 273);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(91, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Утро";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.hourControl5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.hourControl6);
            this.panel3.Location = new System.Drawing.Point(588, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 273);
            this.panel3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.OldLace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(91, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "День";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tomato;
            this.panel4.Controls.Add(this.hourControl7);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.hourControl8);
            this.panel4.Location = new System.Drawing.Point(825, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 273);
            this.panel4.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.OldLace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(91, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Вечер";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourControl7
            // 
            this.hourControl7.BackColor = System.Drawing.Color.OldLace;
            this.hourControl7.Location = new System.Drawing.Point(13, 24);
            this.hourControl7.Name = "hourControl7";
            this.hourControl7.Size = new System.Drawing.Size(100, 227);
            this.hourControl7.TabIndex = 6;
            // 
            // hourControl8
            // 
            this.hourControl8.BackColor = System.Drawing.Color.OldLace;
            this.hourControl8.Location = new System.Drawing.Point(119, 24);
            this.hourControl8.Name = "hourControl8";
            this.hourControl8.Size = new System.Drawing.Size(100, 227);
            this.hourControl8.TabIndex = 7;
            // 
            // hourControl5
            // 
            this.hourControl5.BackColor = System.Drawing.Color.OldLace;
            this.hourControl5.Location = new System.Drawing.Point(13, 24);
            this.hourControl5.Name = "hourControl5";
            this.hourControl5.Size = new System.Drawing.Size(100, 227);
            this.hourControl5.TabIndex = 6;
            // 
            // hourControl6
            // 
            this.hourControl6.BackColor = System.Drawing.Color.OldLace;
            this.hourControl6.Location = new System.Drawing.Point(119, 24);
            this.hourControl6.Name = "hourControl6";
            this.hourControl6.Size = new System.Drawing.Size(100, 227);
            this.hourControl6.TabIndex = 7;
            // 
            // hourControl3
            // 
            this.hourControl3.BackColor = System.Drawing.Color.OldLace;
            this.hourControl3.Location = new System.Drawing.Point(13, 24);
            this.hourControl3.Name = "hourControl3";
            this.hourControl3.Size = new System.Drawing.Size(100, 227);
            this.hourControl3.TabIndex = 6;
            // 
            // hourControl4
            // 
            this.hourControl4.BackColor = System.Drawing.Color.OldLace;
            this.hourControl4.Location = new System.Drawing.Point(119, 24);
            this.hourControl4.Name = "hourControl4";
            this.hourControl4.Size = new System.Drawing.Size(100, 227);
            this.hourControl4.TabIndex = 7;
            // 
            // hourControl1
            // 
            this.hourControl1.BackColor = System.Drawing.Color.OldLace;
            this.hourControl1.Location = new System.Drawing.Point(13, 24);
            this.hourControl1.Name = "hourControl1";
            this.hourControl1.Size = new System.Drawing.Size(100, 227);
            this.hourControl1.TabIndex = 6;
            // 
            // hourControl2
            // 
            this.hourControl2.BackColor = System.Drawing.Color.OldLace;
            this.hourControl2.Location = new System.Drawing.Point(119, 24);
            this.hourControl2.Name = "hourControl2";
            this.hourControl2.Size = new System.Drawing.Size(100, 227);
            this.hourControl2.TabIndex = 7;
            // 
            // TodayWeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempL);
            this.Name = "TodayWeatherControl";
            this.Size = new System.Drawing.Size(1075, 305);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tempL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private HourControl hourControl1;
        private HourControl hourControl2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private HourControl hourControl3;
        private System.Windows.Forms.Label label7;
        private HourControl hourControl4;
        private System.Windows.Forms.Panel panel3;
        private HourControl hourControl5;
        private System.Windows.Forms.Label label8;
        private HourControl hourControl6;
        private System.Windows.Forms.Panel panel4;
        private HourControl hourControl7;
        private System.Windows.Forms.Label label9;
        private HourControl hourControl8;
    }
}
