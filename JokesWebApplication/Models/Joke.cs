namespace JokesWebApplication.Models
{
    public class Joke
    {
        public int jokeID { get; set; }

        public string jokeQuestion { get; set; }

        public string jokeAnswer { get; set; }

        public string jokeAuthor { get; set;}

        public Joke()
        {
                
        }
    }
}
