using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class FCompanyDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCompanyDetail));
            this.cbbCompanySize = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cbbCompanyType = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtWebsiteLink = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.cbbWTEnd = new ReaLTaiizor.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbWTB = new ReaLTaiizor.Controls.MaterialComboBox();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtPhoneNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtCompanyName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtDetail = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCompanySize
            // 
            this.cbbCompanySize.AutoResize = false;
            this.cbbCompanySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbCompanySize.Depth = 0;
            this.cbbCompanySize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbCompanySize.DropDownHeight = 174;
            this.cbbCompanySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCompanySize.DropDownWidth = 121;
            this.cbbCompanySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbCompanySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbCompanySize.FormattingEnabled = true;
            this.cbbCompanySize.Hint = "Company Size";
            this.cbbCompanySize.IntegralHeight = false;
            this.cbbCompanySize.ItemHeight = 43;
            this.cbbCompanySize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cbbCompanySize.Location = new System.Drawing.Point(27, 231);
            this.cbbCompanySize.MaxDropDownItems = 4;
            this.cbbCompanySize.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbbCompanySize.Name = "cbbCompanySize";
            this.cbbCompanySize.Size = new System.Drawing.Size(298, 49);
            this.cbbCompanySize.StartIndex = 0;
            this.cbbCompanySize.TabIndex = 78;
            // 
            // cbbCompanyType
            // 
            this.cbbCompanyType.AutoResize = false;
            this.cbbCompanyType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbCompanyType.Depth = 0;
            this.cbbCompanyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbCompanyType.DropDownHeight = 174;
            this.cbbCompanyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCompanyType.DropDownWidth = 121;
            this.cbbCompanyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbCompanyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbCompanyType.FormattingEnabled = true;
            this.cbbCompanyType.Hint = "Company Type";
            this.cbbCompanyType.IntegralHeight = false;
            this.cbbCompanyType.ItemHeight = 43;
            this.cbbCompanyType.Items.AddRange(new object[] {
            "Outsource",
            "Product",
            "HeadHunter",
            "Non - IT",
            "Services and Consulting"});
            this.cbbCompanyType.Location = new System.Drawing.Point(374, 159);
            this.cbbCompanyType.MaxDropDownItems = 4;
            this.cbbCompanyType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbbCompanyType.Name = "cbbCompanyType";
            this.cbbCompanyType.Size = new System.Drawing.Size(298, 49);
            this.cbbCompanyType.StartIndex = 0;
            this.cbbCompanyType.TabIndex = 77;
            // 
            // txtWebsiteLink
            // 
            this.txtWebsiteLink.AllowPromptAsInput = true;
            this.txtWebsiteLink.AnimateReadOnly = false;
            this.txtWebsiteLink.AsciiOnly = false;
            this.txtWebsiteLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtWebsiteLink.BeepOnError = false;
            this.txtWebsiteLink.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtWebsiteLink.Depth = 0;
            this.txtWebsiteLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWebsiteLink.HidePromptOnLeave = false;
            this.txtWebsiteLink.HideSelection = true;
            this.txtWebsiteLink.Hint = "Website Link";
            this.txtWebsiteLink.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtWebsiteLink.LeadingIcon = null;
            this.txtWebsiteLink.Location = new System.Drawing.Point(374, 90);
            this.txtWebsiteLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWebsiteLink.Mask = "";
            this.txtWebsiteLink.MaxLength = 32767;
            this.txtWebsiteLink.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtWebsiteLink.Name = "txtWebsiteLink";
            this.txtWebsiteLink.PasswordChar = '\0';
            this.txtWebsiteLink.PrefixSuffixText = null;
            this.txtWebsiteLink.PromptChar = '_';
            this.txtWebsiteLink.ReadOnly = false;
            this.txtWebsiteLink.RejectInputOnFirstFailure = false;
            this.txtWebsiteLink.ResetOnPrompt = true;
            this.txtWebsiteLink.ResetOnSpace = true;
            this.txtWebsiteLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWebsiteLink.SelectedText = "";
            this.txtWebsiteLink.SelectionLength = 0;
            this.txtWebsiteLink.SelectionStart = 0;
            this.txtWebsiteLink.ShortcutsEnabled = true;
            this.txtWebsiteLink.Size = new System.Drawing.Size(298, 48);
            this.txtWebsiteLink.SkipLiterals = true;
            this.txtWebsiteLink.TabIndex = 74;
            this.txtWebsiteLink.TabStop = false;
            this.txtWebsiteLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWebsiteLink.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtWebsiteLink.TrailingIcon = null;
            this.txtWebsiteLink.UseSystemPasswordChar = false;
            this.txtWebsiteLink.ValidatingType = null;
            // 
            // cbbWTEnd
            // 
            this.cbbWTEnd.AutoResize = false;
            this.cbbWTEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbWTEnd.Depth = 0;
            this.cbbWTEnd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbWTEnd.DropDownHeight = 174;
            this.cbbWTEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWTEnd.DropDownWidth = 121;
            this.cbbWTEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbWTEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbWTEnd.FormattingEnabled = true;
            this.cbbWTEnd.IntegralHeight = false;
            this.cbbWTEnd.ItemHeight = 43;
            this.cbbWTEnd.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbbWTEnd.Location = new System.Drawing.Point(374, 304);
            this.cbbWTEnd.MaxDropDownItems = 4;
            this.cbbWTEnd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbbWTEnd.Name = "cbbWTEnd";
            this.cbbWTEnd.Size = new System.Drawing.Size(154, 49);
            this.cbbWTEnd.StartIndex = 0;
            this.cbbWTEnd.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(334, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 72;
            this.label1.Text = "to";
            // 
            // cbbWTB
            // 
            this.cbbWTB.AutoResize = false;
            this.cbbWTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbWTB.Depth = 0;
            this.cbbWTB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbWTB.DropDownHeight = 174;
            this.cbbWTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWTB.DropDownWidth = 121;
            this.cbbWTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbWTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbWTB.FormattingEnabled = true;
            this.cbbWTB.IntegralHeight = false;
            this.cbbWTB.ItemHeight = 43;
            this.cbbWTB.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbbWTB.Location = new System.Drawing.Point(171, 305);
            this.cbbWTB.MaxDropDownItems = 4;
            this.cbbWTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbbWTB.Name = "cbbWTB";
            this.cbbWTB.Size = new System.Drawing.Size(154, 49);
            this.cbbWTB.StartIndex = 0;
            this.cbbWTB.TabIndex = 71;
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWorkingTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWorkingTime.Location = new System.Drawing.Point(27, 316);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(138, 28);
            this.lblWorkingTime.TabIndex = 69;
            this.lblWorkingTime.Text = "Working Time:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.ptbAvatar);
            this.panel1.Location = new System.Drawing.Point(768, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 266);
            this.panel1.TabIndex = 64;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.ptbAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbAvatar.ErrorImage")));
            this.ptbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("ptbAvatar.Image")));
            this.ptbAvatar.Location = new System.Drawing.Point(4, 11);
            this.ptbAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(209, 247);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 8;
            this.ptbAvatar.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AllowPromptAsInput = true;
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.AsciiOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.BeepOnError = false;
            this.txtEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HidePromptOnLeave = false;
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "Email";
            this.txtEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(27, 160);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Mask = "";
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.PromptChar = '_';
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RejectInputOnFirstFailure = false;
            this.txtEmail.ResetOnPrompt = true;
            this.txtEmail.ResetOnSpace = true;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(298, 48);
            this.txtEmail.SkipLiterals = true;
            this.txtEmail.TabIndex = 63;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.ValidatingType = null;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AllowPromptAsInput = true;
            this.txtPhoneNumber.AnimateReadOnly = false;
            this.txtPhoneNumber.AsciiOnly = false;
            this.txtPhoneNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPhoneNumber.BeepOnError = false;
            this.txtPhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.HidePromptOnLeave = false;
            this.txtPhoneNumber.HideSelection = true;
            this.txtPhoneNumber.Hint = "Phone Number";
            this.txtPhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPhoneNumber.LeadingIcon = null;
            this.txtPhoneNumber.Location = new System.Drawing.Point(27, 90);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Mask = "";
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PrefixSuffixText = null;
            this.txtPhoneNumber.PromptChar = '_';
            this.txtPhoneNumber.ReadOnly = false;
            this.txtPhoneNumber.RejectInputOnFirstFailure = false;
            this.txtPhoneNumber.ResetOnPrompt = true;
            this.txtPhoneNumber.ResetOnSpace = true;
            this.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(298, 48);
            this.txtPhoneNumber.SkipLiterals = true;
            this.txtPhoneNumber.TabIndex = 62;
            this.txtPhoneNumber.TabStop = false;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhoneNumber.TrailingIcon = null;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
            this.txtPhoneNumber.ValidatingType = null;
            // 
            // txtAddress
            // 
            this.txtAddress.AllowPromptAsInput = true;
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.AsciiOnly = false;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.BeepOnError = false;
            this.txtAddress.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.HidePromptOnLeave = false;
            this.txtAddress.HideSelection = true;
            this.txtAddress.Hint = "Address";
            this.txtAddress.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtAddress.LeadingIcon = null;
            this.txtAddress.Location = new System.Drawing.Point(374, 22);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Mask = "";
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PrefixSuffixText = null;
            this.txtAddress.PromptChar = '_';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.RejectInputOnFirstFailure = false;
            this.txtAddress.ResetOnPrompt = true;
            this.txtAddress.ResetOnSpace = true;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(298, 48);
            this.txtAddress.SkipLiterals = true;
            this.txtAddress.TabIndex = 61;
            this.txtAddress.TabStop = false;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddress.TrailingIcon = null;
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.ValidatingType = null;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AllowPromptAsInput = true;
            this.txtCompanyName.AnimateReadOnly = false;
            this.txtCompanyName.AsciiOnly = false;
            this.txtCompanyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCompanyName.BeepOnError = false;
            this.txtCompanyName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanyName.Depth = 0;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompanyName.HidePromptOnLeave = false;
            this.txtCompanyName.HideSelection = true;
            this.txtCompanyName.Hint = "Company Name";
            this.txtCompanyName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCompanyName.LeadingIcon = null;
            this.txtCompanyName.Location = new System.Drawing.Point(27, 22);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Mask = "";
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.PrefixSuffixText = null;
            this.txtCompanyName.PromptChar = '_';
            this.txtCompanyName.ReadOnly = false;
            this.txtCompanyName.RejectInputOnFirstFailure = false;
            this.txtCompanyName.ResetOnPrompt = true;
            this.txtCompanyName.ResetOnSpace = true;
            this.txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.SelectionLength = 0;
            this.txtCompanyName.SelectionStart = 0;
            this.txtCompanyName.ShortcutsEnabled = true;
            this.txtCompanyName.Size = new System.Drawing.Size(298, 48);
            this.txtCompanyName.SkipLiterals = true;
            this.txtCompanyName.TabIndex = 60;
            this.txtCompanyName.TabStop = false;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompanyName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanyName.TrailingIcon = null;
            this.txtCompanyName.UseSystemPasswordChar = false;
            this.txtCompanyName.ValidatingType = null;
            // 
            // txtDetail
            // 
            this.txtDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtDetail.Hint = "Details";
            this.txtDetail.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtDetail.Location = new System.Drawing.Point(27, 374);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDetail.MaxLength = 32767;
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.PasswordChar = '\0';
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetail.SelectedText = "";
            this.txtDetail.SelectionLength = 0;
            this.txtDetail.SelectionStart = 0;
            this.txtDetail.Size = new System.Drawing.Size(946, 174);
            this.txtDetail.TabIndex = 59;
            this.txtDetail.TabStop = false;
            this.txtDetail.Text = "Details";
            this.txtDetail.UseSystemPasswordChar = false;
            // 
            // FCompanyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.cbbCompanySize);
            this.Controls.Add(this.cbbCompanyType);
            this.Controls.Add(this.txtWebsiteLink);
            this.Controls.Add(this.cbbWTEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbWTB);
            this.Controls.Add(this.lblWorkingTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtDetail);
            this.Name = "FCompanyDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCompanyDetail";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cbbCompanySize;
        private ReaLTaiizor.Controls.MaterialComboBox cbbCompanyType;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtWebsiteLink;
        private ReaLTaiizor.Controls.MaterialComboBox cbbWTEnd;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialComboBox cbbWTB;
        private Label lblWorkingTime;
        private Panel panel1;
        private PictureBox ptbAvatar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEmail;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPhoneNumber;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAddress;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCompanyName;
        private ReaLTaiizor.Controls.HopeRichTextBox txtDetail;
    }
}