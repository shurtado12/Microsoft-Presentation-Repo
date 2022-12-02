using System.Collections.Generic;
using UnityEngine;

public class boardStartManage : MonoBehaviour
{
    public static GameObject BoardPositions;
    public static GameObject ChessPieces;
    // Start is called before the first frame update
    void Start()
    {
        SetupBoard();
    }

    public void SetupBoard()
    {
        print("RESETTING BOARD");

        // This Script should be added to the board.
        // It is expected that the Board will have 2 childrem
        //  Child 1 = The ChessSet, this is all the pieces in the board
        //  Child 2 = The Board Positions this is the 64 meshes that are on the board A1, A2, A3, etc
        //      Note Make sure that each on of the Cell positions is and empty game object with just the CellProperties script.
        //      The mesh/primitive that acts as the collider should be a child of the Cell. it will act weird otherwise
        //  The TLDR is if you add a child to an object that you had to scale, it will also apply the scale values to the child once you add it.

        // Step 1 Get the parents
        foreach (Transform child in transform)
        {
            if (child.name.Contains("positions"))
            {
                print("Found it");
                BoardPositions = child.gameObject;
            }

            if (child.name.Contains("ChessSet"))
            {
                print("Found Chess Set");
                ChessPieces = child.gameObject;
            }
        }

        //  Step 2 set the board positions.
        //  I am sure there is a better way, but this works for now
        //  You will have to do this for each black and white chess piece.
        //  You can foreach over the string array you created


        Dictionary<string, string> startingPosition = new Dictionary<string, string>
        { 
           // {"A1","DarkRook"},
           // {"A2", "DarkKnight"},
           // {"A3", "DarkBishop"},
           {"a1", "RookLight"},
           {"b1", "KnightLight"},
           {"c1", "BishopLight"},
           {"d1", "QueenLight"},
           {"e1", "KingLight"},
           {"f1", "BishopLight (1)"},
           {"g1", "KnightLight (1)"},
           {"h1", "RookLight (1)"},
           {"a2", "PawnLight (7)"},
           {"b2", "PawnLight (6)"},
           {"c2", "PawnLight (5)"},
           {"d2", "PawnLight (4)"},
           {"e2", "PawnLight (3)"},
           {"f2", "PawnLight (2)"},
           {"g2", "PawnLight (1)"},
           {"h2", "PawnLight"},

           {"h8", "RookDark (1)"},
           {"g8", "KnightDark (1)"},
           {"f8", "BishopDark"},
           {"e8", "QueenDark"},
           {"d8", "KingDark"},
           {"c8", "BishopDark (1)"},
           {"b8", "KnightDark"},
           {"a8", "RookDark"},
           {"h7", "PawnDark (7)"},
           {"g7", "PawnDark (6)"},
           {"f7", "PawnDark (5)"},
           {"e7", "PawnDark (4)"},
           {"d7", "PawnDark (3)"},
           {"c7", "PawnDark (2)"},
           {"b7", "PawnDark (1)"},
           {"a7", "PawnDark"}
        };


        foreach (var (key, value) in startingPosition)
        {
            // Get board position A1
            Transform cell = BoardPositions.transform.Find(key);

            // Get DarkRook
            GameObject chessPiece = ChessPieces.transform.Find(value).gameObject;

            // Get the Cell Properties script
            CellProperties cellDefaults = cell.gameObject.GetComponent<CellProperties>();

            //Print log message
            print(cellDefaults.DefaultState);

            // Set the default parameters these will be used to keep game state later
            cellDefaults.PositionID = key;
            cellDefaults.DefaultState = chessPiece.name.ToString();
            cellDefaults.CurrentState = chessPiece.name.ToString();

            // I don't think this is necessary because the cell is now the parent of the gameobject but just putting it here for now
            cellDefaults.DefaultStateGO = chessPiece;


            // This will Move the Chess piece to be a child of the Cell A1            
            chessPiece.transform.SetParent(cell.transform);
            //Log message
            print(cell.transform.position);

            // Move the chess piece to the position of the cell.  This will only work if you check the TLDR above.
            // The cell should be an empty object so there is no wierd position offset.
            chessPiece.transform.position = cell.transform.position;
            print(chessPiece.transform.position);
        }

    }
}
