using System;
using System.Collections.Generic;
using System.Xml.Linq;

public class Tetrimino
{
    public string Name { get; set; }
    
    public int[] Shape { get; set; }

    public Tetrimino(string name, int[] shape)
    {
        Name = name;
        Shape = shape;
    }

    // 0 is empty, 1 is full, 2 is to jump line
    private static readonly List<Tetrimino> TetriminoList = new List<Tetrimino>
    {
        new("Square", new int[] {1, 1, 2, 1, 1}),
        new("Line", new int[] {1, 1, 1, 1}),
        new("T", new int[]  {1, 1, 1, 2, 0, 1, 0}),
        new("Z", new int[] {1, 1, 0, 2, 0, 1, 1}),
        new("S", new int[] {0, 1, 1, 2, 1, 1, 0}),
        new("L", new int[] {0, 0, 1, 2, 1, 1, 1}),
        new("J", new int[] {1, 1, 1, 2, 0, 0, 1})
    };

    public static Tetrimino GetRandomTetrimino()
    {
        Random random = new ();
        int randomIndex = random.Next(0, TetriminoList.Count);
        Tetrimino randomTetrimino = TetriminoList[randomIndex];
        return randomTetrimino;
    }
}
