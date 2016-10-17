using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Yunjr
{
	public class TitleLauncting : MonoBehaviour
	{
		private GameObject m_title_panel_main_menu = null;

		void Start()
		{
			// GameObject m_text_bottom = GameObject.FindGameObjectWithTag("TextBottom");
			// GameObject m_dialog_box = GameObject.FindGameObjectWithTag("ImageDialogBox");

			m_title_panel_main_menu = GameObject.FindGameObjectWithTag("TitlePanelMainMenu");
			m_title_panel_main_menu.SetActive(false);
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

			m_title_panel_main_menu.SetActive(true);
		}

		public void OnMenuExit()
		{
			Debug.Log("OnMenuExit() ---->");
			Application.Quit();
		}
	}
}
