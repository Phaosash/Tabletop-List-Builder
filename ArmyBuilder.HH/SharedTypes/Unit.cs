using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTypes;


// Sample unit class with ForceOrgSlot matching DetachmentSlot.UnitType
internal class Unit {
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? ForceOrgSlot { get; set; }  // e.g., "Command", "Troops"
    // other properties omitted for brevity

    //public int TotalPoints => BasePoints + SelectedUpgrades.Sum(u => u.PointCost);
}
