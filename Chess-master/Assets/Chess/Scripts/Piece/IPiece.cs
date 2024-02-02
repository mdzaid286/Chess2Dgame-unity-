using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class IPiece : MonoBehaviour
{
    [SerializeField] protected int row, column;

    public Vector2Int Position => new Vector2Int(row, column);

    public void UpdateVisualPosition()
    {
        transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }

    protected virtual void Start()
    {
        UpdateVisualPosition();
    }

    public abstract IEnumerable<Vector2Int> GetAllPossibleMovements();

    protected List<Vector2Int> GetPath(int _row, int _col, int steps, int deltaRow, int deltaCol)
    {
        var result = new List<Vector2Int>() { };
        _row += deltaRow;
        _col += deltaCol;
        var cell = new Vector2Int(_row, _col);

        if ((steps <= 0) || // Check if all steps are over
        (_row < 0 || _row > 7 || _col < 0 || _col > 7) || // Check if position is inside the board
        ChessBoardPlacementHandler.Instance.GetAllPiecesPositions().Contains(cell) // Check if path is obstructed by any piece
        ) return result;

        result = GetPath(_row, _col, --steps, deltaRow, deltaCol);
        result.Add(cell);
        return result;
    }
}
