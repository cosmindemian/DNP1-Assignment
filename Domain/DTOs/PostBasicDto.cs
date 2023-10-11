namespace Domain.DTOs;

public class PostBasicDto
{
    public int Id { get; }
    public string OwnerName { get; }
    public string Title { get; }
    public string Body { get; }
    public bool IsCompleted { get;  }

    public PostBasicDto(int id, string ownerName, string title, string body, bool isCompleted)
    {
        Id = id;
        OwnerName = ownerName;
        Title = title;
        IsCompleted = isCompleted;
        Body = body;
    }
}