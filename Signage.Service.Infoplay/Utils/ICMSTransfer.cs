using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Signage.Service.Infoplay
{
    public interface  ICMSTransfer
    {
        void Write(string content, string SaveFileName);
        void Write(Stream ms, string SaveFileName);
        Stream Writer(string SaveFileName);
    }
}
