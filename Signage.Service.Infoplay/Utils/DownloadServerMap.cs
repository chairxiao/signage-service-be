using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Signage.Service.Infoplay
{
    static public class DownloadServerMap
    {
        /// <summary>
        /// URI中主机映射表，添加URI到playerDownloads时查此表转换
        /// </summary>
        static private Dictionary<string, string> HostMaps = new Dictionary<string, string>();
        /// <summary>
        /// 读取配置文件
        /// </summary>
        static  DownloadServerMap()
        {
            string str = ConfigurationManager.AppSettings["DownloadServerMap"];
            string[] maps = str.Split(new char[] {'|' });
            foreach (var map in maps)
            {
                string[] servers = map.Split(new char[] { '=' });
                if (servers.Count() != 2) continue;
                string value;
                string key = servers[0];
                if (HostMaps.TryGetValue(key, out value))
                {
                    HostMaps[key] = servers[1];

                }
                else
                {
                    HostMaps.Add(servers[0], servers[1]);
                }
            }
        }
        static public void Add(string sourcePath, string destPath)
        {
            string str;
            if (HostMaps.TryGetValue(sourcePath, out str))
            {
                HostMaps[sourcePath] = destPath;
            }
            else
            {
                HostMaps.Add(sourcePath, destPath);
            }

        }
        static public void Remove(string sourcePath)
        {
            while (true)
            {
                if (!HostMaps.Remove(sourcePath)) break;
            }
        }
        static public void Clear()
        {
            HostMaps.Clear();
        }
        static public string DestUri(string uri)
        {
            foreach (var M in HostMaps)
            {
                if (uri.Contains(M.Key))
                {
                    return uri.Replace(M.Key, M.Value);
                }
            }
            return uri;
        }
    }
}
