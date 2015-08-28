using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseHelper;
using ComBCL;
using ComBCL.BdPush;
using Newtonsoft.Json;

namespace BaiduPush.SendMessage
{
    public partial class BrandCast : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Send_Click(object sender, EventArgs e)
        {
            string apikKey = PubSql.ApiKey;
            string secretKey = PubSql.SecretKey;

            Notice_Android_Mod dam = new Notice_Android_Mod(txtTitle.Value,txtContent.Value);
            string json = JsonConvert.SerializeObject(dam);
            Push_All_Mod pam = new Push_All_Mod(apikKey, json, (int)Baidu_Helper.Message_Type.Notice);
            Push_All pa = new Push_All(secretKey, pam);

            txtResponse.Value= pa.PushMessage();
        }
    }
}