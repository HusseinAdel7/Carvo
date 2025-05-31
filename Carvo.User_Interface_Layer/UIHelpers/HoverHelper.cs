using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carvo.User_Interface_Layer.UIHelpers
{
    /// <summary>
    /// this class provides hover effects for buttons in a Windows Forms application.
    /// </summary>
    internal class HoverHelper
    {
        /// <summary>
        /// props for storing original button styles.
        /// </summary>
        public Color BackColor { get; set; }
        public  Color ForeColor { get; set; }
        public  Font Font { get; set; }

        public static void ApplyHoverToAllButtons(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button btn)
                {
                    // store original styles in the Tag property
                    btn.Tag = new HoverHelper()
                    {
                        BackColor = btn.BackColor,
                        ForeColor = btn.ForeColor,
                        Font = btn.Font
                    };

                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                }
                else if (control.HasChildren)
                {
                    ApplyHoverToAllButtons(control);
                }
            }
        }

        static void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightBlue;
            btn.ForeColor = Color.DarkBlue;
            btn.Font = new Font(btn.Font, FontStyle.Bold); 
        }

        private static void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag is HoverHelper original)
            {
                btn.BackColor = original.BackColor;
                btn.ForeColor = original.ForeColor;
                btn.Font = original.Font;
            }
        }

    }
}
