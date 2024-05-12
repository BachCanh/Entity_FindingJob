using System.Windows.Forms;
using System.Drawing;
namespace Entity
{
    partial class FFilter
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.btnReset = new ReaLTaiizor.Controls.ParrotButton();
            this.btnApply = new ReaLTaiizor.Controls.ParrotButton();
            this.pnBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemote = new System.Windows.Forms.Button();
            this.btnAtOffice = new System.Windows.Forms.Button();
            this.btnHybrid = new System.Windows.Forms.Button();
            this.pnType = new System.Windows.Forms.Panel();
            this.btnHeadHunter = new System.Windows.Forms.Button();
            this.btnOutsource = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnNonIT = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.pnLevel = new System.Windows.Forms.Panel();
            this.btnJunior = new System.Windows.Forms.Button();
            this.btnFresher = new System.Windows.Forms.Button();
            this.btnSenior = new System.Windows.Forms.Button();
            this.btnIntern = new System.Windows.Forms.Button();
            this.tbFrom = new System.Windows.Forms.TrackBar();
            this.lblSalaryRange = new System.Windows.Forms.Label();
            this.lblWorkForm = new System.Windows.Forms.Label();
            this.lblTypeCompany = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TrackBar();
            this.pnHeader.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnType.SuspendLayout();
            this.pnLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHeader.Controls.Add(this.lblFilter);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(898, 102);
            this.pnHeader.TabIndex = 0;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilter.Location = new System.Drawing.Point(32, 28);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(92, 41);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter";
            // 
            // pnFooter
            // 
            this.pnFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFooter.Controls.Add(this.btnReset);
            this.pnFooter.Controls.Add(this.btnApply);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 830);
            this.pnFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(898, 90);
            this.pnFooter.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnReset.ButtonImage = null;
            this.btnReset.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnReset.ButtonText = "Reset";
            this.btnReset.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnReset.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.CornerRadius = 5;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReset.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.btnReset.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.btnReset.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnReset.Location = new System.Drawing.Point(38, 31);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 33);
            this.btnReset.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnReset.TabIndex = 36;
            this.btnReset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(46)))), ((int)(((byte)(237)))));
            this.btnReset.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnReset.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.btnApply.ButtonImage = null;
            this.btnApply.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnApply.ButtonText = "Apply";
            this.btnApply.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(180)))));
            this.btnApply.ClickTextColor = System.Drawing.Color.Black;
            this.btnApply.CornerRadius = 6;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApply.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnApply.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(197)))));
            this.btnApply.HoverTextColor = System.Drawing.Color.Black;
            this.btnApply.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnApply.Location = new System.Drawing.Point(701, 20);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(150, 51);
            this.btnApply.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnApply.TabIndex = 35;
            this.btnApply.TextColor = System.Drawing.Color.Black;
            this.btnApply.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnApply.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pnBody
            // 
            this.pnBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBody.Controls.Add(this.panel1);
            this.pnBody.Controls.Add(this.pnType);
            this.pnBody.Controls.Add(this.pnLevel);
            this.pnBody.Controls.Add(this.tbFrom);
            this.pnBody.Controls.Add(this.lblSalaryRange);
            this.pnBody.Controls.Add(this.lblWorkForm);
            this.pnBody.Controls.Add(this.lblTypeCompany);
            this.pnBody.Controls.Add(this.lblSalary);
            this.pnBody.Controls.Add(this.lblLevel);
            this.pnBody.Controls.Add(this.tbTo);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 102);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(898, 728);
            this.pnBody.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemote);
            this.panel1.Controls.Add(this.btnAtOffice);
            this.panel1.Controls.Add(this.btnHybrid);
            this.panel1.Location = new System.Drawing.Point(33, 581);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 107);
            this.panel1.TabIndex = 41;
            // 
            // btnRemote
            // 
            this.btnRemote.BackColor = System.Drawing.Color.Transparent;
            this.btnRemote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemote.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemote.Image = global::Entity.Properties.Resources.plus;
            this.btnRemote.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemote.Location = new System.Drawing.Point(182, 23);
            this.btnRemote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemote.Name = "btnRemote";
            this.btnRemote.Size = new System.Drawing.Size(126, 51);
            this.btnRemote.TabIndex = 36;
            this.btnRemote.Text = "Remote";
            this.btnRemote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemote.UseVisualStyleBackColor = false;
            // 
            // btnAtOffice
            // 
            this.btnAtOffice.BackColor = System.Drawing.Color.Transparent;
            this.btnAtOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtOffice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtOffice.Image = global::Entity.Properties.Resources.plus;
            this.btnAtOffice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtOffice.Location = new System.Drawing.Point(3, 23);
            this.btnAtOffice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtOffice.Name = "btnAtOffice";
            this.btnAtOffice.Size = new System.Drawing.Size(131, 51);
            this.btnAtOffice.TabIndex = 36;
            this.btnAtOffice.Text = "At office";
            this.btnAtOffice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtOffice.UseVisualStyleBackColor = false;
            // 
            // btnHybrid
            // 
            this.btnHybrid.BackColor = System.Drawing.Color.Transparent;
            this.btnHybrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHybrid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHybrid.Image = global::Entity.Properties.Resources.plus;
            this.btnHybrid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHybrid.Location = new System.Drawing.Point(354, 23);
            this.btnHybrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHybrid.Name = "btnHybrid";
            this.btnHybrid.Size = new System.Drawing.Size(115, 51);
            this.btnHybrid.TabIndex = 36;
            this.btnHybrid.Text = "Hybrid";
            this.btnHybrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHybrid.UseVisualStyleBackColor = false;
            // 
            // pnType
            // 
            this.pnType.Controls.Add(this.btnHeadHunter);
            this.pnType.Controls.Add(this.btnOutsource);
            this.pnType.Controls.Add(this.btnProduct);
            this.pnType.Controls.Add(this.btnNonIT);
            this.pnType.Controls.Add(this.btnServices);
            this.pnType.Location = new System.Drawing.Point(32, 361);
            this.pnType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnType.Name = "pnType";
            this.pnType.Size = new System.Drawing.Size(747, 164);
            this.pnType.TabIndex = 40;
            // 
            // btnHeadHunter
            // 
            this.btnHeadHunter.BackColor = System.Drawing.Color.Transparent;
            this.btnHeadHunter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeadHunter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHeadHunter.Image = global::Entity.Properties.Resources.plus;
            this.btnHeadHunter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHeadHunter.Location = new System.Drawing.Point(368, 4);
            this.btnHeadHunter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHeadHunter.Name = "btnHeadHunter";
            this.btnHeadHunter.Size = new System.Drawing.Size(167, 51);
            this.btnHeadHunter.TabIndex = 36;
            this.btnHeadHunter.Text = "HeadHunter";
            this.btnHeadHunter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeadHunter.UseVisualStyleBackColor = false;
            // 
            // btnOutsource
            // 
            this.btnOutsource.BackColor = System.Drawing.Color.Transparent;
            this.btnOutsource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutsource.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOutsource.Image = global::Entity.Properties.Resources.plus;
            this.btnOutsource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOutsource.Location = new System.Drawing.Point(5, 4);
            this.btnOutsource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOutsource.Name = "btnOutsource";
            this.btnOutsource.Size = new System.Drawing.Size(153, 51);
            this.btnOutsource.TabIndex = 36;
            this.btnOutsource.Text = "Outsource";
            this.btnOutsource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutsource.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduct.Image = global::Entity.Properties.Resources.plus;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.Location = new System.Drawing.Point(197, 4);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(127, 51);
            this.btnProduct.TabIndex = 36;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnNonIT
            // 
            this.btnNonIT.BackColor = System.Drawing.Color.Transparent;
            this.btnNonIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonIT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNonIT.Image = global::Entity.Properties.Resources.plus;
            this.btnNonIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNonIT.Location = new System.Drawing.Point(577, 4);
            this.btnNonIT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNonIT.Name = "btnNonIT";
            this.btnNonIT.Size = new System.Drawing.Size(138, 51);
            this.btnNonIT.TabIndex = 36;
            this.btnNonIT.Text = "Non - IT";
            this.btnNonIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNonIT.UseVisualStyleBackColor = false;
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.Transparent;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnServices.Image = global::Entity.Properties.Resources.plus;
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServices.Location = new System.Drawing.Point(5, 91);
            this.btnServices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(378, 51);
            this.btnServices.TabIndex = 36;
            this.btnServices.Text = "Services and Consulting solutions";
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.UseVisualStyleBackColor = false;
            // 
            // pnLevel
            // 
            this.pnLevel.Controls.Add(this.btnJunior);
            this.pnLevel.Controls.Add(this.btnFresher);
            this.pnLevel.Controls.Add(this.btnSenior);
            this.pnLevel.Controls.Add(this.btnIntern);
            this.pnLevel.Location = new System.Drawing.Point(33, 80);
            this.pnLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnLevel.Name = "pnLevel";
            this.pnLevel.Size = new System.Drawing.Size(711, 96);
            this.pnLevel.TabIndex = 40;
            // 
            // btnJunior
            // 
            this.btnJunior.BackColor = System.Drawing.Color.Transparent;
            this.btnJunior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJunior.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJunior.Image = global::Entity.Properties.Resources.plus;
            this.btnJunior.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJunior.Location = new System.Drawing.Point(167, 21);
            this.btnJunior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJunior.Name = "btnJunior";
            this.btnJunior.Size = new System.Drawing.Size(112, 51);
            this.btnJunior.TabIndex = 36;
            this.btnJunior.Text = "Junior";
            this.btnJunior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJunior.UseVisualStyleBackColor = false;
            // 
            // btnFresher
            // 
            this.btnFresher.BackColor = System.Drawing.Color.Transparent;
            this.btnFresher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFresher.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFresher.Image = global::Entity.Properties.Resources.plus;
            this.btnFresher.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFresher.Location = new System.Drawing.Point(3, 21);
            this.btnFresher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFresher.Name = "btnFresher";
            this.btnFresher.Size = new System.Drawing.Size(123, 51);
            this.btnFresher.TabIndex = 36;
            this.btnFresher.Text = "Fresher";
            this.btnFresher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFresher.UseVisualStyleBackColor = false;
            // 
            // btnSenior
            // 
            this.btnSenior.BackColor = System.Drawing.Color.Transparent;
            this.btnSenior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenior.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSenior.Image = global::Entity.Properties.Resources.plus;
            this.btnSenior.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSenior.Location = new System.Drawing.Point(320, 21);
            this.btnSenior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSenior.Name = "btnSenior";
            this.btnSenior.Size = new System.Drawing.Size(115, 51);
            this.btnSenior.TabIndex = 36;
            this.btnSenior.Text = "Senior";
            this.btnSenior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenior.UseVisualStyleBackColor = false;
            // 
            // btnIntern
            // 
            this.btnIntern.BackColor = System.Drawing.Color.Transparent;
            this.btnIntern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntern.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIntern.Image = global::Entity.Properties.Resources.plus;
            this.btnIntern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIntern.Location = new System.Drawing.Point(483, 21);
            this.btnIntern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIntern.Name = "btnIntern";
            this.btnIntern.Size = new System.Drawing.Size(103, 51);
            this.btnIntern.TabIndex = 36;
            this.btnIntern.Text = "Intern";
            this.btnIntern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntern.UseVisualStyleBackColor = false;
            // 
            // tbFrom
            // 
            this.tbFrom.LargeChange = 100;
            this.tbFrom.Location = new System.Drawing.Point(254, 232);
            this.tbFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(249, 56);
            this.tbFrom.TabIndex = 39;
            this.tbFrom.TickFrequency = 2;
            // 
            // lblSalaryRange
            // 
            this.lblSalaryRange.AutoSize = true;
            this.lblSalaryRange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalaryRange.Location = new System.Drawing.Point(33, 235);
            this.lblSalaryRange.Name = "lblSalaryRange";
            this.lblSalaryRange.Size = new System.Drawing.Size(144, 28);
            this.lblSalaryRange.TabIndex = 1;
            this.lblSalaryRange.Text = "$500 - $10,000";
            // 
            // lblWorkForm
            // 
            this.lblWorkForm.AutoSize = true;
            this.lblWorkForm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWorkForm.Location = new System.Drawing.Point(32, 544);
            this.lblWorkForm.Name = "lblWorkForm";
            this.lblWorkForm.Size = new System.Drawing.Size(169, 32);
            this.lblWorkForm.TabIndex = 1;
            this.lblWorkForm.Text = "Working Form";
            // 
            // lblTypeCompany
            // 
            this.lblTypeCompany.AutoSize = true;
            this.lblTypeCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTypeCompany.Location = new System.Drawing.Point(33, 309);
            this.lblTypeCompany.Name = "lblTypeCompany";
            this.lblTypeCompany.Size = new System.Drawing.Size(175, 32);
            this.lblTypeCompany.TabIndex = 1;
            this.lblTypeCompany.Text = "Type Company";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalary.Location = new System.Drawing.Point(33, 180);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(81, 32);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salary";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.Location = new System.Drawing.Point(33, 39);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(70, 32);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Level";
            // 
            // tbTo
            // 
            this.tbTo.LargeChange = 100;
            this.tbTo.Location = new System.Drawing.Point(495, 232);
            this.tbTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(249, 56);
            this.tbTo.TabIndex = 39;
            this.tbTo.TickFrequency = 2;
            this.tbTo.Value = 10;
            // 
            // FFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(898, 920);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFilter";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnFooter.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnType.ResumeLayout(false);
            this.pnLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnHeader;
        private Label lblFilter;
        private Panel pnFooter;
        private Panel pnBody;
        private ReaLTaiizor.Controls.AirButton airButton1;
        public ReaLTaiizor.Controls.ParrotButton btnApply;
        private Label lblWorkForm;
        private Label lblTypeCompany;
        private Label lblSalary;
        private Label lblLevel;
        private Button btnFresher;
        private Button btnIntern;
        private Button btnSenior;
        private Button btnJunior;
        private TrackBar tbFrom;
        private TrackBar tbTo;
        private Label lblSalaryRange;
        private Button btnNonIT;
        private Button btnHeadHunter;
        private Button btnProduct;
        private Button btnOutsource;
        private Button btnServices;
        private Button btnHybrid;
        private Button btnRemote;
        private Button btnAtOffice;
        private Panel pnType;
        private Panel pnLevel;
        private Panel panel1;
        public ReaLTaiizor.Controls.ParrotButton btnReset;
    }
}