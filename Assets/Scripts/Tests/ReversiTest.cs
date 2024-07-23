using System;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class ReversiTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ReversiFrontReverseTest()
        {
            // Use the Assert class to test conditions
            Piece piece = new Piece(true);
            piece.Reverse();
            Assert.IsFalse(piece.IsFront);
        }
        
        [Test]
        public void ReversiBackReverseTest()
        {
            // Use the Assert class to test conditions
            Piece piece = new Piece(false);
            piece.Reverse();
            Assert.IsTrue(piece.IsFront);
        }
        
        [Test]
        public void ReversiGetPieceTest()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            board.TryPut(new Vector2Int(2, 2), new Piece(true));
            Assert.IsTrue(board.GetPiece(new Vector2Int(2, 2)).IsFront);
        }
        
        [Test]
        public void ReversiGetPieceRangeTest2()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.Catch<IndexOutOfRangeException>(() => board.GetPiece(new Vector2Int(7, 8)));
        }
        
        [Test]
        public void ReversiGetPieceRangeTest3()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.Catch<IndexOutOfRangeException>(() => board.GetPiece(new Vector2Int(8, 7)));
        }
        
        [Test]
        public void ReversiGetPieceRangeTest4()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.Catch<IndexOutOfRangeException>(() => board.GetPiece(new Vector2Int(-1, 0)));
        }
        
        [Test]
        public void ReversiGetPieceRangeTest5()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.Catch<IndexOutOfRangeException>(() => board.GetPiece(new Vector2Int(0, -1)));
        }
        
        [Test]
        public void ReversiGetPieceRangeTest6()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.IsNull(board.GetPiece(new Vector2Int(4, 4)));
        }
        
        [Test]
        public void ReversiBoardRangeTest()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.Catch<IndexOutOfRangeException>(() => board.TryPut(new Vector2Int(7, 8), new Piece(true)));
        }
        
        [Test]
        public void ReversiBoardRangeTest2()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.Catch<IndexOutOfRangeException>(() => board.TryPut(new Vector2Int(8, 7), new Piece(true)));
        }
        
        [Test]
        public void ReversiBoardRangeTest3()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.Catch<IndexOutOfRangeException>(() => board.TryPut(new Vector2Int(-1, 0), new Piece(true)));
        }
        
        [Test]
        public void ReversiBoardRangeTest4()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.Catch<IndexOutOfRangeException>(() => board.TryPut(new Vector2Int(0, -1), new Piece(true)));
        }
        
        [Test]
        public void ReversiBoardRangeTest5()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            Assert.IsTrue(board.TryPut(new Vector2Int(4, 4), new Piece(true)));
        }
        
        [Test]
        public void ReversiBoardRangeTest6()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            board.TryPut(new Vector2Int(6, 6), new Piece(true));
            Assert.IsFalse(board.TryPut(new Vector2Int(6, 6), new Piece(true)));
        }
        
        [Test]
        public void ReversiBoardPutTest()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(3, 1));
            board.TryPut(new Vector2Int(0, 0), new Piece(true));
            board.TryPut(new Vector2Int(1, 0), new Piece(false));
            board.TryPut(new Vector2Int(2, 0), new Piece(true));
            Assert.IsTrue(board.GetPiece(new Vector2Int(1, 0)).IsFront);
        }
        
        [Test]
        public void ReversiBoardPutTest2()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(1, 3));
            board.TryPut(new Vector2Int(0, 0), new Piece(true));
            board.TryPut(new Vector2Int(0, 1), new Piece(false));
            board.TryPut(new Vector2Int(0, 2), new Piece(true));
            Assert.IsTrue(board.GetPiece(new Vector2Int(0, 1)).IsFront);
        }
        
        [Test]
        public void ReversiBoardPutTest3()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(3, 3));
            board.TryPut(new Vector2Int(0, 0), new Piece(true));
            board.TryPut(new Vector2Int(1, 1), new Piece(false));
            board.TryPut(new Vector2Int(2, 2), new Piece(true));
            Assert.IsTrue(board.GetPiece(new Vector2Int(1, 1)).IsFront);
        }
        
        [Test]
        public void ReversiBoardPutTest4()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(3, 3));
            board.TryPut(new Vector2Int(0, 2), new Piece(true));
            board.TryPut(new Vector2Int(1, 1), new Piece(false));
            board.TryPut(new Vector2Int(2, 0), new Piece(true));
            Assert.IsTrue(board.GetPiece(new Vector2Int(1, 1)).IsFront);
        }
        
        [Test]
        public void ReversiBoardPutComplexTest()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(5, 5));
            board.TryPut(new Vector2Int(0, 0), new Piece(true));
            board.TryPut(new Vector2Int(2, 0), new Piece(true));
            board.TryPut(new Vector2Int(4, 0), new Piece(true));
            board.TryPut(new Vector2Int(4, 2), new Piece(true));
            board.TryPut(new Vector2Int(4, 4), new Piece(true));
            board.TryPut(new Vector2Int(2, 4), new Piece(true));
            board.TryPut(new Vector2Int(0, 4), new Piece(true));
            board.TryPut(new Vector2Int(0, 2), new Piece(true));
            
            board.TryPut(new Vector2Int(1, 1), new Piece(false));
            board.TryPut(new Vector2Int(2, 1), new Piece(false));
            board.TryPut(new Vector2Int(3, 1), new Piece(false));
            board.TryPut(new Vector2Int(3, 2), new Piece(false));
            board.TryPut(new Vector2Int(3, 3), new Piece(false));
            board.TryPut(new Vector2Int(2, 3), new Piece(false));
            board.TryPut(new Vector2Int(1, 3), new Piece(false));
            board.TryPut(new Vector2Int(1, 2), new Piece(false));

            board.TryPut(new Vector2Int(2, 2), new Piece(true));
            Assert.IsTrue(board.GetPiece(new Vector2Int(1, 1)).IsFront);
            Assert.IsTrue(board.GetPiece(new Vector2Int(2, 1)).IsFront);
            Assert.IsTrue(board.GetPiece(new Vector2Int(3, 1)).IsFront);
            Assert.IsTrue(board.GetPiece(new Vector2Int(3, 2)).IsFront);
            Assert.IsTrue(board.GetPiece(new Vector2Int(3, 3)).IsFront);
            Assert.IsTrue(board.GetPiece(new Vector2Int(2, 3)).IsFront);
            Assert.IsTrue(board.GetPiece(new Vector2Int(1, 3)).IsFront);
            Assert.IsTrue(board.GetPiece(new Vector2Int(1, 2)).IsFront);
        }
        
        [Test]
        public void ReversiBoardPutComplexTest2()
        {
            // Use the Assert class to test conditions
            Board board = new Board(new Vector2Int(8, 8));
            board.TryPut(new Vector2Int(0, 0), new Piece(true));
            board.TryPut(new Vector2Int(7, 0), new Piece(true));
            board.TryPut(new Vector2Int(0, 7), new Piece(true));

            for (int i = 1; i <= 6; i++)
            {
                board.TryPut(new Vector2Int(i, i), new Piece(false));
            }
            for (int i = 1; i <= 6; i++)
            {
                board.TryPut(new Vector2Int(i, 7), new Piece(false));
            }
            for (int i = 1; i <= 6; i++)
            {
                board.TryPut(new Vector2Int(7, i), new Piece(false));
            }

            board.TryPut(new Vector2Int(7, 7), new Piece(true));
            
            for (int i = 1; i <= 6; i++)
            {
                Assert.IsTrue(board.GetPiece(new Vector2Int(i, i)).IsFront);
            }
            for (int i = 1; i <= 6; i++)
            {
                Assert.IsTrue(board.GetPiece(new Vector2Int(i, 7)).IsFront);
            }
            for (int i = 1; i <= 6; i++)
            {
                Assert.IsTrue(board.GetPiece(new Vector2Int(7, i)).IsFront);
            }
        }
    }
}
