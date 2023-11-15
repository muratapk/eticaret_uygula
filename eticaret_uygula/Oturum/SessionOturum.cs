using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace eticaret_uygula.Oturum
{
    public static class SessionOturum
    {
        public static void SetJson(this ISession session,string key,object value)
        {
            session.SetString(key,JsonConvert.SerializeObject(value));
        }
        public static  T GetJson<T>(this ISession session,string key)
        {
            var sessionData=session.GetString(key);
            return sessionData == null ? default(T):JsonConvert.DeserializeObject<T>(sessionData);
        }
    }
}
