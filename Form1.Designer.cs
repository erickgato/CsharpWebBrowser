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
            this.SuspendLayout();
            // 
            // Bback
            // 
            this.Bback.Location = new System.Drawing.Point(1, 0);
            this.Bback.Name = "Bback";
            this.Bback.Size = new System.Drawing.Size(80, 32);
            this.Bback.TabIndex = 0;
            this.Bback.Text = "<<";
            this.Bback.UseVisualStyleBackColor = true;
            this.Bback.Click += new System.EventHandler(this.Bback_Click);
            // 
            // BNext
            // 
            this.BNext.Location = new System.Drawing.Point(87, 0);
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
            this.URL.Location = new System.Drawing.Point(262, 0);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(818, 32);
            this.URL.TabIndex = 2;
            this.URL.TextChanged += new System.EventHandler(this.URL_TextChanged);
            this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URL_KeyDown);
            // 
            // BRef
            // 
            this.BRef.Location = new System.Drawing.Point(173, 0);
            this.BRef.Name = "BRef";
            this.BRef.Size = new System.Drawing.Size(83, 31);
            this.BRef.TabIndex = 3;
            this.BRef.Text = "Ref";
            this.BRef.UseVisualStyleBackColor = true;
            this.BRef.Click += new System.EventHandler(this.BRef_Click);
            // 
            // PBrowser
            // 
            this.PBrowser.Location = new System.Drawing.Point(1, 52);
            this.PBrowser.Name = "PBrowser";
            this.PBrowser.Size = new System.Drawing.Size(1079, 388);
            this.PBrowser.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1092, 443);
            this.Controls.Add(this.PBrowser);
            this.Controls.Add(this.BRef);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.BNext);
            this.Controls.Add(this.Bback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Erick Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bback;
        private System.Windows.Forms.Button BNext;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button BRef;
        private System.Windows.Forms.Panel PBrowser;
    }
}

