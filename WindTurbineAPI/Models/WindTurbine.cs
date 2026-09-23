namespace WindTurbineAPI.Models;
{
public class WindTurbine
{
    public int Id { get; set; } // Primary Key
    // Properties of the Wind Turbine
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public double Capacity { get; set; } // in MW
    public string Status { get; set; } = "Active"; // e.g., "Operational", "Maintenance" , "Offline
   
}


}