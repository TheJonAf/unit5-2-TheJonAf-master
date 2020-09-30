using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    public class TestBase
    {
        private StringWriter consoleOutput;
        private StringReader consoleInput;
        private string output;

        /// <summary>
        /// Gets all of the text printed to the console
        /// </summary>
        public string Output
        {
            get
            {
                if (output == null)
                {
                    this.consoleOutput.Flush();
                    output = this.consoleOutput.GetStringBuilder().ToString();
                }

                return output;
            }
        }

        /// <summary>
        /// Gets the test printed to the console with a separate array element per line
        /// </summary>
        public string[] OutputByLine
            => this.Output.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

        [TestInitialize]
        public void InitializeTest()
        {
            // Redirect the console output
            this.consoleOutput = new StringWriter();
            Console.SetOut(this.consoleOutput);

            // Configure the console input
            this.SetUpInput(string.Empty);
        }

        [TestCleanup]
        public void CleanupTest()
        {
            this.consoleOutput.Dispose();
            this.consoleInput.Dispose();
        }

        protected void SetUpInput(string input)
        {
            this.consoleInput?.Dispose();

            this.consoleInput = new StringReader(input);
            Console.SetIn(this.consoleInput);
        }

        protected void SetUpInput(params object[] inputs)
        {
            var input = string.Join(Environment.NewLine, inputs);
            this.SetUpInput(input);
        }
    }
}
