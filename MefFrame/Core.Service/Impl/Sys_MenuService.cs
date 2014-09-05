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
    /// ——Sys_Menu
    /// </summary>    
    public class SysMenuService : CoreServiceBase, ISys_MenuContract
    {
        #region 受保护属性 获取或设置数据访问对象

        [Import]
        protected ISys_MenuRepository Sys_MenuRepository { get; set; }  
 
        #endregion

        #region 公共属性
        /// <summary>
        /// 数据对象
        /// </summary>
        public IQueryable<Sys_Menu> Sys_Menus
        {
            get { return Sys_MenuRepository.Entities; }
        }

        #endregion

        #region 公共方法
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Insert(Sys_Menu entity)
        {
            return Sys_MenuRepository.Insert(entity);
        }
        /// <summary>
        /// 删除-根据ID删除实体
        /// </summary>
        /// <param name="id"> ID主键 </param>
        /// <param name="isSave"> 默认值false;是否执行保存.isSave:true 保存，isSave:false 不保存 </param>
        /// <returns> 操作影响的行数 </returns>
         public int Delete(int id,bool isSave=false)
        {
            //return Sys_MenuRepository.Delete(m=>m.Id==id,isSave);
            return 0;
        }
        /// <summary>
        /// 修改-根据ID修改实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <param name="updateExpression">Lamda表达式 修改实体</param>
        /// <param name="isSave"> 默认值false;是否执行保存.isSave:true 保存，isSave:false 不保存 </param>
        /// <returns></returns>
        public int Update(int id, Expression<Func<Sys_Menu, Sys_Menu>> updateExpression,bool isSave=false)
        {
            //return Sys_MenuRepository.Update(m=>m.Id==id, updateExpression, isSave);
            return 0;
        }

        #endregion
       
    }
}
