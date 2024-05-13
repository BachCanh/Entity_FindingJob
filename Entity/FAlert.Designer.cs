using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FAlert
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
            txtSearch = new ReaLTaiizor.Controls.HopeTextBox();
            flpAlert = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(247, 218, 218);
            txtSearch.BaseColor = Color.FromArgb(44, 55, 66);
            txtSearch.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSearch.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.FromArgb(48, 49, 51);
            txtSearch.Hint = "Enter Search";
            txtSearch.Location = new Point(73, 48);
            txtSearch.MaxLength = 32767;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.Size = new Size(946, 38);
            txtSearch.TabIndex = 2;
            txtSearch.TabStop = false;
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // flpAlert
            // 
            flpAlert.AutoScroll = true;
            flpAlert.Location = new Point(24, 108);
            flpAlert.Name = "flpAlert";
            flpAlert.Size = new Size(1043, 124);
            flpAlert.TabIndex = 4;
            // 
            // FAlert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1079, 635);
            Controls.Add(flpAlert);
            Controls.Add(txtSearch);
            Name = "FAlert";
            Text = "FAlert";
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox txtSearch;
        private UCAlert ucAlert1;
        private FlowLayoutPanel flpAlert;
    }
}