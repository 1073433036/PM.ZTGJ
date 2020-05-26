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
    /// 实体类TbProjectCompany。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TbProjectCompany")]
    [Serializable]
    public partial class TbProjectCompany : Entity
    {
        #region Model
		private int _ID;
		private string _ProjectId;
		private string _CompanyCode;
		private string _OrgType;

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
		/// 组织机构id
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
		[Field("OrgType")]
		public string OrgType
		{
			get{ return _OrgType; }
			set
			{
				this.OnPropertyValueChange("OrgType");
				this._OrgType = value;
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
				_.ProjectId,
				_.CompanyCode,
				_.OrgType,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._ProjectId,
				this._CompanyCode,
				this._OrgType,
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
			public readonly static Field All = new Field("*", "TbProjectCompany");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TbProjectCompany", "ID");
            /// <summary>
			/// 项目id
			/// </summary>
			public readonly static Field ProjectId = new Field("ProjectId", "TbProjectCompany", "项目id");
            /// <summary>
			/// 组织机构id
			/// </summary>
			public readonly static Field CompanyCode = new Field("CompanyCode", "TbProjectCompany", "组织机构id");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OrgType = new Field("OrgType", "TbProjectCompany", "");
        }
        #endregion
	}
}