# [Alexandros]

[Alexandros] is a Japanese rock band.  
Alexandros attribute has no meaning. Just a joke.

## Usage

```cs
public class Target
{
    [Alexandros]
    public SearchResult SearchProperty { get; set; }

    [Alexandros]
    public string StringProperty { get; set; }

    [Alexandros]
    public long LongProperty { get; set; }
}
```

```cs
var provider = new AlexandrosProvider<Target>();
var target = await provider.ProvideAsync();
```
