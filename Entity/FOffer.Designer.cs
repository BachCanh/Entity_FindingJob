using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class FOffer
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtContent = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblToT = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm2 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnInterview = new Guna.UI2.WinForms.Guna2Button();
            this.cbbSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 30;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSend.Location = new System.Drawing.Point(686, 346);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(153, 39);
            this.btnSend.TabIndex = 38;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(866, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 39);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtContent
            // 
            this.txtContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtContent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtContent.Hint = "";
            this.txtContent.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtContent.Location = new System.Drawing.Point(141, 113);
            this.txtContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContent.MaxLength = 32767;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.SelectedText = "";
            this.txtContent.SelectionLength = 0;
            this.txtContent.SelectionStart = 0;
            this.txtContent.Size = new System.Drawing.Size(879, 189);
            this.txtContent.TabIndex = 36;
            this.txtContent.TabStop = false;
            this.txtContent.Text = "Enter content";
            this.txtContent.UseSystemPasswordChar = false;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblContent.Location = new System.Drawing.Point(30, 113);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(105, 32);
            this.lblContent.TabIndex = 35;
            this.lblContent.Text = "Content:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSubject.Location = new System.Drawing.Point(30, 70);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(98, 32);
            this.lblSubject.TabIndex = 34;
            this.lblSubject.Text = "Subject:";
            // 
            // lblToT
            // 
            this.lblToT.AutoSize = true;
            this.lblToT.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblToT.Location = new System.Drawing.Point(141, 28);
            this.lblToT.Name = "lblToT";
            this.lblToT.Size = new System.Drawing.Size(44, 32);
            this.lblToT.TabIndex = 33;
            this.lblToT.Text = "To:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTo.Location = new System.Drawing.Point(30, 28);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(44, 32);
            this.lblTo.TabIndex = 32;
            this.lblTo.Text = "To:";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            // 
            // guna2ShadowForm2
            // 
            this.guna2ShadowForm2.BorderRadius = 30;
            // 
            // btnInterview
            // 
            this.btnInterview.BorderRadius = 10;
            this.btnInterview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInterview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInterview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInterview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInterview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnInterview.Font = new System.Drawing.Font("Arial", 11F);
            this.btnInterview.ForeColor = System.Drawing.Color.Black;
            this.btnInterview.Location = new System.Drawing.Point(413, 70);
            this.btnInterview.Name = "btnInterview";
            this.btnInterview.Size = new System.Drawing.Size(122, 38);
            this.btnInterview.TabIndex = 40;
            this.btnInterview.Text = "Interview";
            this.btnInterview.Visible = false;
            this.btnInterview.Click += new System.EventHandler(this.btnInterview_Click);
            // 
            // cbbSubject
            // 
            this.cbbSubject.BackColor = System.Drawing.Color.Transparent;
            this.cbbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSubject.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.cbbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSubject.ItemHeight = 30;
            this.cbbSubject.Items.AddRange(new object[] {
            "Approve",
            "Decline"});
            this.cbbSubject.Location = new System.Drawing.Point(141, 70);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(252, 36);
            this.cbbSubject.TabIndex = 39;
            this.cbbSubject.SelectedIndexChanged += new System.EventHandler(this.cbbSubject_SelectedIndexChanged);
            // 
            // FOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 412);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblToT);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnInterview);
            this.Controls.Add(this.cbbSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOffer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Button btnSend;
        private Button btnCancel;
        private ReaLTaiizor.Controls.HopeRichTextBox txtContent;
        private Label lblContent;
        private Label lblSubject;
        private Label lblToT;
        private Label lblTo;
        private Guna.UI2.WinForms.Guna2Button btnInterview;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSubject;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm2;
    }
}