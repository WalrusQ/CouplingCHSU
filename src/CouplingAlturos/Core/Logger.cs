using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Accord.IO;
using CouplingAlturos.Abstractions;
using CouplingAlturos.Core.Models;

namespace CouplingAlturos.Core
{
	[System.Runtime.InteropServices.Guid("741B81E4-846E-4C24-97E2-249B2448FBDA")]
	public class Logger : ILogger
	{   
		public List<LogMessage> Messages { get; }

        public Logger()
        {
            Messages = new List<LogMessage>();
            Initialize();
        }

        private static void Initialize()
        {
	        var directory = new DirectoryInfo(Constants.LogsFolder);
	        if (!directory.Exists) directory.Create();
		}

        public void Clear()
        {
            Messages.Clear();
        }

		public void WriteLine(string message)
		{
            Messages.Add(new LogMessage(message));
		}

		public void Save(string filename)
		{
			var strings = Messages.Select(x => x.ToString()).ToList();
			var fullPath = Path.Combine(Constants.LogsFolder, $"{filename}.log");

			using (var writer = new StreamWriter(fullPath))
			{
				writer.Write(string.Join("\r\n", strings));
			}
		}
	}
}