using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class FFindApplicant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFindApplicant));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnBody = new Panel();
            pnSubBody = new FlowLayoutPanel();
            lblListApplicant = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            pnBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnBody
            // 
            pnBody.AutoScroll = true;
            pnBody.AutoSize = true;
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(pnSubBody);
            pnBody.Controls.Add(lblListApplicant);
            pnBody.Controls.Add(txtSearch);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Margin = new Padding(3, 4, 3, 4);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1233, 847);
            pnBody.TabIndex = 3;
            // 
            // pnSubBody
            // 
            pnSubBody.AutoScroll = true;
            pnSubBody.Location = new Point(43, 173);
            pnSubBody.Margin = new Padding(3, 4, 3, 4);
            pnSubBody.Name = "pnSubBody";
            pnSubBody.Size = new Size(1143, 660);
            pnSubBody.TabIndex = 4;
            // 
            // lblListApplicant
            // 
            lblListApplicant.AutoSize = true;
            lblListApplicant.BackColor = Color.White;
            lblListApplicant.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold);
            lblListApplicant.ForeColor = SystemColors.ControlText;
            lblListApplicant.Location = new Point(53, 39);
            lblListApplicant.Name = "lblListApplicant";
            lblListApplicant.Size = new Size(308, 42);
            lblListApplicant.TabIndex = 3;
            lblListApplicant.Text = "List Of Applicants";
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
            txtSearch.Location = new Point(43, 104);
            txtSearch.Margin = new Padding(5, 4, 5, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search for applicants";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(1143, 48);
            txtSearch.TabIndex = 43;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // FFindApplicant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 847);
            Controls.Add(pnBody);
            Name = "FFindApplicant";
            Text = "FFindApplicant";
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnBody;
        private FlowLayoutPanel pnSubBody;
        private Label lblListApplicant;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}