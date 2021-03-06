﻿//------------------------------------------------------------------------------------------------
//
//
//         All rights reserved
//
//		   filename:Push_All_Mod
//		   desciption:
//
//		   created by 张潇 at 2015/8/28 14:13:03
//
//------------------------------------------------------------------------------------------------

using ComBCL.BdPush;

namespace ComBCL
{
    public class Push_All_Mod : Baidu_Mod
    {

        #region 属性
        /// <summary>
        ///  number 	否 	取值如下：0：消息；1：通知。默认为0 	消息类型
        /// </summary>
        public uint msg_type
        {
            get;
            set;
        }

        /// <summary>
        /// string 	是 	详情见消息/通知数据格式 	消息内容，json格式
        /// </summary>
        public string msg
        {
            get;
            set;
        }

        /// <summary>
        /// number 	否 	0~604800(86400*7)，默认为5小时(18000秒) 	相对于当前时间的消息过期时间，单位为秒
        /// </summary>
        public uint msg_expires
        {
            get;
            set;
        }

        /// <summary>
        /// number 	否 	取值为：1：开发状态；2：生产状态； 若不指定，则默认设置为生产状态。 	设置iOS应用的部署状态，仅iOS应用推送时使用
        /// </summary>
        public uint deploy_status
        {
            get;
            set;
        }

        /// <summary>
        /// number    否  指定的实际发送时间，必须在当前时间60s以外，1年以内 	定时推送，用于指定的实际发送时间
        /// </summary>
        public uint send_time
        {
            get;
            set;
        }
        #endregion

        #region 构造函数
        public Push_All_Mod(string apikey, string msg, uint msgExpires)
        {
            this.apikey = apikey;
            this.msg = msg;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.msg_type = 0;              //消息
            this.msg_expires = msgExpires;      //过期时间(一秒为单位)
            this.device_type = 3;           //安卓
            this.deploy_status = 2;         //生产状态
        }

        public Push_All_Mod(string apikey, string msg, uint msgType, uint msgExpires)
        {
            this.apikey = apikey;
            this.msg = msg;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.msg_type = msgType;       //消息类型
            this.msg_expires = msgExpires;      //过期时间(一秒为单位)
            this.device_type = 3;           //安卓
            this.deploy_status = 2;         //生产状态
        }
        #endregion

    }
}
