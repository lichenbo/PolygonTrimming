namespace PolygonTrimming
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
            this.picImg = new System.Windows.Forms.PictureBox();
            this.picWindow = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.txtWindow = new System.Windows.Forms.TextBox();
            this.comboAlgo = new System.Windows.Forms.ComboBox();
            this.btnClip = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(12, 12);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(249, 225);
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            // 
            // picWindow
            // 
            this.picWindow.Location = new System.Drawing.Point(12, 243);
            this.picWindow.Name = "picWindow";
            this.picWindow.Size = new System.Drawing.Size(249, 225);
            this.picWindow.TabIndex = 1;
            this.picWindow.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(559, 124);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(249, 225);
            this.picResult.TabIndex = 2;
            this.picResult.TabStop = false;
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(277, 12);
            this.txtImg.Multiline = true;
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(124, 186);
            this.txtImg.TabIndex = 3;
            // 
            // txtWindow
            // 
            this.txtWindow.Location = new System.Drawing.Point(277, 244);
            this.txtWindow.Multiline = true;
            this.txtWindow.Name = "txtWindow";
            this.txtWindow.Size = new System.Drawing.Size(124, 185);
            this.txtWindow.TabIndex = 4;
            // 
            // comboAlgo
            // 
            this.comboAlgo.FormattingEnabled = true;
            this.comboAlgo.Items.AddRange(new object[] {
            "Sutherland-Hodgman",
            "Weilerr-Atherton"});
            this.comboAlgo.Location = new System.Drawing.Point(408, 178);
            this.comboAlgo.Name = "comboAlgo";
            this.comboAlgo.Size = new System.Drawing.Size(145, 20);
            this.comboAlgo.TabIndex = 5;
            // 
            // btnClip
            // 
            this.btnClip.Location = new System.Drawing.Point(408, 266);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(145, 23);
            this.btnClip.TabIndex = 6;
            this.btnClip.Text = "Clip";
            this.btnClip.UseVisualStyleBackColor = true;
            this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(279, 208);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(122, 28);
            this.btnImg.TabIndex = 7;
            this.btnImg.Text = "Draw";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnWindow
            // 
            this.btnWindow.Location = new System.Drawing.Point(279, 440);
            this.btnWindow.Name = "btnWindow";
            this.btnWindow.Size = new System.Drawing.Size(122, 28);
            this.btnWindow.TabIndex = 8;
            this.btnWindow.Text = "Draw";
            this.btnWindow.UseVisualStyleBackColor = true;
            this.btnWindow.Click += new System.EventHandler(this.btnWindow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 499);
            this.Controls.Add(this.btnWindow);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnClip);
            this.Controls.Add(this.comboAlgo);
            this.Controls.Add(this.txtWindow);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picWindow);
            this.Controls.Add(this.picImg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.PictureBox picWindow;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.TextBox txtWindow;
        private System.Windows.Forms.ComboBox comboAlgo;
        private System.Windows.Forms.Button btnClip;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnWindow;
    }
}

