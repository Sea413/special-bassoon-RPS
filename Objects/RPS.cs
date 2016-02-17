using System;
using System.Linq;
using System.Collections.Generic;

namespace RPSNameSpace
{
  public class RPS
  {
    private int _score;
    private int _p1input;
    private int _p2input;
    private string _choice1;
    private string _choice2;
    private string[] types = {"Rock", "Paper", "Scissors"};

    public RPS(int input1, int input2)
    {
      _p1input = input1;
      _p2input = input2;
      _choice1=types[input1];
      _choice2=types[input2];

    }

    public string GetResult()
    {
      //0,2 p1 1,0 p1 2,1 p1      win1 +2,   win2 -1, -1   draw equal choice
      //2,0 p2 0,1 p2 1,2 p2 -2, +1, +1
      //p1moves[input1], p2moves[input2],
      //if p1moves[0] && p2moves[1], p2 wins, set p2 as winner break loops
      //
        string result;
        string player1win="Player 1 wins";
        string player2win="Player 2 wins";
        string playerDraw="Draw";

        if ((_p1input+2)==_p2input) //player 1 wins
        {
          result=player1win;
        }
        else if (_p1input-1==_p2input) //player 1 wins
        {
          result=player1win;
        }
        else if (_p1input==_p2input) //draw
        {
          result=playerDraw;
        }
        else
        {
            result=player2win;
        }
      return result;
    }

  }
}
