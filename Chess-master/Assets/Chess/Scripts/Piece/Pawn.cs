using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : IPiece
{
    public override IEnumerable<Vector2Int> GetAllPossibleMovements()
    {
        return GetPath(row, column, row == 1 ? 2 : 1, 1, 0);
    }
}
