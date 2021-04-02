using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Homework3
{
    public class Repository
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("node_id")]
        public string node_id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("full_name")]
        public string full_name { get; set; }
        //[JsonPropertyName("pprivate")]
        //public bool pprivate { get; set; }
        [JsonPropertyName("owner")]
        public Owner owner { get; set; }
        //[JsonPropertyName("html_url")]
        //public string html_url { get; set; }
        //[JsonPropertyName("description")]
        //public string description { get; set; }
        //[JsonPropertyName("fork")]
        //public bool fork { get; set; }
        //[JsonPropertyName("url")]
        //public string url { get; set; }
        //[JsonPropertyName("forks_url")]
        //public string forks_url { get; set; }
        //[JsonPropertyName("keys_url")]
        //public string keys_url { get; set; }
        //[JsonPropertyName("collaborators_url")]
        //public string collaborators_url { get; set; }
        //[JsonPropertyName("teams_url")]
        //public string teams_url { get; set; }
        //[JsonPropertyName("hooks_url")]
        //public string hooks_url { get; set; }
        //[JsonPropertyName("issue_events_url")]
        //public string issue_events_url { get; set; }
        //[JsonPropertyName("events_url")]
        //public string events_url { get; set; }
        //[JsonPropertyName("assignees_url")]
        //public string assignees_url { get; set; }
        //[JsonPropertyName("branches_url")]
        //public string branches_url { get; set; }
        //[JsonPropertyName("tags_url")]
        //public string tags_url { get; set; }
        //[JsonPropertyName("blobs_url")]
        //public string blobs_url { get; set; }
        //[JsonPropertyName("git_tags_url")]
        //public string git_tags_url { get; set; }
        //[JsonPropertyName("git_refs_url")]
        //public string git_refs_url { get; set; }
        //[JsonPropertyName("trees_url")]
        //public string trees_url { get; set; }
        //[JsonPropertyName("statuses_url")]
        //public string statuses_url { get; set; }
        //[JsonPropertyName("languages_url")]
        //public string languages_url { get; set; }
        //[JsonPropertyName("stargazers_url")]
        //public string stargazers_url { get; set; }
        //[JsonPropertyName("contributors_url")]
        //public string contributors_url { get; set; }
        //[JsonPropertyName("subscribers_url")]
        //public string subscribers_url { get; set; }
        //[JsonPropertyName("subscription_url")]
        //public string subscription_url { get; set; }
        [JsonPropertyName("commits_url")]
        public string commits_url { get; set; }
        //[JsonPropertyName("git_commits_url")]
        //public string git_commits_url { get; set; }
        //[JsonPropertyName("comments_url")]
        //public string comments_url { get; set; }
        //[JsonPropertyName("issue_comment_url")]
        //public string issue_comment_url { get; set; }
        //[JsonPropertyName("contents_url")]
        //public string contents_url { get; set; }
        //[JsonPropertyName("compare_url")]
        //public string compare_url { get; set; }
        //[JsonPropertyName("merges_url")]
        //public string merges_url { get; set; }
        //[JsonPropertyName("archive_url")]
        //public string archive_url { get; set; }
        //[JsonPropertyName("downloads_url")]
        //public string downloads_url { get; set; }
        //[JsonPropertyName("issues_url")]
        //public string issues_url { get; set; }
        //[JsonPropertyName("pulls_url")]
        //public string pulls_url { get; set; }
        //[JsonPropertyName("milestones_url")]
        //public string milestones_url { get; set; }
        //[JsonPropertyName("notifications_url")]
        //public string notifications_url { get; set; }
        //[JsonPropertyName("labels_url")]
        //public string labels_url { get; set; }
        //[JsonPropertyName("releases_url")]
        //public string releases_url { get; set; }
        //[JsonPropertyName("deployments_url")]
        //public string deployments_url { get; set; }
        //[JsonPropertyName("created_at")]
        //public DateTime created_at { get; set; }
        //[JsonPropertyName("updated_at")]
        //public DateTime updated_at { get; set; }
        //[JsonPropertyName("pushed_at")]
        //public DateTime pushed_at { get; set; }
        //[JsonPropertyName("git_url")]
        //public string git_url { get; set; }
        //[JsonPropertyName("ssh_url")]
        //public string ssh_url { get; set; }
        //[JsonPropertyName("clone_url")]
        //public string clone_url { get; set; }
        //[JsonPropertyName("svn_url")]
        //public string svn_url { get; set; }
        //[JsonPropertyName("homepage")]
        //public string homepage { get; set; }
        //[JsonPropertyName("size")]
        //public int size { get; set; }
        [JsonPropertyName("stargazers_count")]
        public int stargazers_count { get; set; }
        //[JsonPropertyName("watchers_count")]
        //public int watchers_count { get; set; }
        //[JsonPropertyName("language")]
        //public string language { get; set; }
        //[JsonPropertyName("has_issues")]
        //public bool has_issues { get; set; }
        //[JsonPropertyName("has_projects")]
        //public bool has_projects { get; set; }
        //[JsonPropertyName("has_downloads")]
        //public bool has_downloads { get; set; }
        //[JsonPropertyName("has_wiki")]
        //public bool has_wiki { get; set; }
        //[JsonPropertyName("has_pages")]
        //public bool has_pages { get; set; }
        //[JsonPropertyName("forks_count")]
        //public int forks_count { get; set; }
        //[JsonPropertyName("mirror_url")]
        //public bool mirror_url { get; set; }
        //[JsonPropertyName("archived")]
        //public bool archived { get; set; }
        //[JsonPropertyName("disabled")]
        //public bool disabled { get; set; }
        //[JsonPropertyName("open_issues_count")]
        //public int open_issues_count { get; set; }
        //[JsonPropertyName("license")]
        public License license { get; set; }
        //[JsonPropertyName("forks")]
        //public int forks { get; set; }
        //[JsonPropertyName("open_issues")]
        //public int open_issues { get; set; }
        //[JsonPropertyName("watchers")]
        //public int watchers { get; set; }
        //[JsonPropertyName("default_branch")]
        //public string default_branch { get; set; }

    }
}
