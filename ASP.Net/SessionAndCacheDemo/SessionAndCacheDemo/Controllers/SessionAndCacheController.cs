using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using SessionAndCacheDemo.Models;
using System;

namespace SessionAndCacheDemo.Controllers
{
    /// <summary>
    /// Based on https://docs.microsoft.com/en-us/aspnet/core/fundamentals/app-state?view=aspnetcore-2.2#cache
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SessionAndCacheController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;

        public readonly string _sessionKeyId = "_SessionId";
        public readonly string _cacheKeyName = "_Name";
        public readonly string _cacheKeyAge = "_Age";
        
        public SessionAndCacheController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet("[action]")]
        public IActionResult SetCache([FromQuery] UserData userData)
        {
            Guid sessionId = Guid.Empty;

            if (string.IsNullOrEmpty(HttpContext.Session?.GetString(_sessionKeyId)))
            {
                sessionId = Guid.NewGuid();
                HttpContext.Session.SetString(_sessionKeyId, sessionId.ToString());
            }
            else
            {
                sessionId = Guid.Parse(HttpContext.Session.GetString(_sessionKeyId));
            }

            _memoryCache.Set(sessionId, userData);

            return StatusCode(200, "Cache is created.");
        }

        [HttpGet("[action]")]
        public IActionResult GetCache()
        {
            Guid sessionId = Guid.Parse(HttpContext.Session.GetString(_sessionKeyId));
            UserData userData = _memoryCache.Get<UserData>(sessionId);

            return StatusCode(200, $"Cached data:{Environment.NewLine}Username: {userData.Name}{Environment.NewLine}Age: {userData.Age}");
        }
    }
}
