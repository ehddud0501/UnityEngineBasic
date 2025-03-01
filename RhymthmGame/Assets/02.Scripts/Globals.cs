﻿using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;

namespace RhythmGame
{
    public static class Globals
    {
        public const int SCORE_COOL = 500;
        public const int SCORE_GREAT = 300;
        public const int SCORE_GOOD = 100;
        public const int SCORE_MISS = 0;
        public const int SCORE_BAD = 0;

        public const float HIT_JUDGE_RANGE_COOL = 0.7f;
        public const float HIT_JUDGE_RANGE_GREAT = 1.0f;
        public const float HIT_JUDGE_RANGE_GOOD = 1.8f;
        public const float HIT_JUDGE_RANGE_BAD = 2.5f;
        public const float HIT_JUDGE_RANGE_MISS = 3.0f;
    }

    public enum HitJudge
    {
        None,
        Bad,
        Miss,
        Good,
        Great,
        Cool
    }
}
