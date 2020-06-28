using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CsharpWebView
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser Browser;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            CefSettings Configs = new CefSettings();
            Cef.Initialize(Configs);
            URL.Text = "https://www.google.com";
            Browser = new ChromiumWebBrowser(URL.Text);
            this.PBrowser.Controls.Add(Browser);
            Browser.Dock = DockStyle.Fill;
            Browser.AddressChanged += Chrome_Address_Changed;
        }
        private void Chrome_Address_Changed(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() => {
                URL.Text = e.Address;
            }));
        }
        private void URL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void URL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Browser.Load(URL.Text);
            }
        }

        private void Browser_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Bback_Click(object sender, EventArgs e)
        {
            if (Browser.CanGoBack)
                Browser.Back();
        }

        private void BNext_Click(object sender, EventArgs e)
        {
            if (Browser.CanGoForward)
                Browser.Forward();
            
        }

        private void BRef_Click(object sender, EventArgs e)
        {
            Browser.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
