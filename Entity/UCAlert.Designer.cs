using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class UCAlert
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAlert));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblFromT = new Label();
            pictureBox1 = new PictureBox();
            lblDateT = new Label();
            ptbCompanyPicture = new PictureBox();
            lblJobNameT = new Label();
            lblSubjectT = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            lblStatus = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbCompanyPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 232, 223);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(ptbCompanyPicture);
            panel1.Controls.Add(lblJobNameT);
            panel1.Controls.Add(lblSubjectT);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 3, 10, 10);
            panel1.MaximumSize = new Size(531, 206);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 159);
            panel1.TabIndex = 8;
            panel1.Click += panel1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblFromT);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(lblDateT);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(lblStatus);
            flowLayoutPanel1.Location = new Point(14, 63);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(364, 30);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // lblFromT
            // 
            lblFromT.AutoSize = true;
            lblFromT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFromT.ForeColor = Color.FromArgb(64, 64, 64);
            lblFromT.Location = new Point(3, 0);
            lblFromT.Name = "lblFromT";
            lblFromT.Size = new Size(58, 25);
            lblFromT.TabIndex = 0;
            lblFromT.Text = "From:";
            lblFromT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.ForeColor = Color.FromArgb(64, 64, 64);
            lblDateT.Location = new Point(103, 0);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(58, 25);
            lblDateT.TabIndex = 0;
            lblDateT.Text = "Date: ";
            lblDateT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptbCompanyPicture
            // 
            ptbCompanyPicture.Location = new Point(384, 14);
            ptbCompanyPicture.Margin = new Padding(3, 2, 3, 2);
            ptbCompanyPicture.Name = "ptbCompanyPicture";
            ptbCompanyPicture.Size = new Size(91, 91);
            ptbCompanyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCompanyPicture.TabIndex = 9;
            ptbCompanyPicture.TabStop = false;
            // 
            // lblJobNameT
            // 
            lblJobNameT.AutoSize = true;
            lblJobNameT.Font = new Font("Segoe UI Semibold", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobNameT.Location = new Point(14, 14);
            lblJobNameT.Name = "lblJobNameT";
            lblJobNameT.Size = new Size(140, 37);
            lblJobNameT.TabIndex = 1;
            lblJobNameT.Text = "Job Name";
            // 
            // lblSubjectT
            // 
            lblSubjectT.AutoSize = true;
            lblSubjectT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubjectT.ForeColor = Color.FromArgb(64, 64, 64);
            lblSubjectT.Location = new Point(14, 111);
            lblSubjectT.Name = "lblSubjectT";
            lblSubjectT.Size = new Size(79, 25);
            lblSubjectT.TabIndex = 0;
            lblSubjectT.Text = "Subject: ";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = panel1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(64, 64, 64);
            lblStatus.Location = new Point(203, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(167, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // UCAlert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 10, 10);
            Name = "UCAlert";
            Size = new Size(500, 159);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbCompanyPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label lblSubjectT;
        public Label lblJobNameT;
        private PictureBox ptbCompanyPicture;
        private FlowLayoutPanel flowLayoutPanel1;
        public Label lblFromT;
        public Label lblDateT;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PictureBox pictureBox2;
        public Label lblStatus;
    }
}
