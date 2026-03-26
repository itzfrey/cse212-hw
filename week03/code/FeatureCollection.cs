public class FeatureCollection
{
    public List<Feature> Features { get; set; } = [];
}
 
/// <summary>
/// Represents a single earthquake event (GeoJSON Feature).
/// </summary>
public class Feature
{
    public EarthquakeProperties Properties { get; set; } = new();
}
 
/// <summary>
/// Holds the relevant properties of each earthquake event.
/// </summary>
public class EarthquakeProperties
{
    public string Place { get; set; } = "";
    public double? Mag   { get; set; }
}