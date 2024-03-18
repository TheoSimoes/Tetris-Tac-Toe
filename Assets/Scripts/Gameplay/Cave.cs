using Utils;


namespace Gameplay
{

    public class Cave
    {
        private readonly int _maxWidth;
        private readonly int _maxHeight;

        public Grid<GridCell<bool>> Grid { get; }

        public Cave(int maxWidth, int maxHeight)
        {
            _maxWidth = maxWidth;
            _maxHeight = maxHeight;
            Grid = new Grid<GridCell<bool>>(maxWidth, maxHeight, InitializeCaveCell);
        }

        private GridCell<bool> InitializeCaveCell(int x, int y)
        {
            return new GridCell<bool>(x,y, true);
        }
    }
}