﻿using NSubstitute;
using NUnit.Framework;

namespace TennisKata.Tests
{
    [TestFixture]
    public class TennisMatchShould
    {
        private TennisMatch _tennisMatch;
        private ScoreBoard _scoreBoard;

        [SetUp]
        public void SetUp()
        {
            var console = Substitute.For<IConsole>();
            _scoreBoard = Substitute.For<ScoreBoard>(console);
            _tennisMatch = new TennisMatch(_scoreBoard, null, null, null, null);
        }

        [Test]
        public void DisplayTheScoreBoard()
        {
            _tennisMatch.DisplayScore();

            _scoreBoard.Received().Display( null, null, null, null);
        }

    }
}
