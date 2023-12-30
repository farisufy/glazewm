namespace GlazeWM.Domain.UserConfigs
{
  public class FocusTimerComponentConfig : BarComponentConfig
  {
    /// <summary>
    /// Formatted text to display during a focus session.
    /// </summary>
    public string LabelFocus { get; set; } = "Focus";
    /// <summary>
    /// Formatted text to display during a break session.
    /// </summary>
    public string LabelBreak { get; set; } = "Break";
    /// <summary>
    /// The duration of a Pomodoro session in minutes.
    /// </summary>
    public int FocusDurationMinutes { get; set; } = 25;
    /// <summary>
    /// The duration of the break between Pomodoro sessions in minutes.
    /// </summary>
    public int BreakDurationMinutes { get; set; } = 5;
    /// <summary>
    /// How often this component refreshes in milliseconds.
    /// </summary>
    public int RefreshIntervalMs { get; set; } = 1000;
  }
}
