using UnityEngine;
using System.Collections;

public class TitleLauncting : MonoBehaviour
{
	void OnInit()
	{
	}

	void OnFloatingTitleEnd()
	{
		Animator animator = gameObject.GetComponent<Animator>();
		animator.Stop();
	}
}
