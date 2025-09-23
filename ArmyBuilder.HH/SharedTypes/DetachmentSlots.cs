namespace SharedTypes;

internal class DetachmentSlots {
    public string? SlotId { get; set; }            // Unique ID like "prime-command-1"
    public string? SlotType { get; set; }          // e.g., "prime" or "standard"
    public string? UnitType { get; set; }          // e.g., "Command", "Troops"
    public bool IsFilled { get; set; } = false;   // Tracks if this slot is occupied
    public string? AssignedUnitId { get; set; }    // Which unit is assigned here (optional)
}