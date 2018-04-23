<<<<<<< HEAD
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Custom Unity Events that take in additional parameters
//
//=============================================================================

using UnityEngine.Events;
using System;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public static class CustomEvents
	{
		//-------------------------------------------------
		[System.Serializable]
		public class UnityEventSingleFloat : UnityEvent<float>
		{
		}


		//-------------------------------------------------
		[System.Serializable]
		public class UnityEventHand : UnityEvent<Hand>
		{
		}
	}
}
=======
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Custom Unity Events that take in additional parameters
//
//=============================================================================

using UnityEngine.Events;
using System;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public static class CustomEvents
	{
		//-------------------------------------------------
		[System.Serializable]
		public class UnityEventSingleFloat : UnityEvent<float>
		{
		}


		//-------------------------------------------------
		[System.Serializable]
		public class UnityEventHand : UnityEvent<Hand>
		{
		}
	}
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
