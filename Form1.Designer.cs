namespace Weather_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCity = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblSR = new System.Windows.Forms.Label();
            this.lblSRna = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            this.lblSSna = new System.Windows.Forms.Label();
            this.lblWS = new System.Windows.Forms.Label();
            this.lblWSna = new System.Windows.Forms.Label();
            this.lblPna = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTna = new System.Windows.Forms.Label();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(75, 46);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(53, 28);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(134, 43);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(287, 36);
            this.TBCity.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(450, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 37);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.Transparent;
            this.lblCon.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.ForeColor = System.Drawing.Color.White;
            this.lblCon.Location = new System.Drawing.Point(75, 124);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(108, 28);
            this.lblCon.TabIndex = 5;
            this.lblCon.Text = "Condition:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(75, 187);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(81, 28);
            this.lblDetails.TabIndex = 6;
            this.lblDetails.Text = "Details:";
            // 
            // lblSR
            // 
            this.lblSR.AutoSize = true;
            this.lblSR.BackColor = System.Drawing.Color.Transparent;
            this.lblSR.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSR.ForeColor = System.Drawing.Color.White;
            this.lblSR.Location = new System.Drawing.Point(75, 312);
            this.lblSR.Name = "lblSR";
            this.lblSR.Size = new System.Drawing.Size(95, 28);
            this.lblSR.TabIndex = 7;
            this.lblSR.Text = "Sun Rise:";
            // 
            // lblSRna
            // 
            this.lblSRna.AutoSize = true;
            this.lblSRna.BackColor = System.Drawing.Color.Transparent;
            this.lblSRna.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSRna.ForeColor = System.Drawing.Color.White;
            this.lblSRna.Location = new System.Drawing.Point(176, 312);
            this.lblSRna.Name = "lblSRna";
            this.lblSRna.Size = new System.Drawing.Size(48, 28);
            this.lblSRna.TabIndex = 8;
            this.lblSRna.Text = "N/A";
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.BackColor = System.Drawing.Color.Transparent;
            this.lblSS.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSS.ForeColor = System.Drawing.Color.White;
            this.lblSS.Location = new System.Drawing.Point(75, 371);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(88, 28);
            this.lblSS.TabIndex = 9;
            this.lblSS.Text = "Sun Set:";
            // 
            // lblSSna
            // 
            this.lblSSna.AutoSize = true;
            this.lblSSna.BackColor = System.Drawing.Color.Transparent;
            this.lblSSna.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSna.ForeColor = System.Drawing.Color.White;
            this.lblSSna.Location = new System.Drawing.Point(176, 371);
            this.lblSSna.Name = "lblSSna";
            this.lblSSna.Size = new System.Drawing.Size(48, 28);
            this.lblSSna.TabIndex = 10;
            this.lblSSna.Text = "N/A";
            // 
            // lblWS
            // 
            this.lblWS.AutoSize = true;
            this.lblWS.BackColor = System.Drawing.Color.Transparent;
            this.lblWS.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWS.ForeColor = System.Drawing.Color.White;
            this.lblWS.Location = new System.Drawing.Point(445, 124);
            this.lblWS.Name = "lblWS";
            this.lblWS.Size = new System.Drawing.Size(129, 28);
            this.lblWS.TabIndex = 11;
            this.lblWS.Text = "Wind Speed:";
            // 
            // lblWSna
            // 
            this.lblWSna.AutoSize = true;
            this.lblWSna.BackColor = System.Drawing.Color.Transparent;
            this.lblWSna.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSna.ForeColor = System.Drawing.Color.White;
            this.lblWSna.Location = new System.Drawing.Point(580, 124);
            this.lblWSna.Name = "lblWSna";
            this.lblWSna.Size = new System.Drawing.Size(48, 28);
            this.lblWSna.TabIndex = 12;
            this.lblWSna.Text = "N/A";
            // 
            // lblPna
            // 
            this.lblPna.AutoSize = true;
            this.lblPna.BackColor = System.Drawing.Color.Transparent;
            this.lblPna.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPna.ForeColor = System.Drawing.Color.White;
            this.lblPna.Location = new System.Drawing.Point(580, 187);
            this.lblPna.Name = "lblPna";
            this.lblPna.Size = new System.Drawing.Size(48, 28);
            this.lblPna.TabIndex = 13;
            this.lblPna.Text = "N/A";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.BackColor = System.Drawing.Color.Transparent;
            this.lblPressure.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.ForeColor = System.Drawing.Color.White;
            this.lblPressure.Location = new System.Drawing.Point(445, 187);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(98, 28);
            this.lblPressure.TabIndex = 14;
            this.lblPressure.Text = "Pressure:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(743, 46);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(134, 106);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 15;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(75, 249);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(137, 28);
            this.lblTemp.TabIndex = 16;
            this.lblTemp.Text = "Temperature:";
            // 
            // lblTna
            // 
            this.lblTna.AutoSize = true;
            this.lblTna.BackColor = System.Drawing.Color.Transparent;
            this.lblTna.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTna.ForeColor = System.Drawing.Color.White;
            this.lblTna.Location = new System.Drawing.Point(218, 249);
            this.lblTna.Name = "lblTna";
            this.lblTna.Size = new System.Drawing.Size(48, 28);
            this.lblTna.TabIndex = 17;
            this.lblTna.Text = "N/A";
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(134, 402);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(848, 155);
            this.FLP.TabIndex = 18;
            this.FLP.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 569);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.lblTna);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.lblPna);
            this.Controls.Add(this.lblWSna);
            this.Controls.Add(this.lblWS);
            this.Controls.Add(this.lblSSna);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.lblSRna);
            this.Controls.Add(this.lblSR);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.lblCity);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblSR;
        private System.Windows.Forms.Label lblSRna;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label lblSSna;
        private System.Windows.Forms.Label lblWS;
        private System.Windows.Forms.Label lblWSna;
        private System.Windows.Forms.Label lblPna;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblTna;
        private System.Windows.Forms.FlowLayoutPanel FLP;
    }
}

