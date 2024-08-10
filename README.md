# Password Hasher

A console app that reads a string and outputs the hash of that string that would be the `PasswordHash` of the `IdentityUser` in ASP.NET Core Identity if a user was registered with that string as the password.

```
> dotnet run
Enter the password that you want to hash:
777777777
Your hashed password:
AQAAAAIAAYagAAAAEHf5mHXxQU+WYiLqCrTteJmAK4gzo6vt2lup+WLm/HdhRvtUJe5Y1KAs1ayB8uk7ow==
```
