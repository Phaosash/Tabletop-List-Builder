using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTypes;

// Your main detachment class holds all slots
internal class Detachment {
    public string? Name { get; set; }
    public List<DetachmentSlots>? Slots { get; set; }

    // Attempt to assign a unit to an available slot
    public bool TryAssignUnit(Unit unit)
    {
        // Find first available slot matching unit's forceOrgSlot (unit.UnitType)
        var availableSlot = Slots.FirstOrDefault(slot =>
            !slot.IsFilled && slot.UnitType == unit.ForceOrgSlot);

        if (availableSlot == null)
        {
            // No available slot found
            return false;
        }

        // Assign unit to slot
        availableSlot.IsFilled = true;
        availableSlot.AssignedUnitId = unit.Id;
        return true;
    }

    // Remove unit assignment (e.g., user removes unit)
    public bool RemoveUnit(string unitId)
    {
        var slot = Slots.FirstOrDefault(s => s.AssignedUnitId == unitId);
        if (slot == null)
            return false;

        slot.IsFilled = false;
        slot.AssignedUnitId = null;
        return true;
    }

    // Validate if detachment is legal: all required slots filled, etc.
    public bool Validate(out List<string> errors)
    {
        errors = new List<string>();

        // Example: Check if any prime slots are unfilled
        var unfilledPrimeSlots = Slots
            .Where(s => s.SlotType == "prime" && !s.IsFilled)
            .ToList();

        if (unfilledPrimeSlots.Any())
        {
            errors.Add("Some prime slots are not filled.");
        }

        // Could add more validation here: min/max counts, etc.

        return errors.Count == 0;
    }

}