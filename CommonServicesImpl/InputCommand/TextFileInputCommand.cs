using System.Collections.Generic;
using System.IO;
using CommonServices;

namespace CommonServicesImpl.InputCommand
{
    public class TextFileInputCommand : IInputCommand
    {
        #region IInputCommand Members

        private string fullFilePath = string.Empty;

        public TextFileInputCommand(string fullFilePath)
        {
            FileInfo f = new FileInfo(fullFilePath);
            if ((f.Name != ".txt") && (f.Name.EndsWith(".txt") == true))
            {
                this.fullFilePath = fullFilePath;
            }
        }

        public IList<string> GetInputCommands()
        {
            List<string> result = new List<string>();
            if (File.Exists(fullFilePath) == true)
            {
                using (StreamReader sr = new StreamReader(fullFilePath))
                {
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        result.Add(line);
                    }
                }
            }
            else
            {
                // Can log/display message ..etc if needed
                // Do nothing here - the list of commands returned will be empty
            }
            return result;
        }

        #endregion
    }
}
