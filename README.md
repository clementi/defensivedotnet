DefensiveDotNet: Defensive Programming for .NET
===============================================

Ever find yourself checking for null or otherwise invalid parameters?

```csharp
public void SomeMethod(string parameter)
{
    if (parameter == null)
        throw new ArgumentNullException("parameter");
        
    // Do something interesting with the parameter
}
```

With DefensiveDotNet, you can do this instead:

```csharp
public void SomeMethod(string parameter)
{
    Defend.AgainstNullParameter(parameter, "parameter");
    
    // Do something interesting with the parameter
}
```
