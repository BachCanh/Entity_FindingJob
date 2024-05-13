using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class FApplicant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FApplicant));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flpApplicant = new FlowLayoutPanel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // flpApplicant
            // 
            flpApplicant.Location = new Point(47, 139);
            flpApplicant.Margin = new Padding(3, 4, 3, 4);
            flpApplicant.Name = "flpApplicant";
            flpApplicant.Size = new Size(1086, 272);
            flpApplicant.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 23;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 10.8F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(121, 44);
            txtSearch.Margin = new Padding(5, 4, 5, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search for jobs";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(813, 48);
            txtSearch.TabIndex = 38;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // FApplicant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1160, 847);
            Controls.Add(txtSearch);
            Controls.Add(flpApplicant);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FApplicant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FApplicant";
            Load += FApplicant_Load;
            ResumeLayout(false);
        }

        #endregion
        private UCApplicant ucApplicant1;
        private FlowLayoutPanel flpApplicant;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}