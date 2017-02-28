using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Alexandros
{
    public class AlexandrosProvider<T> where T : new()
    {

        private T Object { get; }

        public AlexandrosProvider()
        {
            Object = new T();
        }

        public async Task<T> InjectAsync()
        {
            var properties = typeof(T).GetRuntimeProperties();
            foreach (var property in properties)
            {
                var attr = property.GetCustomAttribute(typeof(Alexandros));
                if (attr == null)
                {
                    continue;
                }

                if (!property.CanWrite || !(property.SetMethod?.IsPublic ?? false))
                {
                    continue;
                }

                var response = await ApiClient.Search("Alexandros", "ja_jp", "jp", 10);
                var random = new Random();
                var result = response.Results[random.Next(response.ResultCount)];
                if (property.PropertyType == typeof(SearchResult))
                {
                    property.SetValue(Object, result);
                }
                if (property.PropertyType == typeof(string))
                {
                    property.SetValue(Object, result.TrackName);
                }
                if (property.PropertyType == typeof(long))
                {
                    property.SetValue(Object, result.TrackId);
                }
            }
            return Object;
        }

    }
}