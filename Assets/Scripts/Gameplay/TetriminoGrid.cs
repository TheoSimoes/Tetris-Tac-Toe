using System;
using UnityEngine;
using UnityEngine.Tilemaps;
using Utils;

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

/*        [ContextMenu("Generate TetriminoGrid")]
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
        }*/

        [ContextMenu("Generate Tetrimino")]
        public void ColorGrid()
        {
            Cave cave = new Cave(width, height);
            _groundTilemap.ClearAllTiles();

            Tetrimino tetrimino = Tetrimino.GetRandomTetrimino();
            Debug.Log(string.Format(tetrimino.Name));
            TileBase ground = _groundTiles[0];
            switch (tetrimino.Name)
            {
                case "Square":
                    ground = _groundTiles[1];
                    break;
                case "Line":
                    ground = _groundTiles[2];
                    break;
                case "T":
                    ground = _groundTiles[3];
                    break;
                case "Z":
                    ground = _groundTiles[4];
                    break;
                case "S":
                    ground = _groundTiles[5];
                    break;
                case "L":
                    ground = _groundTiles[6];
                    break;
                case "J":
                    ground = _groundTiles[7];
                    break;
            }
            foreach (var cell in cave.Grid.Cells)
            {

                _groundTilemap.SetTile(new Vector3Int(cell.X, cell.Y, 0), ground);
            }
        }
    }
}