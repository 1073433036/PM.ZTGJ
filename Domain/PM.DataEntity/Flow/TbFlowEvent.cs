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
    /// 实体类TbFlowEvent。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TbFlowEvent")]
    [Serializable]
    public partial class TbFlowEvent : Entity
    {
        #region Model
		private int _id;
		private string _FormCode;
		private string _EventDescriptionName;
		private string _EventDescription;
		private string _EventDescriptionsql;

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
		/// 流程节点事件菜单编号
		/// </summary>
		[Field("FormCode")]
		public string FormCode
		{
			get{ return _FormCode; }
			set
			{
				this.OnPropertyValueChange("FormCode");
				this._FormCode = value;
			}
		}
		/// <summary>
		/// 流程节点事件名称
		/// </summary>
		[Field("EventDescriptionName")]
		public string EventDescriptionName
		{
			get{ return _EventDescriptionName; }
			set
			{
				this.OnPropertyValueChange("EventDescriptionName");
				this._EventDescriptionName = value;
			}
		}
		/// <summary>
		/// 流程事件执行条件描述
		/// </summary>
		[Field("EventDescription")]
		public string EventDescription
		{
			get{ return _EventDescription; }
			set
			{
				this.OnPropertyValueChange("EventDescription");
				this._EventDescription = value;
			}
		}
		/// <summary>
		/// 流程事件执行sql
		/// </summary>
		[Field("EventDescriptionsql")]
		public string EventDescriptionsql
		{
			get{ return _EventDescriptionsql; }
			set
			{
				this.OnPropertyValueChange("EventDescriptionsql");
				this._EventDescriptionsql = value;
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
				_.id,
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
				_.FormCode,
				_.EventDescriptionName,
				_.EventDescription,
				_.EventDescriptionsql,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._id,
				this._FormCode,
				this._EventDescriptionName,
				this._EventDescription,
				this._EventDescriptionsql,
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
			public readonly static Field All = new Field("*", "TbFlowEvent");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field id = new Field("id", "TbFlowEvent", "");
            /// <summary>
			/// 流程节点事件菜单编号
			/// </summary>
			public readonly static Field FormCode = new Field("FormCode", "TbFlowEvent", "流程节点事件菜单编号");
            /// <summary>
			/// 流程节点事件名称
			/// </summary>
			public readonly static Field EventDescriptionName = new Field("EventDescriptionName", "TbFlowEvent", "流程节点事件名称");
            /// <summary>
			/// 流程事件执行条件描述
			/// </summary>
			public readonly static Field EventDescription = new Field("EventDescription", "TbFlowEvent", "流程事件执行条件描述");
            /// <summary>
			/// 流程事件执行sql
			/// </summary>
			public readonly static Field EventDescriptionsql = new Field("EventDescriptionsql", "TbFlowEvent", "流程事件执行sql");
        }
        #endregion
	}
}