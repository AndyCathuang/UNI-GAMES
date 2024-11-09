using System;

namespace Microsoft.Win32
{
    internal class OpenFolderDialog
    {
        internal object FolderName;

        public string Title { get; internal set; }
        public string InitialDirectory { get; internal set; }

        internal bool ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}