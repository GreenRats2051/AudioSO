using UnityEngine;

[CreateAssetMenu(fileName = "AudioManager", menuName = "ScriptableObjects/AudioManager")]
public class AudioManager : ScriptableObject
{
    public string uniqueID;
    public AudioContentType audioContentType;
    public AudioClipData[] dangerousAudioClips;
    public AudioClipData[] friendlyAudioClips;
    public AudioClipData[] neutralAudioClips;

    [TextArea(3, 10)]
    public string longText;
}

public enum AudioContentType
{
    Dangerous,
    Friendly,
    Neutral
}
