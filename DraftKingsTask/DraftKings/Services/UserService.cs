using DraftKings.Endpoints;
using DraftKings.Models;
using DraftKings.Utilities;
using Newtonsoft.Json;

namespace DraftKings.Services
{
    /// <summary>
    /// User Service
    /// </summary>
    public class UserService : BaseSingletonLazy<UserService>
    {
        /// <summary>
        /// Get Article Users.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public async Task <GetArticleUsersResponseDto> GetArticleUsers(HttpClient client, int page)          
        {
            var url = client.BaseAddress + UserServiceEndpoints.Instance.GetArticleUsersPerPage(page);

            var response = await client.GetStringAsync(url);

            GetArticleUsersResponseDto articleUsers = JsonConvert.DeserializeObject<GetArticleUsersResponseDto>(response);

            return articleUsers;

        }
    }
}
