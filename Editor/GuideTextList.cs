using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GuideTextList", menuName = "EasyState/GuideTextList", order = 1)]
public class GuideTextList : ScriptableObject
{
     public List<GuideList> guideLists; 
}
[System.Serializable]
public class GuideList {
    public string guideTitle;
    public string guideDescription;
    public AudioClip guideDescriptionVoice;
 }