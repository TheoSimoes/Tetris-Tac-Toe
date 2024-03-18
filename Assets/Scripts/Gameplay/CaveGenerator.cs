using UnityEngine;
using UnityEngine.Tilemaps;

namespace Gameplay
{

    public class CaveGenerator : MonoBehaviour
    {
        //initialise le sol de base
        [SerializeField]
        private Tilemap _groundTilemap;

        [SerializeField]
        private TileBase[] _groundTiles;

        [SerializeField]
        private int _maxWidth;
        
        [SerializeField]
        private int _maxHeight;

        [ContextMenu("Generate Cave")]
        public void Generate(){
            var cave = new Cave(_maxWidth, _maxHeight);
            _groundTilemap.ClearAllTiles();
            //populate
            foreach (var cell in cave.Grid.Cells)
            {
                var randomGround = _groundTiles[Random.Range(0, _groundTiles.Length)];
                _groundTilemap.SetTile(new Vector3Int(cell.X, cell.Y, 0),randomGround);
            }
        }
    }
    
}