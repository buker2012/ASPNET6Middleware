using ASPNET6Middleware.Extensions;
using ASPNET6Middleware.Logging;
using ASPNET6Middleware.Middleware;

var builder = WebApplication.CreateBuilder(args);

// ��������ӷ���
builder.Services.AddRazorPages();
builder.Services.AddTransient<ILoggingService, LoggingService>();

var app = builder.Build();


// ���� HTTP ����ܵ���
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// ��ܵ�������м���������������ʹ�� Run() ������
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello Dear Readers!");
//});

// ���ǿ�������Զ����м��
// ��ܵ�������м����Ļ��������ǵ��� UseMiddleware<T>
app.UseMiddleware<LayoutMiddleware>();

// ���ǻ�����ʹ���Զ�����չ������ܵ�������м����
app.UseLoggingMiddleware();


// ������м����ע�͵��ˣ���Ϊ����һ���ն��м��
//app.UseSimpleResponseMiddleware();

// ʱ���¼�м��
app.UseTimeLoggingMiddleware();

// �ӳ��м����
// ��ʱ���ӳٱ�������ʱ����־�С�
app.UseIntentionalDelayMiddleware();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
