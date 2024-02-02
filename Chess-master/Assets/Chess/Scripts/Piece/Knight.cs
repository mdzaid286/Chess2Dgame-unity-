using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : IPiece
{
    public override IEnumerable<Vector2Int> GetAllPossibleMovements()
    {
        var result = new List<Vector2Int>() { };
        result.AddRange(GetPath(row, column, 1, 1, -2));
        result.AddRange(GetPath(row, column, 1, 2, -1));
        result.AddRange(GetPath(row, column, 1, 1, 2));
        result.AddRange(GetPath(row, column, 1, 2, 1));
        result.AddRange(GetPath(row, column, 1, -1, -2));
        result.AddRange(GetPath(row, column, 1, -2, -1));
        result.AddRange(GetPath(row, column, 1, -1, 2));
        result.AddRange(GetPath(row, column, 1, -2, 1));
        return result;
    }
}