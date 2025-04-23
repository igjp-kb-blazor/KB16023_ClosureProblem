namespace KB16023_BlazorWasmApp1.Data;

public class SimpleTodoItem
{
    public String UniqueKey { get; set; } = Guid.NewGuid().ToString();
    public String Text { get; set; } = "";
    public bool Done { get; set; }
}
