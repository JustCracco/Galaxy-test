using Galaxy_test;

namespace Libreria_Tests
{
    public class Libreria_Tests
    {
        [Fact]
        public void AddFilmTest()
        {
            Libreria testLibreria = new Libreria();
            Film test_film1 = new Film("Spider-Man", "Sam Raimi", 4.8, false);
            Film test_film2 = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            testLibreria.AddFilm(test_film1);
            testLibreria.AddFilm(test_film2);

            Assert.Equal(testLibreria.getFilmPerNome("Spider-Man"), test_film1.getName());
            Assert.Equal(testLibreria.getFilmPerNome("Guardiani della Galassia"), test_film2.getName());
        }

        [Fact]
        public void GetFilmNotSeenTest()
        {
            Libreria testLibreria = new Libreria();
            Film test_film1 = new Film("Spider-Man", "Sam Raimi", 4.8, false);
            Film test_film2 = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            testLibreria.AddFilm(test_film1);
            testLibreria.AddFilm(test_film2);

            Assert.Equal("Spider-Man, Guardiani della Galassia, ", testLibreria.getListaFilmDaVedere());
        }

        [Fact]
        public void GetFilmTest()
        {
            Libreria testLibreria = new Libreria();
            Film test_film1 = new Film("Spider-Man", "Sam Raimi", 4.8, false);
            Film test_film2 = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            testLibreria.AddFilm(test_film1);
            testLibreria.AddFilm(test_film2);

            Assert.Equal("Spider-Man, Guardiani della Galassia, ", testLibreria.getListaFilm());
        }

        [Fact]
        public void GetFilmFromDirectorTest()
        {
            Libreria testLibreria = new Libreria();
            Film test_film1 = new Film("Spider-Man", "Sam Raimi", 4.8, false);
            Film test_film2 = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            testLibreria.AddFilm(test_film1);
            testLibreria.AddFilm(test_film2);

            Assert.Equal("Spider-Man, ", testLibreria.getFilmFromRegista("Sam Raimi"));
        }

        [Fact]
        public void GetFilmFromNameTest()
        {
            Libreria testLibreria = new Libreria();
            Film test_film1 = new Film("Spider-Man", "Sam Raimi", 4.8, false);
            Film test_film2 = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            testLibreria.AddFilm(test_film1);
            testLibreria.AddFilm(test_film2);

            Assert.Equal("Spider-Man", testLibreria.getFilmPerNome("Spider-Man"));
        }

        [Fact]
        public void DeleteFilmTest()
        {
            Libreria testLibreria = new Libreria();
            Film test_film1 = new Film("Spider-Man", "Sam Raimi", 4.8, false);
            Film test_film2 = new Film("Guardiani della Galassia", "James Gunn", 4.5, false);

            testLibreria.AddFilm(test_film1);
            testLibreria.AddFilm(test_film2);

            testLibreria.RemoveFilm(test_film1);

            Assert.NotEqual("Spider-Man", testLibreria.getFilmPerNome("Spider-Man"));
        }
    }
}