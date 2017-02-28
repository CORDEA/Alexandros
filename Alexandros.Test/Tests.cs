using System.Threading.Tasks;
using NUnit.Framework;

namespace Alexandros.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public async Task 値が入ること()
        {
            var provider = new AlexandrosProvider<TestClass>();
            var test = await provider.InjectAsync();

            Assert.NotNull(test.StringProperty);

            Assert.NotZero(test.LongProperty);

            var result = test.SearchProperty;
            Assert.NotZero(result.ArtistId);
            Assert.NotZero(result.CollectionId);
            Assert.NotZero(result.TrackId);
            Assert.NotNull(result.ArtistName);
            Assert.NotNull(result.CollectionName);
            Assert.NotNull(result.TrackName);
            Assert.NotNull(result.CollectionCensoredName);
            Assert.NotNull(result.TrackCensoredName);
            Assert.NotNull(result.ArtistViewUrl);
            Assert.NotNull(result.CollectionViewUrl);
            Assert.NotNull(result.TrackViewUrl);
            Assert.NotNull(result.ArtworkUrl30);
            Assert.NotNull(result.ArtworkUrl60);
            Assert.NotNull(result.ArtworkUrl100);
            Assert.NotZero(result.CollectionPrice);
            Assert.NotZero(result.TrackPrice);
            Assert.NotNull(result.ReleaseDate);
            Assert.NotZero(result.DiscCount);
            Assert.NotZero(result.DiscNumber);
            Assert.NotZero(result.TrackCount);
            Assert.NotZero(result.TrackNumber);
            Assert.NotZero(result.TrackTimeMillis);
            Assert.NotNull(result.Currency);
        }

        [Test]
        public async Task 値が入らないこと()
        {
            var provider = new AlexandrosProvider<TestClass>();
            var test = await provider.InjectAsync();

            Assert.Null(test.ReadOnlyStringProperty);

            Assert.Zero(test.ReadOnlyLongProperty);

            Assert.Null(test.ReadOnlySearchProperty);
        }

        [Test]
        public async Task 想定外の型に値が入らないこと()
        {
            var provider = new AlexandrosProvider<TestClass>();
            var test = await provider.InjectAsync();

            Assert.Zero(test.IntProperty);

            Assert.Null(test.StringsProperty);
        }
    }
}