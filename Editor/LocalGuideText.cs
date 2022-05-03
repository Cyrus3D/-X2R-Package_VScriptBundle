using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Guide", menuName = "EasyState/GuideText", order = 1)]
public class LocalGuideText : ScriptableObject
{
    public int guidIndex;
    public string guideTitle;
    public List<string> guideDescription;
    public List<AudioClip> guideDescriptionVoice;
}
