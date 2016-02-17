using System;
using System.Collections.Generic;
using Xunit;

namespace RPSNameSpace
{
  public class RPSclass
  {

      [Fact]
      public void Test1_CheckWin_Player1()
      {
        RPS newRPS = new RPS(2,0);

        Assert.Equal("Player 2 wins", newRPS.GetResult());
      }
      // [Fact]

  }
}
