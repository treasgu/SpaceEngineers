﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sandbox.Engine.Utils;
using Microsoft.Win32;

using Sandbox;
using SteamSDK;

namespace Sandbox.Engine.Networking
{
    /// <summary>
    /// Ingame shortcut for various things
    /// </summary>
    public static class MySteam
    {
        public static SteamAPI API { get { return MySandboxGame.Services.SteamService.SteamAPI; } }
        public static GameServer Server { get { return MySandboxGame.Services.SteamService.SteamServerAPI != null ?MySandboxGame.Services.SteamService.SteamServerAPI.GameServer : null; } }

        public static uint AppId { get { return MySandboxGame.Services.SteamService.AppId; } }
        public static bool IsActive
        {
            get
            {
                return MySandboxGame.Services.SteamService == null ? false : MySandboxGame.Services.SteamService.IsActive;
            }
        }

        public static bool IsOnline { get { return MySandboxGame.Services.SteamService != null ? MySandboxGame.Services.SteamService.IsOnline : false;  } }
        public static bool IsOverlayEnabled { get { return MySandboxGame.Services.SteamService.IsOverlayEnabled; } }
        public static bool OwnsGame { get { return MySandboxGame.Services.SteamService.OwnsGame; } }

        public static ulong UserId
        {
            get
            {
                return MySandboxGame.Services != null && MySandboxGame.Services.SteamService != null ? MySandboxGame.Services.SteamService.UserId : 0;
            }
        }

        public static string UserName { get { return MySandboxGame.Services.SteamService.UserName; } }
        public static Universe UserUniverse { get { return MySandboxGame.Services.SteamService.UserUniverse; } }
        public static string BranchName { get { return MySandboxGame.Services.SteamService.BranchName; } }

        public static void OpenOverlayUrl(string url)
        {
            if (API != null)
            {
                API.OpenOverlayUrl(url);
            }
        }
    }
}
