using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ChaptersController : ControllerBase
{
    private readonly LearnDBContext learnDBContext;

    public ChaptersController(LearnDBContext learnDBContext)
    {
        this.learnDBContext = learnDBContext;
    }

    [HttpGet]
    public async Task<IEnumerable<Chapter>> GetChaptersAsync()
    {
        return await learnDBContext.Chapters.ToListAsync();
    }

    [HttpPost]
    public async Task<Chapter> PostChapterAsync(Chapter chapter)
    {
        learnDBContext.Chapters.Add(chapter);
        await learnDBContext.SaveChangesAsync();
        return chapter;
    }

    [HttpPut]
    public async Task<Chapter> PutChapterAsync(Chapter chapter)
    {
       learnDBContext.Update(chapter);
       await learnDBContext.SaveChangesAsync();
       return chapter;
    }

    [HttpDelete]
    public async Task DeleteChapterAsync(Chapter chapter)
    {
        learnDBContext.Chapters.Remove(chapter);
        await learnDBContext.SaveChangesAsync();
    }
}