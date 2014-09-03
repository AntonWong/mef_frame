//------------------------------------------------------------------------------
// <copyright file="Sys_FunctionsConfiguration.generated.cs">
//        生成时间：2014-09-02 13:50
// </copyright>
//------------------------------------------------------------------------------
using Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using Component.Data;
using Core.Models;


namespace Core.Service.Impl
{
    /// <summary>
    /// ——Sys_Functions
    /// </summary>    
    public partial class Sys_FunctionsService : CoreServiceBase, ISys_FunctionsContract
    {
        #region 受保护属性 获取或设置数据访问对象

        [Import]
        protected ISys_FunctionsRepository Sys_FunctionsRepository { get; set; }  
 
        #endregion

        #region 公共属性
        /// <summary>
        /// 数据对象
        /// </summary>
        public IQueryable<Sys_Functions> Sys_Functionss
        {
            get { return Sys_FunctionsRepository.Entities; }
        }

        #endregion

        #region 公共方法
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Insert(Sys_Functions entity)
        {
            return Sys_FunctionsRepository.Insert(entity);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="predicate">Lamda表达式</param>
        /// <returns></returns>
        public int Delete(Expression<Func<Sys_Functions, bool>> predicate)
        {
            return Sys_FunctionsRepository.Delete(predicate);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="predicate1">Lamda表达式 条件</param>
        /// <param name="predicate2">Lamda表达式 修改实体</param>
        /// <returns></returns>
        public int Update(Expression<Func<Sys_Functions, bool>> predicate1, Expression<Func<Sys_Functions, Sys_Functions>> predicate2)
        {
            return Sys_FunctionsRepository.Update(predicate1, predicate2);
        }

        #endregion
       
    }
}
