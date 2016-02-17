using System;
using System.Linq;
using System.Collections.Generic;

namespace RPSNameSpace
{
  public class RPS
  {
    private int _score;
    private string _p1input;
    private string _p2input;

    public RPS(string input1, string input2)
    {
      string result;
      string[] p1moves={"rock","paper","scissors"};
      string[] p2moves={"rock","paper","scissors"};

      _p1input = input1;
      _p2input = input2;

      


    }

    public string GetInput()
    {
    }
    public List<string> GetAll()
    {
    }
    public void SetCandidate(string candidateInput)
    {
    }
    public List<string> GetCandidate()
    {
    }

  }
}
