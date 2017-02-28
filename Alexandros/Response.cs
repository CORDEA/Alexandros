using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alexandros
{
    [JsonObject(MemberSerialization.OptOut)]
    internal class Response
    {
        public int ResultCount { get; set; }

        public List<SearchResult> Results { get; set; }
    }
}