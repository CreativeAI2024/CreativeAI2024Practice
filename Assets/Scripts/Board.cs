



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
        return null;
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
        return true;
    }
}
