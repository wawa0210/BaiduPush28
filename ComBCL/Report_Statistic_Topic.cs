﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComBCL.BdPush
{
    /// <summary>
    /// 作者：冼树华
    /// QQ：56472465
    /// 日期：20150-04-29
    /// 功能：统计当前应用下一个分类主题的消息数量
    /// 注：支持单播、批量单播。
    /// </summary>
    public class Report_Statistic_Topic : Baidu_Send
    {

        #region 构造函数
        public Report_Statistic_Topic(string secret_key, Baidu_Mod mod)
        {
            this.httpMehtod = Baidu_Helper.HTTP_POST;
            this.url = "http://api.tuisong.baidu.com/rest/3.0/" + Baidu_Helper.REPORT_STATISTIC_TOPIC;
            this.secret_key = secret_key;
            this.mod = mod;
        }
        public Report_Statistic_Topic(string httpMehtod, string secret_key, Baidu_Mod mod)
        {
            this.httpMehtod = httpMehtod;
            this.url = "http://api.tuisong.baidu.com/rest/3.0/" + Baidu_Helper.REPORT_STATISTIC_TOPIC;
            this.secret_key = secret_key;
            this.mod = mod;
        }
        #endregion

        #region 重写PushMessage方法
        public override string PushMessage()
        {
            string strResult = "";

            //1.创建异步任务
            Task<string> task = Baidu_Helper.SendBaidu(this.httpMehtod, this.url, this.secret_key, this.mod);

            //2.等待任务完成
            task.Wait();

            //3.异步任务完成
            if (task.IsCompleted)
            {
                strResult = task.Result.ToString();
            }

            return strResult;
        }
        #endregion

    }
}
