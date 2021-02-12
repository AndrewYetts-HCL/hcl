using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tic_Tac_Toe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe.Tests
{
    [TestClass()]
    public class GameFormTests
    {
        [TestMethod()]
        public void CheckForWinner1Test()
        {
            string playerMark = "X";
            GameForm game = new GameForm(playerMark, "Game7");
            game.board = new string[] { playerMark, playerMark, playerMark, "", "O", "", "", "O", "" };
            bool actual = game.CheckForWinner(playerMark);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckForWinner2Test()
        {
            string playerMark = "O";
            GameForm game = new GameForm(playerMark, "Game7");
            game.board = new string[] { "X", playerMark, "X", "", playerMark, "", "", "X", "" };
            bool actual = game.CheckForWinner(playerMark);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestWinner1()
        {
            string playerMark = "X";
            GameForm game = new GameForm(playerMark, "Game8");
            game.board = new string[] { playerMark, "", playerMark, "", "O", "O", "", "", "", ""};
            bool actual = game.TestWinner(1, playerMark);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestWinner2()
        {
            string playerMark = "O";
            GameForm game = new GameForm(playerMark, "Game8");
            game.board = new string[] { "X", "", playerMark, "", "O", "O", "", "", "", "" };
            bool actual = game.TestWinner(1, playerMark);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}