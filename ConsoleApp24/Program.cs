double? x = null;
double? y = 10.0;
    
Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);