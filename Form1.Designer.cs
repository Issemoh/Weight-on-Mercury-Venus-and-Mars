namespace Weight_on_Mercury__Venus__and_Mars
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
            this.lblEarth = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.txtMercuryWeight = new System.Windows.Forms.TextBox();
            this.txtVenusWeight = new System.Windows.Forms.TextBox();
            this.txtMarsWeight = new System.Windows.Forms.TextBox();
            this.lblMercury = new System.Windows.Forms.Label();
            this.lblVenus = new System.Windows.Forms.Label();
            this.lblMars = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEarth
            // 
            this.lblEarth.AutoSize = true;
            this.lblEarth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarth.Location = new System.Drawing.Point(63, 33);
            this.lblEarth.Name = "lblEarth";
            this.lblEarth.Size = new System.Drawing.Size(42, 17);
            this.lblEarth.TabIndex = 0;
            this.lblEarth.Text = "Earth";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(66, 86);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.Location = new System.Drawing.Point(125, 33);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(100, 20);
            this.txtEarthWeight.TabIndex = 2;
            // 
            // txtMercuryWeight
            // 
            this.txtMercuryWeight.Location = new System.Drawing.Point(416, 34);
            this.txtMercuryWeight.Name = "txtMercuryWeight";
            this.txtMercuryWeight.ReadOnly = true;
            this.txtMercuryWeight.Size = new System.Drawing.Size(100, 20);
            this.txtMercuryWeight.TabIndex = 3;
            // 
            // txtVenusWeight
            // 
            this.txtVenusWeight.Location = new System.Drawing.Point(416, 72);
            this.txtVenusWeight.Name = "txtVenusWeight";
            this.txtVenusWeight.ReadOnly = true;
            this.txtVenusWeight.Size = new System.Drawing.Size(100, 20);
            this.txtVenusWeight.TabIndex = 4;
            // 
            // txtMarsWeight
            // 
            this.txtMarsWeight.Location = new System.Drawing.Point(416, 106);
            this.txtMarsWeight.Name = "txtMarsWeight";
            this.txtMarsWeight.ReadOnly = true;
            this.txtMarsWeight.Size = new System.Drawing.Size(100, 20);
            this.txtMarsWeight.TabIndex = 5;
            // 
            // lblMercury
            // 
            this.lblMercury.AutoSize = true;
            this.lblMercury.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMercury.Location = new System.Drawing.Point(351, 34);
            this.lblMercury.Name = "lblMercury";
            this.lblMercury.Size = new System.Drawing.Size(59, 17);
            this.lblMercury.TabIndex = 6;
            this.lblMercury.Text = "Mercury";
            // 
            // lblVenus
            // 
            this.lblVenus.AutoSize = true;
            this.lblVenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenus.Location = new System.Drawing.Point(362, 72);
            this.lblVenus.Name = "lblVenus";
            this.lblVenus.Size = new System.Drawing.Size(48, 17);
            this.lblVenus.TabIndex = 7;
            this.lblVenus.Text = "Venus";
            // 
            // lblMars
            // 
            this.lblMars.AutoSize = true;
            this.lblMars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMars.Location = new System.Drawing.Point(371, 106);
            this.lblMars.Name = "lblMars";
            this.lblMars.Size = new System.Drawing.Size(39, 17);
            this.lblMars.TabIndex = 8;
            this.lblMars.Text = "Mars";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(65, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 29);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMars);
            this.Controls.Add(this.lblVenus);
            this.Controls.Add(this.lblMercury);
            this.Controls.Add(this.txtMarsWeight);
            this.Controls.Add(this.txtVenusWeight);
            this.Controls.Add(this.txtMercuryWeight);
            this.Controls.Add(this.txtEarthWeight);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblEarth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEarth;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtEarthWeight;
        private System.Windows.Forms.TextBox txtMercuryWeight;
        private System.Windows.Forms.TextBox txtVenusWeight;
        private System.Windows.Forms.TextBox txtMarsWeight;
        private System.Windows.Forms.Label lblMercury;
        private System.Windows.Forms.Label lblVenus;
        private System.Windows.Forms.Label lblMars;
        private System.Windows.Forms.Button btnExit;
    }
}

