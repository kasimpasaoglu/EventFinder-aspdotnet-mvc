using Microsoft.AspNetCore.Mvc;

public class EventController:Controller

{
    private readonly AppDbContext _context;
    public EventController(AppDbContext context)
    {
        _context=context;
    }
public IActionResult Index()
{
    List<Event> events=_context.Events.ToList();
    return View(events);
}
}