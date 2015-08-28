//------------------------------------------------------------------------------------------------
//
//
//         All rights reserved
//
//		   filename:PubSql
//		   desciption:
//
//		   created by 张潇 at 2015/8/28 10:04:46
//
//------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHelper
{
    public static class PubSql
    {
        public static readonly string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
        public static readonly string SecretKey = ConfigurationManager.AppSettings["SecretKey"];
        public static readonly string ChannelId = ConfigurationManager.AppSettings["ChannelId"];
        public static readonly string UserId = ConfigurationManager.AppSettings["UserId"];
    }
}
