using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseHelper;
using ComBCL.BdPush;
using Newtonsoft.Json;

namespace BaiduPush.SendMessage
{
    public partial class SendSingleDevice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Send_Click(object sender, EventArgs e)
        {
            string apikKey = PubSql.ApiKey;
            string secretKey = PubSql.SecretKey;
            string channel_id = PubSql.ChannelId;

            Notice_Android_Mod dam = new Notice_Android_Mod(txtTitle.Value, txtContent.Value);
            string json = JsonConvert.SerializeObject(dam);
            Push_Single_Device_Mod psdm = new Push_Single_Device_Mod(apikKey, channel_id, json, (int)Baidu_Helper.Message_Type.Notice, 1);

            Push_Single_Device psd = new Push_Single_Device(secretKey, psdm);
            txtResponse.Value = psd.PushMessage();
        }
    }
}