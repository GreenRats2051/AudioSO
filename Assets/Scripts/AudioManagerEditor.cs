using UnityEngine;
using UnityEngine.UI;

public class AudioManagerEditor : MonoBehaviour
{
    public AudioManager audioManager;
    public GameObject audioListPanel;
    public GameObject longTextPanel;
    public Text uniqueIDText;
    public Slider volumeSlider;
    public GameObject dangerousList;
    public GameObject friendlyList;
    public GameObject neutralList;

    private void Start()
    {
        uniqueIDText.text = audioManager.uniqueID;
        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        UpdateAudioList();
    }

    public void ShowAudioList()
    {
        audioListPanel.SetActive(true);
        longTextPanel.SetActive(false);
        UpdateAudioList();
    }

    public void ShowLongText()
    {
        audioListPanel.SetActive(false);
        longTextPanel.SetActive(true);
    }

    public void HideAll()
    {
        audioListPanel.SetActive(false);
        longTextPanel.SetActive(false);
    }

    private void UpdateAudioList()
    {
        dangerousList.SetActive(audioManager.audioContentType == AudioContentType.Dangerous);
        friendlyList.SetActive(audioManager.audioContentType == AudioContentType.Friendly);
        neutralList.SetActive(audioManager.audioContentType == AudioContentType.Neutral);
    }

    private void OnVolumeChanged(float value)
    {
        Debug.Log("Volume changed to: " + value);
    }
}

