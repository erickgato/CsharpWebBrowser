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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bback = new System.Windows.Forms.Button();
            this.BNext = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.BRef = new System.Windows.Forms.Button();
            this.PBrowser = new System.Windows.Forms.Panel();
            this.Navigation = new System.Windows.Forms.TabControl();
            this.DefaltPage = new System.Windows.Forms.TabPage();
            this.Navigation.SuspendLayout();
            this.DefaltPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bback
            // 
            this.Bback.BackColor = System.Drawing.Color.Transparent;
            this.Bback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bback.BackgroundImage")));
            this.Bback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bback.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Bback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bback.Location = new System.Drawing.Point(6, 6);
            this.Bback.Name = "Bback";
            this.Bback.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bback.Size = new System.Drawing.Size(42, 32);
            this.Bback.TabIndex = 0;
            this.Bback.UseVisualStyleBackColor = false;
            this.Bback.Click += new System.EventHandler(this.Bback_Click);
            // 
            // BNext
            // 
            this.BNext.BackColor = System.Drawing.Color.Transparent;
            this.BNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BNext.BackgroundImage")));
            this.BNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BNext.Location = new System.Drawing.Point(54, 5);
            this.BNext.Name = "BNext";
            this.BNext.Size = new System.Drawing.Size(44, 33);
            this.BNext.TabIndex = 1;
            this.BNext.UseVisualStyleBackColor = false;
            this.BNext.Click += new System.EventHandler(this.BNext_Click);
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(164, 7);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(1095, 32);
            this.URL.TabIndex = 2;
            this.URL.TextChanged += new System.EventHandler(this.URL_TextChanged);
            this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URL_KeyDown);
            // 
            // BRef
            // 
            this.BRef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BRef.BackgroundImage")));
            this.BRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRef.ForeColor = System.Drawing.Color.DimGray;
            this.BRef.Location = new System.Drawing.Point(104, 3);
            this.BRef.Name = "BRef";
            this.BRef.Size = new System.Drawing.Size(54, 37);
            this.BRef.TabIndex = 3;
            this.BRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BRef.UseVisualStyleBackColor = true;
            this.BRef.Click += new System.EventHandler(this.BRef_Click);
            // 
            // PBrowser
            // 
            this.PBrowser.BackColor = System.Drawing.Color.Transparent;
            this.PBrowser.Location = new System.Drawing.Point(1, 45);
            this.PBrowser.Name = "PBrowser";
            this.PBrowser.Size = new System.Drawing.Size(1258, 514);
            this.PBrowser.TabIndex = 6;
            // 
            // Navigation
            // 
            this.Navigation.Controls.Add(this.DefaltPage);
            this.Navigation.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navigation.Location = new System.Drawing.Point(-1, 1);
            this.Navigation.Name = "Navigation";
            this.Navigation.SelectedIndex = 0;
            this.Navigation.Size = new System.Drawing.Size(1277, 608);
            this.Navigation.TabIndex = 7;
            // 
            // DefaltPage
            // 
            this.DefaltPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.DefaltPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DefaltPage.Controls.Add(this.PBrowser);
            this.DefaltPage.Controls.Add(this.URL);
            this.DefaltPage.Controls.Add(this.BRef);
            this.DefaltPage.Controls.Add(this.Bback);
            this.DefaltPage.Controls.Add(this.BNext);
            this.DefaltPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaltPage.Location = new System.Drawing.Point(4, 33);
            this.DefaltPage.Name = "DefaltPage";
            this.DefaltPage.Padding = new System.Windows.Forms.Padding(3);
            this.DefaltPage.Size = new System.Drawing.Size(1269, 571);
            this.DefaltPage.TabIndex = 0;
            this.DefaltPage.Text = "Home";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1279, 605);
            this.Controls.Add(this.Navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Erick Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Navigation.ResumeLayout(false);
            this.DefaltPage.ResumeLayout(false);
            this.DefaltPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bback;
        private System.Windows.Forms.Button BNext;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button BRef;
        private System.Windows.Forms.Panel PBrowser;
        private System.Windows.Forms.TabControl Navigation;
        private System.Windows.Forms.TabPage DefaltPage;
    }
}

