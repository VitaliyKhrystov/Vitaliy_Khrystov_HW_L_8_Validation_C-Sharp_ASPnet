namespace Task1
{
    public class Program
    {

        //Задание 1 (Additional Task)
        //Создайте форму регистрации на консультацию.В форме должны быть поля:
        //Имя Фамилия
        //Email
        //Желаемая дата консультации
        //Все поля обязательные для ввода.Email должен быть в соответствующем формате. Дата
        //консультации должна быть правильной датой, она должна быть в будущем и не должна
        //попадать на выходные дни.
        //При наличии ошибок, необходимо оповестить пользователя об ошибках.

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{data?}");

            app.Run();
        }
    }
}