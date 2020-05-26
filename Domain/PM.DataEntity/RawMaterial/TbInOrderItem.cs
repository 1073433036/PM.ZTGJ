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
    /// 入库单明细
    /// </summary>
    [Table("TbInOrderItem")]
    [Serializable]
    public partial class TbInOrderItem : Entity
    {
        #region Model
		private int _ID;
		private string _InOrderCode;
		private string _MaterialCode;
		private string _MaterialName;
		private string _SpecificationModel;
		private string _MeasurementUnit;
		private decimal? _PassCount;
		private string _Factory;
		private string _BatchNumber;
		private string _TestReportNo;
		private string _SupplierCode;
		private int? _StockRecordId;
		private decimal? _DeductionCount;
		private int? _ChackState;
		private string _ItemId;
		private DateTime? _ReturnTime;
		private decimal? _NoPass;
		private string _NoPassReason;
		private int? _BatchPlanItemId;
		private string _BatchPlanItemNewCode;

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
		/// 入库单号
		/// </summary>
		[Field("InOrderCode")]
		public string InOrderCode
		{
			get{ return _InOrderCode; }
			set
			{
				this.OnPropertyValueChange("InOrderCode");
				this._InOrderCode = value;
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
		/// 规格
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
		/// 合格数量
		/// </summary>
		[Field("PassCount")]
		public decimal? PassCount
		{
			get{ return _PassCount; }
			set
			{
				this.OnPropertyValueChange("PassCount");
				this._PassCount = value;
			}
		}
		/// <summary>
		/// 厂家
		/// </summary>
		[Field("Factory")]
		public string Factory
		{
			get{ return _Factory; }
			set
			{
				this.OnPropertyValueChange("Factory");
				this._Factory = value;
			}
		}
		/// <summary>
		/// 批号
		/// </summary>
		[Field("BatchNumber")]
		public string BatchNumber
		{
			get{ return _BatchNumber; }
			set
			{
				this.OnPropertyValueChange("BatchNumber");
				this._BatchNumber = value;
			}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		[Field("SupplierCode")]
		public string SupplierCode
		{
			get{ return _SupplierCode; }
			set
			{
				this.OnPropertyValueChange("SupplierCode");
				this._SupplierCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("StockRecordId")]
		public int? StockRecordId
		{
			get{ return _StockRecordId; }
			set
			{
				this.OnPropertyValueChange("StockRecordId");
				this._StockRecordId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("DeductionCount")]
		public decimal? DeductionCount
		{
			get{ return _DeductionCount; }
			set
			{
				this.OnPropertyValueChange("DeductionCount");
				this._DeductionCount = value;
			}
		}
		/// <summary>
		/// 检测结果（0未检测 1合格 2不合格）
		/// </summary>
		[Field("ChackState")]
		public int? ChackState
		{
			get{ return _ChackState; }
			set
			{
				this.OnPropertyValueChange("ChackState");
				this._ChackState = value;
			}
		}
		/// <summary>
		/// 入库单明细Id
		/// </summary>
		[Field("ItemId")]
		public string ItemId
		{
			get{ return _ItemId; }
			set
			{
				this.OnPropertyValueChange("ItemId");
				this._ItemId = value;
			}
		}
		/// <summary>
		/// 退回时间
		/// </summary>
		[Field("ReturnTime")]
		public DateTime? ReturnTime
		{
			get{ return _ReturnTime; }
			set
			{
				this.OnPropertyValueChange("ReturnTime");
				this._ReturnTime = value;
			}
		}
		/// <summary>
		/// 不合格数量
		/// </summary>
		[Field("NoPass")]
		public decimal? NoPass
		{
			get{ return _NoPass; }
			set
			{
				this.OnPropertyValueChange("NoPass");
				this._NoPass = value;
			}
		}
		/// <summary>
		/// 不合格原因
		/// </summary>
		[Field("NoPassReason")]
		public string NoPassReason
		{
			get{ return _NoPassReason; }
			set
			{
				this.OnPropertyValueChange("NoPassReason");
				this._NoPassReason = value;
			}
		}
		/// <summary>
		/// 批次计划明细Id
		/// </summary>
		[Field("BatchPlanItemId")]
		public int? BatchPlanItemId
		{
			get{ return _BatchPlanItemId; }
			set
			{
				this.OnPropertyValueChange("BatchPlanItemId");
				this._BatchPlanItemId = value;
			}
		}
		/// <summary>
		/// 供货历史记录编号
		/// </summary>
		[Field("BatchPlanItemNewCode")]
		public string BatchPlanItemNewCode
		{
			get{ return _BatchPlanItemNewCode; }
			set
			{
				this.OnPropertyValueChange("BatchPlanItemNewCode");
				this._BatchPlanItemNewCode = value;
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
				_.InOrderCode,
				_.MaterialCode,
				_.MaterialName,
				_.SpecificationModel,
				_.MeasurementUnit,
				_.PassCount,
				_.Factory,
				_.BatchNumber,
				_.TestReportNo,
				_.SupplierCode,
				_.StockRecordId,
				_.DeductionCount,
				_.ChackState,
				_.ItemId,
				_.ReturnTime,
				_.NoPass,
				_.NoPassReason,
				_.BatchPlanItemId,
				_.BatchPlanItemNewCode,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._InOrderCode,
				this._MaterialCode,
				this._MaterialName,
				this._SpecificationModel,
				this._MeasurementUnit,
				this._PassCount,
				this._Factory,
				this._BatchNumber,
				this._TestReportNo,
				this._SupplierCode,
				this._StockRecordId,
				this._DeductionCount,
				this._ChackState,
				this._ItemId,
				this._ReturnTime,
				this._NoPass,
				this._NoPassReason,
				this._BatchPlanItemId,
				this._BatchPlanItemNewCode,
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
			public readonly static Field All = new Field("*", "TbInOrderItem");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TbInOrderItem", "ID");
            /// <summary>
			/// 入库单号
			/// </summary>
			public readonly static Field InOrderCode = new Field("InOrderCode", "TbInOrderItem", "入库单号");
            /// <summary>
			/// 原材料编号
			/// </summary>
			public readonly static Field MaterialCode = new Field("MaterialCode", "TbInOrderItem", "原材料编号");
            /// <summary>
			/// 原材料名称
			/// </summary>
			public readonly static Field MaterialName = new Field("MaterialName", "TbInOrderItem", "原材料名称");
            /// <summary>
			/// 规格
			/// </summary>
			public readonly static Field SpecificationModel = new Field("SpecificationModel", "TbInOrderItem", "规格");
            /// <summary>
			/// 计量单位
			/// </summary>
			public readonly static Field MeasurementUnit = new Field("MeasurementUnit", "TbInOrderItem", "计量单位");
            /// <summary>
			/// 合格数量
			/// </summary>
			public readonly static Field PassCount = new Field("PassCount", "TbInOrderItem", "合格数量");
            /// <summary>
			/// 厂家
			/// </summary>
			public readonly static Field Factory = new Field("Factory", "TbInOrderItem", "厂家");
            /// <summary>
			/// 批号
			/// </summary>
			public readonly static Field BatchNumber = new Field("BatchNumber", "TbInOrderItem", "批号");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TestReportNo = new Field("TestReportNo", "TbInOrderItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field SupplierCode = new Field("SupplierCode", "TbInOrderItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field StockRecordId = new Field("StockRecordId", "TbInOrderItem", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DeductionCount = new Field("DeductionCount", "TbInOrderItem", "");
            /// <summary>
			/// 检测结果（0未检测 1合格 2不合格）
			/// </summary>
			public readonly static Field ChackState = new Field("ChackState", "TbInOrderItem", "检测结果（0未检测 1合格 2不合格）");
            /// <summary>
			/// 入库单明细Id
			/// </summary>
			public readonly static Field ItemId = new Field("ItemId", "TbInOrderItem", "入库单明细Id");
            /// <summary>
			/// 退回时间
			/// </summary>
			public readonly static Field ReturnTime = new Field("ReturnTime", "TbInOrderItem", "退回时间");
            /// <summary>
			/// 不合格数量
			/// </summary>
			public readonly static Field NoPass = new Field("NoPass", "TbInOrderItem", "不合格数量");
            /// <summary>
			/// 不合格原因
			/// </summary>
			public readonly static Field NoPassReason = new Field("NoPassReason", "TbInOrderItem", "不合格原因");
            /// <summary>
			/// 批次计划明细Id
			/// </summary>
			public readonly static Field BatchPlanItemId = new Field("BatchPlanItemId", "TbInOrderItem", "批次计划明细Id");
            /// <summary>
			/// 供货历史记录编号
			/// </summary>
			public readonly static Field BatchPlanItemNewCode = new Field("BatchPlanItemNewCode", "TbInOrderItem", "供货历史记录编号");
        }
        #endregion
	}
}