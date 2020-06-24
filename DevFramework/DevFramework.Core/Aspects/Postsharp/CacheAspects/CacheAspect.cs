using DevFramework.Core.CrossCuttingConcerns.Caching;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DevFramework.Core.Aspects.Postsharp.CacheAspects
{
    [Serializable]
    public class CacheAspect :MethodInterceptionAspect
    {
        private Type _cacheType;
        private int _cacheByMinutes;
        ICacheManager _cacheManager; //Memory REDİS
        public CacheAspect(Type cachetype,int cacheByMinutes=60)
        {
            _cacheType = cachetype;
            _cacheByMinutes = cacheByMinutes;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("Wrong Cache manager");
            }
            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var methodName = string.Format("{0}.{1}.{2}",
                args.Method.ReflectedType.Namespace,
                args.Method.ReflectedType.Name, //class name
                args.Method.Name //metot adı
                );
            var parametres = args.Arguments.ToList();
            var key = string.Format("{0}({1})", methodName, string.Join(",", parametres.Select(x => x != null ? x.ToString() : "<Null>")));
            if (_cacheManager.IsAdd(key)) //varsa olanı getir
                args.ReturnValue = _cacheManager.Get<object>(key);
            _cacheManager.Add(key, args.ReturnValue, _cacheByMinutes);
          
        }
    }
}
