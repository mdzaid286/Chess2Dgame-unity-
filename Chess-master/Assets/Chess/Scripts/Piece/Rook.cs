using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : IPiece
{
    public override IEnumerable<Vector2Int> GetAllPossibleMovements()
    {
        var result = new List<Vector2Int>() { };
        result.AddRange(GetPath(row, column, 8, 1, 0));
        result.AddRange(GetPath(row, column, 8, -1, 0));
        result.AddRange(GetPath(row, column, 8, 0, -1));
        result.AddRange(GetPath(row, column, 8, 0, 1));
        return result;
    }
}