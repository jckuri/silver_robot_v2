using UnityEngine;

namespace Udacity.GameDevelopment.Shared.Templates
{
	public class TemplateComponent : MonoBehaviour
	{
		//  Properties ------------------------------------
		public string SamplePublicText
		{
			get
			{
				return _samplePublicText;
			}
			set
			{
				_samplePublicText = value;
			}
		}


		//  Fields ----------------------------------------
		[SerializeField]
		private string _samplePublicText;


		//  Unity Methods ---------------------------------
		private void Start()
		{

		}


		private void Update()
		{

		}	


		//  Methods ---------------------------------------
		public string SamplePublicMethod(string message)
		{
			return message;
		}


		//  Event Handlers --------------------------------
		public void Target_OnCompleted(string message)
		{

		}
	}
}
