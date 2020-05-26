﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
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
    /// 人员费用核算明细
    /// </summary>
    [Table("TbUserCostItem")]
    [Serializable]
    public partial class TbUserCostItem : Entity
    {
        #region Model
		private int _ID;
		private string _CheckCode;
		private string _MachinType;
		private int _MachinNumber;
		private decimal _Days;
		private decimal _Price;
		private decimal _TotalPrice;

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
		[Field("CheckCode")]
		public string CheckCode
		{
			get{ return _CheckCode; }
			set
			{
				this.OnPropertyValueChange("CheckCode");
				this._CheckCode = value;
			}
		}
		/// <summary>
		/// 加工种类
		/// </summary>
		[Field("MachinType")]
		public string MachinType
		{
			get{ return _MachinType; }
			set
			{
				this.OnPropertyValueChange("MachinType");
				this._MachinType = value;
			}
		}
		/// <summary>
		/// 加工人数
		/// </summary>
		[Field("MachinNumber")]
		public int MachinNumber
		{
			get{ return _MachinNumber; }
			set
			{
				this.OnPropertyValueChange("MachinNumber");
				this._MachinNumber = value;
			}
		}
		/// <summary>
		/// 天数
		/// </summary>
		[Field("Days")]
		public decimal Days
		{
			get{ return _Days; }
			set
			{
				this.OnPropertyValueChange("Days");
				this._Days = value;
			}
		}
		/// <summary>
		/// 单价
		/// </summary>
		[Field("Price")]
		public decimal Price
		{
			get{ return _Price; }
			set
			{
				this.OnPropertyValueChange("Price");
				this._Price = value;
			}
		}
		/// <summary>
		/// 总价
		/// </summary>
		[Field("TotalPrice")]
		public decimal TotalPrice
		{
			get{ return _TotalPrice; }
			set
			{
				this.OnPropertyValueChange("TotalPrice");
				this._TotalPrice = value;
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
				_.CheckCode,
				_.MachinType,
				_.MachinNumber,
				_.Days,
				_.Price,
				_.TotalPrice,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._CheckCode,
				this._MachinType,
				this._MachinNumber,
				this._Days,
				this._Price,
				this._TotalPrice,
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
			public readonly static Field All = new Field("*", "TbUserCostItem");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TbUserCostItem", "ID");
            /// <summary>
			/// 核算编号
			/// </summary>
			public readonly static Field CheckCode = new Field("CheckCode", "TbUserCostItem", "核算编号");
            /// <summary>
			/// 加工种类
			/// </summary>
			public readonly static Field MachinType = new Field("MachinType", "TbUserCostItem", "加工种类");
            /// <summary>
			/// 加工人数
			/// </summary>
			public readonly static Field MachinNumber = new Field("MachinNumber", "TbUserCostItem", "加工人数");
            /// <summary>
			/// 天数
			/// </summary>
			public readonly static Field Days = new Field("Days", "TbUserCostItem", "天数");
            /// <summary>
			/// 单价
			/// </summary>
			public readonly static Field Price = new Field("Price", "TbUserCostItem", "单价");
            /// <summary>
			/// 总价
			/// </summary>
			public readonly static Field TotalPrice = new Field("TotalPrice", "TbUserCostItem", "总价");
        }
        #endregion
	}
}