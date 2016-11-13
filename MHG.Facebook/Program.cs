using Facebook;

namespace MHG.Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://developers.facebook.com/docs/facebook-login/access-tokens#extending
            var fb = new FacebookClient("[accessToken]");
            var res = fb.Get("/me");
        }
    }
}
