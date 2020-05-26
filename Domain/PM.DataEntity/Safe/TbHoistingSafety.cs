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
    /// 吊装安全
    /// </summary>
    [Table("TbHoistingSafety")]
    [Serializable]
    public partial class TbHoistingSafety : Entity
    {
        #region Model
		private int _ID;
		private string _HoistingCode;
		private string _ProcessFactoryCode;
		private string _SuperviseUser;
		private string _ConstructionUser;
		private string _TzWorkZgz;
		private string _MechanicsIsNormal;
		private string _KzIsSolid;
		private string _IsProhibition;
		private string _HoistContent;
		private DateTime? _BeginTime;
		private string _Examinestatus;
		private string _Enclosure;
		private string _Remark;
		private string _InsertUserCode;
		private DateTime _InsertTime;
		private string _HoistFileCode;
		private string _ConstructionUserName;
		private string _ProjectId;
		private string _ProjectIdStr;

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
		/// 吊装安全管理编号
		/// </summary>
		[Field("HoistingCode")]
		public string HoistingCode
		{
			get{ return _HoistingCode; }
			set
			{
				this.OnPropertyValueChange("HoistingCode");
				this._HoistingCode = value;
			}
		}
		/// <summary>
		/// 加工厂编号
		/// </summary>
		[Field("ProcessFactoryCode")]
		public string ProcessFactoryCode
		{
			get{ return _ProcessFactoryCode; }
			set
			{
				this.OnPropertyValueChange("ProcessFactoryCode");
				this._ProcessFactoryCode = value;
			}
		}
		/// <summary>
		/// 监管人员
		/// </summary>
		[Field("SuperviseUser")]
		public string SuperviseUser
		{
			get{ return _SuperviseUser; }
			set
			{
				this.OnPropertyValueChange("SuperviseUser");
				this._SuperviseUser = value;
			}
		}
		/// <summary>
		/// 施工人员
		/// </summary>
		[Field("ConstructionUser")]
		public string ConstructionUser
		{
			get{ return _ConstructionUser; }
			set
			{
				this.OnPropertyValueChange("ConstructionUser");
				this._ConstructionUser = value;
			}
		}
		/// <summary>
		/// 特种作业资格证
		/// </summary>
		[Field("TzWorkZgz")]
		public string TzWorkZgz
		{
			get{ return _TzWorkZgz; }
			set
			{
				this.OnPropertyValueChange("TzWorkZgz");
				this._TzWorkZgz = value;
			}
		}
		/// <summary>
		/// 机械是否正常
		/// </summary>
		[Field("MechanicsIsNormal")]
		public string MechanicsIsNormal
		{
			get{ return _MechanicsIsNormal; }
			set
			{
				this.OnPropertyValueChange("MechanicsIsNormal");
				this._MechanicsIsNormal = value;
			}
		}
		/// <summary>
		/// 捆扎是否牢固
		/// </summary>
		[Field("KzIsSolid")]
		public string KzIsSolid
		{
			get{ return _KzIsSolid; }
			set
			{
				this.OnPropertyValueChange("KzIsSolid");
				this._KzIsSolid = value;
			}
		}
		/// <summary>
		/// 有无禁止行为
		/// </summary>
		[Field("IsProhibition")]
		public string IsProhibition
		{
			get{ return _IsProhibition; }
			set
			{
				this.OnPropertyValueChange("IsProhibition");
				this._IsProhibition = value;
			}
		}
		/// <summary>
		/// 吊装内容
		/// </summary>
		[Field("HoistContent")]
		public string HoistContent
		{
			get{ return _HoistContent; }
			set
			{
				this.OnPropertyValueChange("HoistContent");
				this._HoistContent = value;
			}
		}
		/// <summary>
		/// 开始时间
		/// </summary>
		[Field("BeginTime")]
		public DateTime? BeginTime
		{
			get{ return _BeginTime; }
			set
			{
				this.OnPropertyValueChange("BeginTime");
				this._BeginTime = value;
			}
		}
		/// <summary>
		/// 审批状态
		/// </summary>
		[Field("Examinestatus")]
		public string Examinestatus
		{
			get{ return _Examinestatus; }
			set
			{
				this.OnPropertyValueChange("Examinestatus");
				this._Examinestatus = value;
			}
		}
		/// <summary>
		/// 附件
		/// </summary>
		[Field("Enclosure")]
		public string Enclosure
		{
			get{ return _Enclosure; }
			set
			{
				this.OnPropertyValueChange("Enclosure");
				this._Enclosure = value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		[Field("Remark")]
		public string Remark
		{
			get{ return _Remark; }
			set
			{
				this.OnPropertyValueChange("Remark");
				this._Remark = value;
			}
		}
		/// <summary>
		/// 录入人编号
		/// </summary>
		[Field("InsertUserCode")]
		public string InsertUserCode
		{
			get{ return _InsertUserCode; }
			set
			{
				this.OnPropertyValueChange("InsertUserCode");
				this._InsertUserCode = value;
			}
		}
		/// <summary>
		/// 录入时间
		/// </summary>
		[Field("InsertTime")]
		public DateTime InsertTime
		{
			get{ return _InsertTime; }
			set
			{
				this.OnPropertyValueChange("InsertTime");
				this._InsertTime = value;
			}
		}
		/// <summary>
		/// 吊装令文件
		/// </summary>
		[Field("HoistFileCode")]
		public string HoistFileCode
		{
			get{ return _HoistFileCode; }
			set
			{
				this.OnPropertyValueChange("HoistFileCode");
				this._HoistFileCode = value;
			}
		}
		/// <summary>
		/// 施工人员名称
		/// </summary>
		[Field("ConstructionUserName")]
		public string ConstructionUserName
		{
			get{ return _ConstructionUserName; }
			set
			{
				this.OnPropertyValueChange("ConstructionUserName");
				this._ConstructionUserName = value;
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
		/// 吊装令归属
		/// </summary>
		[Field("ProjectIdStr")]
		public string ProjectIdStr
		{
			get{ return _ProjectIdStr; }
			set
			{
				this.OnPropertyValueChange("ProjectIdStr");
				this._ProjectIdStr = value;
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
				_.HoistingCode,
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
				_.HoistingCode,
				_.ProcessFactoryCode,
				_.SuperviseUser,
				_.ConstructionUser,
				_.TzWorkZgz,
				_.MechanicsIsNormal,
				_.KzIsSolid,
				_.IsProhibition,
				_.HoistContent,
				_.BeginTime,
				_.Examinestatus,
				_.Enclosure,
				_.Remark,
				_.InsertUserCode,
				_.InsertTime,
				_.HoistFileCode,
				_.ConstructionUserName,
				_.ProjectId,
				_.ProjectIdStr,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._HoistingCode,
				this._ProcessFactoryCode,
				this._SuperviseUser,
				this._ConstructionUser,
				this._TzWorkZgz,
				this._MechanicsIsNormal,
				this._KzIsSolid,
				this._IsProhibition,
				this._HoistContent,
				this._BeginTime,
				this._Examinestatus,
				this._Enclosure,
				this._Remark,
				this._InsertUserCode,
				this._InsertTime,
				this._HoistFileCode,
				this._ConstructionUserName,
				this._ProjectId,
				this._ProjectIdStr,
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
			public readonly static Field All = new Field("*", "TbHoistingSafety");
            /// <summary>
			/// ID
			/// </summary>
			public readonly static Field ID = new Field("ID", "TbHoistingSafety", "ID");
            /// <summary>
			/// 吊装安全管理编号
			/// </summary>
			public readonly static Field HoistingCode = new Field("HoistingCode", "TbHoistingSafety", "吊装安全管理编号");
            /// <summary>
			/// 加工厂编号
			/// </summary>
			public readonly static Field ProcessFactoryCode = new Field("ProcessFactoryCode", "TbHoistingSafety", "加工厂编号");
            /// <summary>
			/// 监管人员
			/// </summary>
			public readonly static Field SuperviseUser = new Field("SuperviseUser", "TbHoistingSafety", "监管人员");
            /// <summary>
			/// 施工人员
			/// </summary>
			public readonly static Field ConstructionUser = new Field("ConstructionUser", "TbHoistingSafety", "施工人员");
            /// <summary>
			/// 特种作业资格证
			/// </summary>
			public readonly static Field TzWorkZgz = new Field("TzWorkZgz", "TbHoistingSafety", "特种作业资格证");
            /// <summary>
			/// 机械是否正常
			/// </summary>
			public readonly static Field MechanicsIsNormal = new Field("MechanicsIsNormal", "TbHoistingSafety", "机械是否正常");
            /// <summary>
			/// 捆扎是否牢固
			/// </summary>
			public readonly static Field KzIsSolid = new Field("KzIsSolid", "TbHoistingSafety", "捆扎是否牢固");
            /// <summary>
			/// 有无禁止行为
			/// </summary>
			public readonly static Field IsProhibition = new Field("IsProhibition", "TbHoistingSafety", "有无禁止行为");
            /// <summary>
			/// 吊装内容
			/// </summary>
			public readonly static Field HoistContent = new Field("HoistContent", "TbHoistingSafety", "吊装内容");
            /// <summary>
			/// 开始时间
			/// </summary>
			public readonly static Field BeginTime = new Field("BeginTime", "TbHoistingSafety", "开始时间");
            /// <summary>
			/// 审批状态
			/// </summary>
			public readonly static Field Examinestatus = new Field("Examinestatus", "TbHoistingSafety", "审批状态");
            /// <summary>
			/// 附件
			/// </summary>
			public readonly static Field Enclosure = new Field("Enclosure", "TbHoistingSafety", "附件");
            /// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Remark = new Field("Remark", "TbHoistingSafety", "备注");
            /// <summary>
			/// 录入人编号
			/// </summary>
			public readonly static Field InsertUserCode = new Field("InsertUserCode", "TbHoistingSafety", "录入人编号");
            /// <summary>
			/// 录入时间
			/// </summary>
			public readonly static Field InsertTime = new Field("InsertTime", "TbHoistingSafety", "录入时间");
            /// <summary>
			/// 吊装令文件
			/// </summary>
			public readonly static Field HoistFileCode = new Field("HoistFileCode", "TbHoistingSafety", "吊装令文件");
            /// <summary>
			/// 施工人员名称
			/// </summary>
			public readonly static Field ConstructionUserName = new Field("ConstructionUserName", "TbHoistingSafety", "施工人员名称");
            /// <summary>
			/// 项目id
			/// </summary>
			public readonly static Field ProjectId = new Field("ProjectId", "TbHoistingSafety", "项目id");
            /// <summary>
			/// 吊装令归属
			/// </summary>
			public readonly static Field ProjectIdStr = new Field("ProjectIdStr", "TbHoistingSafety", "吊装令归属");
        }
        #endregion
	}
}