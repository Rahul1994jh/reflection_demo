// See https://aka.ms/new-console-template for more information
using ReflectionDemo;
using System.Reflection;

TransformLogSearch();

static void TransformLogSearch()
{
    var logSearch =  LogSearch.GetDummyLogSearch();
    var keys = FilterPropertyWithValue<LogSearch>(logSearch);
    foreach (var key in keys)
    {
        Console.WriteLine(key);
    }
}

static string?[] FilterPropertyWithValue<T>(T input)
{
    return typeof(T)
               .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
               .Where(x => Attribute.IsDefined(x, typeof(SearchAttribute)))
               .Where(x => x.GetValue(input) != null)
               .Select(x =>
                    x.GetCustomAttributes(true)
                        .First(y => y.GetType() == typeof(SearchAttribute)) as SearchAttribute)
               .Select(x => x?.Name)
               .ToArray();
}