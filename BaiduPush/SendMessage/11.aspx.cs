using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseHelper;
using ComBCL.BdPush;

namespace BaiduPush.SendMessage
{
    public partial class _11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string apikKey = PubSql.ApiKey;
            string secretKey = PubSql.SecretKey;
            string channel_id = PubSql.ChannelId;


            Push_Single_Device_Mod psdm = new Push_Single_Device_Mod(apikKey, channel_id, "{\"title\":\"胶圈体育总局通知：\",\"description\":\"老荣膝盖酸痛退役！\"}",1);
            Push_Single_Device psd = new Push_Single_Device(secretKey, psdm);
            string result = psd.PushMessage();
            Response.Write(result);
        }
    }
}