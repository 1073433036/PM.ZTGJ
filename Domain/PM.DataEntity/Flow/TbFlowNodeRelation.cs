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
    /// 实体类TbFlowNodeRelation。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TbFlowNodeRelation")]
    [Serializable]
    public partial class TbFlowNodeRelation : Entity
    {
        #region Model
		private int _id;
		private string _FlowCode;
		private string _ParentNodeCode;
		private string _ChildNodeCode;

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
		/// 流程代码
		/// </summary>
		[Field("FlowCode")]
		public string FlowCode
		{
			get{ return _FlowCode; }
			set
			{
				this.OnPropertyValueChange("FlowCode");
				this._FlowCode = value;
			}
		}
		/// <summary>
		/// 流程节点代码
		/// </summary>
		[Field("ParentNodeCode")]
		public string ParentNodeCode
		{
			get{ return _ParentNodeCode; }
			set
			{
				this.OnPropertyValueChange("ParentNodeCode");
				this._ParentNodeCode = value;
			}
		}
		/// <summary>
		/// 关联的节点代码
		/// </summary>
		[Field("ChildNodeCode")]
		public string ChildNodeCode
		{
			get{ return _ChildNodeCode; }
			set
			{
				this.OnPropertyValueChange("ChildNodeCode");
				this._ChildNodeCode = value;
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
				_.FlowCode,
				_.ParentNodeCode,
				_.ChildNodeCode,
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
				_.FlowCode,
				_.ParentNodeCode,
				_.ChildNodeCode,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._id,
				this._FlowCode,
				this._ParentNodeCode,
				this._ChildNodeCode,
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
			public readonly static Field All = new Field("*", "TbFlowNodeRelation");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field id = new Field("id", "TbFlowNodeRelation", "");
            /// <summary>
			/// 流程代码
			/// </summary>
			public readonly static Field FlowCode = new Field("FlowCode", "TbFlowNodeRelation", "流程代码");
            /// <summary>
			/// 流程节点代码
			/// </summary>
			public readonly static Field ParentNodeCode = new Field("ParentNodeCode", "TbFlowNodeRelation", "流程节点代码");
            /// <summary>
			/// 关联的节点代码
			/// </summary>
			public readonly static Field ChildNodeCode = new Field("ChildNodeCode", "TbFlowNodeRelation", "关联的节点代码");
        }
        #endregion
	}
}