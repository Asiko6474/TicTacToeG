using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeG
{
    class Board
    {
        private char _player1Token;
        private char _player2Token;
        private char _currentToken;
        private char[,] _board;

        public void Start()
        {
            _player1Token = 'x';
            _player2Token = 'o';
            _currentToken = _player1Token;
            _board = new char[3, 3]{ { '0', '0', '0' }, { '0', '0', '0' }, { '0', '0', '0' } };
        }
        /// <summary>
        /// Gets the input from player to set the player token to the desired location in the 2D array.
        /// Then checks to see if there is a winner and to change the token in play.
        /// </summary>
        public void Update()
        {
            if (Game.GetInput() == 1)
            {
                _board[0, 0] = _currentToken;
            }

            if (_currentToken == _player1Token)
                _currentToken = _player2Token;
            else
                _currentToken = _player1Token;
        }

        /// <summary>
        /// Draws the board and lets the players know whose turn it is.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine(_board[0, 0] + " | " + _board[0,1] + " | " + _board[0,2] + "\n" +
                                                    "________________\n" +
                              _board[1,0] + " | " + _board[1,1] + " | " + _board[1,2] + "\n" +
                                                    "________________\n" +
                              _board[2,0] + " | " + _board[2,1] + " | " + _board[2,2] + "\n");
                
        }
        public void End()
        {

        }
        /// <summary>
        /// Assigns the spot at the given indices in the board array to be the given token.
        /// </summary>
        /// <param name="token">The token to set the array index to</param>
        /// <param name="posX">The x position of the token</param>
        /// <param name="posY">The y position of the token</param>
        /// <returns>Returns false if the indices are out of range.</returns>
        public bool SetToken(char token, int posX, int posY)
        {
            return false;
        }


        
        /// <summary>
        /// Check to see if there are three of the given token appears 3 times consecutively, vertically, horizontally, or diagonally.
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool CheckWinner(char token)
        {
            return false;
        }
        /// <summary>
        /// resets the board to its default state.
        /// </summary>
        public void ClearBoard()
        {

        }

        public static int GetInput()
        {
            int choice = -1;
            
            if (!int.TryParse(Console.ReadLine(), out choice))
                choice = -1;

            return choice;
        }
    }
}
