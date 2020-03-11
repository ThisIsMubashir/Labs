using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_Console;



namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -10.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            account.Debit(debitAmount);
            // Act and assert
            // Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DebitAmount_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 12.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            account.Debit(debitAmount);
            // Act and assert
            // Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));

        }

    }
}
