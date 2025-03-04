using WM_ControlIngreso_Api.Repositories.Implementations;
using WM_ControlIngreso_Api.Repositories.Interfaces;
using WM_ControlIngreso_Api.Services.Implementations;
using WM_ControlIngreso_Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// 1. Agrega CORS en los servicios
builder.Services.AddCors(options =>
{
    // Puedes nombrar la política como desees, aquí la llamamos "AngularPolicy"
    options.AddPolicy(name: "AngularPolicy",
                      policy =>
                      {
                          // Ajusta la URL de tu cliente Angular
                          policy.WithOrigins("http://localhost:4200")
                                .AllowAnyHeader()
                                .AllowAnyMethod()
                                .AllowCredentials();
                      });
});

// 2. Agrega controladores
builder.Services.AddControllers();

// Configurar inyección de dependencias
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ISubvencionRepository, SubvencionRepository>();
builder.Services.AddScoped<ISubvencionService, SubvencionService>();
builder.Services.AddScoped<IRacionRepository, RacionRepository>();
builder.Services.AddScoped<IRacionService, RacionService>();

// 3. Configura Swagger, si lo usas
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 4. Construye la aplicación
var app = builder.Build();

// 5. Usa la política de CORS antes de MapControllers
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Importante: CORS se aplica antes de MapControllers
app.UseCors("AngularPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
