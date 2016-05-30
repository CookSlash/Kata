using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using Trivia_csharp.Init;

namespace Trivia
{
    class NonRegTriviaTest
    {

        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void NonRegressionTest()
        {
            var output = new StringBuilder();
            Console.SetOut(new StringWriter(output));

            Game aGame = new Game();

            aGame.Add("Chet");
            aGame.Add("Pat");
            aGame.Add("Sue");
            aGame.Roll(2);
            aGame.WrongAnswer();
            aGame.Roll(3);
            aGame.wasCorrectlyAnswered();
            aGame.Roll(4);
            aGame.wasCorrectlyAnswered();
            aGame.Roll(5);
            aGame.wasCorrectlyAnswered();
            aGame.Roll(4);
            aGame.wasCorrectlyAnswered();
            aGame.Roll(4);
            aGame.wasCorrectlyAnswered();
            aGame.Roll(2);
            aGame.Roll(1);
            aGame.WrongAnswer();
            aGame.Roll(5);
            aGame.wasCorrectlyAnswered();
            aGame.Roll(2);
            aGame.Roll(2);
            aGame.Roll(5);
            aGame.wasCorrectlyAnswered();
            aGame.Roll(1);
            aGame.wasCorrectlyAnswered();
            aGame.Roll(4);
            aGame.Roll(2);
            aGame.wasCorrectlyAnswered();
            aGame.Roll(4);
            aGame.Roll(4);
            aGame.Roll(5);
            aGame.wasCorrectlyAnswered();
            Approvals.Verify(output.ToString());

        }
    }
}
