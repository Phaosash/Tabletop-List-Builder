using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTypes;

internal class ViewModelSample {
    //public Detachment SelectedDetachment { get; set; }
    //public ObservableCollection<DetachmentSlotViewModel> Slots { get; set; }
    //public ObservableCollection<Unit> AvailableUnits { get; set; }
    
    //// Called when user selects a detachment
    //public void LoadDetachment(Detachment detachment)
    //{
    //    SelectedDetachment = detachment;
    //    Slots = new ObservableCollection<DetachmentSlotViewModel>(
    //        detachment.Slots.Select(s => new DetachmentSlotViewModel(s)));
        
    //    // Filter AvailableUnits by faction, allegiance, and slot UnitType (initially show all units)
    //}
    
    //// User picks a unit for a slot
    //public bool AssignUnitToSlot(Unit unit, DetachmentSlotViewModel slot)
    //{
    //    if(slot.IsFilled) return false; // slot already taken
    //    if(unit.ForceOrgSlot != slot.UnitType) return false; // mismatch
        
    //    slot.AssignUnit(unit);
    //    AvailableUnits.Remove(unit);
    //    return true;
    //}
    
    //// User removes unit from slot
    //public void RemoveUnitFromSlot(DetachmentSlotViewModel slot)
    //{
    //    var unit = slot.AssignedUnit;
    //    slot.Clear();
    //    if(unit != null)
    //        AvailableUnits.Add(unit);
    //}
}
