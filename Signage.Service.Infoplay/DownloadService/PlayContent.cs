using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Signage.Service
{
    public class PlayContent
    {
        public string title { get; set; }
        public ContentType type { get; set; }
        public string content { get; set; }

    }

    public enum ContentType
    {
        Text = 1,
        File = 2

    }
    public static class PlayContentExtentions
    {
        public static List<PlayContent> GetPlayContentFromFile(this string fullFileName)
        {
            var content = File.ReadAllText(fullFileName);
            List<PlayContent> rc = new List<PlayContent>();
            //Regex r = new Regex(@"PT_SS.*?:(\d*)", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            Regex r = new Regex(@".*?playContent.*?=.*?({.+?})", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            //"playTime={\"PT_SS\":30}; alertMode={\"alertMode\":\"0402\"}; "
            MatchCollection mc = r.Matches(content);
            foreach (Match m in mc)
            {

                string str0 = m.Groups[0].Value;
                string str = m.Groups[1].Value;
                try
                {
                    PlayContent pc = JsonConvert.DeserializeObject<PlayContent>(str);
                    switch (pc.type)
                    {
                        case ContentType.File:

                            break;
                        default:
                            break;
                    }
                    rc.Add(pc);
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
            return rc;
        }


    }
}
