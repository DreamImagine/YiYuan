using System;

namespace YiYuan.Entity
{
	
	public class T_GoodsActivity 
	{
		
		public string ActivityId { get; set; }

		public DateTime CreateDatetime { get; set; }

		public DateTime EndDatetime { get; set; }

		public int Flag { get; set; }

		public string GoodsId { get; set; }

		public string ImgAddr { get; set; }

		public decimal LimitQty { get; set; }

		public string Memo { get; set; }

		public decimal Points { get; set; }

		public decimal Price { get; set; }

		public decimal Qty { get; set; }

		public string Scope { get; set; }

		public int SourceType { get; set; }

		public DateTime StartDatetime { get; set; }

		public bool Void { get; set; }
	}


	public class T_GoodsActivityGoods  
	{
		public string AGoodsId { get; set; }

		public DateTime CreateDatetime { get; set; }

		public int Flag { get; set; }

		public string GoodsId { get; set; }

		public int HotNumber { get; set; }

		public string ImgAddr { get; set; }

		public bool IsMpos { get; set; }

		public bool IsPublish { get; set; }

		public string KnockId { get; set; }

		public string Memo { get; set; }

		public decimal Price { get; set; }

		public decimal Qty { get; set; }

		public int Statue { get; set; }

		public decimal TotalPrice { get; set; }

		public bool Void { get; set; }
	}

	
	public class T_GoodsActivityIssue 
	{
		public string AGoodsId { get; set; }

		public int ClickNum { get; set; }

		public DateTime CreateDatetime { get; set; }

		public DateTime EndDatetime { get; set; }

		public int Flag { get; set; }

		public string IssueId { get; set; }

		public string IssueNo { get; set; }

		public int IssueStatue { get; set; }

		public DateTime LimitDatetime { get; set; }

		public decimal OpenBase { get; set; }

		public DateTime OpenDatetime { get; set; }

		public string PIssueNo { get; set; }

		public decimal Points { get; set; }

		public decimal SSCBase { get; set; }

		public DateTime SSCDatetime { get; set; }

		public string SSCNo { get; set; }

		public decimal SSCOpenNum { get; set; }

		public DateTime StartDatetime { get; set; }

		public decimal UsedNum { get; set; }

		public decimal UsedQty { get; set; }

		public bool Void { get; set; }

		public string WinNum { get; set; }
	}


	public class T_GoodsActivityKnock 
	{
		public int AgentNumber { get; set; }

		public DateTime CreateDatetime { get; set; }

		public string ImgAddr { get; set; }

		public bool IsPublish { get; set; }

		public string KnockId { get; set; }

		public string KnockName { get; set; }

		public int KnockStatue { get; set; }

		public int KnockType { get; set; }

		public string Memo { get; set; }

		public string SellerId { get; set; }

		public bool Void { get; set; }
	}


	public class T_GoodsActivityOrder 
	{
		public DateTime CreateDatetime { get; set; }

		public int IsBrowse { get; set; }

		public bool IsPay { get; set; }

		public string IssueId { get; set; }

		public bool IsVerify { get; set; }

		public string MainOrderId { get; set; }

		public DateTime OrderDatetime { get; set; }

		public string OrderId { get; set; }

		public string OrderNum { get; set; }

		public DateTime PayDatetime { get; set; }

		public int PayLimit { get; set; }

		public decimal PayPrice { get; set; }

		public decimal Price { get; set; }

		public decimal Qty { get; set; }

		public string UserAddr { get; set; }

		public int UserDetailsId { get; set; }

		public long UserId { get; set; }

		public string UserIP { get; set; }

		public DateTime VerifyDatetime { get; set; }

		public string VerifyUser { get; set; }

		public bool Void { get; set; }
	}

	//[Serializable]
	public class T_GoodsActivityOrderDetail 
	{
		public DateTime CreateDatetime { get; set; }

		public bool IsWin { get; set; }

		public string OrderDetailId { get; set; }

		public string OrderId { get; set; }

		public string OrderNum { get; set; }

		public bool Void { get; set; }
	}

	//[Serializable]
	public class T_GoodsActivityOrderMain 
	{
		public int BuyNoticeCount { get; set; }

		public DateTime BuyNoticeDatetime { get; set; }

		public string BuyNoticeRemarks { get; set; }

		public int BuyNoticeState { get; set; }

		public DateTime CreateDatetime { get; set; }

		public string MainOrderId { get; set; }

		public decimal MposCommission { get; set; }

		public bool MposIsPrint { get; set; }

		public string OrderPayType { get; set; }

		public long OrderStatus { get; set; }

		public DateTime PayNoticeDatetime { get; set; }

		public string PayNumber { get; set; }

		public string SellerMobile { get; set; }

