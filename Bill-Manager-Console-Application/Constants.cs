using System;

namespace Bill_Manager_Console_Application
{
    public static class Constants
    {
        #region Fields

        private static readonly string docName = @"\UserData.bin";
        private static readonly string docPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string fileName;

        #endregion "Fields"

        #region Constructors

        static Constants()
        {
            fileName = docPath + docName;
        }

        #endregion "Constructors"

        #region Properties

        public static string FileName { get { return fileName; } }

        #endregion "Properties"
    }
}
