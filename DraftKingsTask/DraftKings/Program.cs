using DraftKings.Factories;
using DraftKings.Services;


int page = 1;
int submission = 10;


HttpClient client = new HttpClient().GetClient();

var articleUsers = UserService.Instance.GetArticleUsers(client: client, page: page);

var usernames = UserFactory.Instance.GetUsernames(articleUsers: articleUsers.Result, submission: submission);


foreach (var username in usernames)
{
    Console.WriteLine(username);
}


