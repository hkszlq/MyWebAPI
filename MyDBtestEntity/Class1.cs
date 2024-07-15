using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Newtonsoft.Json;

namespace MyDBtestEntity
{
    [Table("VTM_TELLER_LOGIN_LOG", Schema = "VTM_HKGWKGPAN_DEV01")]
    public class VTM_TELLER_LOGIN_LOG
    {
        /// <summary>
        /// C_ID
        /// </summary>
        
        [Key, Column(Order = 1)]
        [Description("编号")]
        [JsonProperty(PropertyName = "id")]
        public String C_ID { get; set; }

        /// <summary>
        /// TELLER_ID
        /// </summary>
        [Description("柜员ID")]
        [JsonProperty(PropertyName = "TellerId")]
        public String TELLER_ID { get; set; }

        /// <summary>
        /// VTMA_ID
        /// </summary>
        [Description("vtmaId")]
        [JsonProperty(PropertyName = "vtmaId")]
        public String VTMA_ID { get; set; }

        /// <summary>
        /// USER_ID
        /// </summary>
        [Description("用户Id")]
        [JsonProperty(PropertyName = "userId")]
        public String USER_ID { get; set; }

        /// <summary>
        /// LOGIN_DATE
        /// </summary>
        [Description("登入日期")]
        [JsonProperty(PropertyName = "loginDate")]
        public DateTime? LOGIN_DATE { get; set; }

        /// <summary>
        /// LOGOUT_DATE
        /// </summary>
        [Description("登出日期")]
        [JsonProperty(PropertyName = "logoutDate")]
        public DateTime? LOGOUT_DATE { get; set; }

        /// <summary>
        /// STATE
        /// </summary>
        
        [Description("状态")]
        [JsonProperty(PropertyName = "state")]
        public String STATE { get; set; }

        /// <summary>
        /// DESCRIPTION
        /// </summary>
        [Description("描述")]
        [JsonProperty(PropertyName = "description")]
        public String DESCRIPTION { get; set; }
    }
    public class Class1
    {
    }
}
