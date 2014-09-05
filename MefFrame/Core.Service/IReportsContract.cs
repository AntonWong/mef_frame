//------------------------------------------------------------------------------
//Copyright ©车易拍-公共服务组团队. All Rights Reserved.
//------------------------------------------------------------------------------
using Core.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Core.Service
{
    /// <summary>
    /// ——Reports
    /// </summary>    
    public interface IReportsContract
    {
       
        //查询数据集
        IQueryable<Reports> Reportss { get; }
        //添加
        int Insert(Reports entity);
        /// <summary>
        ///  删除-根据ID删除实体
        /// </summary>
        /// <param name="id"> 主键ID </param>
        /// <param name="isSave"> 默认值false;是否执行保存.isSave:true 保存，isSave:false 不保存 </param>
        /// <returns> 操作影响的行数 </returns>
        int Delete(int id,bool isSave=false);
        /// <summary>

        ///  修改-根据ID修改实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <param name="updateExpression">Lamda表达式 修改实体</param>
        /// <param name="isSave"> 默认值false;是否执行保存.isSave:true 保存，isSave:false 不保存 </param>
        /// <returns></returns>
        int Update(int id, Expression<Func<Reports, Reports>> updateExpression,bool isSave=false);
   
    }
}
