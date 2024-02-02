using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                var piece = hit.transform.GetComponent<IPiece>();
                if (piece)
                {
                    HandleTap(piece);
                }
            }
        }
    }

    private void HandleTap(IPiece piece)
    {
        foreach (var pos in piece.GetAllPossibleMovements())
        {
            ChessBoardPlacementHandler.Instance.Highlight(pos.x, pos.y);
        }
    }
}
