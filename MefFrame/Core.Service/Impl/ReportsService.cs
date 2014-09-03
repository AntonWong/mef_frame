//------------------------------------------------------------------------------
// <copyright file="ReportsConfiguration.generated.cs">
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
    /// ——Reports
    /// </summary>    
    public partial class ReportsService : CoreServiceBase, IReportsContract
    {
        #region 受保护属性 获取或设置数据访问对象

        [Import]
        protected IReportsRepository ReportsRepository { get; set; }  
 
        #endregion

        #region 公共属性
        /// <summary>
        /// 数据对象
        /// </summary>
        public IQueryable<Reports> Reportss
        {
            get { return ReportsRepository.Entities; }
        }

        #endregion

        #region 公共方法
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Insert(Reports entity)
        {
            return ReportsRepository.Insert(entity);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="predicate">Lamda表达式</param>
        /// <returns></returns>
        public int Delete(Expression<Func<Reports, bool>> predicate)
        {
            return ReportsRepository.Delete(predicate);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="predicate1">Lamda表达式 条件</param>
        /// <param name="predicate2">Lamda表达式 修改实体</param>
        /// <returns></returns>
        public int Update(Expression<Func<Reports, bool>> predicate1, Expression<Func<Reports, Reports>> predicate2)
        {
            return ReportsRepository.Update(predicate1, predicate2);
        }

        #endregion
       
    }
}
