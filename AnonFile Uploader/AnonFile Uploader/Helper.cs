using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonFile_Uploader
{
    class Helper
    {
        public static string ApiKey()
        {
            if (File.Exists(Application.StartupPath.ToString() + @"\Api.txt"))
            {

                string put = Application.StartupPath.ToString() + @"\Api.txt";
                FileStream stream = new FileStream(put, FileMode.Open);
                StreamReader reader = new StreamReader(stream);
                string ppr = reader.ReadToEnd();
                stream.Close();

                if (ppr.Length > 0)
                {
                    string url = "https://anonfile.com/api/upload?token=" + ppr;
                    return url;
                }

                else
                {
                    string url = "https://anonfile.com/api/upload";
                    return url;
                }
            }

            else
            {
                string url = "https://anonfile.com/api/upload";
                return url;
            }
        }


    }
}
