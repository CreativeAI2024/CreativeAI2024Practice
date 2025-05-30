



using System;
using System.Reflection;
using UnityEngine;

public class Board
{
    private Piece[][] _pieces;
    private Vector2Int _size;
    
    public Board(Vector2Int size)
    {
        _size = size;
        _pieces = new Piece[_size.x][];
        for (int i = 0; i < _size.x; i++)
        {
            _pieces[i] = new Piece[_size.y];
        }
    }
    
    /// <summary>
    /// インデックスでピースを取得する処理を書いてね
    /// </summary>
    /// <param name="index">指定する盤面のインデックス位置</param>
    /// <returns>指定されたピース</returns>
    public Piece GetPiece(Vector2Int index)
    {
        return _pieces[index.x][index.y];
    }

    /// <summary>
    /// インデックスの位置にピースを設置する処理を書いてね。
    /// </summary>
    /// <remarks>
    /// 既に置かれているものがあると設置しないようにしてね。
    /// </remarks>
    /// <param name="index">指定する盤面のインデックス位置</param>
    /// <param name="piece">設置するピース</param>
    /// <returns>設置できたか</returns>
    public bool TryPut(Vector2Int index, Piece piece)
    {
        //Debug.Log(GetPiece(index));
        if (GetPiece(index) == null && (index.x < _size.x && index.y < _size.y && index.x >= 0 && index.y >= 0))
        {
            _pieces[index.x][index.y] = piece;
            TracePiece(_size.x - index.x, index.x, index.y, 1, 0, piece);
            TracePiece(index.x+1, index.x, index.y, -1, 0, piece);
            TracePiece(_size.y - index.y, index.x, index.y, 0, 1, piece);
            TracePiece(index.y+1, index.x, index.y, 0, -1, piece);

            if ((_size.x - index.x) < (_size.y - index.y))
            {
                TracePiece(_size.x - index.x, index.x, index.y, 1, 1, piece);
            }
            else
            {
                TracePiece(_size.y - index.y, index.x, index.y, 1, 1, piece);
            }

            if ((index.x) < (_size.y - index.y))
            {
                TracePiece(index.x+1, index.x, index.y, -1, 1, piece);
            }
            else
            {
                TracePiece(_size.y - index.y, index.x, index.y, -1, 1, piece);
            }

            if ((_size.x - index.x) < (index.y))
            {
                TracePiece(_size.x - index.x, index.x, index.y, 1, -1, piece);
            }
            else
            {
                TracePiece(index.y+1, index.x, index.y, 1, -1, piece);
            }

            if ((index.x) < (index.y))
            {
                TracePiece(index.x+1, index.x, index.y, -1, -1, piece);
            }
            else
            {
                TracePiece(index.y+1, index.x, index.y, -1, -1, piece);
            }
            return true;
        }
        return false;
        
    }

    private int CheckFront(int x,int y,Piece piece)
    {
        //Debug.Log("piece:"+x+":"+y+":"+_pieces[x][y]);
        Vector2Int index = new Vector2Int(x,y);
        if (GetPiece(index) == null)
        {
            return 0;
        }
        else if (GetPiece(index).IsFront == piece.IsFront)
        {
            return -1;
        }
        else if (GetPiece(index).IsFront != piece.IsFront)
        {
            return 1;
        }
        
        return 0;
    }

    private void TracePiece(int max,int cfx,int cfy,int cfxx,int cfyy, Piece piece)
    {
        int[] checkPieces = new int[max];
        int sum = 0;
        for (int i = 1; i < max; i++)
        {
            if ((cfx + (i * cfxx)) >= 0 && (cfy + (i * cfyy)) >= 0 && (cfx + (i * cfxx)) < _size.x && (cfy + (i * cfyy)) < _size.y)
            {
                checkPieces[i - 1] = CheckFront(cfx + (i * cfxx), cfy + (i * cfyy), piece);
            }
            //Debug.Log(cfx + (i * cfxx)+ ":" + (cfy + (i * cfyy)));
        }
        for (int i = 1; i <= checkPieces.Length; i++)
        {
            //Debug.Log(sum + ":" + (i - 1)+":"+ checkPieces[i - 1]);
            if (checkPieces[i - 1] == -1 && sum == i - 1)
            {
                //Debug.Log("a");
                for (int j = 1; j < i; j++)
                {
                    if((cfx + (j * cfxx))>=0&&(cfy + (j * cfyy)) >= 0&& (cfx + (j * cfxx)) < _size.x && (cfy + (j * cfyy)) < _size.y)
                    {
                        _pieces[cfx + (j * cfxx)][cfy + (j * cfyy)].Reverse();
                    }
                }
                break;
            }
            sum += checkPieces[i - 1];
        }
    }
}
