using Microsoft.AspNetCore.Identity;

string? input = null;

while (input == null)
{
    Console.WriteLine("Enter the password that you want to hash:");
    input = Console.ReadLine();
} 

PasswordHasher<IdentityUser> passwordHasher = new();

IdentityUser testUser = new()
{
    Email = "test@example.com"
};

string hash = passwordHasher.HashPassword(testUser, input);

Console.WriteLine("Your hashed password:");
Console.WriteLine(hash);
