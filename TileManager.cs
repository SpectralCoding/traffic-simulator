using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrafficSim {
	public static class TileManager {
        private static List<Tile> m_Tiles;

		/// <summary>
		/// Loads Tiles from Sprite Sheet
		/// </summary>
		/// <returns>Integer denoting how many Tiles were loaded</returns>
        public static int LoadTiles() {
			string tileMapFile = @"E:\Programming\C#\100917 TrafficSim\Sprites\SpriteSheet 0-5.png";
            m_Tiles = new List<Tile>();
			for (int y = 0; y < 2; y++) {
				for (int x = 0; x < 5; x++) {
                    m_Tiles.Add( Tile.FromTilemap( tileMapFile, x, y ));
                }
            }
            return m_Tiles.Count;
        }

		/// <summary>
		/// Returns a tile from the TileManager's list of Tiles
		/// </summary>
		/// <param name="index">Tile to return</param>
		/// <returns>Tile from list of Tiles</returns>
        public static Tile GetTile(int index) {
            return m_Tiles[index];
        }

	}
}
