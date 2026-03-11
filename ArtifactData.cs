using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
//202500532 박도현 컴퓨터공학과

//유물 아이템 정보를 불러오기위한 것
[CreateAssetMenu(fileName = "Artifact", menuName = "Scriptable Objects/Artifact")]
public class ArtifactData : ScriptableObject
{
    public string Name;
    public string Description;
    public rarity Rarity;
    public Sprite Image;
    public int Size;
    public int Prize;

}

