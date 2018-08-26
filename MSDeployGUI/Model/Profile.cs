using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MSDeployGUI.Model
{
    public class Profile
    {
        public string Name { get; set; }
        public string Server { get; set; }
        public string SiteName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DestinationURL { get; set; }

        public static Profile LoadProfile(string ProfileFilePath)
        {
            try
            {
                XDocument doc = XDocument.Load(ProfileFilePath);
                using (var reader = doc.CreateReader())
                {
                    var serializer = new DataContractSerializer(typeof(Profile));
                    Profile p = (Profile)serializer.ReadObject(reader);
                    return p;
                }
            }
            catch (Exception )
            {
                throw;
            }
        }

        public void SaveProfile(string BaseDirectory)
        {
            try
            {
                var ProfilePath = CreateProfilePathIfNecessary(BaseDirectory);
                XDocument doc = new XDocument();
                using (var writer = doc.CreateWriter())
                {
                    var serializer = new DataContractSerializer(this.GetType());
                    serializer.WriteObject(writer, this);
                }

                var cleanFileName = this.Name.Replace(" ", "");
                File.WriteAllText(Path.Combine(ProfilePath, cleanFileName + ".xml"), doc.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }

        private string CreateProfilePathIfNecessary(string BaseDirectory)
        {
            string ProfilePath = Path.Combine(BaseDirectory, "Profiles");
            DirectoryInfo di = System.IO.Directory.CreateDirectory(ProfilePath);
            return di.FullName;
        }
    }
}