		public decimal TotalPrice { get; set; }

		public DateTime UpdateDatetime { get; set; }

		public long UserId { get; set; }
	}

	//[Serializable]
	public class T_GoodsActivityShopping 
	{
		public DateTime CreateDatetime { get; set; }

		public bool IsChecked { get; set; }

		public string IssueId { get; set; }

		public decimal Price { get; set; }

		public decimal Qty { get; set; }

		public string ShoppingAGoodsId { get; set; }

		public string ShoppingId { get; set; }

		public long ShoppingIssueStatue { get; set; }

		public long ShoppingTotalQty { get; set; }

		public long ShoppingUsedQty { get; set; }

		public DateTime UpdateDatetime { get; set; }

		public long UserId { get; set; }
	}

	//[Serializable]
	public class T_GoodsActivityWin
	{
		public string CDKEY { get; set; }

		public DateTime ConfirmAddressTime { get; set; }

		public decimal CostPrice { get; set; }

		public DateTime CreateDatetime { get; set; }

		public int FeeFlag { get; set; }

		public int IsBrowse { get; set; }

		public bool IsPushOverdueReminder { get; set; }

		public bool IsRecived { get; set; }

		public bool IsSend { get; set; }

		public string IssueId { get; set; }

		public bool IsVerify { get; set; }

		public string Mobile { get; set; }

		public string OrderId { get; set; }

		public DateTime RecivedDatetime { get; set; }

		public string RecivedUser { get; set; }

		public string SendAddr { get; set; }

		public DateTime SendDatetime { get; set; }

		public decimal SendFee { get; set; }

		public int SendStatus { get; set; }

		public string SerialNumber { get; set; }

		public long UserId { get; set; }

		public DateTime VerifyDatetime { get; set; }

		public string VerifyUser { get; set; }

		public bool Void { get; set; }

		public DateTime WinDatetime { get; set; }

		public string WinId { get; set; }

