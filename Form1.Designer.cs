namespace CsharpWebView
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bback = new System.Windows.Forms.Button();
            this.BNext = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.BRef = new System.Windows.Forms.Button();
            this.PBrowser = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bback
            // 
            this.Bback.Location = new System.Drawing.Point(6, 6);
            this.Bback.Name = "Bback";
            this.Bback.Size = new System.Drawing.Size(80, 32);
            this.Bback.TabIndex = 0;
            this.Bback.Text = "<<";
            this.Bback.UseVisualStyleBackColor = true;
            this.Bback.Click += new System.EventHandler(this.Bback_Click);
            // 
            // BNext
            // 
            this.BNext.Location = new System.Drawing.Point(101, 6);
            this.BNext.Name = "BNext";
            this.BNext.Size = new System.Drawing.Size(80, 32);
            this.BNext.TabIndex = 1;
            this.BNext.Text = ">>";
            this.BNext.UseVisualStyleBackColor = true;
            this.BNext.Click += new System.EventHandler(this.BNext_Click);
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(312, 7);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(759, 32);
            this.URL.TabIndex = 2;
            this.URL.TextChanged += new System.EventHandler(this.URL_TextChanged);
            this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URL_KeyDown);
            // 
            // BRef
            // 
            this.BRef.Location = new System.Drawing.Point(201, 7);
            this.BRef.Name = "BRef";
            this.BRef.Size = new System.Drawing.Size(83, 31);
            this.BRef.TabIndex = 3;
            this.BRef.Text = "Ref";
            this.BRef.UseVisualStyleBackColor = true;
            this.BRef.Click += new System.EventHandler(this.BRef_Click);
            // 
            // PBrowser
            // 
            this.PBrowser.BackColor = System.Drawing.Color.Transparent;
            this.PBrowser.Location = new System.Drawing.Point(6, 45);
            this.PBrowser.Name = "PBrowser";
            this.PBrowser.Size = new System.Drawing.Size(1065, 361);
            this.PBrowser.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1085, 438);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage1.Controls.Add(this.PBrowser);
            this.tabPage1.Controls.Add(this.URL);
            this.tabPage1.Controls.Add(this.BRef);
            this.tabPage1.Controls.Add(this.Bback);
            this.tabPage1.Controls.Add(this.BNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1077, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1092, 443);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Erick Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bback;
        private System.Windows.Forms.Button BNext;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button BRef;
        private System.Windows.Forms.Panel PBrowser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

