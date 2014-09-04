//------------------------------------------------------------------------------
// <copyright file="TestDataConfiguration.generated.cs">
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
using EntityFramework.Extensions;


namespace Core.Service.Impl
{
    /// <summary>
    /// ——TestData
    /// </summary>    
    public partial class TestDataService : CoreServiceBase, ITestDataContract
    {
        #region 受保护属性 获取或设置数据访问对象

        [Import]
        protected ITestDataRepository TestDataRepository { get; set; }  
 
        #endregion

        #region 公共属性
        /// <summary>
        /// 数据对象
        /// </summary>
        public IQueryable<TestData> TestDatas
        {
            get { return TestDataRepository.Entities; }
        }

        #endregion

        #region 公共方法
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Insert(TestData entity)
        {
          
            int result =  TestDataRepository.Insert(entity,false);
            TestDatas.Delete(s => s.Id == 1);
            string name = "AAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAAAAAAA";
            TestDataRepository.Insert(new TestData {Name = name});
            return  TestDataRepository.Delete(s => s.Id == 12);
            // TestDatas.
            //TestDataRepository.
            //UnitOfWork.Commit();

        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="predicate">Lamda表达式</param>
        /// <returns></returns>
        public int Delete(Expression<Func<TestData, bool>> predicate)
        {
            return TestDataRepository.DeleteBySql(s=>s.Id==999);
        }
        public int Delete(int id)
        {
            TestDataRepository.DeleteBySql(null);
            return UnitOfWork.Commit();
        }

        public int Update(Expression<Func<TestData, object>> propertyExpression, params TestData[] entities)
        {
            TestDataRepository.Update(propertyExpression, false, entities);
            return UnitOfWork.Commit();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="predicate1">Lamda表达式 条件</param>
        /// <param name="predicate2">Lamda表达式 修改实体</param>
        /// <returns></returns>
        public int Update(Expression<Func<TestData, bool>> predicate1, Expression<Func<TestData, TestData>> predicate2)
        {
          //  Update(s=>new TestData{Id = } )
            return TestDataRepository.Update(predicate1, predicate2);
        }

        #endregion
       
    }
}
