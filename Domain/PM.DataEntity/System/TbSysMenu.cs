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
    /// 实体类TbSysMenu。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TbSysMenu")]
    [Serializable]
    public partial class TbSysMenu : Entity
    {
        #region Model
		private int _ID;
		private string _MenuCode;
		private string _MenuName;
		private string _MenuUrl;
		private string _MenuPCode;
		private string _MenuIconCls;
		private string _OperationExamination;
		private string _OperationView;
		private string _OperationAdd;
		private string _OperationEdit;
		private string _OperationDel;
		private string _OperationOutput;
		private string _OperationOther1;
		private string _OperationOther1IconCls;
		private string _OperationOther1Fun;
		private string _OperationOther2;
		private string _OperationOther2IconCls;
		private string _OperationOther2Fun;
		private string _OperationOther3;
		private string _OperationOther3IconCls;
		private string _OperationOther3Fun;
		private string _OperationOther4;
		private string _OperationOther4IconCls;
		private string _OperationOther4Fun;
		private string _OperationOther5;
		private string _OperationOther5IconCls;
		private string _OperationOther5Fun;
		private int _Sort;
		private string _IsShow;
		private string _DataAuthority;
		private string _DuanXinTemplate;
		private string _MenuType;
		private string _IsNoticeOrEarly;

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
		/// 
		/// </summary>
		[Field("MenuName")]
		public string MenuName
		{
			get{ return _MenuName; }
			set
			{
				this.OnPropertyValueChange("MenuName");
				this._MenuName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("MenuUrl")]
		public string MenuUrl
		{
			get{ return _MenuUrl; }
			set
			{
				this.OnPropertyValueChange("MenuUrl");
				this._MenuUrl = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("MenuPCode")]
		public string MenuPCode
		{
			get{ return _MenuPCode; }
			set
			{
				this.OnPropertyValueChange("MenuPCode");
				this._MenuPCode = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("MenuIconCls")]
		public string MenuIconCls
		{
			get{ return _MenuIconCls; }
			set
			{
				this.OnPropertyValueChange("MenuIconCls");
				this._MenuIconCls = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationExamination")]
		public string OperationExamination
		{
			get{ return _OperationExamination; }
			set
			{
				this.OnPropertyValueChange("OperationExamination");
				this._OperationExamination = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationView")]
		public string OperationView
		{
			get{ return _OperationView; }
			set
			{
				this.OnPropertyValueChange("OperationView");
				this._OperationView = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationAdd")]
		public string OperationAdd
		{
			get{ return _OperationAdd; }
			set
			{
				this.OnPropertyValueChange("OperationAdd");
				this._OperationAdd = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationEdit")]
		public string OperationEdit
		{
			get{ return _OperationEdit; }
			set
			{
				this.OnPropertyValueChange("OperationEdit");
				this._OperationEdit = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationDel")]
		public string OperationDel
		{
			get{ return _OperationDel; }
			set
			{
				this.OnPropertyValueChange("OperationDel");
				this._OperationDel = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOutput")]
		public string OperationOutput
		{
			get{ return _OperationOutput; }
			set
			{
				this.OnPropertyValueChange("OperationOutput");
				this._OperationOutput = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther1")]
		public string OperationOther1
		{
			get{ return _OperationOther1; }
			set
			{
				this.OnPropertyValueChange("OperationOther1");
				this._OperationOther1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther1IconCls")]
		public string OperationOther1IconCls
		{
			get{ return _OperationOther1IconCls; }
			set
			{
				this.OnPropertyValueChange("OperationOther1IconCls");
				this._OperationOther1IconCls = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther1Fun")]
		public string OperationOther1Fun
		{
			get{ return _OperationOther1Fun; }
			set
			{
				this.OnPropertyValueChange("OperationOther1Fun");
				this._OperationOther1Fun = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther2")]
		public string OperationOther2
		{
			get{ return _OperationOther2; }
			set
			{
				this.OnPropertyValueChange("OperationOther2");
				this._OperationOther2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther2IconCls")]
		public string OperationOther2IconCls
		{
			get{ return _OperationOther2IconCls; }
			set
			{
				this.OnPropertyValueChange("OperationOther2IconCls");
				this._OperationOther2IconCls = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther2Fun")]
		public string OperationOther2Fun
		{
			get{ return _OperationOther2Fun; }
			set
			{
				this.OnPropertyValueChange("OperationOther2Fun");
				this._OperationOther2Fun = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther3")]
		public string OperationOther3
		{
			get{ return _OperationOther3; }
			set
			{
				this.OnPropertyValueChange("OperationOther3");
				this._OperationOther3 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther3IconCls")]
		public string OperationOther3IconCls
		{
			get{ return _OperationOther3IconCls; }
			set
			{
				this.OnPropertyValueChange("OperationOther3IconCls");
				this._OperationOther3IconCls = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther3Fun")]
		public string OperationOther3Fun
		{
			get{ return _OperationOther3Fun; }
			set
			{
				this.OnPropertyValueChange("OperationOther3Fun");
				this._OperationOther3Fun = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther4")]
		public string OperationOther4
		{
			get{ return _OperationOther4; }
			set
			{
				this.OnPropertyValueChange("OperationOther4");
				this._OperationOther4 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther4IconCls")]
		public string OperationOther4IconCls
		{
			get{ return _OperationOther4IconCls; }
			set
			{
				this.OnPropertyValueChange("OperationOther4IconCls");
				this._OperationOther4IconCls = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther4Fun")]
		public string OperationOther4Fun
		{
			get{ return _OperationOther4Fun; }
			set
			{
				this.OnPropertyValueChange("OperationOther4Fun");
				this._OperationOther4Fun = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther5")]
		public string OperationOther5
		{
			get{ return _OperationOther5; }
			set
			{
				this.OnPropertyValueChange("OperationOther5");
				this._OperationOther5 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther5IconCls")]
		public string OperationOther5IconCls
		{
			get{ return _OperationOther5IconCls; }
			set
			{
				this.OnPropertyValueChange("OperationOther5IconCls");
				this._OperationOther5IconCls = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("OperationOther5Fun")]
		public string OperationOther5Fun
		{
			get{ return _OperationOther5Fun; }
			set
			{
				this.OnPropertyValueChange("OperationOther5Fun");
				this._OperationOther5Fun = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("Sort")]
		public int Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange("Sort");
				this._Sort = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("IsShow")]
		public string IsShow
		{
			get{ return _IsShow; }
			set
			{
				this.OnPropertyValueChange("IsShow");
				this._IsShow = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[Field("DataAuthority")]
		public string DataAuthority
		{
			get{ return _DataAuthority; }
			set
			{
				this.OnPropertyValueChange("DataAuthority");
				this._DataAuthority = value;
			}
		}
		/// <summary>
		/// 短信模板Code
		/// </summary>
		[Field("DuanXinTemplate")]
		public string DuanXinTemplate
		{
			get{ return _DuanXinTemplate; }
			set
			{
				this.OnPropertyValueChange("DuanXinTemplate");
				this._DuanXinTemplate = value;
			}
		}
		/// <summary>
		/// 菜单类型
		/// </summary>
		[Field("MenuType")]
		public string MenuType
		{
			get{ return _MenuType; }
			set
			{
				this.OnPropertyValueChange("MenuType");
				this._MenuType = value;
			}
		}
		/// <summary>
		/// 是否存在消息或预警0:不存在1:存在
		/// </summary>
		[Field("IsNoticeOrEarly")]
		public string IsNoticeOrEarly
		{
			get{ return _IsNoticeOrEarly; }
			set
			{
				this.OnPropertyValueChange("IsNoticeOrEarly");
				this._IsNoticeOrEarly = value;
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
				_.MenuCode,
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
				_.MenuCode,
				_.MenuName,
				_.MenuUrl,
				_.MenuPCode,
				_.MenuIconCls,
				_.OperationExamination,
				_.OperationView,
				_.OperationAdd,
				_.OperationEdit,
				_.OperationDel,
				_.OperationOutput,
				_.OperationOther1,
				_.OperationOther1IconCls,
				_.OperationOther1Fun,
				_.OperationOther2,
				_.OperationOther2IconCls,
				_.OperationOther2Fun,
				_.OperationOther3,
				_.OperationOther3IconCls,
				_.OperationOther3Fun,
				_.OperationOther4,
				_.OperationOther4IconCls,
				_.OperationOther4Fun,
				_.OperationOther5,
				_.OperationOther5IconCls,
				_.OperationOther5Fun,
				_.Sort,
				_.IsShow,
				_.DataAuthority,
				_.DuanXinTemplate,
				_.MenuType,
				_.IsNoticeOrEarly,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._MenuCode,
				this._MenuName,
				this._MenuUrl,
				this._MenuPCode,
				this._MenuIconCls,
				this._OperationExamination,
				this._OperationView,
				this._OperationAdd,
				this._OperationEdit,
				this._OperationDel,
				this._OperationOutput,
				this._OperationOther1,
				this._OperationOther1IconCls,
				this._OperationOther1Fun,
				this._OperationOther2,
				this._OperationOther2IconCls,
				this._OperationOther2Fun,
				this._OperationOther3,
				this._OperationOther3IconCls,
				this._OperationOther3Fun,
				this._OperationOther4,
				this._OperationOther4IconCls,
				this._OperationOther4Fun,
				this._OperationOther5,
				this._OperationOther5IconCls,
				this._OperationOther5Fun,
				this._Sort,
				this._IsShow,
				this._DataAuthority,
				this._DuanXinTemplate,
				this._MenuType,
				this._IsNoticeOrEarly,
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
			public readonly static Field All = new Field("*", "TbSysMenu");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuCode = new Field("MenuCode", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuName = new Field("MenuName", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuUrl = new Field("MenuUrl", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuPCode = new Field("MenuPCode", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field MenuIconCls = new Field("MenuIconCls", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationExamination = new Field("OperationExamination", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationView = new Field("OperationView", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationAdd = new Field("OperationAdd", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationEdit = new Field("OperationEdit", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationDel = new Field("OperationDel", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOutput = new Field("OperationOutput", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther1 = new Field("OperationOther1", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther1IconCls = new Field("OperationOther1IconCls", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther1Fun = new Field("OperationOther1Fun", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther2 = new Field("OperationOther2", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther2IconCls = new Field("OperationOther2IconCls", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther2Fun = new Field("OperationOther2Fun", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther3 = new Field("OperationOther3", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther3IconCls = new Field("OperationOther3IconCls", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther3Fun = new Field("OperationOther3Fun", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther4 = new Field("OperationOther4", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther4IconCls = new Field("OperationOther4IconCls", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther4Fun = new Field("OperationOther4Fun", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther5 = new Field("OperationOther5", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther5IconCls = new Field("OperationOther5IconCls", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field OperationOther5Fun = new Field("OperationOther5Fun", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field Sort = new Field("Sort", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field IsShow = new Field("IsShow", "TbSysMenu", "");
            /// <summary>
			/// 
			/// </summary>
			public readonly static Field DataAuthority = new Field("DataAuthority", "TbSysMenu", "");
            /// <summary>
			/// 短信模板Code
			/// </summary>
			public readonly static Field DuanXinTemplate = new Field("DuanXinTemplate", "TbSysMenu", "短信模板Code");
            /// <summary>
			/// 菜单类型
			/// </summary>
			public readonly static Field MenuType = new Field("MenuType", "TbSysMenu", "菜单类型");
            /// <summary>
			/// 是否存在消息或预警0:不存在1:存在
			/// </summary>
			public readonly static Field IsNoticeOrEarly = new Field("IsNoticeOrEarly", "TbSysMenu", "是否存在消息或预警0:不存在1:存在");
        }
        #endregion
	}
}