		public string WinNum { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_Address 
	{
		public string AdsId { get; set; }

		public int CityId { get; set; }

		public string Consignee { get; set; }

		public DateTime CreateDateTime { get; set; }

		public string DetailedAddress { get; set; }

		public bool IsFirst { get; set; }

		public int ProvinceId { get; set; }

		public int Region { get; set; }

		public string TelPhone { get; set; }

		public DateTime UpdateDateTime { get; set; }

		public string UserCarNum { get; set; }

		public long UserId { get; set; }

		public string Zipcode { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_DengJiDuiYingBiLv 
	{
		public double BiLv { get; set; }

		public DateTime CreateDatetime { get; set; }

		public decimal DengJiBeginMoney { get; set; }

		public int DengJiCode { get; set; }

		public decimal DengJiEndMoney { get; set; }

		public string DengJiName { get; set; }

		public int Id { get; set; }

		public string Remark { get; set; }

		public string TypeCode { get; set; }

		public DateTime UpdateDatetime { get; set; }

		public long UpdateUserId { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_DengJiDuiYingBiLv_Back 
	{
		public DateTime BackDatetime { get; set; }

		public long BackUserId { get; set; }

		public double BiLv { get; set; }

		public DateTime CreateDatetime { get; set; }

		public decimal DengJiBeginMoney { get; set; }

		public int DengJiCode { get; set; }

		public decimal DengJiEndMoney { get; set; }

		public string DengJiName { get; set; }

		public int Id { get; set; }

		public int OldId { get; set; }

		public string Remark { get; set; }

		public string TypeCode { get; set; }

		public DateTime UpdateDatetime { get; set; }

		public long UpdateUserId { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_FanXianMingXi
	{
		public string BeiYongRelatedNo { get; set; }

		public string BeiZhu { get; set; }

		public int FanXianBiaoShi { get; set; }

		public decimal FanXianBiLv { get; set; }

		public decimal FanXianMoney { get; set; }

		public string Memo { get; set; }

		public DateTime MingXiDateTime { get; set; }

		public string MxId { get; set; }

		public string OperatorType { get; set; }

		public string OperatorTypeName { get; set; }

		public long OperatorUserId { get; set; }

		public long OperatorUserName { get; set; }

		public string RelatedNo { get; set; }

		public long SiteId { get; set; }

		public long UserId { get; set; }

		public string UserName { get; set; }

		public decimal XiaoFeiMoney { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_FanYongZhanBi 
	{
		public DateTime CreateDatetime { get; set; }

		public int Id { get; set; }

		public string Remark { get; set; }

		public double SuperiorSuperiorZhanBi { get; set; }

		public double SuperiorZhanBi { get; set; }

		public string TypeCode { get; set; }

		public DateTime UpdateDatetime { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_Goods 
	{
		public string Agent { get; set; }

		public int AgentNumber { get; set; }

		public string AgentTele { get; set; }

		public string BarCode { get; set; }

		public string Color { get; set; }

		public DateTime CreateDatetime { get; set; }

		public int Flag { get; set; }

		public int GoodsClassification { get; set; }

		public string GoodsId { get; set; }

		public string GoodsName { get; set; }

		public string GoodsNo { get; set; }

		public string ImgAddr { get; set; }

		public string LogoAddr { get; set; }

		public string Memo { get; set; }

		public int OrderNum { get; set; }

		public decimal Points { get; set; }

		public decimal Price { get; set; }

		public decimal Qty { get; set; }

		public decimal Size { get; set; }

		public string Spec { get; set; }

		public string Supplier { get; set; }

		public string SupplierTele { get; set; }

		public string TypeId { get; set; }

		public bool Void { get; set; }

		public decimal Weight { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_GoodsImage 
	{
		public DateTime CreateDatetime { get; set; }

		public int Flag { get; set; }

		public string GoodsId { get; set; }

		public string ImageId { get; set; }

		public string ImgAddr { get; set; }

		public string ImgName { get; set; }

		public string ImgOrgName { get; set; }

		public string ImgType { get; set; }

		public bool IsDefault { get; set; }

		public string Memo { get; set; }

		public int OrderNum { get; set; }

		public bool Void { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_OpenIssueOrder 
	{
		public string Id { get; set; }

		public string IssueId { get; set; }

		public long Number { get; set; }

		public DateTime OrderDateTime { get; set; }

		public long UserId { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_QiangBaoNumber 
	{
		public DateTime CreateDatetime { get; set; }

		public string IssueId { get; set; }

		public string MainOrderId { get; set; }

		public long Number { get; set; }

		public DateTime NumberDatetime { get; set; }

		public string NumberId { get; set; }

		public string OrderDetailId { get; set; }

		public string OrderId { get; set; }

		public DateTime UpdateDatetime { get; set; }

		public long UserId { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_TiXian 
	{
		public string AccountName { get; set; }

		public string AccountNum { get; set; }

		public string AccountType { get; set; }

		public DateTime CreateDateTime { get; set; }

		public string Id { get; set; }

		public bool IsVerify { get; set; }

		public decimal ShiJiTiXianMoney { get; set; }

		public DateTime TiXianDatetime { get; set; }

		public decimal TiXianMoney { get; set; }

		public int TiXianStatus { get; set; }

		public long UserId { get; set; }

		public string UserName { get; set; }

		public DateTime VerifyDateTime { get; set; }

		public string VerifyUserId { get; set; }

		public string VerifyUserName { get; set; }

		public bool Void { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_TiXianAccount 
	{
		public string AccountName { get; set; }

		public string AccountNum { get; set; }

		public string AccountType { get; set; }

		public DateTime CreateDateTime { get; set; }

		public string Id { get; set; }

		public long UserId { get; set; }

		public string UserName { get; set; }

		public bool Void { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_UserShare 
	{
		public string Centent { get; set; }

		public DateTime CheckDateTime { get; set; }

		public int CheckStatus { get; set; }

		public long CheckUserId { get; set; }

		public DateTime CreateDateTime { get; set; }

		public long Id { get; set; }

		public string IssueId { get; set; }

		public long UserId { get; set; }

		public bool Void { get; set; }
	}

	//[Serializable]
	public class T_PLKQ_UserShareImage 
	{
		public DateTime CreateDateTime { get; set; }

		public string Id { get; set; }

		public string ImgUrl { get; set; }

		public long ShareId { get; set; }
	}

	//[Serializable]
	public class T_PLKQCA_RiHuiZong 
	{
		public string AgentName { get; set; }

		public int AgentNumber { get; set; }

		public int ChongZhiRenShu { get; set; }

		public decimal ChongZhiSum { get; set; }

		public DateTime CreateDatetime { get; set; }

		public DateTime Dateindex { get; set; }

		public int FangWenLiang { get; set; }

		public int FuFeiYongHuRenShu { get; set; }

		public int HuoYueRenShu { get; set; }

		public decimal QdRiBalance { get; set; }

		public decimal QdRiMoney { get; set; }

		public decimal QdRiYongJin { get; set; }

		public string RiGuid { get; set; }

		public string ShortName { get; set; }

		public decimal UpdateCount { get; set; }

		public DateTime UpdateDatetime { get; set; }

		public decimal XiaoFeiSum { get; set; }

		public int XinZengFuFeiYongHuRenShu { get; set; }

		public double YongJinBiLv { get; set; }

		public decimal YongJinMoney { get; set; }

		public int ZhongJiangRenShu { get; set; }

		public int ZhuCeRenShu { get; set; }
	}


}