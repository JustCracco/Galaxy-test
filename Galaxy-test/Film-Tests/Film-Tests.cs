using Galaxy_test;

namespace Film_Tests
{
    public class Film_Tests
    {
        [Fact]
        public void ConstructorTest()
        {
            Film test_film = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            Assert.Equal("Guardiani della Galassia", test_film.getName());
        }

        [Fact]
        public void DirectorTest() 
        {
            Film test_film = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            Assert.Equal("James Gunn", test_film.getRegista());
        }

        [Fact]
        public void VotesTest()
        {
            Film test_film = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            Assert.Equal(4.5, test_film.getMediarecensione(), .001);
        }

        [Fact]
        public void SeenTest()
        {
            Film test_film = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            Assert.False(test_film.getVisto());
        }

        [Fact]
        public void ModifiedSeenTest()
        {
            Film test_film = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            test_film.setVisto();

            Assert.True(test_film.getVisto());
        }
    }
}