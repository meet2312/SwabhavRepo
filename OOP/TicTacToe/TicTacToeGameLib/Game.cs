using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGameLib
{
  public  class Game
    {
        private Board _board;
        private Player _player;
        private ResultAnalyzer _resultanalyzer;
        private static int _turn = 0;
        private Result _status;



        public Board Board
        {
            get
            {
                return _board;
            }
        }

        public Player Player
        {
            get
            {
                return _player;
            }
        }

        public Result Status
        {
            get
            {
                return _status;
            }
        }

        public String getCurrentStatus()

        {

            String result;

            if (_status.Equals(Result.DRAW))

            {

                result = "DRAW";

            }

            else if (_status.Equals(Result.WIN))

            {

                result = "WIN";

            }

            else

            {

                result = "ONGOING";

            }

            return result;



        }


        public Game()
        {
            _board = new Board();
            _resultanalyzer = new ResultAnalyzer(_board);
            _status = Result.ONGOING;

        }

        public Result Play(int index)
        {
               if(_status.Equals(Result.ONGOING))
                {
         //        _turn = index;
                _player= PlayerTurn();
                _board.SetLocation(_player.GetMark(), index);
                _status = _resultanalyzer.AnalyzeResult();
                 }
            return _status;
        }


        public Player PlayerTurn()
        {
            _turn = _turn + 1;
            if(_turn % 2 == 0)
            {
                return new Player("priyank", Mark.X);
            }
            return new Player("meet", Mark.O);
        }

      


    }
}
