using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Carvo.User_Interface_Layer.UIHelpers
{
    /// <summary>
    /// Class for Extra UI designs
    /// </summary>
    public static class UIHelper
    {
        /// <summary>
        /// Applies a rounded corner effect to the specified control.
        /// </summary>
        /// <remarks>This method modifies the <see cref="Control.Region"/> property of the specified
        /// control to create a rounded corner effect. The control's dimensions and the specified corner radius
        /// determine the curvature of the corners.</remarks>
        /// <param name="control">The <see cref="Control"/> to which the rounded corners will be applied.</param>
        /// <param name="cornerRadius">The radius of the corners, in pixels. Must be a non-negative value. The default is 15.</param>
        public static void MakeControlRounded(Control control, int cornerRadius = 15)
        {
            var path = new GraphicsPath();
            int arcSize = cornerRadius * 2;

            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(control.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(control.Width - arcSize, control.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, control.Height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseAllFigures();

            control.Region = new Region(path);
        }

        public static void SetupDataGridView(DataGridView dataGridView)
        {
           

            // جعل الأعمدة تمتد لعرض الجدول بالكامل
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // جعل الصفوف تأخذ ارتفاع المحتوى
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // إلغاء إضافة صف جديد تلقائي (السطر الفاضي تحت)
            dataGridView.AllowUserToAddRows = false;

            // منع تعديل الأعمدة مباشرة
            dataGridView.ReadOnly = true;

            // منع المستخدم من تعديل حجم الأعمدة والصفوف
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;

            // إلغاء الحدود
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView.GridColor = Color.White;

            // تنسيق رأس الجدول (الأعمدة)

            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        }

    }
}
