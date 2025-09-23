using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTypes;

internal class DetachmentSlotViewModel /*: INotifyPropertyChanged*/ {
    //public string SlotId { get; }
    //public string SlotType { get; }
    //public string UnitType { get; }
    
    //private Unit _assignedUnit;
    //public Unit AssignedUnit
    //{
    //    get => _assignedUnit;
    //    private set
    //    {
    //        _assignedUnit = value;
    //        OnPropertyChanged();
    //        OnPropertyChanged(nameof(IsFilled));
    //    }
    //}

    //public bool IsFilled => AssignedUnit != null;

    //public DetachmentSlotViewModel(DetachmentSlot slot)
    //{
    //    SlotId = slot.SlotId;
    //    SlotType = slot.SlotType;
    //    UnitType = slot.UnitType;
    //}

    //public void AssignUnit(Unit unit) => AssignedUnit = unit;
    //public void Clear() => AssignedUnit = null;

    //private Unit _assignedUnit;
    //public Unit AssignedUnit
    //{
    //    get => _assignedUnit;
    //    set
    //    {
    //        this.RaiseAndSetIfChanged(ref _assignedUnit, value);
    //        this.RaisePropertyChanged(nameof(SlotPoints));
    //        PointsChanged?.Invoke(); // Notify parent
    //    }
    //}

    //public int SlotPoints => AssignedUnit?.TotalPoints ?? 0;

    //public event Action PointsChanged;
}
