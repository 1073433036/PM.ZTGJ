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
    /// 实体类TbFlowPerformMessage。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TbFlowPerformMessage")]
    [Serializable]
    public partial class TbFlowPerformMessage : Entity
    {
        #region Model
		private int _id;
		private string _messageID;
		private DateTime _messageCreateTime;
		private int _messageType;
		private string _messageTitle;
		private string _messageContent;
		private string _FlowPerformID;
		private string _FlowNodeCode;
		private int? _IsRead;
		private DateTime? _ReadTime;
		private string _UserCode;
		private string _ProjectId;
		private string _MenuCode;
		private string _EWFormDataCode;
		private string _MsgType;

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
		/// 
		/// </summary>
		[Field("messageID")]
		public string messageID
		{
			get{ return _messageID; }
			set
			{
				this.OnPropertyValueChange("messageID");
				this._messageID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("messageCreateTime")]
		public DateTime messageCreateTime
		{
			get{ return _messageCreateTime; }
			set
			{
				this.OnPropertyValueChange("messageCreateTime");
				this._messageCreateTime = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("messageType")]
		public int messageType
		{
			get{ return _messageType; }
			set
			{
				this.OnPropertyValueChange("messageType");
				this._messageType = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("messageTitle")]
		public string messageTitle
		{
			get{ return _messageTitle; }
			set
			{
				this.OnPropertyValueChange("messageTitle");
				this._messageTitle = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("messageContent")]
		public string messageContent
		{
			get{ return _messageContent; }
			set
			{
				this.OnPropertyValueChange("messageContent");
				this._messageContent = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("FlowPerformID")]
		public string FlowPerformID
		{
			get{ return _FlowPerformID; }
			set
			{
				this.OnPropertyValueChange("FlowPerformID");
				this._FlowPerformID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("FlowNodeCode")]
		public string FlowNodeCode
		{
			get{ return _FlowNodeCode; }
			set
			{
				this.OnPropertyValueChange("FlowNodeCode");
				this._FlowNodeCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("IsRead")]
		public int? IsRead
		{
			get{ return _IsRead; }
			set
			{
				this.OnPropertyValueChange("IsRead");
				this._IsRead = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ReadTime")]
		public DateTime? ReadTime
		{
			get{ return _ReadTime; }
			set
			{
				this.OnPropertyValueChange("ReadTime");
				this._ReadTime = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("UserCode")]
		public string UserCode
		{
			get{ return _UserCode; }
			set
			{
				this.OnPropertyValueChange("UserCode");
				this._UserCode = value;
			}
		}
		/// <summary>
		/// 项目id
		/// </summary>
		[Field("ProjectId")]
		public string ProjectId
		{
			get{ return _ProjectId; }
			set
			{
				this.OnPropertyValueChange("ProjectId");
				this._ProjectId = value;
			}
		}
		/// <summary>
		/// 菜单编号
		/// </summary>
		[Field("MenuCode")]
		public string MenuCode
		{
			get{ return _MenuCode; }
			set
			{
				this.OnPropertyValueChange("MenuCode");
				this._MenuCode = value;
			}
		}
		/// <summary>
		/// 数据编号
		/// </summary>
		[Field("EWFormDataCode")]
		public string EWFormDataCode
		{
			get{ return _EWFormDataCode; }
			set
			{
				this.OnPropertyValueChange("EWFormDataCode");
				this._EWFormDataCode = value;
			}
		}
		/// <summary>
		/// 消息类型
		/// </summary>
		[Field("MsgType")]
		public string MsgType
		{
			get{ return _MsgType; }
			set
			{
				this.OnPropertyValueChange("MsgType");
				this._MsgType = value;
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
				_.messageID,
				_.messageCreateTime,
				_.messageType,
				_.messageTitle,
				_.messageContent,
				_.FlowPerformID,
				_.FlowNodeCode,
				_.IsRead,
				_.ReadTime,
				_.UserCode,
				_.ProjectId,
				_.MenuCode,
				_.EWFormDataCode,
				_.MsgType,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._id,
				this._messageID,
				this._messageCreateTime,
				this._messageType,
				this._messageTitle,
				this._messageContent,
				this._FlowPerformID,
				this._FlowNodeCode,
				this._IsRead,
				this._ReadTime,
				this._UserCode,
				this._ProjectId,
				this._MenuCode,
				this._EWFormDataCode,
				this._MsgType,
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
			public readonly static Field All = new Field("*", "TbFlowPerformMessage");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field id = new Field("id", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field messageID = new Field("messageID", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field messageCreateTime = new Field("messageCreateTime", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field messageType = new Field("messageType", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field messageTitle = new Field("messageTitle", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field messageContent = new Field("messageContent", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FlowPerformID = new Field("FlowPerformID", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field FlowNodeCode = new Field("FlowNodeCode", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IsRead = new Field("IsRead", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ReadTime = new Field("ReadTime", "TbFlowPerformMessage", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UserCode = new Field("UserCode", "TbFlowPerformMessage", "");
            /// <summary>
			/// 项目id
			/// </summary>
			public readonly static Field ProjectId = new Field("ProjectId", "TbFlowPerformMessage", "项目id");
            /// <summary>
			/// 菜单编号
			/// </summary>
			public readonly static Field MenuCode = new Field("MenuCode", "TbFlowPerformMessage", "菜单编号");
            /// <summary>
			/// 数据编号
			/// </summary>
			public readonly static Field EWFormDataCode = new Field("EWFormDataCode", "TbFlowPerformMessage", "数据编号");
            /// <summary>
			/// 消息类型
			/// </summary>
			public readonly static Field MsgType = new Field("MsgType", "TbFlowPerformMessage", "消息类型");
        }
        #endregion
	}
}