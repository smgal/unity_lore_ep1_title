using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Yunjr
{
	public class TitleLauncting : MonoBehaviour
	{
		private GameObject m_title_scroll_bar = null;

		void Start()
		{
			// GameObject m_text_bottom = GameObject.FindGameObjectWithTag("TextBottom");
			// GameObject m_dialog_box = GameObject.FindGameObjectWithTag("ImageDialogBox");

			m_title_scroll_bar = GameObject.FindGameObjectWithTag("TitleScrollBar");
			m_title_scroll_bar.SetActive(false);
		}

		void OnFloatingTitle()
		{
		}

		void OnBottomText()
		{
		}

		void OnDialogBox()
		{
		}

		void OnTitleAnimationEnd()
		{
			Animator animator = gameObject.GetComponent<Animator>();
			animator.Stop();

			m_title_scroll_bar.SetActive(true);
		}

		public void OnMenuExit()
		{
			Application.Quit();
		}
	}
}
