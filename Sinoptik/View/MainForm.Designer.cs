namespace Sinoptik
{
    partial class MainForm
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
            this.weatherTodayL = new System.Windows.Forms.Label();
            this.weatherPB = new System.Windows.Forms.PictureBox();
            this.lightDayL = new System.Windows.Forms.Label();
            this.dayInfoL = new System.Windows.Forms.Label();
            this.historyInfoL = new System.Windows.Forms.Label();
            this.termL = new System.Windows.Forms.PictureBox();
            this.minTempL = new System.Windows.Forms.Label();
            this.maxTempL = new System.Windows.Forms.Label();
            this.historyTempL = new System.Windows.Forms.Label();
            this.currentTempL = new System.Windows.Forms.Label();
            this.todayWeatherControl1 = new Sinoptik.View.CustomControls.TodayWeatherControl();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termL)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherTodayL
            // 
            this.weatherTodayL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weatherTodayL.Location = new System.Drawing.Point(12, 9);
            this.weatherTodayL.Name = "weatherTodayL";
            this.weatherTodayL.Size = new System.Drawing.Size(152, 23);
            this.weatherTodayL.TabIndex = 1;
            this.weatherTodayL.Text = "label1";
            // 
            // weatherPB
            // 
            this.weatherPB.Location = new System.Drawing.Point(15, 35);
            this.weatherPB.Name = "weatherPB";
            this.weatherPB.Size = new System.Drawing.Size(149, 138);
            this.weatherPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.weatherPB.TabIndex = 2;
            this.weatherPB.TabStop = false;
            // 
            // lightDayL
            // 
            this.lightDayL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lightDayL.Location = new System.Drawing.Point(12, 176);
            this.lightDayL.Name = "lightDayL";
            this.lightDayL.Size = new System.Drawing.Size(152, 23);
            this.lightDayL.TabIndex = 3;
            this.lightDayL.Text = "label1";
            // 
            // dayInfoL
            // 
            this.dayInfoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayInfoL.Location = new System.Drawing.Point(207, 9);
            this.dayInfoL.Name = "dayInfoL";
            this.dayInfoL.Size = new System.Drawing.Size(414, 75);
            this.dayInfoL.TabIndex = 4;
            this.dayInfoL.Text = "label1";
            // 
            // historyInfoL
            // 
            this.historyInfoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyInfoL.Location = new System.Drawing.Point(207, 111);
            this.historyInfoL.Name = "historyInfoL";
            this.historyInfoL.Size = new System.Drawing.Size(414, 75);
            this.historyInfoL.TabIndex = 5;
            this.historyInfoL.Text = "label2";
            // 
            // termL
            // 
            this.termL.Image = global::Sinoptik.Properties.Resources.thermometer;
            this.termL.Location = new System.Drawing.Point(638, 124);
            this.termL.Name = "termL";
            this.termL.Size = new System.Drawing.Size(58, 75);
            this.termL.TabIndex = 6;
            this.termL.TabStop = false;
            // 
            // minTempL
            // 
            this.minTempL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minTempL.Location = new System.Drawing.Point(702, 132);
            this.minTempL.Name = "minTempL";
            this.minTempL.Size = new System.Drawing.Size(152, 23);
            this.minTempL.TabIndex = 7;
            this.minTempL.Text = "label1";
            this.minTempL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxTempL
            // 
            this.maxTempL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxTempL.Location = new System.Drawing.Point(702, 155);
            this.maxTempL.Name = "maxTempL";
            this.maxTempL.Size = new System.Drawing.Size(152, 23);
            this.maxTempL.TabIndex = 8;
            this.maxTempL.Text = "label2";
            this.maxTempL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // historyTempL
            // 
            this.historyTempL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyTempL.Location = new System.Drawing.Point(635, 98);
            this.historyTempL.Name = "historyTempL";
            this.historyTempL.Size = new System.Drawing.Size(219, 23);
            this.historyTempL.TabIndex = 9;
            this.historyTempL.Text = "label1";
            this.historyTempL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentTempL
            // 
            this.currentTempL.BackColor = System.Drawing.Color.White;
            this.currentTempL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTempL.Location = new System.Drawing.Point(46, 132);
            this.currentTempL.Name = "currentTempL";
            this.currentTempL.Size = new System.Drawing.Size(77, 32);
            this.currentTempL.TabIndex = 10;
            this.currentTempL.Text = "label1";
            this.currentTempL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayWeatherControl1
            // 
            this.todayWeatherControl1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.todayWeatherControl1.Location = new System.Drawing.Point(12, 218);
            this.todayWeatherControl1.Name = "todayWeatherControl1";
            this.todayWeatherControl1.Size = new System.Drawing.Size(1075, 305);
            this.todayWeatherControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 535);
            this.Controls.Add(this.currentTempL);
            this.Controls.Add(this.historyTempL);
            this.Controls.Add(this.maxTempL);
            this.Controls.Add(this.minTempL);
            this.Controls.Add(this.termL);
            this.Controls.Add(this.historyInfoL);
            this.Controls.Add(this.dayInfoL);
            this.Controls.Add(this.lightDayL);
            this.Controls.Add(this.weatherPB);
            this.Controls.Add(this.weatherTodayL);
            this.Controls.Add(this.todayWeatherControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.weatherPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private View.CustomControls.TodayWeatherControl todayWeatherControl1;
        private System.Windows.Forms.Label weatherTodayL;
        private System.Windows.Forms.PictureBox weatherPB;
        private System.Windows.Forms.Label lightDayL;
        private System.Windows.Forms.Label dayInfoL;
        private System.Windows.Forms.Label historyInfoL;
        private System.Windows.Forms.PictureBox termL;
        private System.Windows.Forms.Label minTempL;
        private System.Windows.Forms.Label maxTempL;
        private System.Windows.Forms.Label historyTempL;
        private System.Windows.Forms.Label currentTempL;
    }
}

