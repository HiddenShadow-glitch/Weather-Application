namespace Weather_Application
{
    partial class ForecastUC
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
            this.picWIcon = new System.Windows.Forms.PictureBox();
            this.labDT = new System.Windows.Forms.Label();
            this.labMainW = new System.Windows.Forms.Label();
            this.labWDes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWIcon
            // 
            this.picWIcon.Location = new System.Drawing.Point(27, 21);
            this.picWIcon.Name = "picWIcon";
            this.picWIcon.Size = new System.Drawing.Size(149, 120);
            this.picWIcon.TabIndex = 0;
            this.picWIcon.TabStop = false;
            // 
            // labDT
            // 
            this.labDT.AutoSize = true;
            this.labDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDT.ForeColor = System.Drawing.Color.White;
            this.labDT.Location = new System.Drawing.Point(182, 29);
            this.labDT.Name = "labDT";
            this.labDT.Size = new System.Drawing.Size(64, 20);
            this.labDT.TabIndex = 2;
            this.labDT.Text = "Sunday";
            // 
            // labMainW
            // 
            this.labMainW.AutoSize = true;
            this.labMainW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainW.ForeColor = System.Drawing.Color.White;
            this.labMainW.Location = new System.Drawing.Point(182, 66);
            this.labMainW.Name = "labMainW";
            this.labMainW.Size = new System.Drawing.Size(49, 20);
            this.labMainW.TabIndex = 3;
            this.labMainW.Text = "Clear";
            // 
            // labWDes
            // 
            this.labWDes.AutoSize = true;
            this.labWDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWDes.ForeColor = System.Drawing.Color.White;
            this.labWDes.Location = new System.Drawing.Point(182, 108);
            this.labWDes.Name = "labWDes";
            this.labWDes.Size = new System.Drawing.Size(95, 20);
            this.labWDes.TabIndex = 4;
            this.labWDes.Text = "Description";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labWDes);
            this.Controls.Add(this.labMainW);
            this.Controls.Add(this.labDT);
            this.Controls.Add(this.picWIcon);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(673, 171);
            ((System.ComponentModel.ISupportInitialize)(this.picWIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labMainW;
        public System.Windows.Forms.Label labDT;
        public System.Windows.Forms.Label labWDes;
        public System.Windows.Forms.PictureBox picWIcon;
    }
}
