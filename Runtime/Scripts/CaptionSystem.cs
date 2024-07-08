/*
 * Main script to add caption support and access options
 */

using UnityEngine;

namespace XRAccess.Chirp
{
    [RequireComponent(typeof(CaptionRenderManager))]
    public class CaptionSystem : MonoBehaviour
    {
        public static CaptionSystem Instance;

        public Camera mainCamera;
        public AudioListener mainAudioListener;

        public CaptionOptions options;

        void Awake()
        {
            Instance = this;
            if (mainAudioListener == null) mainAudioListener = FindAnyObjectByType<AudioListener>();
            if (mainCamera == null) mainCamera = Camera.main;

        }
    }
}
