using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class BtnSkillShow : Guna2Button
    {
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        
        public BtnSkillShow()
        {
            BackColor = Color.Transparent;
            AutoSize = true;
            BorderRadius = 10;
            Cursor = Cursors.Hand;
            CustomizableEdges = customizableEdges;
            DisabledState.BorderColor = Color.DarkGray;
            DisabledState.CustomBorderColor = Color.DarkGray;
            DisabledState.FillColor = Color.FromArgb(248, 212, 187);
            DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            FillColor = Color.FromArgb(248, 212, 187);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(64, 64, 64);
            Location = new Point(46, 72);
            Margin = new Padding(3, 3, 3, 15);
            Name = "guna2Button2";
            ShadowDecoration.BorderRadius = 10;
            ShadowDecoration.CustomizableEdges = customizableEdges;
            ShadowDecoration.Depth = 10;
            ShadowDecoration.Enabled = true;
            TabIndex = 4;
            Text = "guna2Button1";
            TextAlign = HorizontalAlignment.Left;

        }

    }
}
