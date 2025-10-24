using trab1.Model;
using trab1.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Register repositories
builder.Services.AddSingleton<IChannelRepository, ChannelRepository>();
builder.Services.AddSingleton<IMusicRepository, MusicRepository>();
builder.Services.AddSingleton<ICommentRepository, CommentRepository>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => "API está funcionando! Use /api/channel, /api/music, /api/comment");
app.Run();