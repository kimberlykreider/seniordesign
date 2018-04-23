<<<<<<< HEAD
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: This object won't be destroyed when a new scene is loaded
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class DontDestroyOnLoad : MonoBehaviour
	{
		//-------------------------------------------------
		void Awake()
		{
			DontDestroyOnLoad( this );
		}
	}
}
=======
﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: This object won't be destroyed when a new scene is loaded
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class DontDestroyOnLoad : MonoBehaviour
	{
		//-------------------------------------------------
		void Awake()
		{
			DontDestroyOnLoad( this );
		}
	}
}
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
