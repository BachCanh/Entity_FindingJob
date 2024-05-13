using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class FHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHistory));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblListJobs = new Label();
            pnSubBody = new FlowLayoutPanel();
            cbbStatus = new ReaLTaiizor.Controls.DungeonComboBox();
            btnFilter = new Guna.UI2.WinForms.Guna2Button();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // lblListJobs
            // 
            lblListJobs.AutoSize = true;
            lblListJobs.BackColor = Color.White;
            lblListJobs.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblListJobs.ForeColor = SystemColors.ControlText;
            lblListJobs.Location = new Point(37, 29);
            lblListJobs.Name = "lblListJobs";
            lblListJobs.Size = new Size(109, 35);
            lblListJobs.TabIndex = 6;
            lblListJobs.Text = "History";
            // 
            // pnSubBody
            // 
            pnSubBody.Location = new Point(66, 116);
            pnSubBody.Name = "pnSubBody";
            pnSubBody.Size = new Size(980, 222);
            pnSubBody.TabIndex = 7;
            // 
            // cbbStatus
            // 
            cbbStatus.BackColor = Color.FromArgb(246, 246, 246);
            cbbStatus.ColorA = Color.FromArgb(246, 132, 85);
            cbbStatus.ColorB = Color.FromArgb(231, 108, 57);
            cbbStatus.ColorC = Color.FromArgb(242, 241, 240);
            cbbStatus.ColorD = Color.FromArgb(253, 252, 252);
            cbbStatus.ColorE = Color.FromArgb(239, 237, 236);
            cbbStatus.ColorF = Color.FromArgb(180, 180, 180);
            cbbStatus.ColorG = Color.FromArgb(119, 119, 118);
            cbbStatus.ColorH = Color.FromArgb(224, 222, 220);
            cbbStatus.ColorI = Color.FromArgb(250, 249, 249);
            cbbStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cbbStatus.DropDownHeight = 250;
            cbbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbStatus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbbStatus.ForeColor = Color.FromArgb(76, 76, 97);
            cbbStatus.FormattingEnabled = true;
            cbbStatus.HoverSelectionColor = Color.Empty;
            cbbStatus.IntegralHeight = false;
            cbbStatus.ItemHeight = 30;
            cbbStatus.Items.AddRange(new object[] { "All", "Waiting", "Done" });
            cbbStatus.Location = new Point(919, 12);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(129, 36);
            cbbStatus.StartIndex = 0;
            cbbStatus.TabIndex = 2;
            cbbStatus.SelectedIndexChanged += cbbStatus_SelectedIndexChanged;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Transparent;
            btnFilter.BorderRadius = 23;
            btnFilter.CustomizableEdges = customizableEdges1;
            btnFilter.DisabledState.BorderColor = Color.DarkGray;
            btnFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilter.FillColor = Color.FromArgb(248, 212, 187);
            btnFilter.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.Black;
            btnFilter.HoverState.Font = new Font("Sitka Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.Location = new Point(889, 70);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFilter.Size = new Size(86, 36);
            btnFilter.TabIndex = 48;
            btnFilter.Text = "Filter";
            btnFilter.Click += btnFilter_Click;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.Cursor = Cursors.Hand;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Transparent;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Image = (Image)resources.GetObject("guna2CircleButton1.Image");
            guna2CircleButton1.ImageSize = new Size(45, 45);
            guna2CircleButton1.Location = new Point(991, 70);
            guna2CircleButton1.Margin = new Padding(3, 2, 3, 2);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(57, 36);
            guna2CircleButton1.TabIndex = 47;
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 17;
            txtSearch.CustomizableEdges = customizableEdges4;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(59, 70);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search for jobs";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtSearch.Size = new Size(824, 36);
            txtSearch.TabIndex = 46;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // FHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1079, 635);
            Controls.Add(btnFilter);
            Controls.Add(guna2CircleButton1);
            Controls.Add(txtSearch);
            Controls.Add(cbbStatus);
            Controls.Add(pnSubBody);
            Controls.Add(lblListJobs);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FHistory";
            Text = "FHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListJobs;
        private FlowLayoutPanel pnSubBody;
        private ReaLTaiizor.Controls.DungeonComboBox cbbStatus;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}