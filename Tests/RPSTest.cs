using System;
using System.Collections.Generic;
using Xunit;

namespace RPSNameSpace
{
  public class RPSclass
  {

      [Fact]
      public void Test1_CheckWin_Player2Win()
      {
        RPS newRPS = new RPS(2,0);
        Assert.Equal("Player 2 wins", newRPS.GetResult());
      }
      // [Fact]
      [Fact]
      public void Test2_CheckLoss_Player1Win()
      {
        RPS newRPS = new RPS(0,2);
        Assert.Equal("Player 1 wins", newRPS.GetResult());
      }
      [Fact]
      public void Test3_CheckDraw_Draw()
      {
        RPS newRPS = new RPS(1,1);
        Assert.Equal("Draw", newRPS.GetResult());
      }
  }
}
