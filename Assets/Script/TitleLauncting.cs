using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TitleLauncting : MonoBehaviour
{
	private GameObject m_text_bottom = null;
	private GameObject m_dialog_box = null;
	private GameObject m_title_scroll_bar = null;

	void Start()
	{
		m_text_bottom = GameObject.FindGameObjectWithTag("TextBottom");
		m_text_bottom.SetActive(false);

		m_dialog_box = GameObject.FindGameObjectWithTag("ImageDialogBox");
		m_dialog_box.SetActive(false);

		m_title_scroll_bar = GameObject.FindGameObjectWithTag("TitleScrollBar");
		m_title_scroll_bar.SetActive(false);
	}

	void OnFloatingTitle()
	{
	}

	void OnBottomText()
	{
		m_text_bottom.SetActive(true);
	}

	void OnDialogBox()
	{
		m_dialog_box.SetActive(true);
	}

	void OnTitleAnimationEnd()
	{
		Animator animator = gameObject.GetComponent<Animator>();
		animator.Stop();

		m_title_scroll_bar.SetActive(true);
	}
}
