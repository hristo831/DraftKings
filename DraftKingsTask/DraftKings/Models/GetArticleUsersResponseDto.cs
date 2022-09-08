using Newtonsoft.Json;

namespace DraftKings.Models
{
    /// <summary>
    /// Get Aticle Users Response.
    /// </summary>
    public class GetArticleUsersResponseDto
    {
        /// <summary>
        /// Gets or sets page.
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets per page.
        /// </summary>
        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        /// <summary>
        /// Gets or sets total.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets total pages.
        /// </summary>
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        [JsonProperty("data")]
        public List<UserDto> Data { get; set; }
    }

    public class UserDto
    {
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets about.
        /// </summary>
        [JsonProperty("about")]
        public string About { get; set; }

        /// <summary>
        /// Gets or sets submitted.
        /// </summary>
        [JsonProperty("submitted")]
        public int Submitted { get; set; }

        /// <summary>
        /// Gets or sets updatedAt.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets submission count.
        /// </summary>
        [JsonProperty("submission_count")]
        public int SubmissionCount { get; set; }

        /// <summary>
        /// Gets or sets comment count.
        /// </summary>
        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        /// <summary>
        /// Gets or sets createdAt.
        /// </summary>
        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }
}
