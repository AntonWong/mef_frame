//------------------------------------------------------------------------------
// <copyright file="TestDataConfiguration.generated.cs">
//        生成时间：2014-09-02 13:50
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Core.Service.Impl;
using Core.Models;
using Site.Models;

namespace Site.Service.Impl
{
    /// <summary>
    /// ——TestData
    /// </summary>  
    [Export(typeof(ITestDataSiteContract))]
    internal class TestDataSiteService : TestDataService, ITestDataSiteContract
    {
        public List<MenuView> Menus()
        {
            return TestDatas.Select(s => new MenuView {Id = s.Id, Name = s.Name}).ToList();
        }

        public int DeleteMenu(int id)

        {
            return Delete(s => s.Id == id);
        }

        public int AddMenu(MenuView model)
        {
            try
            {
                return Insert(new TestData { Name = model.Name });
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }
    }
}
