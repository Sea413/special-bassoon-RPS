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
        PlayerCheck newPlayerCheck = new PlayerCheck();

        Assert.Equal("Player1 Wins", newPlayerCheck(player P1, player P2));
      }
  }
}
