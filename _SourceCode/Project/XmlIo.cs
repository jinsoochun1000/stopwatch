using System;
using System.IO;
using System.Xml.Serialization;

namespace WorkerClock
{
    public class XmlIO : IDisposable
    {
        #region ' IDisposable 멤버

        public void Dispose()
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region ' TRKConfig Read/Save

        public bool SaveTRKConfig(string path, TRKConfig trkconfig)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string fileName = string.Format(@"{0}\TRKConfig.ini", path);
            if (trkconfig == null) return ShowErrorMsg("TRKConfig 객체가 생성되지 않았습니다.");
            try
            {
                TextWriter writer = new StreamWriter(fileName);
                XmlSerializer serializer = new XmlSerializer(typeof(TRKConfig));
                serializer.Serialize(writer, trkconfig);
                writer.Close();
                return true;
            }
            catch (Exception ex)
            {
                return ShowErrorMsg(ex.Message);
            }
        }

        public TRKConfig ReadTRKConfig(string path)
        {
            string fileName = string.Format(@"{0}\TRKConfig.ini", path);
            TRKConfig trkconfig = new TRKConfig();
            if (!File.Exists(fileName)) return trkconfig;
            try
            {
                Stream streamOut = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlSerializer serializer = new XmlSerializer(typeof(TRKConfig));
                trkconfig = (TRKConfig)serializer.Deserialize(streamOut);
                streamOut.Close();
                return trkconfig;
            }
            catch //(Exception ex)
            {
                //ShowErrorMsg(ex.Message);
                return trkconfig;
            }
        }

        public bool SaveTRKConfig2(string path, string fileName, TRKConfig cfg)
        {
            if (!Directory.Exists(path))
            {
                // Create the directory it does not exist.
                Directory.CreateDirectory(path);
            }
            return SaveTRKConfig2(path + @"\" + fileName, cfg);
        }

        public bool SaveTRKConfig2(string fileName, TRKConfig cfg)
        {
            if (cfg == null) return ShowErrorMsg("TRKConfig 객체가 생성되지 않았습니다.");
            try
            {
                TextWriter writer = new StreamWriter(fileName);
                XmlSerializer serializer = new XmlSerializer(typeof(TRKConfig));
                serializer.Serialize(writer, cfg);
                writer.Close();
                return true;
            }
            catch (Exception ex)
            {
                return ShowErrorMsg(ex.ToString());
            }
        }

        #endregion

        private bool ShowErrorMsg(string msg)
        {
            System.Windows.Forms.MessageBox.Show(msg, "저장오류"
                , System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            return false;
        }
    }

}
