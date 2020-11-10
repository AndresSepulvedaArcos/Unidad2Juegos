using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Taller
{
    public class GameManager : Singleton<GameManager>
    {
        public int score;

        public static event FNotify_1Params<int> OnScoreChange;

        public void AddScore(int ScoreToAdd)
        {
            score += ScoreToAdd;
            OnScoreChange?.Invoke(score);
        }
    }
}

