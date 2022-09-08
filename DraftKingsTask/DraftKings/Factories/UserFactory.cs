using DraftKings.Models;
using DraftKings.Utilities;

namespace DraftKings.Factories
{
    /// <summary>
    /// User Factory
    /// </summary>
    public class UserFactory : BaseSingletonLazy<UserFactory>
    {
        /// <summary>
        /// Get usernames.
        /// </summary>
        /// <param name="articleUsers"></param>
        /// <param name="submission"></param>
        /// <returns></returns>
        public List<string> GetUsernames(GetArticleUsersResponseDto articleUsers, int submission)
        {
            List<string> usernames = new List<string>();    

            foreach (var user in articleUsers.Data)
            {
                if (user.SubmissionCount > submission)
                    usernames.Add(user.Username);
            }

            return usernames;   
        }
    }
}
