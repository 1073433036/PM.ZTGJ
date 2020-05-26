﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dos.ORM;

namespace PM.DataEntity
{
    /// <summary>
    /// 月成本核算收入表
    /// </summary>
    [Table("TbMonthCostHeSuanIncome")]
    [Serializable]
    public partial class TbMonthCostHeSuanIncome : Entity
    {
        #region Model
		private int _ID;
		private string _HeSuanCode;
		private decimal? _SteelWeight;
		private decimal? _SteelUnitPrice;
		private decimal? _SteelTotalPrice;
		private decimal? _GeGouZhongLiWeight;
		private decimal? _GeGouZhongLiUnitPrice;
		private decimal? _GeGouZhongLiTotalPrice;
		private decimal? _HSectionSteelWeight;
		private decimal? _HSectionSteelUnitPrice;
		private decimal? _HSectionSteelTotalPrice;
		private decimal? _AGrilleWeight;
		private decimal? _AGrilleUnitPrice;
		private decimal? _AGrilleTotalPrice;
		private decimal? _SumWeight;
		private decimal? _SumMoney;

		/// <summary>
		/// ID
		/// </summary>
		[Field("ID")]
		public int ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange("ID");
				this._ID = value;
			}
		}
		/// <summary>
		/// 核算编号
		/// </summary>
		[Field("HeSuanCode")]
		public string HeSuanCode
		{
			get{ return _HeSuanCode; }
			set
			{
				this.OnPropertyValueChange("HeSuanCode");
				this._HeSuanCode = value;
			}
		}
		/// <summary>
		/// 钢筋重量
		/// </summary>
		[Field("SteelWeight")]
		public decimal? SteelWeight
		{
			get{ return _SteelWeight; }
			set
			{
				this.OnPropertyValueChange("SteelWeight");
				this._SteelWeight = value;
			}
		}
		/// <summary>
		/// 钢筋单价
		/// </summary>
		[Field("SteelUnitPrice")]
		public decimal? SteelUnitPrice
		{
			get{ return _SteelUnitPrice; }
			set
			{
				this.OnPropertyValueChange("SteelUnitPrice");
				this._SteelUnitPrice = value;
			}
		}
		/// <summary>
		/// 钢筋总价
		/// </summary>
		[Field("SteelTotalPrice")]
		public decimal? SteelTotalPrice
		{
			get{ return _SteelTotalPrice; }
			set
			{
				this.OnPropertyValueChange("SteelTotalPrice");
				this._SteelTotalPrice = value;
			}
		}
		/// <summary>
		/// 格构柱中立柱重量
		/// </summary>
		[Field("GeGouZhongLiWeight")]
		public decimal? GeGouZhongLiWeight
		{
			get{ return _GeGouZhongLiWeight; }
			set
			{
				this.OnPropertyValueChange("GeGouZhongLiWeight");
				this._GeGouZhongLiWeight = value;
			}
		}
		/// <summary>
		/// 格构柱中立柱单价
		/// </summary>
		[Field("GeGouZhongLiUnitPrice")]
		public decimal? GeGouZhongLiUnitPrice
		{
			get{ return _GeGouZhongLiUnitPrice; }
			set
			{
				this.OnPropertyValueChange("GeGouZhongLiUnitPrice");
				this._GeGouZhongLiUnitPrice = value;
			}
		}
		/// <summary>
		/// 格构柱中立柱总价
		/// </summary>
		[Field("GeGouZhongLiTotalPrice")]
		public decimal? GeGouZhongLiTotalPrice
		{
			get{ return _GeGouZhongLiTotalPrice; }
			set
			{
				this.OnPropertyValueChange("GeGouZhongLiTotalPrice");
				this._GeGouZhongLiTotalPrice = value;
			}
		}
		/// <summary>
		/// H型钢重量
		/// </summary>
		[Field("HSectionSteelWeight")]
		public decimal? HSectionSteelWeight
		{
			get{ return _HSectionSteelWeight; }
			set
			{
				this.OnPropertyValueChange("HSectionSteelWeight");
				this._HSectionSteelWeight = value;
			}
		}
		/// <summary>
		/// H型钢单价
		/// </summary>
		[Field("HSectionSteelUnitPrice")]
		public decimal? HSectionSteelUnitPrice
		{
			get{ return _HSectionSteelUnitPrice; }
			set
			{
				this.OnPropertyValueChange("HSectionSteelUnitPrice");
				this._HSectionSteelUnitPrice = value;
			}
		}
		/// <summary>
		/// H型钢总价
		/// </summary>
		[Field("HSectionSteelTotalPrice")]
		public decimal? HSectionSteelTotalPrice
		{
			get{ return _HSectionSteelTotalPrice; }
			set
			{
				this.OnPropertyValueChange("HSectionSteelTotalPrice");
				this._HSectionSteelTotalPrice = value;
			}
		}
		/// <summary>
		/// 格栅重量
		/// </summary>
		[Field("AGrilleWeight")]
		public decimal? AGrilleWeight
		{
			get{ return _AGrilleWeight; }
			set
			{
				this.OnPropertyValueChange("AGrilleWeight");
				this._AGrilleWeight = value;
			}
		}
		/// <summary>
		/// 格栅单价
		/// </summary>
		[Field("AGrilleUnitPrice")]
		public decimal? AGrilleUnitPrice
		{
			get{ return _AGrilleUnitPrice; }
			set
			{
				this.OnPropertyValueChange("AGrilleUnitPrice");
				this._AGrilleUnitPrice = value;
			}
		}
		/// <summary>
		/// 格栅总价
		/// </summary>
		[Field("AGrilleTotalPrice")]
		public decimal? AGrilleTotalPrice
		{
			get{ return _AGrilleTotalPrice; }
			set
			{
				this.OnPropertyValueChange("AGrilleTotalPrice");
				this._AGrilleTotalPrice = value;
			}
		}
		/// <summary>
		/// 总重量
		/// </summary>
		[Field("SumWeight")]
		public decimal? SumWeight
		{
			get{ return _SumWeight; }
			set
			{
				this.OnPropertyValueChange("SumWeight");
				this._SumWeight = value;
			}
		}
		/// <summary>
		/// 总金额
		/// </summary>
		[Field("SumMoney")]
		public decimal? SumMoney
		{
			get{ return _SumMoney; }
			set
			{
				this.OnPropertyValueChange("SumMoney");
				this._SumMoney = value;
			}
		}
		#endregion

		#region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.ID,
			};
        }
		/// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.ID;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.HeSuanCode,
				_.SteelWeight,
				_.SteelUnitPrice,
				_.SteelTotalPrice,
				_.GeGouZhongLiWeight,
				_.GeGouZhongLiUnitPrice,
				_.GeGouZhongLiTotalPrice,
				_.HSectionSteelWeight,
				_.HSectionSteelUnitPrice,
				_.HSectionSteelTotalPrice,
				_.AGrilleWeight,
				_.AGrilleUnitPrice,
				_.AGrilleTotalPrice,
				_.SumWeight,
				_.SumMoney,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._HeSuanCode,
				this._SteelWeight,
				this._SteelUnitPrice,
				this._SteelTotalPrice,
				this._GeGouZhongLiWeight,
				this._GeGouZhongLiUnitPrice,
				this._GeGouZhongLiTotalPrice,
				this._HSectionSteelWeight,
				this._HSectionSteelUnitPrice,
				this._HSectionSteelTotalPrice,
				this._AGrilleWeight,
				this._AGrilleUnitPrice,
				this._AGrilleTotalPrice,
				this._SumWeight,
				this._SumMoney,
			};
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

		#region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*", "TbMonthCostHeSuanIncome");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TbMonthCostHeSuanIncome", "ID");
            /// <summary>
			/// 核算编号
			/// </summary>
			public readonly static Field HeSuanCode = new Field("HeSuanCode", "TbMonthCostHeSuanIncome", "核算编号");
            /// <summary>
			/// 钢筋重量
			/// </summary>
			public readonly static Field SteelWeight = new Field("SteelWeight", "TbMonthCostHeSuanIncome", "钢筋重量");
            /// <summary>
			/// 钢筋单价
			/// </summary>
			public readonly static Field SteelUnitPrice = new Field("SteelUnitPrice", "TbMonthCostHeSuanIncome", "钢筋单价");
            /// <summary>
			/// 钢筋总价
			/// </summary>
			public readonly static Field SteelTotalPrice = new Field("SteelTotalPrice", "TbMonthCostHeSuanIncome", "钢筋总价");
            /// <summary>
			/// 格构柱中立柱重量
			/// </summary>
			public readonly static Field GeGouZhongLiWeight = new Field("GeGouZhongLiWeight", "TbMonthCostHeSuanIncome", "格构柱中立柱重量");
            /// <summary>
			/// 格构柱中立柱单价
			/// </summary>
			public readonly static Field GeGouZhongLiUnitPrice = new Field("GeGouZhongLiUnitPrice", "TbMonthCostHeSuanIncome", "格构柱中立柱单价");
            /// <summary>
			/// 格构柱中立柱总价
			/// </summary>
			public readonly static Field GeGouZhongLiTotalPrice = new Field("GeGouZhongLiTotalPrice", "TbMonthCostHeSuanIncome", "格构柱中立柱总价");
            /// <summary>
			/// H型钢重量
			/// </summary>
			public readonly static Field HSectionSteelWeight = new Field("HSectionSteelWeight", "TbMonthCostHeSuanIncome", "H型钢重量");
            /// <summary>
			/// H型钢单价
			/// </summary>
			public readonly static Field HSectionSteelUnitPrice = new Field("HSectionSteelUnitPrice", "TbMonthCostHeSuanIncome", "H型钢单价");
            /// <summary>
			/// H型钢总价
			/// </summary>
			public readonly static Field HSectionSteelTotalPrice = new Field("HSectionSteelTotalPrice", "TbMonthCostHeSuanIncome", "H型钢总价");
            /// <summary>
			/// 格栅重量
			/// </summary>
			public readonly static Field AGrilleWeight = new Field("AGrilleWeight", "TbMonthCostHeSuanIncome", "格栅重量");
            /// <summary>
			/// 格栅单价
			/// </summary>
			public readonly static Field AGrilleUnitPrice = new Field("AGrilleUnitPrice", "TbMonthCostHeSuanIncome", "格栅单价");
            /// <summary>
			/// 格栅总价
			/// </summary>
			public readonly static Field AGrilleTotalPrice = new Field("AGrilleTotalPrice", "TbMonthCostHeSuanIncome", "格栅总价");
            /// <summary>
			/// 总重量
			/// </summary>
			public readonly static Field SumWeight = new Field("SumWeight", "TbMonthCostHeSuanIncome", "总重量");
            /// <summary>
			/// 总金额
			/// </summary>
			public readonly static Field SumMoney = new Field("SumMoney", "TbMonthCostHeSuanIncome", "总金额");
        }
        #endregion
	}
}