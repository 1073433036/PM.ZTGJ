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
using PM.DataEntity.Base;

namespace PM.DataEntity
{
    /// <summary>
    /// 实体类TbDataManage。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TbDataManage")]
    [Serializable]
    public partial class TbDataManage : BaseEntity
    {
        #region Model
        private int _ID;
        private string _DataCode;
        private string _ProcessFactoryCode;
        private string _TypeName;
        private string _FileCode;
        private string _DataName;
        private string _DepartmentCode;
        private string _DataContent;
        private string _InsertUserCode;
        private DateTime _InsertTime;
        private string _Remark;
        private string _Enclosure;

        /// <summary>
        /// 
        /// </summary>
        [Field("ID")]
        public int ID
        {
            get { return _ID; }
            set
            {
                this.OnPropertyValueChange("ID");
                this._ID = value;
            }
        }
        /// <summary>
        /// 资料分类归档编号
        /// </summary>
        [Field("DataCode")]
        public string DataCode
        {
            get { return _DataCode; }
            set
            {
                this.OnPropertyValueChange("DataCode");
                this._DataCode = value;
            }
        }
        /// <summary>
        /// 加工厂编号/名称
        /// </summary>
        [Field("ProcessFactoryCode")]
        public string ProcessFactoryCode
        {
            get { return _ProcessFactoryCode; }
            set
            {
                this.OnPropertyValueChange("ProcessFactoryCode");
                this._ProcessFactoryCode = value;
            }
        }
        /// <summary>
        /// 资料类别名称
        /// </summary>
        [Field("TypeName")]
        public string TypeName
        {
            get { return _TypeName; }
            set
            {
                this.OnPropertyValueChange("TypeName");
                this._TypeName = value;
            }
        }
        /// <summary>
        /// 文件编号
        /// </summary>
        [Field("FileCode")]
        public string FileCode
        {
            get { return _FileCode; }
            set
            {
                this.OnPropertyValueChange("FileCode");
                this._FileCode = value;
            }
        }
        /// <summary>
        /// 资料名称
        /// </summary>
        [Field("DataName")]
        public string DataName
        {
            get { return _DataName; }
            set
            {
                this.OnPropertyValueChange("DataName");
                this._DataName = value;
            }
        }
        /// <summary>
        /// 归属部门
        /// </summary>
        [Field("DepartmentCode")]
        public string DepartmentCode
        {
            get { return _DepartmentCode; }
            set
            {
                this.OnPropertyValueChange("DepartmentCode");
                this._DepartmentCode = value;
            }
        }
        /// <summary>
        /// 内容摘抄
        /// </summary>
        [Field("DataContent")]
        public string DataContent
        {
            get { return _DataContent; }
            set
            {
                this.OnPropertyValueChange("DataContent");
                this._DataContent = value;
            }
        }
        /// <summary>
        /// 录入人编号
        /// </summary>
        [Field("InsertUserCode")]
        public string InsertUserCode
        {
            get { return _InsertUserCode; }
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
            get { return _InsertTime; }
            set
            {
                this.OnPropertyValueChange("InsertTime");
                this._InsertTime = value;
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        [Field("Remark")]
        public string Remark
        {
            get { return _Remark; }
            set
            {
                this.OnPropertyValueChange("Remark");
                this._Remark = value;
            }
        }
        /// <summary>
        /// 附件
        /// </summary>
        [Field("Enclosure")]
        public string Enclosure
        {
            get { return _Enclosure; }
            set
            {
                this.OnPropertyValueChange("Enclosure");
                this._Enclosure = value;
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
				_.DataCode,
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
				_.DataCode,
				_.ProcessFactoryCode,
				_.TypeName,
				_.FileCode,
				_.DataName,
				_.DepartmentCode,
				_.DataContent,
				_.InsertUserCode,
				_.InsertTime,
				_.Remark,
				_.Enclosure,
                _.ProjectId
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._DataCode,
				this._ProcessFactoryCode,
				this._TypeName,
				this._FileCode,
				this._DataName,
				this._DepartmentCode,
				this._DataContent,
				this._InsertUserCode,
				this._InsertTime,
				this._Remark,
				this._Enclosure,
                this._ProjectId
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
        public class _ : BaseField<TbDataManage>
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "TbDataManage");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "TbDataManage", "");
            /// <summary>
            /// 资料分类归档编号
            /// </summary>
            public readonly static Field DataCode = new Field("DataCode", "TbDataManage", "资料分类归档编号");
            /// <summary>
            /// 加工厂编号/名称
            /// </summary>
            public readonly static Field ProcessFactoryCode = new Field("ProcessFactoryCode", "TbDataManage", "加工厂编号/名称");
            /// <summary>
            /// 资料类别名称
            /// </summary>
            public readonly static Field TypeName = new Field("TypeName", "TbDataManage", "资料类别名称");
            /// <summary>
            /// 文件编号
            /// </summary>
            public readonly static Field FileCode = new Field("FileCode", "TbDataManage", "文件编号");
            /// <summary>
            /// 资料名称
            /// </summary>
            public readonly static Field DataName = new Field("DataName", "TbDataManage", "资料名称");
            /// <summary>
            /// 归属部门
            /// </summary>
            public readonly static Field DepartmentCode = new Field("DepartmentCode", "TbDataManage", "归属部门");
            /// <summary>
            /// 内容摘抄
            /// </summary>
            public readonly static Field DataContent = new Field("DataContent", "TbDataManage", "内容摘抄");
            /// <summary>
            /// 录入人编号
            /// </summary>
            public readonly static Field InsertUserCode = new Field("InsertUserCode", "TbDataManage", "录入人编号");
            /// <summary>
            /// 录入时间
            /// </summary>
            public readonly static Field InsertTime = new Field("InsertTime", "TbDataManage", "录入时间");
            /// <summary>
            /// 备注
            /// </summary>
            public readonly static Field Remark = new Field("Remark", "TbDataManage", "备注");
            /// <summary>
            /// 附件
            /// </summary>
            public readonly static Field Enclosure = new Field("Enclosure", "TbDataManage", "附件");
        }
        #endregion
    }
}