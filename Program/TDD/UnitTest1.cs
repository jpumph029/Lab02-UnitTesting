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
        public void CanViewAnyBalance()
        {
            Assert.Equal(Program.Program.Balance, Program.Program.Balance);
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
        [Fact]
        public void CanDeposit()
        {
            double sysInput = 100;
            Assert.Equal(300, Program.Program.DepositToBalance(Program.Program.Balance, sysInput));
        }
        [Fact]
        public void CantDepositNegativeNumber()
        {
            double sysInput = -100;
            Assert.Equal(Program.Program.Balance, Program.Program.DepositToBalance(Program.Program.Balance, sysInput));
        }
    }
}
