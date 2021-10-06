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
            _player1Token = 'X';
            _player2Token = 'O';
            _currentToken = _player1Token;
            _board = new char[3, 3]{ { '7', '8', '9' }, 
                                     { '4', '5', '6' },     
                                     { '1', '2', '3' } };
        }
        /// <summary>
        /// Gets the input from player to set the player token to the desired location in the 2D array.
        /// Then checks to see if there is a winner and to change the token in play.
        /// </summary>
        public void Update()
        {
            CheckWinner(_player1Token);
            CheckWinner(_player2Token);

            Console.WriteLine(_currentToken + "'s turn");

            char selectLocation = Console.ReadKey(true).KeyChar;

            switch (selectLocation)
            {
                case '1':
                    _board[2, 0] = _currentToken;
                    break;
                case '2':
                    _board[2, 1] = _currentToken;
                    break;
                case '3':
                    _board[2, 2] = _currentToken;
                    break;
                case '4':
                    _board[1, 0] = _currentToken;
                    break;
                case '5':
                    _board[1, 1] = _currentToken;
                    break;
                case '6':
                    _board[1, 2] = _currentToken;
                    break;
                case '7':
                    _board[0, 0] = _currentToken;
                    break;
                case '8':
                    _board[0, 2] = _currentToken;
                    break;
                case '9':
                    _board[0, 2] = _currentToken;
                    break;
            }

            if (_currentToken == _player1Token)
            {
                
                _currentToken = _player2Token;
            }
                
            else
            {
                
                _currentToken = _player1Token;
            }
            
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

            //Lists every possible way X can win.
            if (_board[2, 0] == 'X' && _board[2, 1] == 'X' && _board[2, 2] == 'X') 
            {
                Console.WriteLine("X Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[1, 0] == 'X' && _board[1, 1] == 'X' && _board[1, 2] == 'X')
            {
                Console.WriteLine("X Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[0, 0] == 'X' && _board[0, 1] == 'X' && _board[0, 2] == 'X')
            {
                Console.WriteLine("X Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 0] == 'X' && _board[1, 0] == 'X' && _board[0, 0] == 'X')
            {
                Console.WriteLine("X Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 1] == 'X' && _board[1, 1] == 'X' && _board[0, 1] == 'X')
            {
                Console.WriteLine("X Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 2] == 'X' && _board[1, 2] == 'X' && _board[0, 2] == 'X')
            {
                Console.WriteLine("X Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[0, 0] == 'X' && _board[1, 1] == 'X' && _board[2, 2] == 'X')
            {
                Console.WriteLine("X Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 0] == 'X' && _board[1, 1] == 'X' && _board[0, 2] == 'X')
            {
                Console.WriteLine("X Wins");
                Console.ReadKey(true);
                return true;
            }



            //Lists every possible way O can win.
            if (_board[2, 0] == 'O' && _board[2, 1] == 'O' && _board[2, 2] == 'O')
            {
                Console.WriteLine("O Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[1, 0] == 'O' && _board[1, 1] == 'O' && _board[1, 2] == 'O')
            {
                Console.WriteLine("O Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[0, 0] == 'O' && _board[0, 1] == 'O' && _board[0, 2] == 'O')
            {
                Console.WriteLine("O Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 0] == 'O' && _board[1, 0] == 'O' && _board[0, 0] == 'O')
            {
                Console.WriteLine("O Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 1] == 'O' && _board[1, 1] == 'O' && _board[0, 1] == 'O')
            {
                Console.WriteLine("O Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 2] == 'O' && _board[1, 2] == 'O' && _board[0, 2] == 'O')
            {
                Console.WriteLine("O Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[0, 0] == 'O' && _board[1, 1] == 'O' && _board[2, 2] == 'O')
            {
                Console.WriteLine("O Wins");
                Console.ReadKey(true);
                return true;
            }
            else if (_board[2, 0] == 'O' && _board[1, 1] == 'O' && _board[0, 2] == 'O')
            {
                Console.WriteLine("O Wins");
                Console.ReadKey(true);
                return true;
            }
            //If noone wins yet, return false
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
