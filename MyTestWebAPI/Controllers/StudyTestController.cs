using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyDBtestEntity;
using MyTestWebAPI.Entity;
using MyUtil;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MyTestWebAPI.Filter;
using MyLibDBAccess;
using System.Linq;
using MyTestWebAPI.MyAttrbute;

namespace MyTestWebAPI.Controllers
{
    /// <summary>
    /// 学习控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [MyTestTeXing(666,Destibution ="mytest")]
    public class StudyTestController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IServiceProvider _serviceProvider;
        private ILog log;
        public StudyTestController(ILogger<StudyTestController> logger,IServiceProvider  serviceProvider)
        {
             _logger = logger;
           _serviceProvider=serviceProvider;
            this.log = LogManager.GetLogger(Startup.repository.Name, typeof(StudyTestController));

        }
       /// <summary>
       /// 获取学生方法
       /// </summary>
       /// <returns></returns>
        [HttpGet]
        [MyactionFilter]
        public List<Student> Get() {
            _logger.LogInformation("进入到action");
          var s=  new List<Student> { new Student() { ID=1,Name="liu",Birthday=DateTime.Now },new Student() { ID = 2, Name = "li" } };
            log.Info("测试我的日志");
           
            return s;
        }
        [HttpPost]
        public async Task<List<EBRANCH_VTMA_DETAIL>> MyeBRANCH_VTMA_DETAILs(Search search)
        {
           var dbcontext= _serviceProvider.GetService(typeof(DbContext));
            var db = (MyDbContext)dbcontext;
            db.eBRANCH_VTMA_DETAILs.Where(a => a.C_TLRHUBID.Equals("1613055"));
            var Iq = db.eBRANCH_VTMA_DETAILs.AsQueryable();
            var where = LinqHelper.True<EBRANCH_VTMA_DETAIL>();
            where = where.And(a => a.C_TLRHUBID.Equals("1613055"));
            return await Iq.Where(where).Take(5).ToListAsync();
           // var result= await Iq.Where(e => e.C_ID== "2c911ddf4f5d67ad014f5f43632704ec").ToListAsync();
            //return result; 
            //return await mydbcontext.eBRANCH_VTMA_DETAILs.FirstOrDefaultAsync();
            
        }

        
    }
}
