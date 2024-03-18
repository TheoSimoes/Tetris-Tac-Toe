using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetriminoGrid<T> : MonoBehaviour
{
    public static int Width = 4;
    public static int Height = 4;
    public T[] Cells = new T[Width * Height];

    public void ColorGrid()
    {
        Console.WriteLine(Tetrimino.GetRandomTetrimino());
        
    }
}
