# 7Wells_Monogame
 A monogame repo for the 7wells game developers community

 How to install monogame:
  https://docs.monogame.net/articles/getting_started/index.html


## Using Option<T> and Result<TOk, TError>

The Option<T> struct provides a way to represent values that may or may not exist, eliminating the use of nulls. This approach enhances safety and clarity in your code. For example, when retrieving a configuration setting:
```
Option<string> GetSetting(string key) {
    if (config.TryGetValue(key, out var value)) {
        return Option.Some(value);
    }
    return Option.None;
}

// Usage
var settingOption = GetSetting("Theme");
settingOption.Match(
    some: setting => Console.WriteLine($"Setting: {setting}"),
    none: () => Console.WriteLine("Setting not found.")
);
```


The Result<TOk, TError> struct is designed for operations that can succeed or fail, allowing you to return a value along with an error state. This avoids exceptions and promotes clearer error handling. For example, consider a function that divides two numbers:

```
Result<double, string> Divide(double numerator, double denominator) {
    if (denominator == 0) {
        return Result.Error("Cannot divide by zero.");
    }
    return Result.Ok(numerator / denominator);
}

// Usage
var result = Divide(10, 2);
result.Match(
    ok => Console.WriteLine($"Result: {ok}"),
    error => Console.WriteLine($"Error: {error}")
);
```
