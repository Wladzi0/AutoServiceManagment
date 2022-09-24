namespace AutoService.Person
{
    interface IBasicUserModel
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string GetFullName { get; }
       
    }
}