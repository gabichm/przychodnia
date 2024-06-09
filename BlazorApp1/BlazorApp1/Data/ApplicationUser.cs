using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public DateOnly? BirthDate { get; set; }
    public  string? Name { get; set; }
    public  string? LastName { get; set; }
    public  string? Phone { get; set; }
   
}
