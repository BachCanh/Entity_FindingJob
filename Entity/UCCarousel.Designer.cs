using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    partial class UCCarousel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCarousel));
            btnRightArrow = new Button();
            btnLeftArrow = new Button();
            SuspendLayout();
            // 
            // btnRightArrow
            // 
            btnRightArrow.BackColor = Color.Transparent;
            btnRightArrow.Dock = DockStyle.Right;
            btnRightArrow.FlatAppearance.BorderSize = 0;
            btnRightArrow.FlatStyle = FlatStyle.Flat;
            btnRightArrow.Image = (Image)resources.GetObject("btnRightArrow.Image");
            btnRightArrow.Location = new Point(713, 0);
            btnRightArrow.Name = "btnRightArrow";
            btnRightArrow.Size = new Size(94, 252);
            btnRightArrow.TabIndex = 1;
            btnRightArrow.UseVisualStyleBackColor = false;
            btnRightArrow.Click += btnRightArrow_Click;
            // 
            // btnLeftArrow
            // 
            btnLeftArrow.BackColor = Color.Transparent;
            btnLeftArrow.Dock = DockStyle.Left;
            btnLeftArrow.FlatAppearance.BorderSize = 0;
            btnLeftArrow.FlatStyle = FlatStyle.Flat;
            btnLeftArrow.Image = (Image)resources.GetObject("btnLeftArrow.Image");
            btnLeftArrow.Location = new Point(0, 0);
            btnLeftArrow.Name = "btnLeftArrow";
            btnLeftArrow.Size = new Size(94, 252);
            btnLeftArrow.TabIndex = 2;
            btnLeftArrow.UseVisualStyleBackColor = false;
            btnLeftArrow.Click += btnLeftArrow_Click;
            // 
            // UCCarousel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnLeftArrow);
            Controls.Add(btnRightArrow);
            Name = "UCCarousel";
            Size = new Size(807, 252);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRightArrow;
        private Button btnLeftArrow;
    }
}
