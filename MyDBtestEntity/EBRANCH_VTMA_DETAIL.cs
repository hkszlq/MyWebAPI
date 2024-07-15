

using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDBtestEntity
{
    /// <summary>
    /// EBRANCH_VTMA_DETAIL
    /// </summary>
    [Table("EBRANCH_VTMA_DETAIL", Schema = "VTM_HKGWKGPAN_DEV01")]
    public class EBRANCH_VTMA_DETAIL
    {
        /// <summary>
        /// planName应用 于文件补传，通过Distribution上传的计划ID  
        /// </summary>
        //[GrgFeelView.Util.HeaderIgnore]
        //public String planName;

        [NotMapped]
        [JsonIgnore]
        public string PlanId { get; set; }

        /// <summary>
        /// planName应用 于文件补传，通过Distribution上传的计划ID 
        /// <br/> = string.Concat(this.C_TLRHUBID, "_", this.C_VTMCID, "_", this.C_TRANDATE, "_", this.C_TRANTIME)
        /// </summary>
        [NotMapped]
        [JsonIgnore]
        public string PlanName
        {
            get
            {
                return string.Concat(this.C_TLRHUBID, "_", this.C_VTMCID, "_", this.C_TRANDATE, "_", this.C_TRANTIME);
            }
        }

        /// <summary>
        /// 该值是OK表示数据正确
        /// </summary>
        
        public String dataStatus = "OK";

        /// <summary>
        /// C_ID
        /// </summary>
        
        [Description("编号")]
        [Key, Column(Order = 1)]
        [JsonProperty(PropertyName = "id")]
        public String C_ID { get; set; }

        /// <summary>
        /// C_USERID
        /// </summary>
        [Description("用户编号")]
        [JsonProperty(PropertyName = "userId")]
        public String C_USERID { get; set; }

        /// <summary>
        /// C_TRANDATE
        /// </summary>
        [Description("交易时间")]
        [JsonProperty(PropertyName = "tranDate")]
        public String C_TRANDATE { get; set; }

        /// <summary>
        /// C_VTMARECORD
        /// </summary>
        [Description("vtma记录")]
        [JsonProperty(PropertyName = "vtmaRecord")]
        public String C_VTMARECORD { get; set; }

        /// <summary>
        /// C_SYSDATE
        /// </summary>
        [Description("系统时间")]
        [JsonProperty(PropertyName = "sysDate")]
        public String C_SYSDATE { get; set; }

        /// <summary>
        /// I_TXNSEQNBR
        /// </summary>
        [Description("交易序列号")]
        [JsonProperty(PropertyName = "txnSeqNbr")]
        public Decimal? I_TXNSEQNBR { get; set; }

        /// <summary>
        /// C_VTMCID
        /// </summary>
        [Description("端机编号")]
        [JsonProperty(PropertyName = "vtmcId")]
        public String C_VTMCID { get; set; }

        /// <summary>
        /// C_TXNSTATUS
        /// </summary>
        [Description("交易状态")]
        [JsonProperty(PropertyName = "txnStatus")]
        public String C_TXNSTATUS { get; set; }

        /// <summary>
        /// C_TXNTYPE
        /// </summary>
        [Description("交易类型")]
        [JsonProperty(PropertyName = "txntype")]
        public String C_TXNTYPE { get; set; }

        /// <summary>
        /// I_CASHINAMT
        /// </summary>
        [Description("存钞金额")]
        [JsonProperty(PropertyName = "cashInAmt")]
        public Decimal? I_CASHINAMT { get; set; }

        /// <summary>
        /// I_CASHOUTAMT
        /// </summary>
        [Description("出钞金额")]
        [JsonProperty(PropertyName = "cashOutAmt")]
        public Decimal? I_CASHOUTAMT { get; set; }

        /// <summary>
        /// I_CHKINAMT
        /// </summary>
        [Description("chkIn金额")]
        [JsonProperty(PropertyName = "chkInAmt")]
        public Decimal? I_CHKINAMT { get; set; }

        /// <summary>
        /// I_CHKOUTAMT
        /// </summary>
        [Description("chkOut金额")]
        [JsonProperty(PropertyName = "chkOutAmt")]
        public Decimal? I_CHKOUTAMT { get; set; }

        /// <summary>
        /// I_TXNAMT
        /// </summary>
        [Description("交易金额")]
        [JsonProperty(PropertyName = "txnAmt")]
        public Decimal? I_TXNAMT { get; set; }

        /// <summary>
        /// C_ACCTNBR
        /// </summary>
        [Description("账户编号")]
        [JsonProperty(PropertyName = "acctNbr")]
        public String C_ACCTNBR { get; set; }

        /// <summary>
        /// C_BRANCHID
        /// </summary>
        [Description("分行编号")]
        [JsonProperty(PropertyName = "branchId")]
        public String C_BRANCHID { get; set; }

        /// <summary>
        /// C_SUPERVISORID
        /// </summary>
        [Description("管理编号")]
        [JsonProperty(PropertyName = "supervisorId")]
        public String C_SUPERVISORID { get; set; }

        /// <summary>
        /// C_SYSTIME
        /// </summary>
        [Description("系统时间")]
        [JsonProperty(PropertyName = "sysTime")]
        public String C_SYSTIME { get; set; }

        /// <summary>
        /// C_CURRCODE
        /// </summary>
        [Description("币种编号")]
        [JsonProperty(PropertyName = "currCode")]
        public String C_CURRCODE { get; set; }

        /// <summary>
        /// C_TXNNAME
        /// </summary>
        [Description("交易名称")]
        [JsonProperty(PropertyName = "txnName")]
        public String C_TXNNAME { get; set; }

        /// <summary>
        /// C_WORKSTATIONID
        /// </summary>
        [Description("工作者编号")]
        [JsonProperty(PropertyName = "workstationId")]
        public String C_WORKSTATIONID { get; set; }

        /// <summary>
        /// C_TLRHUBID
        /// </summary>
        [Description("柜员编号")]
        [JsonProperty(PropertyName = "tlrhubId")]
        public String C_TLRHUBID { get; set; }

        /// <summary>
        /// I_TOTXNAMT
        /// </summary>
        [Description("交易金额")]
        [JsonProperty(PropertyName = "toTxnAmt")]
        public Decimal? I_TOTXNAMT { get; set; }

        /// <summary>
        /// C_TOCURRCODE
        /// </summary>
        [Description("入账币种编码")]
        [JsonProperty(PropertyName = "toCurrCode")]
        public String C_TOCURRCODE { get; set; }

        /// <summary>
        /// C_MNEMONIC
        /// </summary>
        [Description("mnemonic")]
        [JsonProperty(PropertyName = "mnemonic")]
        public String C_MNEMONIC { get; set; }

        /// <summary>
        /// I_TXNAMT1
        /// </summary>
        [Description("交易金额1")]
        [JsonProperty(PropertyName = "txnAmt1")]
        public Decimal? I_TXNAMT1 { get; set; }

        /// <summary>
        /// I_TXNAMT2
        /// </summary>
        [Description("交易金额2")]
        [JsonProperty(PropertyName = "txnAmt2")]
        public Decimal? I_TXNAMT2 { get; set; }

        /// <summary>
        /// I_TXNAMT3
        /// </summary>
        [Description("交易金额3")]
        [JsonProperty(PropertyName = "txnAmt3")]
        public Decimal? I_TXNAMT3 { get; set; }

        /// <summary>
        /// C_EFFECTIVEDATE
        /// </summary>
        [Description("effective Date")]
        [JsonProperty(PropertyName = "effectiveDate")]
        public String C_EFFECTIVEDATE { get; set; }

        /// <summary>
        /// C_GLACCTNBR
        /// </summary>
        [Description("glAcctNbr")]
        [JsonProperty(PropertyName = "glAcctNbr")]
        public String C_GLACCTNBR { get; set; }

        /// <summary>
        /// C_GLCOSTCENTER
        /// </summary>
        [Description("glCostCenter")]
        [JsonProperty(PropertyName = "glCostCenter")]
        public String C_GLCOSTCENTER { get; set; }

        /// <summary>
        /// C_TOACCTNBR
        /// </summary>
        [Description("入账账户编号")]
        [JsonProperty(PropertyName = "toAcctNbr")]
        public String C_TOACCTNBR { get; set; }

        /// <summary>
        /// C_FILENAME
        /// </summary>
        [Description("文件名称")]
        [JsonProperty(PropertyName = "fileName")]
        public String C_FILENAME { get; set; }

        /// <summary>
        /// C_TXNENDDATE
        /// </summary>
        [Description("交易结束时间")]
        [JsonProperty(PropertyName = "txnEndDate")]
        public String C_TXNENDDATE { get; set; }

        /// <summary>
        /// C_TRANTIME
        /// </summary>
        [Description("交易时间")]
        [JsonProperty(PropertyName = "tranTime")]
        public String C_TRANTIME { get; set; }

        /// <summary>
        /// C_HKID
        /// </summary>
        [Description("身份证编号")]
        [JsonProperty(PropertyName = "hkid")]
        public String C_HKID { get; set; }

        /// <summary>
        /// C_VTMAID
        /// </summary>
        [Description("VTMA ID")]
        [JsonProperty(PropertyName = "vtmaId")]
        public String C_VTMAID { get; set; }

        /// <summary>
        /// D_CREATETIME
        /// </summary>
        [Description("创建时间")]
        [JsonProperty(PropertyName = "createTime")]
        public String D_CREATETIME { get; set; }

        /// <summary>
        /// C_NARRATIVE
        /// </summary>
        [Description("narRative")]
        [JsonProperty(PropertyName = "narRative")]
        public String C_NARRATIVE { get; set; }

        /// <summary>
        /// C_REVERSAL
        /// </summary>
        [Description("reversal")]
        [JsonProperty(PropertyName = "reversal")]
        public String C_REVERSAL { get; set; }

        /// <summary>
        /// C_TIGHTNESS
        /// </summary>
        [Description("tightness")]
        [JsonProperty(PropertyName = "tightness")]
        public String C_TIGHTNESS { get; set; }

        [NotMapped]
        [JsonProperty(PropertyName = "fileStatus")]
        public string FileStatus { get; set; }

        [NotMapped]
        [JsonIgnore]
        public string FileId { get; set; }
    }
    /// <summary>
    /// vtma details用
    /// </summary>
    public class ebranchVtmaDetailModel
    {

        /// <summary>
        /// C_ID
        /// </summary>
        
        [Description("编号")]
        [Key, Column(Order = 1)]
        [JsonProperty(PropertyName = "id")]
        public String C_ID { get; set; }


        /// <summary>
        /// C_SYSDATE
        /// </summary>
        [Description("系统时间")]
        [JsonProperty(PropertyName = "sysDate")]
        public String C_SYSDATE { get; set; }

        /// <summary>
        /// C_VTMCID
        /// </summary>
        [Description("端机编号")]
        [JsonProperty(PropertyName = "vtmcId")]
        public String C_VTMCID { get; set; }

        /// <summary>
        /// I_TXNSEQNBR
        /// </summary>
        [Description("交易序列号")]
        [JsonProperty(PropertyName = "txnSeq")]
        public Decimal? I_TXNSEQNBR { get; set; }

        /// <summary>
        /// C_TXNSTATUS
        /// </summary>
        [Description("交易状态")]
        [JsonProperty(PropertyName = "txnStatus")]
        public String C_TXNSTATUS { get; set; }

        /// <summary>
        /// C_TXNTYPE
        /// </summary>
        [Description("交易类型")]
        [JsonProperty(PropertyName = "txntype")]
        public String C_TXNTYPE { get; set; }
        /// <summary>
        /// I_TXNAMT
        /// </summary>
        [Description("交易金额")]
        [JsonProperty(PropertyName = "txnAmt")]
        public Decimal? I_TXNAMT { get; set; }


        /// <summary>
        /// C_ACCTNBR
        /// </summary>
        [Description("账户编号")]
        [JsonProperty(PropertyName = "acctNbr")]
        public String C_ACCTNBR { get; set; }

        /// <summary>
        /// C_CURRCODE
        /// </summary>
        [Description("币种编号")]
        [JsonProperty(PropertyName = "currCode")]
        public String C_CURRCODE { get; set; }

        /// <summary>
        /// C_TXNNAME
        /// </summary>
        [Description("交易名称")]
        [JsonProperty(PropertyName = "txnName")]
        public String C_TXNNAME { get; set; }

        /// <summary>
        /// I_TOTXNAMT
        /// </summary>
        [Description("交易金额")]
        [JsonProperty(PropertyName = "toTxnAmt")]
        public Decimal? I_TOTXNAMT { get; set; }

        /// <summary>
        /// C_TOCURRCODE
        /// </summary>
        [Description("入账币种编码")]
        [JsonProperty(PropertyName = "toCurrCode")]
        public String C_TOCURRCODE { get; set; }

        /// <summary>
        /// C_TOACCTNBR
        /// </summary>
        [Description("入账账户编号")]
        [JsonProperty(PropertyName = "toAcctNbr")]
        public String C_TOACCTNBR { get; set; }
        /// <summary>
        /// C_REVERSAL
        /// </summary>
        [Description("reversal")]
        [JsonProperty(PropertyName = "reversal")]
        public String C_REVERSAL { get; set; }
        /// <summary>
        /// C_HKID
        /// </summary>
        [Description("身份证编号")]
        [JsonProperty(PropertyName = "hkid")]
        public String C_HKID { get; set; }

        /// <summary>
        /// C_HKID
        /// </summary>
        [Description("密码")]
        [JsonProperty(PropertyName = "pin")]
        public String PIN { get; set; }

    }
}