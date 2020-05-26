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
    /// 实体类TbFlowCode。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TbFlowCode")]
    [Serializable]
    public partial class TbFlowCode : Entity
    {
        #region Model
		private int _id;
		private string _CodeType;
		private string _CodePrefix;
		private int _CodeValue;
		private string _CodeDetail;

		/// <summary>
		/// 
		/// </summary>
		[Field("id")]
		public int id
		{
			get{ return _id; }
			set
			{
				this.OnPropertyValueChange("id");
				this._id = value;
			}
		}
		/// <summary>
		/// 代码类型
		/// </summary>
		[Field("CodeType")]
		public string CodeType
		{
			get{ return _CodeType; }
			set
			{
				this.OnPropertyValueChange("CodeType");
				this._CodeType = value;
			}
		}
		/// <summary>
		/// 代码前缀
		/// </summary>
		[Field("CodePrefix")]
		public string CodePrefix
		{
			get{ return _CodePrefix; }
			set
			{
				this.OnPropertyValueChange("CodePrefix");
				this._CodePrefix = value;
			}
		}
		/// <summary>
		/// 代码值
		/// </summary>
		[Field("CodeValue")]
		public int CodeValue
		{
			get{ return _CodeValue; }
			set
			{
				this.OnPropertyValueChange("CodeValue");
				this._CodeValue = value;
			}
		}
		/// <summary>
		/// 代码说明
		/// </summary>
		[Field("CodeDetail")]
		public string CodeDetail
		{
			get{ return _CodeDetail; }
			set
			{
				this.OnPropertyValueChange("CodeDetail");
				this._CodeDetail = value;
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
				_.CodeType,
			};
        }
		/// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.id;
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.id,
				_.CodeType,
				_.CodePrefix,
				_.CodeValue,
				_.CodeDetail,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._id,
				this._CodeType,
				this._CodePrefix,
				this._CodeValue,
				this._CodeDetail,
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
			public readonly static Field All = new Field("*", "TbFlowCode");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field id = new Field("id", "TbFlowCode", "");
            /// <summary>
			/// 代码类型
			/// </summary>
			public readonly static Field CodeType = new Field("CodeType", "TbFlowCode", "代码类型");
            /// <summary>
			/// 代码前缀
			/// </summary>
			public readonly static Field CodePrefix = new Field("CodePrefix", "TbFlowCode", "代码前缀");
            /// <summary>
			/// 代码值
			/// </summary>
			public readonly static Field CodeValue = new Field("CodeValue", "TbFlowCode", "代码值");
            /// <summary>
			/// 代码说明
			/// </summary>
			public readonly static Field CodeDetail = new Field("CodeDetail", "TbFlowCode", "代码说明");
        }
        #endregion
	}
}