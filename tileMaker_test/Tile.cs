using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace tileMaker_test
{
    public class Tile
    {
        public Tile()
        {
            m_selected = false;
            m_rgb = new float[3];
        }

        private int m_width;
        public int Width
        {
            get
            {
                return m_width;
            }
            set
            {
                m_width = value;
            }
        }

        private int m_height;
        public int Height
        {
            get
            {
                return m_height;
            }
            set
            {
                m_height = value;
            }
        }

        private Bitmap m_tileImage;
        public Bitmap TileImage
        {
            get
            {
                if(m_selected)
                {
                    return refresh();
                }
                return m_tileImage;
            }
            set
            {
                m_tileImage = value;
            }
        }

        private int m_id;
        public int Id
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        private Point m_position;
        public Point Position
        {
            get
            {
                return m_position;
            }
            set
            {
                m_position = value;
            }
        }

        private bool m_selected;
        public bool Selected
        {
            get
            {
                return m_selected;
            }
        }

        private float[] m_rgb;
        public float[] RGB
        {
            get
            {
                return m_rgb;
            }
            set
            {
                m_rgb = value;
            }
        }

        public void select()
        {
            if(m_selected)
            {
                m_selected = false;
            }
            else
            {
                m_selected = true;
                
            }
        }

        private Bitmap refresh()
        {
            Bitmap img_ = new Bitmap(m_width, m_height);
            var g = Graphics.FromImage(img_);
            
            g.DrawImage(m_tileImage, new Rectangle(0, 0, m_width, m_height), new Rectangle(0, 0, m_width, m_height), GraphicsUnit.Pixel);

            Pen pen = new Pen(Color.Gold, 4);
            pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            g.DrawRectangle(pen, new Rectangle(0, 0, m_width, m_height));

            return img_;
        }
    }
}
