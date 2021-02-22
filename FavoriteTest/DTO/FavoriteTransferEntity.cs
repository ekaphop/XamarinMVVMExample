using System;
using System.Collections.Generic;

namespace FavoriteTest.DTO
{
    public class FavoriteTransferEntity : BaseEntity
    {
        #region *** Properties section ***

        #region [ Public properties ]

        public int? AccID { get; set; }

        public string CustID { get; set; }

        public int? FavType { get; set; }

        public string BankCode { get; set; }

        public string AccNo { get; set; }

        public int? AccType { get; set; }

        public string AccNickName { get; set; }

        public string AccName { get; set; }

        public string Currency { get; set; }

        public string AccDetail { get; set; }

        public string OrgID { get; set; }

        public string BusinessID { get; set; }

        public int? TransferObjective { get; set; }

        public string TransferObjectiveOther { get; set; }

        public string FromName { get; set; }

        public string ToSMS { get; set; }

        public string ToEmail { get; set; }

        public string ToName { get; set; }

        public string ToAcc { get; set; }

        public string CountryCode { get; set; }

        public string OtherCountry { get; set; }

        public string ToBank { get; set; }

        public string BankAddress { get; set; }

        public string InterBankCode { get; set; }

        public string Memo { get; set; }

        public string ImgPath { get; set; }

        public int? Channel { get; set; }

        public int? Status { get; set; }

        public string IbanCode { get; set; }

        public string BankAbbr { get; set; }

        public string BankNameTH { get; set; }

        public string BankNameEN { get; set; }

        public bool? IsPromptPay { get; set; }

        public bool? IsFCD { get; set; }

        public byte[] ImgPathBytes { get; set; }
        #endregion

        #endregion

        #region Method

        //public string GetBankName(string language)
        //{
        //    string result = BankNameEN;

        //    try
        //    {
        //        if (language.GetValueOrDefault().Equals("en", StringComparison.OrdinalIgnoreCase))
        //            result = BankNameEN;
        //        else
        //            result = BankNameTH;
        //    }
        //    catch { }

        //    return result.GetValueOrDefault();
        //}

        #endregion
    }

    public class FavoriteTransferList : TotalRecords
    {
        public FavoriteTransferList()
        {
            FavoriteTransfer = new List<FavoriteTransferEntity>();
        }

        #region *** Properties section ***

        #region [ Public properties ]

        public List<FavoriteTransferEntity> FavoriteTransfer { get; set; }

        #endregion

        #endregion
    }
}
