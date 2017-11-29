﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player sound effect for player
/// </summary>
public class PlayerSound : MonoBehaviour {

  public AudioClip jumpSound;
  public AudioClip landingSound;
  public AudioClip gameOverSound;

	public void PlayJumpAudioClip() {
		SoundManager.instance.PlaySingle(jumpSound);
	}

  public void PlayerLandingAudioClip() {
		SoundManager.instance.PlaySingle(landingSound);
  }

	public void PlayGameOverAudioClip() {
		SoundManager.instance.PlaySingle(gameOverSound);
	}

}

