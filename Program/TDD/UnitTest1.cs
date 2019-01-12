using System;
using Xunit;
using Program;

namespace TDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanViewBalance()
        {
            Assert.Equal(200, Program.Program.Balance);
        }
        [Fact]
        public void CanWithdrawBalance()
        {
            double input = 100;
            Assert.Equal(100, Program.Program.Balance - input);
        }
        [Fact]
        public void CantWithdrawNegativeNumbers()
        {
            
            double sysInput = -100;
            Assert.Equal(Program.Program.Balance, Program.Program.WithdrawBalance(Program.Program.Balance, sysInput));
        }
    }
}
