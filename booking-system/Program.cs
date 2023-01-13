using booking_system.models;
using MongoDB.Driver;
using booking_system.service;
using Microsoft.Extensions.Options;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<GuestsDatabaseSettings>(
    builder.Configuration.GetSection(nameof(GuestsDatabaseSettings)));

builder.Services.AddSingleton<IGuestsDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<GuestsDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("GuestsDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<IGuestsService, GuestsService>();
builder.Services.AddScoped<IServicesService, ServicesService>();
builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<IAppointmentsService, AppointmentsService>();

builder.Services.Configure<GuestsDatabaseSettings>(
    builder.Configuration.GetSection(nameof(GuestsDatabaseSettings)));
builder.Services.Configure<ServicesDatabaseSettings>(
    builder.Configuration.GetSection(nameof(ServicesDatabaseSettings)));
builder.Services.Configure<StaffDatabaseSettings>(
    builder.Configuration.GetSection(nameof(StaffDatabaseSettings)));
builder.Services.Configure<AppointmentsDatabaseSettings>(
    builder.Configuration.GetSection(nameof(AppointmentsDatabaseSettings)));

builder.Services.AddSingleton<IGuestsDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<GuestsDatabaseSettings>>().Value);
builder.Services.AddSingleton<IServicesDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<ServicesDatabaseSettings>>().Value);
builder.Services.AddSingleton<IStaffDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<StaffDatabaseSettings>>().Value);
builder.Services.AddSingleton<IAppointmentsDatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<AppointmentsDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("GuestsDatabaseSettings:ConnectionString")));
builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("ServicesDatabaseSettings:ConnectionString")));
builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("StaffDatabaseSettings:ConnectionString")));
builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("AppointmentsDatabaseSettings:ConnectionString")));

builder.Services.AddControllersWithViews();

builder.Services.AddSwaggerGen();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:44447","http://www.contoso.com")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();// add the allowed origins
                      });
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod();
        //.AllowCredentials();
    });
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);
app.UseCors("CorsPolicy");


app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapFallbackToFile("index.html");



app.Run();


