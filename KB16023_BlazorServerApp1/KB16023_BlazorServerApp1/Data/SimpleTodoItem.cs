namespace KB16023_BlazorServerApp1.Data;

public class SimpleTodoItem
{
    public String UniqueKey { get; set; } = Guid.NewGuid().ToString();
    public String Text { get; set; } = "";
    public bool Answer { get; set; }

    public SimpleTodoItem()
    {
    }
}
