using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DesktopLiveStreamer
{
    public sealed class ImageDropDownList : ComboBox
    {
        public ImageDropDownList()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();

            e.DrawFocusRectangle();

            if (e.Index >= 0 && e.Index < Items.Count)
            {
                DropDownItem item = (DropDownItem)Items[e.Index];

                if (item.Image != null)
                {
                    e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);
                    e.Graphics.DrawString(item.Value, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + item.Image.Width + 5, e.Bounds.Top + 2);
                }
                else
                    e.Graphics.DrawString(item.Value, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left, e.Bounds.Top + 2);

                
            }

            base.OnDrawItem(e);
        }
    }

    public sealed class DropDownItem
    {
        public string Value { get; set; }

        public Image Image { get; set; }

        public DropDownItem()
            : this("")
        { }

        public DropDownItem(string val)
        {
            Value = val;
            Image = new Bitmap(16, 16);
        }

        public DropDownItem(string val, Image img)
        {
            Value = val;
            Image = img;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
