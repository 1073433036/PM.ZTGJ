﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.36460
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
    /// 实体类TbSiteDischargeCargoDetail。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TbSiteDischargeCargoDetail")]
    [Serializable]
    public partial class TbSiteDischargeCargoDetail : Entity
    {
        #region Model
		private int _ID;
		private string _DischargeCargoCode;
		private string _MaterialCode;
		private string _MaterialName;
		private string _SpecificationModel;
		private string _MeasurementUnit;
		private decimal? _MeasurementUnitZl;
		private decimal? _ItemUseNum;
		private int _Number;
		private decimal? _WeightSmallPlan;
		private string _Manufactor;
		private string _HeatNo;
		private string _TestReportNo;
		private string _ComponentName;
		private string _OrderCode;
		private int? _DisEntOrderId;
		private int? _DisEntOrderItemId;
		private int? _XhPackCount;
		private int? _XhNumber;

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
		/// 卸货编号
		/// </summary>
		[Field("DischargeCargoCode")]
		public string DischargeCargoCode
		{
			get{ return _DischargeCargoCode; }
			set
			{
				this.OnPropertyValueChange("DischargeCargoCode");
				this._DischargeCargoCode = value;
			}
		}
		/// <summary>
		/// 原材料编号
		/// </summary>
		[Field("MaterialCode")]
		public string MaterialCode
		{
			get{ return _MaterialCode; }
			set
			{
				this.OnPropertyValueChange("MaterialCode");
				this._MaterialCode = value;
			}
		}
		/// <summary>
		/// 原材料名称
		/// </summary>
		[Field("MaterialName")]
		public string MaterialName
		{
			get{ return _MaterialName; }
			set
			{
				this.OnPropertyValueChange("MaterialName");
				this._MaterialName = value;
			}
		}
		/// <summary>
		/// 规格型号
		/// </summary>
		[Field("SpecificationModel")]
		public string SpecificationModel
		{
			get{ return _SpecificationModel; }
			set
			{
				this.OnPropertyValueChange("SpecificationModel");
				this._SpecificationModel = value;
			}
		}
		/// <summary>
		/// 计量单位
		/// </summary>
		[Field("MeasurementUnit")]
		public string MeasurementUnit
		{
			get{ return _MeasurementUnit; }
			set
			{
				this.OnPropertyValueChange("MeasurementUnit");
				this._MeasurementUnit = value;
			}
		}
		/// <summary>
		/// 单位重量
		/// </summary>
		[Field("MeasurementUnitZl")]
		public decimal? MeasurementUnitZl
		{
			get{ return _MeasurementUnitZl; }
			set
			{
				this.OnPropertyValueChange("MeasurementUnitZl");
				this._MeasurementUnitZl = value;
			}
		}
		/// <summary>
		/// 单件用量
		/// </summary>
		[Field("ItemUseNum")]
		public decimal? ItemUseNum
		{
			get{ return _ItemUseNum; }
			set
			{
				this.OnPropertyValueChange("ItemUseNum");
				this._ItemUseNum = value;
			}
		}
		/// <summary>
		/// 件数
		/// </summary>
		[Field("Number")]
		public int Number
		{
			get{ return _Number; }
			set
			{
				this.OnPropertyValueChange("Number");
				this._Number = value;
			}
		}
		/// <summary>
		/// 重量小计
		/// </summary>
		[Field("WeightSmallPlan")]
		public decimal? WeightSmallPlan
		{
			get{ return _WeightSmallPlan; }
			set
			{
				this.OnPropertyValueChange("WeightSmallPlan");
				this._WeightSmallPlan = value;
			}
		}
		/// <summary>
		/// 厂家
		/// </summary>
		[Field("Manufactor")]
		public string Manufactor
		{
			get{ return _Manufactor; }
			set
			{
				this.OnPropertyValueChange("Manufactor");
				this._Manufactor = value;
			}
		}
		/// <summary>
		/// 炉批号
		/// </summary>
		[Field("HeatNo")]
		public string HeatNo
		{
			get{ return _HeatNo; }
			set
			{
				this.OnPropertyValueChange("HeatNo");
				this._HeatNo = value;
			}
		}
		/// <summary>
		/// 检测报告编号
		/// </summary>
		[Field("TestReportNo")]
		public string TestReportNo
		{
			get{ return _TestReportNo; }
			set
			{
				this.OnPropertyValueChange("TestReportNo");
				this._TestReportNo = value;
			}
		}
		/// <summary>
		/// 构件名称
		/// </summary>
		[Field("ComponentName")]
		public string ComponentName
		{
			get{ return _ComponentName; }
			set
			{
				this.OnPropertyValueChange("ComponentName");
				this._ComponentName = value;
			}
		}
		/// <summary>
		/// 订单编号
		/// </summary>
		[Field("OrderCode")]
		public string OrderCode
		{
			get{ return _OrderCode; }
			set
			{
				this.OnPropertyValueChange("OrderCode");
				this._OrderCode = value;
			}
		}
		/// <summary>
		/// 配送装车订单信息Id
		/// </summary>
		[Field("DisEntOrderId")]
		public int? DisEntOrderId
		{
			get{ return _DisEntOrderId; }
			set
			{
				this.OnPropertyValueChange("DisEntOrderId");
				this._DisEntOrderId = value;
			}
		}
		/// <summary>
		/// 配送装车订单明细信息Id
		/// </summary>
		[Field("DisEntOrderItemId")]
		public int? DisEntOrderItemId
		{
			get{ return _DisEntOrderItemId; }
			set
			{
				this.OnPropertyValueChange("DisEntOrderItemId");
				this._DisEntOrderItemId = value;
			}
		}
		/// <summary>
		/// 卸货包数
		/// </summary>
		[Field("XhPackCount")]
		public int? XhPackCount
		{
			get{ return _XhPackCount; }
			set
			{
				this.OnPropertyValueChange("XhPackCount");
				this._XhPackCount = value;
			}
		}
		/// <summary>
		/// 卸货件数
		/// </summary>
		[Field("XhNumber")]
		public int? XhNumber
		{
			get{ return _XhNumber; }
			set
			{
				this.OnPropertyValueChange("XhNumber");
				this._XhNumber = value;
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
				_.DischargeCargoCode,
				_.MaterialCode,
				_.MaterialName,
				_.SpecificationModel,
				_.MeasurementUnit,
				_.MeasurementUnitZl,
				_.ItemUseNum,
				_.Number,
				_.WeightSmallPlan,
				_.Manufactor,
				_.HeatNo,
				_.TestReportNo,
				_.ComponentName,
				_.OrderCode,
				_.DisEntOrderId,
				_.DisEntOrderItemId,
				_.XhPackCount,
				_.XhNumber,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._DischargeCargoCode,
				this._MaterialCode,
				this._MaterialName,
				this._SpecificationModel,
				this._MeasurementUnit,
				this._MeasurementUnitZl,
				this._ItemUseNum,
				this._Number,
				this._WeightSmallPlan,
				this._Manufactor,
				this._HeatNo,
				this._TestReportNo,
				this._ComponentName,
				this._OrderCode,
				this._DisEntOrderId,
				this._DisEntOrderItemId,
				this._XhPackCount,
				this._XhNumber,
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
			public readonly static Field All = new Field("*", "TbSiteDischargeCargoDetail");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TbSiteDischargeCargoDetail", "ID");
            /// <summary>
			/// 卸货编号
			/// </summary>
			public readonly static Field DischargeCargoCode = new Field("DischargeCargoCode", "TbSiteDischargeCargoDetail", "卸货编号");
            /// <summary>
			/// 原材料编号
			/// </summary>
			public readonly static Field MaterialCode = new Field("MaterialCode", "TbSiteDischargeCargoDetail", "原材料编号");
            /// <summary>
			/// 原材料名称
			/// </summary>
			public readonly static Field MaterialName = new Field("MaterialName", "TbSiteDischargeCargoDetail", "原材料名称");
            /// <summary>
			/// 规格型号
			/// </summary>
			public readonly static Field SpecificationModel = new Field("SpecificationModel", "TbSiteDischargeCargoDetail", "规格型号");
            /// <summary>
			/// 计量单位
			/// </summary>
			public readonly static Field MeasurementUnit = new Field("MeasurementUnit", "TbSiteDischargeCargoDetail", "计量单位");
            /// <summary>
			/// 单位重量
			/// </summary>
			public readonly static Field MeasurementUnitZl = new Field("MeasurementUnitZl", "TbSiteDischargeCargoDetail", "单位重量");
            /// <summary>
			/// 单件用量
			/// </summary>
			public readonly static Field ItemUseNum = new Field("ItemUseNum", "TbSiteDischargeCargoDetail", "单件用量");
            /// <summary>
			/// 件数
			/// </summary>
			public readonly static Field Number = new Field("Number", "TbSiteDischargeCargoDetail", "件数");
            /// <summary>
			/// 重量小计
			/// </summary>
			public readonly static Field WeightSmallPlan = new Field("WeightSmallPlan", "TbSiteDischargeCargoDetail", "重量小计");
            /// <summary>
			/// 厂家
			/// </summary>
			public readonly static Field Manufactor = new Field("Manufactor", "TbSiteDischargeCargoDetail", "厂家");
            /// <summary>
			/// 炉批号
			/// </summary>
			public readonly static Field HeatNo = new Field("HeatNo", "TbSiteDischargeCargoDetail", "炉批号");
            /// <summary>
			/// 检测报告编号
			/// </summary>
			public readonly static Field TestReportNo = new Field("TestReportNo", "TbSiteDischargeCargoDetail", "检测报告编号");
            /// <summary>
			/// 构件名称
			/// </summary>
			public readonly static Field ComponentName = new Field("ComponentName", "TbSiteDischargeCargoDetail", "构件名称");
            /// <summary>
			/// 订单编号
			/// </summary>
			public readonly static Field OrderCode = new Field("OrderCode", "TbSiteDischargeCargoDetail", "订单编号");
            /// <summary>
			/// 配送装车订单信息Id
			/// </summary>
			public readonly static Field DisEntOrderId = new Field("DisEntOrderId", "TbSiteDischargeCargoDetail", "配送装车订单信息Id");
            /// <summary>
			/// 配送装车订单明细信息Id
			/// </summary>
			public readonly static Field DisEntOrderItemId = new Field("DisEntOrderItemId", "TbSiteDischargeCargoDetail", "配送装车订单明细信息Id");
            /// <summary>
			/// 卸货包数
			/// </summary>
			public readonly static Field XhPackCount = new Field("XhPackCount", "TbSiteDischargeCargoDetail", "卸货包数");
            /// <summary>
			/// 卸货件数
			/// </summary>
			public readonly static Field XhNumber = new Field("XhNumber", "TbSiteDischargeCargoDetail", "卸货件数");
        }
        #endregion
	}
}