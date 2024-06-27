using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class UIManager : MonoBehaviour
{
public TextMeshProUGUI leftPlayer;
public TextMeshProUGUI rightPlayer;


private void Start()
{
 leftPlayer.SetText("0");
 rightPlayer.SetText("0");
}

public void SetLeftPlayerScoreText(string text)
 {
  leftPlayer.SetText(text);
 }

 public void SetRightPlayerScoreText(string text)
 {
  rightPlayer.SetText(text);
 }

}
