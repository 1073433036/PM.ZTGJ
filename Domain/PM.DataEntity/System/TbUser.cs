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
    /// 实体类TbUser。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TbUser")]
    [Serializable]
    public partial class TbUser : Entity
    {
        #region Model
		private int _ID;
		private string _UserCode;
		private string _UserName;
		private string _UserPwd;
		private string _UserClosed;
		private string _UserSex;
		private string _IDNumber;
		private string _Birthday;
		private string _PoliticalLandscape;
		private string _MobilePhone;
		private string _Tell;
		private string _Email;
		private string _QQ;
		private string _WeChat;
		private string _RecruitmentSource;
		private string _PurchaseSocialSecurity;
		private string _TheLaborContract;
		private string _ConfidentialityContract;
		private string _CardNumber;
		private string _CardBankName;
		private string _CardBankAdd;
		private DateTime _CreateTime;
		private string _CreateUser;
		private string _CompanyCode;
		private string _UserId;
		private int? _UserType;

		/// <summary>
		/// 
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
		/// 
		/// </summary>
		[Field("UserName")]
		public string UserName
		{
			get{ return _UserName; }
			set
			{
				this.OnPropertyValueChange("UserName");
				this._UserName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("UserPwd")]
		public string UserPwd
		{
			get{ return _UserPwd; }
			set
			{
				this.OnPropertyValueChange("UserPwd");
				this._UserPwd = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("UserClosed")]
		public string UserClosed
		{
			get{ return _UserClosed; }
			set
			{
				this.OnPropertyValueChange("UserClosed");
				this._UserClosed = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("UserSex")]
		public string UserSex
		{
			get{ return _UserSex; }
			set
			{
				this.OnPropertyValueChange("UserSex");
				this._UserSex = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("IDNumber")]
		public string IDNumber
		{
			get{ return _IDNumber; }
			set
			{
				this.OnPropertyValueChange("IDNumber");
				this._IDNumber = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Birthday")]
		public string Birthday
		{
			get{ return _Birthday; }
			set
			{
				this.OnPropertyValueChange("Birthday");
				this._Birthday = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("PoliticalLandscape")]
		public string PoliticalLandscape
		{
			get{ return _PoliticalLandscape; }
			set
			{
				this.OnPropertyValueChange("PoliticalLandscape");
				this._PoliticalLandscape = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("MobilePhone")]
		public string MobilePhone
		{
			get{ return _MobilePhone; }
			set
			{
				this.OnPropertyValueChange("MobilePhone");
				this._MobilePhone = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Tell")]
		public string Tell
		{
			get{ return _Tell; }
			set
			{
				this.OnPropertyValueChange("Tell");
				this._Tell = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Email")]
		public string Email
		{
			get{ return _Email; }
			set
			{
				this.OnPropertyValueChange("Email");
				this._Email = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("QQ")]
		public string QQ
		{
			get{ return _QQ; }
			set
			{
				this.OnPropertyValueChange("QQ");
				this._QQ = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("WeChat")]
		public string WeChat
		{
			get{ return _WeChat; }
			set
			{
				this.OnPropertyValueChange("WeChat");
				this._WeChat = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("RecruitmentSource")]
		public string RecruitmentSource
		{
			get{ return _RecruitmentSource; }
			set
			{
				this.OnPropertyValueChange("RecruitmentSource");
				this._RecruitmentSource = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("PurchaseSocialSecurity")]
		public string PurchaseSocialSecurity
		{
			get{ return _PurchaseSocialSecurity; }
			set
			{
				this.OnPropertyValueChange("PurchaseSocialSecurity");
				this._PurchaseSocialSecurity = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("TheLaborContract")]
		public string TheLaborContract
		{
			get{ return _TheLaborContract; }
			set
			{
				this.OnPropertyValueChange("TheLaborContract");
				this._TheLaborContract = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("ConfidentialityContract")]
		public string ConfidentialityContract
		{
			get{ return _ConfidentialityContract; }
			set
			{
				this.OnPropertyValueChange("ConfidentialityContract");
				this._ConfidentialityContract = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CardNumber")]
		public string CardNumber
		{
			get{ return _CardNumber; }
			set
			{
				this.OnPropertyValueChange("CardNumber");
				this._CardNumber = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CardBankName")]
		public string CardBankName
		{
			get{ return _CardBankName; }
			set
			{
				this.OnPropertyValueChange("CardBankName");
				this._CardBankName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CardBankAdd")]
		public string CardBankAdd
		{
			get{ return _CardBankAdd; }
			set
			{
				this.OnPropertyValueChange("CardBankAdd");
				this._CardBankAdd = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CreateTime")]
		public DateTime CreateTime
		{
			get{ return _CreateTime; }
			set
			{
				this.OnPropertyValueChange("CreateTime");
				this._CreateTime = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CreateUser")]
		public string CreateUser
		{
			get{ return _CreateUser; }
			set
			{
				this.OnPropertyValueChange("CreateUser");
				this._CreateUser = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("CompanyCode")]
		public string CompanyCode
		{
			get{ return _CompanyCode; }
			set
			{
				this.OnPropertyValueChange("CompanyCode");
				this._CompanyCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("UserId")]
		public string UserId
		{
			get{ return _UserId; }
			set
			{
				this.OnPropertyValueChange("UserId");
				this._UserId = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("UserType")]
		public int? UserType
		{
			get{ return _UserType; }
			set
			{
				this.OnPropertyValueChange("UserType");
				this._UserType = value;
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
				_.UserCode,
				_.UserName,
				_.UserPwd,
				_.UserClosed,
				_.UserSex,
				_.IDNumber,
				_.Birthday,
				_.PoliticalLandscape,
				_.MobilePhone,
				_.Tell,
				_.Email,
				_.QQ,
				_.WeChat,
				_.RecruitmentSource,
				_.PurchaseSocialSecurity,
				_.TheLaborContract,
				_.ConfidentialityContract,
				_.CardNumber,
				_.CardBankName,
				_.CardBankAdd,
				_.CreateTime,
				_.CreateUser,
				_.CompanyCode,
				_.UserId,
				_.UserType,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._UserCode,
				this._UserName,
				this._UserPwd,
				this._UserClosed,
				this._UserSex,
				this._IDNumber,
				this._Birthday,
				this._PoliticalLandscape,
				this._MobilePhone,
				this._Tell,
				this._Email,
				this._QQ,
				this._WeChat,
				this._RecruitmentSource,
				this._PurchaseSocialSecurity,
				this._TheLaborContract,
				this._ConfidentialityContract,
				this._CardNumber,
				this._CardBankName,
				this._CardBankAdd,
				this._CreateTime,
				this._CreateUser,
				this._CompanyCode,
				this._UserId,
				this._UserType,
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
			public readonly static Field All = new Field("*", "TbUser");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UserCode = new Field("UserCode", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UserName = new Field("UserName", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UserPwd = new Field("UserPwd", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UserClosed = new Field("UserClosed", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UserSex = new Field("UserSex", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IDNumber = new Field("IDNumber", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Birthday = new Field("Birthday", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PoliticalLandscape = new Field("PoliticalLandscape", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MobilePhone = new Field("MobilePhone", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Tell = new Field("Tell", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Email = new Field("Email", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field QQ = new Field("QQ", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field WeChat = new Field("WeChat", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field RecruitmentSource = new Field("RecruitmentSource", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field PurchaseSocialSecurity = new Field("PurchaseSocialSecurity", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field TheLaborContract = new Field("TheLaborContract", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ConfidentialityContract = new Field("ConfidentialityContract", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CardNumber = new Field("CardNumber", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CardBankName = new Field("CardBankName", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CardBankAdd = new Field("CardBankAdd", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateUser = new Field("CreateUser", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field CompanyCode = new Field("CompanyCode", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UserId = new Field("UserId", "TbUser", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field UserType = new Field("UserType", "TbUser", "");
        }
        #endregion

        #region 扩展字段
        public string CompanyCodeName { get; set; }
        public string CompanyFullName { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }

        #endregion
	}
}