using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public class RoundButton : Button
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottonRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ClientSize.Width, ClientSize.Height, 15, 15));
            base.OnPaint(e);
        }
    }

}