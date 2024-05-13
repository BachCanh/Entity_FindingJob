using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Entity
{
    partial class UCProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProject));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flPBtnSkills = new FlowLayoutPanel();
            flpSkills = new FlowLayoutPanel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            lblPeriod = new Label();
            lblProjects = new Label();
            flPBtnSkills.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flPBtnSkills
            // 
            flPBtnSkills.AutoSize = true;
            flPBtnSkills.Controls.Add(flpSkills);
            flPBtnSkills.Location = new Point(21, 69);
            flPBtnSkills.Name = "flPBtnSkills";
            flPBtnSkills.Size = new Size(358, 39);
            flPBtnSkills.TabIndex = 122;
            // 
            // flpSkills
            // 
            flpSkills.AutoSize = true;
            flpSkills.Dock = DockStyle.Left;
            flpSkills.Location = new Point(3, 3);
            flpSkills.Name = "flpSkills";
            flpSkills.Size = new Size(0, 0);
            flpSkills.TabIndex = 76;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(btnDelete);
            guna2ShadowPanel1.Controls.Add(lblPeriod);
            guna2ShadowPanel1.Controls.Add(lblProjects);
            guna2ShadowPanel1.Controls.Add(flPBtnSkills);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.MaximumSize = new Size(582, 120);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(582, 120);
            guna2ShadowPanel1.TabIndex = 123;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.FromArgb(224, 224, 224);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageSize = new Size(24, 24);
            btnDelete.Location = new Point(523, 11);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnDelete.Size = new Size(35, 30);
            btnDelete.TabIndex = 125;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.BackColor = Color.White;
            lblPeriod.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeriod.ForeColor = Color.Gray;
            lblPeriod.Location = new Point(21, 47);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(141, 19);
            lblPeriod.TabIndex = 124;
            lblPeriod.Text = "(StartDate - EndDate)";
            // 
            // lblProjects
            // 
            lblProjects.AutoSize = true;
            lblProjects.BackColor = Color.White;
            lblProjects.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProjects.ForeColor = SystemColors.ControlText;
            lblProjects.Location = new Point(16, 12);
            lblProjects.Name = "lblProjects";
            lblProjects.Size = new Size(196, 31);
            lblProjects.TabIndex = 123;
            lblProjects.Text = "Title, Company";
            // 
            // UCProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ShadowPanel1);
            MaximumSize = new Size(582, 120);
            Name = "UCProject";
            Size = new Size(582, 120);
            flPBtnSkills.ResumeLayout(false);
            flPBtnSkills.PerformLayout();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flPBtnSkills;
        private FlowLayoutPanel flpSkills;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Label lblPeriod;
        private Label lblProjects;
    }
}
