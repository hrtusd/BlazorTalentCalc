using BlazorTalentCalc.Shared.Models;
using System;
using System.Collections.Generic;

namespace BlazorTalentCalc.Client.Shared
{
    public class AppState
    {
        public int TotalPoints { get; private set; }
        public int AvailablePoints { get; private set; } = 61;
        public Dictionary<int, int> SpecializationPoints { get; private set; } = new Dictionary<int, int>();
        public TalentBuild Build { get; private set; } = new TalentBuild() { Ranks = new List<TalentRank>(), Steps = new List<BuildStep>() };

        public event Action OnChange;

        public void SetBuildClass(TalentClass talentClass)
        {
            Build.Class = talentClass;
            Build.Ranks = new List<TalentRank>();
            Build.Steps = new List<BuildStep>();
            NotifyStateChanged();
        }

        public void AddBuildRank(TalentRank talentRank)
        {
            if (!Build.Ranks.Contains(talentRank))
            {
                Build.Ranks.Add(talentRank);
            }
            NotifyStateChanged();
        }

        public void RemoveBuildRank(TalentRank talentRank)
        {
            if (Build.Ranks.Contains(talentRank))
            {
                Build.Ranks.Remove(talentRank);
            }
            NotifyStateChanged();
        }

        public void AddBuildStep(BuildStep buildStep)
        {
            if (!Build.Steps.Contains(buildStep))
            {
                Build.Steps.Add(buildStep);
            }
            NotifyStateChanged();
        }

        public void RemoveBuildStep(BuildStep buildStep)
        {
            if (Build.Steps.Contains(buildStep))
            {
                Build.Steps.Remove(buildStep);
            }
            NotifyStateChanged();
        }

        public void SetTotalPoints(int points)
        {
            TotalPoints = points;
            NotifyStateChanged();
        }

        public void SetAvailablePoints(int points)
        {
            AvailablePoints = points;
            NotifyStateChanged();
        }

        public void SetSpecializationPoints(int specKey, int points)
        {
            if (SpecializationPoints.ContainsKey(specKey))
            {
                SpecializationPoints[specKey] = points;
            }
            else
            {
                SpecializationPoints.Add(specKey, points);
            }

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
