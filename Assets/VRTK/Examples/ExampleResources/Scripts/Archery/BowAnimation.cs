<<<<<<< HEAD
﻿namespace VRTK.Examples.Archery
{
    using UnityEngine;

    public class BowAnimation : MonoBehaviour
    {
        public Animation animationTimeline;

        public void SetFrame(float frame)
        {
            animationTimeline["BowPullAnimation"].speed = 0;
            animationTimeline["BowPullAnimation"].time = frame;
            animationTimeline.Play("BowPullAnimation");
        }
    }
=======
﻿namespace VRTK.Examples.Archery
{
    using UnityEngine;

    public class BowAnimation : MonoBehaviour
    {
        public Animation animationTimeline;

        public void SetFrame(float frame)
        {
            animationTimeline["BowPullAnimation"].speed = 0;
            animationTimeline["BowPullAnimation"].time = frame;
            animationTimeline.Play("BowPullAnimation");
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}