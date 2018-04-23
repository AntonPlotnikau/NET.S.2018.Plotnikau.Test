using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2.Solution
{
    public abstract class FileGenerator
    {
        public string WorkingDirectory { get; private set; }

        public string FileExtension { get; private set; }

        public FileGenerator(string WorkingDirectory, string FileExtension)
        {
            this.WorkingDirectory = WorkingDirectory ?? throw new ArgumentNullException(nameof(WorkingDirectory));
            this.FileExtension = FileExtension ?? throw new ArgumentNullException(nameof(FileExtension));
        }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        protected abstract byte[] GenerateFileContent(int contentLength);

        private void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }
    }
}
