/*
 * Defines the structure of a caption
 */

using System;
using UnityEngine;

namespace XRAccess.Chirp
{
    /// <summary>
    /// Base class for a caption in Chirp.
    /// </summary>
    public abstract class Caption
    {
        public float startTime;
        public AudioSource audioSource;
        public GameObject boundingObject;
    }

    /// <summary>
    /// Represents a caption with a defined duration.
    /// </summary> 
    public class TimedCaption : Caption
    {
        public string captionText;
        public float duration;
    }

    public class ConditionalCaption : Caption {
        public string captionText;
        public Func<bool> condition;
    }

    /// <summary>
    /// Represents a realtime caption with partial text that updates as the speaker speaks.
    /// </summary>
    public class RealtimeCaption : Caption
    {
        public string partialCaption;
    }
}