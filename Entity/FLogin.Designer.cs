using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnforgotpw = new ReaLTaiizor.Controls.HopeRoundButton();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.rdojobseeker = new ReaLTaiizor.Controls.ParrotRadioButton();
            this.rdocompany = new ReaLTaiizor.Controls.ParrotRadioButton();
            this.txtemail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtpassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.sRemember = new ReaLTaiizor.Controls.MaterialSwitch();
            this.btnsignup = new ReaLTaiizor.Controls.ParrotButton();
            this.btnsignin = new ReaLTaiizor.Controls.ParrotButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.Black;
            this.bigLabel1.Location = new System.Drawing.Point(75, 29);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(201, 46);
            this.bigLabel1.TabIndex = 12;
            this.bigLabel1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(59)))), ((int)(((byte)(96)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(275, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 43);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.White;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.DimGray;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(911, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 23);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(445, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(585, 378);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnforgotpw
            // 
            this.btnforgotpw.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnforgotpw.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnforgotpw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnforgotpw.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnforgotpw.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnforgotpw.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnforgotpw.ForeColor = System.Drawing.Color.Black;
            this.btnforgotpw.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnforgotpw.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnforgotpw.Location = new System.Drawing.Point(244, 291);
            this.btnforgotpw.Name = "btnforgotpw";
            this.btnforgotpw.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnforgotpw.Size = new System.Drawing.Size(130, 31);
            this.btnforgotpw.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnforgotpw.TabIndex = 28;
            this.btnforgotpw.Text = "Forgot Password?";
            this.btnforgotpw.TextColor = System.Drawing.Color.White;
            this.btnforgotpw.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // foxLabel2
            // 
            this.foxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.foxLabel2.ForeColor = System.Drawing.Color.Black;
            this.foxLabel2.Location = new System.Drawing.Point(107, 83);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(232, 29);
            this.foxLabel2.TabIndex = 29;
            this.foxLabel2.Text = "Sign in With Email Address";
            // 
            // rdojobseeker
            // 
            this.rdojobseeker.Checked = false;
            this.rdojobseeker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdojobseeker.ForeColor = System.Drawing.Color.Black;
            this.rdojobseeker.Location = new System.Drawing.Point(107, 132);
            this.rdojobseeker.Name = "rdojobseeker";
            this.rdojobseeker.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.rdojobseeker.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.rdojobseeker.RadioHoverColor = System.Drawing.Color.Fuchsia;
            this.rdojobseeker.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            this.rdojobseeker.Size = new System.Drawing.Size(86, 14);
            this.rdojobseeker.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.rdojobseeker.TabIndex = 30;
            this.rdojobseeker.Text = "Job Seeker";
            this.rdojobseeker.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // rdocompany
            // 
            this.rdocompany.Checked = false;
            this.rdocompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdocompany.ForeColor = System.Drawing.Color.Black;
            this.rdocompany.Location = new System.Drawing.Point(255, 132);
            this.rdocompany.Name = "rdocompany";
            this.rdocompany.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.rdocompany.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.rdocompany.RadioHoverColor = System.Drawing.Color.Fuchsia;
            this.rdocompany.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            this.rdocompany.Size = new System.Drawing.Size(86, 14);
            this.rdocompany.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.rdocompany.TabIndex = 30;
            this.rdocompany.Text = "Company";
            this.rdocompany.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtemail
            // 
            this.txtemail.AnimateReadOnly = false;
            this.txtemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtemail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtemail.Depth = 0;
            this.txtemail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtemail.HideSelection = true;
            this.txtemail.Hint = "Enter Email Address";
            this.txtemail.LeadingIcon = null;
            this.txtemail.Location = new System.Drawing.Point(63, 166);
            this.txtemail.MaxLength = 32767;
            this.txtemail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PrefixSuffixText = null;
            this.txtemail.ReadOnly = false;
            this.txtemail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(288, 48);
            this.txtemail.TabIndex = 31;
            this.txtemail.TabStop = false;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtemail.TrailingIcon = null;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // txtpassword
            // 
            this.txtpassword.AnimateReadOnly = false;
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpassword.Depth = 0;
            this.txtpassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtpassword.HideSelection = true;
            this.txtpassword.Hint = "Enter Password";
            this.txtpassword.LeadingIcon = null;
            this.txtpassword.Location = new System.Drawing.Point(63, 225);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PrefixSuffixText = null;
            this.txtpassword.ReadOnly = false;
            this.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(288, 48);
            this.txtpassword.TabIndex = 32;
            this.txtpassword.TabStop = false;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.TrailingIcon = null;
            this.txtpassword.UseSystemPasswordChar = false;
            // 
            // sRemember
            // 
            this.sRemember.AutoSize = true;
            this.sRemember.Depth = 0;
            this.sRemember.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.sRemember.Location = new System.Drawing.Point(49, 290);
            this.sRemember.Margin = new System.Windows.Forms.Padding(0);
            this.sRemember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sRemember.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.sRemember.Name = "sRemember";
            this.sRemember.Ripple = true;
            this.sRemember.Size = new System.Drawing.Size(168, 37);
            this.sRemember.TabIndex = 33;
            this.sRemember.Text = "Remember me?";
            this.sRemember.UseAccentColor = false;
            this.sRemember.UseVisualStyleBackColor = true;
            // 
            // btnsignup
            // 
            this.btnsignup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.btnsignup.ButtonImage = null;
            this.btnsignup.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnsignup.ButtonText = "Sign Up";
            this.btnsignup.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(180)))));
            this.btnsignup.ClickTextColor = System.Drawing.Color.Black;
            this.btnsignup.CornerRadius = 6;
            this.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsignup.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsignup.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(197)))));
            this.btnsignup.HoverTextColor = System.Drawing.Color.Black;
            this.btnsignup.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnsignup.Location = new System.Drawing.Point(255, 336);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(112, 33);
            this.btnsignup.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnsignup.TabIndex = 34;
            this.btnsignup.TextColor = System.Drawing.Color.Black;
            this.btnsignup.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnsignup.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnsignin
            // 
            this.btnsignin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.btnsignin.ButtonImage = null;
            this.btnsignin.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnsignin.ButtonText = "Sign In";
            this.btnsignin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(180)))));
            this.btnsignin.ClickTextColor = System.Drawing.Color.Black;
            this.btnsignin.CornerRadius = 6;
            this.btnsignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsignin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsignin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(197)))));
            this.btnsignin.HoverTextColor = System.Drawing.Color.Black;
            this.btnsignin.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnsignin.Location = new System.Drawing.Point(63, 336);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(112, 33);
            this.btnsignin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnsignin.TabIndex = 34;
            this.btnsignin.TextColor = System.Drawing.Color.Black;
            this.btnsignin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnsignin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 401);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.sRemember);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.rdocompany);
            this.Controls.Add(this.rdojobseeker);
            this.Controls.Add(this.foxLabel2);
            this.Controls.Add(this.btnforgotpw);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(224, 53);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.HopeRoundButton btnforgotpw;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.ParrotRadioButton rdojobseeker;
        private ReaLTaiizor.Controls.ParrotRadioButton rdocompany;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtemail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtpassword;
        private ReaLTaiizor.Controls.MaterialSwitch sRemember;
        private ReaLTaiizor.Controls.ParrotButton btnsignup;
        private ReaLTaiizor.Controls.ParrotButton btnsignin;
    }
}