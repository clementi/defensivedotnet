Defensive.NET
===============

Defensive Programming for .NET

Ever find yourself checking for null or otherwise invalid parameters?

```csharp
public void SomeMethod(string parameter)
{
    if (parameter == null)
        throw new ArgumentNullException("parameter");
        
    // Do something interesting with the parameter
}
```

With Defensive.NET, you can do this instead:

```csharp
public void SomeMethod(string parameter)
{
    Defend.AgainstNullParameter(parameter, "parameter");
    
    // Do something interesting with the parameter
}
```

You can also defend against:

* Null or empty string parameters
* Null or whitespace string parameters
* Any "bad" condition: `Defend.Against(IsBad(parameter), "parameter")`

Defensive.NET is based on code by Loren Whitney.
