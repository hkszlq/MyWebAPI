using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using System.Threading.Tasks;
using System;

namespace MyTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MycacheController : ControllerBase
    {
        private readonly IDistributedCache _cache;

        public MycacheController(IDistributedCache cache)
        {
            _cache = cache;
        }

        [HttpGet]
        public async Task<string> GetCachedValue(string key)
        {
            string s = "jljeljllj";
            var s2 = s?.Split(',');
            // 尝试获取缓存数据
            byte[] data = await _cache.GetAsync(key);
            if (data != null)
            {
                return Encoding.UTF8.GetString(data);
            }

            // 如果缓存不存在，则生成数据并添加到缓存
            string value = "Value to cache";
            data = Encoding.UTF8.GetBytes(value);
            await _cache.SetAsync(key, data, new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10))); // 设置缓存过期时间为10分钟

            return value;
        }
    }
}
