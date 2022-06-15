using U_Send_First.Common;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<Settings>(builder.Configuration.GetSection(nameof(Settings)));

builder.Services.AddData(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataServices();

builder.Services.AddCors(option => { option.AddPolicy("all", p => { p.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader(); }); });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("all");
app.UseAuthorization();

app.MapControllers();

app.Run();
