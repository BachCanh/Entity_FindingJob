using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FRate
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            rtStars = new Guna.UI2.WinForms.Guna2RatingStar();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            rtxtContents = new ReaLTaiizor.Controls.HopeRichTextBox();
            btnRate = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // rtStars
            // 
            rtStars.Location = new Point(91, 12);
            rtStars.Name = "rtStars";
            rtStars.Size = new Size(120, 28);
            rtStars.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15F);
            guna2HtmlLabel1.Location = new Point(12, 7);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(54, 30);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Rates:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 15F);
            guna2HtmlLabel2.Location = new Point(12, 43);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(101, 30);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "Comments:";
            // 
            // rtxtContents
            // 
            rtxtContents.BorderColor = Color.FromArgb(220, 223, 230);
            rtxtContents.Font = new Font("Segoe UI", 12F);
            rtxtContents.ForeColor = Color.FromArgb(48, 49, 51);
            rtxtContents.Hint = "";
            rtxtContents.HoverBorderColor = Color.FromArgb(64, 158, 255);
            rtxtContents.Location = new Point(12, 79);
            rtxtContents.MaxLength = 32767;
            rtxtContents.Multiline = true;
            rtxtContents.Name = "rtxtContents";
            rtxtContents.PasswordChar = '\0';
            rtxtContents.ScrollBars = ScrollBars.None;
            rtxtContents.SelectedText = "";
            rtxtContents.SelectionLength = 0;
            rtxtContents.SelectionStart = 0;
            rtxtContents.Size = new Size(218, 225);
            rtxtContents.TabIndex = 4;
            rtxtContents.TabStop = false;
            rtxtContents.UseSystemPasswordChar = false;
            // 
            // btnRate
            // 
            btnRate.BackColor = Color.Transparent;
            btnRate.BorderRadius = 10;
            btnRate.CustomizableEdges = customizableEdges1;
            btnRate.DisabledState.BorderColor = Color.DarkGray;
            btnRate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRate.FillColor = Color.FromArgb(192, 192, 255);
            btnRate.Font = new Font("Segoe UI", 20F);
            btnRate.ForeColor = Color.Black;
            btnRate.Location = new Point(34, 312);
            btnRate.Name = "btnRate";
            btnRate.ShadowDecoration.BorderRadius = 10;
            btnRate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRate.ShadowDecoration.Depth = 10;
            btnRate.ShadowDecoration.Enabled = true;
            btnRate.Size = new Size(180, 45);
            btnRate.TabIndex = 5;
            btnRate.Text = "RATE";
            btnRate.Click += btnRate_Click;
            // 
            // FRate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(242, 366);
            Controls.Add(btnRate);
            Controls.Add(rtxtContents);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(rtStars);
            Name = "FRate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2RatingStar rtStars;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private ReaLTaiizor.Controls.HopeRichTextBox rtxtContents;
        public Guna.UI2.WinForms.Guna2Button btnRate;
    }
}