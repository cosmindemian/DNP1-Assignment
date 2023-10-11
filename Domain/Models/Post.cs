namespace Domain.Models;

public class Post
{
    public int Id { get; set; }
    public User Owner { get; }
    public string Title { get; }

    public bool IsCompleted { get; set; }

    public Post(User owner, string title)
    {
        Owner = owner;
        Title = title;
    }
}