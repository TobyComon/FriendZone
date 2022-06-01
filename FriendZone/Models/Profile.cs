using System;
using FriendZone.Interfaces;

namespace FriendZone.Models
{
    public class Profile : IRepoItem<string, Id>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}