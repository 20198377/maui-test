namespace phis_ievents_offline.Data;

public class Registrant
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string EmployeeId { get; set; }
    public string Department { get; set; }
    public string SubDepartment { get; set; }
    public string Gender { get; set; }
    public string ManagerEmployeeId { get; set; }
    public Guid Qr { get; set; }
    public bool IsRegistered { get; set; }
    public bool IsTranspoRegistered { get; set; }
    public string Schedule { get; set; }
    public string Room { get; set; }
    public string Group { get; set; }
    public string DietaryRestriction { get; set; }
}
