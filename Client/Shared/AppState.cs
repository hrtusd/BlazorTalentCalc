using System;

namespace BlazorTalentCalc.Client.Shared
{
    public class AppState
    {
        public int TotalPoints { get; private set; }

        public event Action OnChange;

        public void SetTotalPoints(int points)
        {
            TotalPoints = points;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
