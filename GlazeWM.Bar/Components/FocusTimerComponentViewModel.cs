using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using GlazeWM.Domain.UserConfigs;

namespace GlazeWM.Bar.Components
{
  public class FocusTimerViewModel : ComponentViewModel
  {
    private readonly FocusTimerComponentConfig _config;
    private LabelViewModel _label;
    public LabelViewModel Label
    {
      get => _label;
      protected set => SetField(ref _label, value);
    }
    public FocusTimerViewModel(
      BarViewModel parentViewModel,
      FocusTimerComponentConfig config) : base(parentViewModel, config)
    {
      _config = config;
      Observable.Timer(
          TimeSpan.Zero,
          TimeSpan.FromMilliseconds(_config.RefreshIntervalMs)
        )
        .TakeUntil(_parentViewModel.WindowClosing)
        .Subscribe((_) => Label = CreateLabel());
    }
    private LabelViewModel CreateLabel()
    {
      var variableDictionary = new Dictionary<string, Func<string>>()
      {
        {
          "focus_timer", () => ""
        },
      };

      return XamlHelper.ParseLabel(_config.LabelFocus, variableDictionary, this);
    }
  }
}
