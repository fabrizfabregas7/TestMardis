
using UnityEngine;
using WebStyleDemo.Models;
namespace WebStyleDemo.Services
{
    class JsonServices : IService
    {

        // Singleton
        private static JsonServices instance;
        public static JsonServices Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JsonServices();
                }

                return instance;
            }
        }

        void IService.Dispose()
        {
            
        }

        void IService.Initialize()
        {
            
        }
        private JsonServices() { }

        public void Initialize() { }
        public void Dispose() { }

        /// <summary>
        /// String to object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="text"></param>
        /// <returns></returns>
        public T Deserialize<T>(string text)
        {
            return JsonUtility.FromJson<T>(text);
        }

        /// <summary>
        /// Object to String
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public string Serialize<T>(T data)
        {
            return JsonUtility.ToJson(data);
        }
    }
}
