using UnityEngine;
using System.Collections;

public class SoundPlayer : MonoBehaviour {
	
	public AudioClip[] Sound;
	
	//0 - כ‘כ”ל§€ כ“±ל¥ם•  כ•ל˜ ל†כ¦¬
	//1 - כ‚˜ל כ‘כ”ל§€ ל¡םכ•ל˜ ל†כ¦¬
	//2 - ל¢‹ל€ כ‘כ”ל§€ ל¡םכ•ל˜ ל†כ¦¬
	
	public void SoundPlay(int Sound_Number){
		
		GetComponent<AudioSource>().clip = Sound[Sound_Number];		
		GetComponent<AudioSource>().Play();
	}
}
