using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly LearnDBContext learnDBContext;

    public UsersController(LearnDBContext learnDBContext)
    {
        this.learnDBContext = learnDBContext;
    }

    [HttpGet]
    public async Task<IEnumerable<User>> GetChaptersAsync()
    {
        return await learnDBContext.Users.ToListAsync();
    }

    [HttpPost]
    public async Task<User> PostChapterAsync(User user)
    {
        learnDBContext.Users.Add(user);
        await learnDBContext.SaveChangesAsync();
        return user;
    }

    [HttpPut]
    public async Task<User> PutChapterAsync(User user)
    {
       learnDBContext.Update(user);
       await learnDBContext.SaveChangesAsync();
       return user;
    }

    [HttpDelete]
    public async Task DeleteChapterAsync(User user)
    {
        learnDBContext.Users.Remove(user);
        await learnDBContext.SaveChangesAsync();
    }
}