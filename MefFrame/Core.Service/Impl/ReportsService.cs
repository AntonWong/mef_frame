//------------------------------------------------------------------------------
//Copyright ©车易拍-公共服务组团队. All Rights Reserved.
//------------------------------------------------------------------------------
using Core.Data.Repositories;
using System;
using System.ComponentModel.Composition;
using System.Linq;
using System.Linq.Expressions;
using Core.Models;


namespace Core.Service.Impl
{
    /// <summary>
    /// ——Reports
    /// </summary>    
    public class ReportsService : CoreServiceBase, IReportsContract
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
        /// 删除-根据ID删除实体
        /// </summary>
        /// <param name="id"> ID主键 </param>
        /// <param name="isSave"> 默认值false;是否执行保存.isSave:true 保存，isSave:false 不保存 </param>
        /// <returns> 操作影响的行数 </returns>
         public int Delete(int id,bool isSave=false)
        {
            //return ReportsRepository.Delete(m=>m.Id==id,isSave);
            return 0;
        }
        /// <summary>
        /// 修改-根据ID修改实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <param name="updateExpression">Lamda表达式 修改实体</param>
        /// <param name="isSave"> 默认值false;是否执行保存.isSave:true 保存，isSave:false 不保存 </param>
        /// <returns></returns>
        public int Update(int id, Expression<Func<Reports, Reports>> updateExpression,bool isSave=false)
        {
            //return ReportsRepository.Update(m=>m.Id==id, updateExpression, isSave);
            return 0;
        }

        #endregion
       
    }
}
