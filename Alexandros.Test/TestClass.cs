using System.Collections.Generic;

namespace Alexandros.Test
{
	public class TestClass
	{

	    [Alexandros]
	    public SearchResult SearchProperty { get; set; }

	    [Alexandros]
	    public string StringProperty { get; set; }

	    [Alexandros]
	    public long LongProperty { get; set; }

	    [Alexandros]
	    public SearchResult ReadOnlySearchProperty { get; }

	    [Alexandros]
	    public string ReadOnlyStringProperty { get; }

	    [Alexandros]
	    public long ReadOnlyLongProperty { get; }

	    [Alexandros]
	    public int IntProperty { get; set; }

	    [Alexandros]
	    public List<string> StringsProperty { get; set; }

	}
}
