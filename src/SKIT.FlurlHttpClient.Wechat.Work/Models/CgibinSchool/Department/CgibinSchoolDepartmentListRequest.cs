﻿namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/department/list 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolDepartmentListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定上级部门 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? ParentDepartmentId { get; set; }
    }
}
