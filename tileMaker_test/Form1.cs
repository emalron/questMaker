using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tileMaker_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            init();
        }

        Bitmap m_map;
        List<Tile> m_tiles;
        List<Tile> m_selectedTiles;
        List<Area> m_areas;

        void init()
        {
            m_selectedTiles = new List<Tile>();
            m_areas = new List<Area>();

            listBoxAreas.DataSource = m_areas;
            listBoxAreas.DisplayMember = "Name";

            listBoxTiles.DataSource = m_selectedTiles;
            listBoxTiles.DisplayMember = "Id";
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Bitmap files (*.bmp)|*.bmp";

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    m_map = new Bitmap(ofd.FileName);
                }
            }
        }

        void showMap(Bitmap map)
        {
            Bitmap map_ = map;

            PictureBox pb = pictureBox1;
            Controls.Add(pb);
            pb.Image = map_;
            // pb.Size = map_.Size;
        }

        void showMap(List<Tile> tiles)
        {
            Tile last = tiles.Last();
            Bitmap map_ = new Bitmap(last.Width * (last.Position.X+1), last.Height * (last.Position.Y+1));
            var g = Graphics.FromImage(map_);

            foreach (Tile t in tiles)
            {
                int w_ = t.Width;
                int h_ = t.Height;
                int x_ = t.Position.X;
                int y_ = t.Position.Y;

                g.DrawImage(t.TileImage, x_ * w_, y_ * h_);
            }

            PictureBox pb = pictureBox1;

            pb.Image = map_;
            // pb.Size = map_.Size;
        }

        bool sliceMap(Bitmap map, int resolution, ref List<Tile> output)
        {
            Bitmap map_ = map;
            int mapWidth_ = map_.Width;
            int mapHeight_ = map_.Height;

            int res_ = resolution;
            int unitWidth_ = mapWidth_ / res_;
            int unitHeight_ = mapHeight_ / res_;

            bool isValidUnitSize = unitWidth_ > 0 && unitHeight_ > 0;
            if (!isValidUnitSize) return false;

            int unitLength_ = Math.Min(unitWidth_, unitHeight_);

            int numWidth = mapWidth_ / unitLength_;
            int numHeigth = mapHeight_ / unitLength_;

            for (int j = 0; j < numHeigth; j++)
            {
                for (int i = 0; i < numWidth; i++)
                {
                    Tile tile_ = new Tile();

                    tile_.Id = i + numWidth * j;

                    tile_.Position = new Point(i, j);

                    tile_.Width = unitLength_;
                    tile_.Height = unitLength_;

                    tile_.TileImage = sliceImage(map_, i, j, unitLength_);

                    output.Add(tile_);
                }
            }

            return true;
        }

        Bitmap sliceImage(Bitmap map, int x, int y, int width, int height)
        {
            int w_ = width;
            int h_ = height;
            Bitmap output = new Bitmap(w_, h_);

            var g = Graphics.FromImage(output);

            g.DrawImage(map, new Rectangle(0, 0, w_, h_), new Rectangle(x * w_, y * h_, w_, h_), GraphicsUnit.Pixel);

            for(int i=0;i<w_;i++)
            {
                output.SetPixel(i, 0, Color.Red);
                output.SetPixel(i, h_ - 1, Color.Red);
            }
            for (int j = 0; j < h_; j++)
            {
                output.SetPixel(0, j, Color.Red);
                output.SetPixel(w_ - 1, j, Color.Red);
            }

            return output;
        }

        Bitmap sliceImage(Bitmap map, int x, int y, int length)
        {
            int w_ = length;

            Bitmap output = new Bitmap(w_, w_);

            var g = Graphics.FromImage(output);

            g.DrawImage(map, new Rectangle(0, 0, w_, w_), new Rectangle(x * w_, y * w_, w_, w_), GraphicsUnit.Pixel);

            for (int i = 0; i < w_; i++)
            {
                output.SetPixel(i, 0, Color.Black);
                output.SetPixel(i, w_ - 1, Color.Black);
            }
            for (int j = 0; j < w_; j++)
            {
                output.SetPixel(0, j, Color.Black);
                output.SetPixel(w_ - 1, j, Color.Black);
            }

            return output;
        }

        private void btnTileMake_Click(object sender, EventArgs e)
        {
            m_tiles = new List<Tile>();
            int res_ = Convert.ToInt32(numericResolution.Value);

            if(sliceMap(m_map, res_, ref m_tiles))
            {
                label2.Text = "성공";

                showMap(m_tiles);
            }
            else
            {
                label2.Text = "실패";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs e_ = e as MouseEventArgs;
            int x_ = e_.X;
            int y_ = e_.Y;

            bool areTilesExist = m_tiles != null;
            if (areTilesExist)
            {
                int w_ = m_tiles[0].Width;
                int h_ = m_tiles[0].Height;

                int pX_ = x_ / w_;
                int pY_ = y_ / h_;

                int clickedID = pX_ + (m_tiles.Last().Position.X+1) * pY_;

                string msg = String.Format("{0}, {1}, id: {2}", pX_, pY_, clickedID);
                label2.Text = msg;

                m_tiles[clickedID].select();

                showMap(m_tiles);

                updateSelctedTilesList();
            }
        }

        void updateSelctedTilesList()
        {
            List<Tile> output = new List<Tile>();

            foreach(Tile t in m_tiles)
            {
                if(t.Selected)
                {
                    output.Add(t);
                }
            }

            m_selectedTiles = output;
            updateListBox(listBoxTiles, m_selectedTiles, "Id");
        }

        void updateListBox<T>(Control c, List<T> list, string displayMember)
        {
            ListBox c_ = c as ListBox;

            c_.DataSource = null;
            c_.DataSource = list;
            c_.DisplayMember = displayMember;
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            if (tbAreaName.Text == String.Empty) return;
            if (tbAreaDesc.Text == String.Empty) return;
            if (listBoxTiles.Items.Count == 0) return;

            m_areas.Add(new Area(m_selectedTiles, tbAreaName.Text, tbAreaDesc.Text));
            updateListBox(listBoxAreas, m_areas, "Name");
        }

        private void listBoxAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Area area_ = listBoxAreas.SelectedItem as Area;

            tbAreaName.Text = area_.Name;
            tbAreaDesc.Text = area_.Description;

            foreach(Tile t in m_tiles)
            {
                if(t.Selected)
                {
                    t.select();
                }
            }
           
            foreach(Tile t in area_.Tiles)
            {
                m_tiles[t.Id].select();
            }
            

            showMap(m_tiles);
        }
    }
}
