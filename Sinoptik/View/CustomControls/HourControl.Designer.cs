namespace Sinoptik.View.CustomControls
{
    partial class HourControl
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
            this.hoursL = new System.Windows.Forms.Label();
            this.weatherPB = new System.Windows.Forms.PictureBox();
            this.mainTempL = new System.Windows.Forms.Label();
            this.sensTempL = new System.Windows.Forms.Label();
            this.pressL = new System.Windows.Forms.Label();
            this.windL = new System.Windows.Forms.Label();
            this.wetnessL = new System.Windows.Forms.Label();
            this.precipitL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPB)).BeginInit();
            this.SuspendLayout();
            // 
            // hoursL
            // 
            this.hoursL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hoursL.Location = new System.Drawing.Point(6, 14);
            this.hoursL.Name = "hoursL";
            this.hoursL.Size = new System.Drawing.Size(123, 20);
            this.hoursL.TabIndex = 0;
            this.hoursL.Text = "label1";
            this.hoursL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherPB
            // 
            this.weatherPB.Location = new System.Drawing.Point(6, 37);
            this.weatherPB.Name = "weatherPB";
            this.weatherPB.Size = new System.Drawing.Size(123, 39);
            this.weatherPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.weatherPB.TabIndex = 1;
            this.weatherPB.TabStop = false;
            // 
            // mainTempL
            // 
            this.mainTempL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTempL.Location = new System.Drawing.Point(6, 79);
            this.mainTempL.Name = "mainTempL";
            this.mainTempL.Size = new System.Drawing.Size(123, 25);
            this.mainTempL.TabIndex = 2;
            this.mainTempL.Text = "label1";
            this.mainTempL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sensTempL
            // 
            this.sensTempL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensTempL.Location = new System.Drawing.Point(6, 104);
            this.sensTempL.Name = "sensTempL";
            this.sensTempL.Size = new System.Drawing.Size(123, 23);
            this.sensTempL.TabIndex = 3;
            this.sensTempL.Text = "label1";
            this.sensTempL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pressL
            // 
            this.pressL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressL.Location = new System.Drawing.Point(6, 127);
            this.pressL.Name = "pressL";
            this.pressL.Size = new System.Drawing.Size(123, 23);
            this.pressL.TabIndex = 4;
            this.pressL.Text = "label1";
            this.pressL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windL
            // 
            this.windL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windL.Location = new System.Drawing.Point(6, 173);
            this.windL.Name = "windL";
            this.windL.Size = new System.Drawing.Size(123, 23);
            this.windL.TabIndex = 5;
            this.windL.Text = "label1";
            this.windL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wetnessL
            // 
            this.wetnessL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wetnessL.Location = new System.Drawing.Point(6, 150);
            this.wetnessL.Name = "wetnessL";
            this.wetnessL.Size = new System.Drawing.Size(123, 23);
            this.wetnessL.TabIndex = 6;
            this.wetnessL.Text = "label1";
            this.wetnessL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precipitL
            // 
            this.precipitL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.precipitL.Location = new System.Drawing.Point(6, 196);
            this.precipitL.Name = "precipitL";
            this.precipitL.Size = new System.Drawing.Size(123, 23);
            this.precipitL.TabIndex = 7;
            this.precipitL.Text = "label1";
            this.precipitL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HourControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.precipitL);
            this.Controls.Add(this.wetnessL);
            this.Controls.Add(this.windL);
            this.Controls.Add(this.pressL);
            this.Controls.Add(this.sensTempL);
            this.Controls.Add(this.mainTempL);
            this.Controls.Add(this.weatherPB);
            this.Controls.Add(this.hoursL);
            this.Name = "HourControl";
            this.Size = new System.Drawing.Size(141, 227);
            ((System.ComponentModel.ISupportInitialize)(this.weatherPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hoursL;
        private System.Windows.Forms.PictureBox weatherPB;
        private System.Windows.Forms.Label mainTempL;
        private System.Windows.Forms.Label sensTempL;
        private System.Windows.Forms.Label pressL;
        private System.Windows.Forms.Label windL;
        private System.Windows.Forms.Label wetnessL;
        private System.Windows.Forms.Label precipitL;
    }
}
