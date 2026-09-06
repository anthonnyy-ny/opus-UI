using System.IO;
using System.Xml.Serialization;

namespace opusViewerPro.Config
{
    // 檔案位置由外部提供；讀寫 XML 的細節集中在這裡。
    public class ConfigStore
    {
        private readonly string _filePath;
        public ConfigStore(string filePath) { _filePath = filePath; }

        public InspectionConfig Load()
        {
            if (!File.Exists(_filePath)) return new InspectionConfig();
            using (var stream = File.OpenRead(_filePath))
            {
                var config = (InspectionConfig)new XmlSerializer(typeof(InspectionConfig)).Deserialize(stream);
                config.Validate();
                return config;
            }
        }

        public void Save(InspectionConfig config)
        {
            config.Validate();
            Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(_filePath)));
            using (var stream = File.Create(_filePath))
                new XmlSerializer(typeof(InspectionConfig)).Serialize(stream, config);
        }
    }
}
