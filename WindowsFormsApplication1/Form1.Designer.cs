namespace WindowsFormsApplication1
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
            this.w1 = new System.Windows.Forms.WebBrowser();
            this.baslat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // w1
            // 
            this.w1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w1.Location = new System.Drawing.Point(0, 0);
            this.w1.MinimumSize = new System.Drawing.Size(20, 20);
            this.w1.Name = "w1";
            this.w1.ScriptErrorsSuppressed = true;
            this.w1.Size = new System.Drawing.Size(649, 535);
            this.w1.TabIndex = 0;
            this.w1.Url = new System.Uri("https://www.bilyoner.com/milli-piyango/milli-piyango-bileti-al", System.UriKind.Absolute);
            this.w1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.w1_DocumentCompleted);
            // 
            // baslat
            // 
            this.baslat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.baslat.Location = new System.Drawing.Point(0, 0);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(128, 74);
            this.baslat.TabIndex = 1;
            this.baslat.Text = "BAŞLAT";
            this.baslat.UseVisualStyleBackColor = true;
            this.baslat.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(283, 155);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(326, 20);
            this.t1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 535);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.w1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser w1;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t1;
    }
}

