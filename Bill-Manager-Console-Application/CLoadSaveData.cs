using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bill_Manager_Console_Application
{
    class CLoadSaveData
    {
        #region Methods

        public void OnApplicationLoad()
        {
            readWriteToFile(true);
        }

        public void OnApplicationClose()
        {
            readWriteToFile(false);
        }

        private void readWriteToFile(bool isLoading)
        {
            List<CBill> data = new List<CBill>();
            BinaryFormatter formatter = new BinaryFormatter();

            switch (isLoading)
            {
                case true:
                    if (File.Exists(Constants.FileName))
                    {
                        Stream loadFileStream = File.OpenRead(Constants.FileName);
                        data = (List<CBill>)formatter.Deserialize(loadFileStream);
                        loadFileStream.Close();

                        if (data != null)
                        {
                            CBillDatabase.SharedInstance.Database = data;
                        }
                    }
                    break;

                case false:
                    try
                    {
                        Stream saveFileStream = File.Create(Constants.FileName);
                        data = CBillDatabase.SharedInstance.Database;
                        formatter.Serialize(saveFileStream, data);
                        saveFileStream.Close();
                    }
                    catch (NullReferenceException) { }
                    break;
            }
        }

        #endregion "Methods"
    }
}
