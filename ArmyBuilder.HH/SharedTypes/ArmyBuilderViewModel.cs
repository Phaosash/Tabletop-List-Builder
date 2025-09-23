using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedTypes;

public class ArmyBuilderViewModel /*: ReactiveObject*/
{
    //public ObservableCollection<DetachmentViewModel> Detachments { get; }

    //public int TotalPoints => Detachments.Sum(d => d.TotalPoints);

    //public ArmyBuilderViewModel()
    //{
    //    Detachments = new ObservableCollection<DetachmentViewModel>();

    //    // Listen to changes from each detachment
    //    Detachments.CollectionChanged += (s, e) =>
    //    {
    //        if (e.NewItems != null)
    //        {
    //            foreach (DetachmentViewModel d in e.NewItems)
    //                d.PointsChanged += () => this.RaisePropertyChanged(nameof(TotalPoints));
    //        }

    //        this.RaisePropertyChanged(nameof(TotalPoints));
    //    };
    //}

    //Sample binding
    //<TextBlock Text="{Binding TotalPoints, StringFormat='Total Points: {0}'}" />

    //  LLOK INTO DATA TEMPLATES
}
