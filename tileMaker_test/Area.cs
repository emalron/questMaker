using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tileMaker_test
{
    public class Area
    {
        public Area(List<Tile> tiles, string name, string desc)
        {
            this.m_tiles = tiles;
            this.m_name = name;
            this.m_description = desc;
        }

        private List<Tile> m_tiles;
        private string m_name, m_description;

        public List<Tile> Tiles
        {
            get
            {
                return m_tiles;
            }
            set
            {
                m_tiles = value;
            }
        }

        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        public string Description
        {
            get
            {
                return m_description;
            }
            set
            {
                m_description = value;
            }
        }
    }
}
