using UnityEngine;
using UnityEngine.Tilemaps;

namespace Gameplay
{

    public class TetriminoGrid : MonoBehaviour
    {

        private readonly int width = 4;
        private readonly int height = 4;
        [SerializeField]
        private Tilemap _groundTilemap;

        [SerializeField]
        private TileBase[] _groundTiles;

        [ContextMenu("Generate TetriminoGrid")]
        public void Generate()
        {
            var cave = new Cave(width, height);
            _groundTilemap.ClearAllTiles();
            //populate
            foreach (var cell in cave.Grid.Cells)
            {
                var ground = _groundTiles[0];
                _groundTilemap.SetTile(new Vector3Int(cell.X, cell.Y, 0), ground);
            }
        }
        [ContextMenu("Generate Tetrimino")]
        public void ColorGrid()
        {
            Debug.Log(string.Format(Tetrimino.GetRandomTetrimino().Name));

        }
    }
}