<<<<<<< HEAD
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Sends UnityEvents for basic hand interactions
//
//=============================================================================

using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	[RequireComponent( typeof( Interactable ) )]
	public class InteractableHoverEvents : MonoBehaviour
	{
		public UnityEvent onHandHoverBegin;
		public UnityEvent onHandHoverEnd;
		public UnityEvent onAttachedToHand;
		public UnityEvent onDetachedFromHand;

		//-------------------------------------------------
		private void OnHandHoverBegin()
		{
			onHandHoverBegin.Invoke();
		}


		//-------------------------------------------------
		private void OnHandHoverEnd()
		{
			onHandHoverEnd.Invoke();
		}


		//-------------------------------------------------
		private void OnAttachedToHand( Hand hand )
		{
			onAttachedToHand.Invoke();
		}


		//-------------------------------------------------
		private void OnDetachedFromHand( Hand hand )
		{
			onDetachedFromHand.Invoke();
		}
	}
}
=======
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Sends UnityEvents for basic hand interactions
//
//=============================================================================

using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	[RequireComponent( typeof( Interactable ) )]
	public class InteractableHoverEvents : MonoBehaviour
	{
		public UnityEvent onHandHoverBegin;
		public UnityEvent onHandHoverEnd;
		public UnityEvent onAttachedToHand;
		public UnityEvent onDetachedFromHand;

		//-------------------------------------------------
		private void OnHandHoverBegin()
		{
			onHandHoverBegin.Invoke();
		}


		//-------------------------------------------------
		private void OnHandHoverEnd()
		{
			onHandHoverEnd.Invoke();
		}


		//-------------------------------------------------
		private void OnAttachedToHand( Hand hand )
		{
			onAttachedToHand.Invoke();
		}


		//-------------------------------------------------
		private void OnDetachedFromHand( Hand hand )
		{
			onDetachedFromHand.Invoke();
		}
	}
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
