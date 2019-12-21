using System;

public abstract class BaseEntity
{
    public string Id { get; set; }

    public BaseEntity(){
        Id = Guid.NewGuid().ToString();
    }
}