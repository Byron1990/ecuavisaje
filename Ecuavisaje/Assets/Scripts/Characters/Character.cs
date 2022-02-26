using System.Collections;
using System.Collections.Generic;
using UnityEngine;
﻿using System;

public enum CharacterEnum
{
    None,
    Lasso,
    Conserje
}

public enum CharacterAudioEnum
{
    Punch
}

[Serializable]
 public struct CharacterAudio {
    public CharacterAudioEnum characterAudioEnum;
    public AudioClip audio;
}

public enum SkillType
{
    normal, throw_object
}

[Serializable]
 public struct Skill {
    public SkillType skillType;
    public GameObject gameObjectPrefab;
}

[CreateAssetMenu(menuName = "Character")]
public class Character: ScriptableObject
{
    [SerializeField] public Sprite icon;
    [SerializeField] public CharacterEnum characterEnum;
    [SerializeField] public GameObject characterPrefab;
    [SerializeField] public string description;
    [SerializeField] public CharacterAudio[] audios;
    [SerializeField] public AudioClip dump;

    [SerializeField] public Skill special1;

}
