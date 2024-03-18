using System;
using System.Collections.Generic;

public class Tetrimino
{
    private int [,] _shape;
    private static List<int[,]> TetriminoList = new List<int[,]>
    {
        new int[,] {{1, 1}, {1, 1}},  // Square
        new int[,] {{1, 1, 1, 1}}, // Line
        new int[,] {{1, 1, 1}, {0, 1, 0}}, // T
        new int[,] {{1, 1, 0}, {0, 1, 1}}, // Z
        new int[,] {{0, 1, 1}, {1, 1, 0}}, // S
        new int[,] {{0, 1, 0}, {1, 1, 1}}, // L
        new int[,] {{1, 0}, {1, 0}, {1, 1}} // J
    };

    public int [,] Shape {
        get { return _shape; }
        set { _shape = value; }
    }

    public Tetrimino(int[,] shape)
    {
        _shape = shape;
    }

    public Tetrimino GetRamdomTetrimino()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, TetriminoList.Count);
        int [,] randomTetrimino = TetriminoList[randomIndex];
        return new Tetrimino (randomTetrimino);
    }
}
