<<<<<<< HEAD
﻿// Daydream Defines|SDK_Daydream|001
namespace VRTK
{
    /// <summary>
    /// Handles all the scripting define symbols for the Daydream SDK.
    /// </summary>
    public static class SDK_DaydreamDefines
    {
        /// <summary>
        /// The scripting define symbol for the Daydream SDK.
        /// </summary>
        public const string ScriptingDefineSymbol = SDK_ScriptingDefineSymbolPredicateAttribute.RemovableSymbolPrefix + "SDK_DAYDREAM";

        [SDK_ScriptingDefineSymbolPredicate(ScriptingDefineSymbol, "Android")]
        private static bool IsDaydreamAvailable()
        {
            return VRTK_SharedMethods.GetTypeUnknownAssembly("GvrController") != null;
        }
    }
=======
﻿// Daydream Defines|SDK_Daydream|001
namespace VRTK
{
    /// <summary>
    /// Handles all the scripting define symbols for the Daydream SDK.
    /// </summary>
    public static class SDK_DaydreamDefines
    {
        /// <summary>
        /// The scripting define symbol for the Daydream SDK.
        /// </summary>
        public const string ScriptingDefineSymbol = SDK_ScriptingDefineSymbolPredicateAttribute.RemovableSymbolPrefix + "SDK_DAYDREAM";

        [SDK_ScriptingDefineSymbolPredicate(ScriptingDefineSymbol, "Android")]
        private static bool IsDaydreamAvailable()
        {
            return VRTK_SharedMethods.GetTypeUnknownAssembly("GvrController") != null;
        }
    }
>>>>>>> 55a10351f611f5493cf6f67f6cf76a4844defc4d
}