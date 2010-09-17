using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SdlDotNet.Graphics;
using SdlDotNet.Core;
using System.Drawing;
namespace TrafficSim {
	public class Tile {
        private Surface m_Surface;
        private static Surface m_Tilemap = null;

		public Tile(Surface surf) {
            m_Surface = surf;
        }
        public Surface Surface {
            get { return m_Surface; }
        }
        public Size Size {
            get { return new Size( m_Surface.Width, m_Surface.Height ); }
        }

		/// <summary>
		/// Actually reads the tiles from the file and returns the Tile at that location.
		/// </summary>
		/// <param name="fileName">File containing the Sprite Sheet</param>
		/// <param name="x">X Coordinate of the Tile (Unit: Tiles)</param>
		/// <param name="y">Y Coordinate of the Tile (Unit: Tiles)</param>
		/// <returns>Tile from fileName at X, Y</returns>
        public static Tile FromTilemap(string fileName, int x, int y) {
			if (m_Tilemap == null) { m_Tilemap = new Surface(fileName); }
            
            Surface tile = new Surface( 25, 25 );

            int offsetX = ( x * 25 ); // X offset into Tilemap
            int offsetY = ( y * 25 ); // Y offset into Tilemap

			tile.Blit(m_Tilemap, new Point(0, 0), new Rectangle(offsetX, offsetY, 25, 25));

            return new Tile( tile );
        }

	}
}
