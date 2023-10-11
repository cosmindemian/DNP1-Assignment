namespace Domain.DTOs;

public class PostCreationDto
{
    public int OwnerId { get; }
    public string Title { get; }

    public PostCreationDto(int ownerId, string title)
    {
        OwnerId = ownerId;
        Title = title;
    }
}