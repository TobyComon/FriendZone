using System;

namespace FriendZone.Interfaces
{
    public interface IRepoItem<T, T2>
    {
        string Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}