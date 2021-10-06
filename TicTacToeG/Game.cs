using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeG
{
    class Game
    {
        public static bool _gameOver = false;
        private Board _gameBoard;
        /// <summary>
        /// Begins the game
        /// </summary>
        public void Run()
        {
            Start();

            while (!_gameOver)
            {
                    Draw();
                    Update();

            }

            End();

        }
        /// <summary>
        /// called when the 
        /// </summary>
        private void Start()
        {
            _gameBoard = new Board();
            _gameBoard.Start();
        }

        private void Update()
        {
           _gameBoard.Update();
        }
        /// <summary>
        /// Plays when leaving the game
        /// </summary>
        public void End()
        {
            _gameBoard.End();
        }
        /// <summary>
        /// upddates the display to reflect any changes while running
        /// </summary>
        public void Draw()
        {
            Console.Clear();
            _gameBoard.Draw();
            
            
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
