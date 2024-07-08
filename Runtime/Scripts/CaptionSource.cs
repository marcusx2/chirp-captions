/*
 * CaptionSource is attached to a GameObject for playing captions from it.
 */

using Amazon.Auth.AccessControlPolicy;
using System;
using UnityEngine;

namespace XRAccess.Chirp
{
    public class CaptionSource : MonoBehaviour
    {
        public AudioSource audioSource;
        public GameObject boundingObject;
        public string sourceLabel;


        /// <summary>
        /// Method to play a caption from the caption source.
        /// </summary> 
        /// <param name="captionText">The text content of the caption.</param>
        /// <param name="duration">The duration of the caption in seconds.</param>
        public void ShowTimedCaption(string captionText, float duration)
        {
            TimedCaption caption = new TimedCaption();
            caption.startTime = Time.time;
            caption.captionText = captionText;
            caption.duration = duration;
            caption.audioSource = audioSource;
            caption.boundingObject = boundingObject;

            CaptionRenderManager.Instance.AddTimedCaption(caption);
        }

        public void ShowConditionalCaption(string captionText, Func<bool> condition) {
            ConditionalCaption caption = new ConditionalCaption();
            caption.startTime = Time.time;
            caption.captionText = captionText;
            caption.audioSource = audioSource;
            caption.boundingObject = boundingObject;

            caption.condition = condition;

            CaptionRenderManager.Instance.AddConditionalCaption(caption);
        }

        private void Reset()
        {
            audioSource = this.GetComponent<AudioSource>();
            boundingObject = this.gameObject;
        }
    }
}