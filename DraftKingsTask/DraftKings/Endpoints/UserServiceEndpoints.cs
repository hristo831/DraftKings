using DraftKings.Utilities;

namespace DraftKings.Endpoints
{
    /// <summary>
    /// Gets user service endpoints.
    /// </summary>
    public class UserServiceEndpoints : BaseSingletonLazy<UserServiceEndpoints>
    {
        /// <summary>
        /// Gets article users per page.
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public string GetArticleUsersPerPage(int page)
            => $"/article_users?page={page}";
    }
}
