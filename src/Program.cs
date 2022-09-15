using JlucsxCourses.ContentContext;
using JlucsxCourses.SubscriptionContext;

var articles = new List<Article>();
articles.Add(
    new("Artigo sobre OOP", "orientacao-objetos")
    );
articles.Add(
    new("Artigo sobre C#", "csharp")
    );
articles.Add(
    new("Artigo sobre .NET", "dotnet")
    );
foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
    Console.WriteLine("==");
}

var courseOop = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCs = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAsp = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
var courses = new List<Course>();
courses.Add(courseOop);
courses.Add(courseCs);
courses.Add(courseAsp);


var careers = new List<Career>();
var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
var careerItem1 = new CareerItem(
    1, "Comece por aqui", "Primeiro curso!", courseOop);
var careerItem2 = new CareerItem(
    2, "Fundamentos do C#", "O básico essencial sobre C#", null);
careerDotnet.Items.Add(careerItem2);
careerDotnet.Items.Add(careerItem1);
careers.Add(careerDotnet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.Write($"{item.Order} - {item.Title}");
        if (item.IsInvalid)
            Console.WriteLine($"| <Invalid>[{item.Notifications.Single().Message}]");
        Console.WriteLine();
    }
}

var payPalSubscription = new PayPalSubscription();
var student = new Student();
student.CreateSubscription(payPalSubscription);

static void Breakpoint() { }