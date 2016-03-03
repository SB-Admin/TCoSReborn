﻿namespace Network
{
    public enum LoginHeader : ushort
    {
        CONNECT = 0xFFFD,
        DISCONNECT = 0xFFFE,
        C2L_USER_LOGIN = 0,
        L2C_USER_LOGIN_ACK = 1,
        C2L_QUERY_UNIVERSE_LIST = 2,
        L2C_QUERY_UNIVERSE_LIST_ACK = 3,
        C2L_UNIVERSE_SELECTED = 4,
        L2C_UNIVERSE_SELECTED_ACK = 5
    }

    public enum GameHeader : ushort
    {
        CONNECT = 0xFFFD,
        DISCONNECT = 0xFFFE,
        C2S_TRAVEL_CONNECT = 0,
        S2C_WORLD_PRE_LOGIN = 1,
        C2S_WORLD_PRE_LOGIN_ACK = 2,
        S2C_WORLD_LOGIN = 3,
        C2S_WORLD_LOGIN_ACK = 4,
        C2S_WORLD_LOGOUT = 5,
        S2C_WORLD_LOGOUT_ACK = 6,
        C2S_TRAVEL_WORLD = 7,
        S2C_TRAVEL_WORLD_ACK = 8,
        S2C_FORCED_LOGOUT = 9,
        S2C_USER_ON_LOGIN = 10,
        S2C_USER_ON_LOGOUT = 11,
        S2C_USER_LEVELUP = 12,
        S2C_USER_SET_CLASS = 13,
        S2C_PLAYER_ADD = 17,
        S2C_NPC_ADD = 18,
        S2C_PET_ADD = 19,
        S2C_LEVELOBJECT_REMOVE = 21,
        S2C_GAME_ACTOR_ADD = 22,
        S2C_INTERACTIVELEVELELEMENT_ADD = 23,
        S2C_GAME_ACTOR_MOVE = 24,
        S2C_GAME_INFO_ADD = 25,
        S2C_GAME_INFO_REMOVE = 26,
        S2C_CS_LOGIN = 27,
        C2S_CS_CREATE_CHARACTER = 28,
        S2C_CS_CREATE_CHARACTER_ACK = 29,
        C2S_CS_DELETE_CHARACTER = 30,
        S2C_CS_DELETE_CHARACTER_ACK = 31,
        C2S_CS_SELECT_CHARACTER = 32,
        S2C_CS_SELECT_CHARACTER_ACK = 33,
        S2C_BASE_PAWN_REMOVE = 34,
        S2R_PLAYERPAWN_MOVE = 35,
        S2R_GAME_PLAYERPAWN_UPDATEROTATION = 36,
        S2C_TEAM_ADD_MEMBER = 37,
        S2C_TEAM_REMOVE_MEMBER = 38,
        S2C_REMOVED_FROM_TEAM = 39,
        C2S_TEAM_INVITE = 40,
        S2C_TEAM_INVITE = 41,
        C2S_TEAM_INVITE_ACK = 42,
        S2C_TEAM_INVITE_ACK = 43,
        C2S_TEAM_KICK = 44,
        S2C_TEAM_KICK_ACK = 45,
        C2S_TEAM_LEAVE = 46,
        S2C_TEAM_LEAVE_ACK = 47,
        C2S_TEAM_DISBAND = 48,
        S2C_TEAM_DISBAND_ACK = 49,
        C2S_TEAM_LEADER = 50,
        S2C_TEAM_LEADER_ACK = 51,
        C2S_TEAM_LOOTMODE = 52,
        S2C_TEAM_LOOTMODE_ACK = 53,
        C2S_GET_TEAM_INFO = 54,
        S2C_GET_TEAM_INFO_ACK = 55,
        S2C_TEAM_CHARACTER_STATS_BASE = 56,
        S2C_TEAM_CHARACTER_STATS_UPDATE = 57,
        C2S_CREATE_GUILD = 58,

        C2S_GET_GUILD_INFO = 82,
        S2C_GET_GUILD_INFO_ACK = 83,

        C2S_ADD_PLAYER_TO_FRIENDS_OR_IGNORE_LIST = 84,

        C2S_GET_RELATIONSHIP_INFO = 90,
        S2C_GET_RELATIONSHIP_INFO_ACK = 91,

        S2R_BASE_PAWN_SV2CLREL_QUEUEANIMATION = 92,
        S2R_BASE_PAWN_SV2CLREL_DAMAGEACTIONS = 93,
        S2R_BASE_PAWN_SV2CL_GOTOSTATE = 94,
        S2R_GAME_ACTOR_SV2CLREL_SETENABLED = 95,
        S2R_GAME_ACTOR_SV2CLREL_SHOW = 96,
        S2R_GAME_ACTOR_SV2CLREL_SETCOLLISIONTYPE = 97,
        S2R_INTERACTIVELEVELELEMENT_SV2CLREL_CANCELCLIENTSUBACTION = 98,
        S2R_INTERACTIVELEVELELEMENT_SV2CLREL_ENDCLIENTSUBACTION = 99,
        S2R_INTERACTIVELEVELELEMENT_SV2CLREL_STARTCLIENTSUBACTION = 100,
        C2S_INTERACTIVELEVELELEMENT_CL2SV_ONRADIALMENUOPTION = 101,
        S2R_INTERACTIVELEVELELEMENT_SV2CLREL_UPDATENETISACTIVATED = 102,
        S2R_ANIMATEDLEVELELEMENT_SV2CLREL_PLAYOPTIONANIMATION = 103,
        S2C_GAME_CONTROLLER_SV2CL_SETPERSISTENTVARIABLE = 104,

        S2C_GAME_PLAYERCONTROLLER_SV2CL_PONG = 107,

        S2C_GAME_PLAYERCONTROLLER_SV2CL_UPDATENETSTATE = 110,
        S2C_GAME_PLAYERCONTROLLER_SV2CL_UPDATESERVERTIME = 111,

        S2R_GAME_CHARACTER_SV2CLREL_SETFACTION = 118,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_UPDATESTATERANKSHIFT = 119,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_UPDATEMOVEMENTSPEED = 120,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_UPDATEFROZENFLAGS = 121,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_UPDATEMAXHEALTH = 122,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_UPDATEHEALTH = 123,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_UPDATECONCENTRATION = 124,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_UPDATEMORALE = 125,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_UPDATEPHYSIQUE = 126,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_UPDATESTATEVARIABLES = 127,
        S2C_GAME_CHARACTERSTATS_SV2CL_UPDATEMAGICRESISTANCE = 128,
        S2C_GAME_CHARACTERSTATS_SV2CL_UPDATERANGEDRESISTANCE = 129,
        S2C_GAME_CHARACTERSTATS_SV2CL_UPDATEMELEERESISTANCE = 130,
        S2C_GAME_CHARACTERSTATS_SV2CL_UPDATEFOCUSDELTA = 131,
        S2C_GAME_CHARACTERSTATS_SV2CL_UPDATEMINDDELTA = 132,
        S2C_GAME_CHARACTERSTATS_SV2CL_UPDATEBODYDELTA = 133,
        S2R_GAME_CHARACTERSTATS_SV2CLREL_FREEZEANIMATION = 134,

        S2C_GAME_CHAT_SV2CL_ONMESSAGE = 136,
        C2S_GAME_CHAT_SEND_TEXTMESSAGE = 137,

        S2R_GAME_COMBATSTATE_SV2REL_SHEATHEWEAPON = 139,
        S2R_GAME_COMBATSTATE_SV2REL_DRAWWEAPON = 140,
        S2C_GAME_COMBATSTATS_SV2CL_UPDATEINCOMBAT = 141,

        S2R_GAME_EFFECTS_SV2CLREL_STOPREPLICATED = 173,
        S2R_GAME_EFFECTS_SV2CLREL_STARTREPLICATED = 174,
        S2C_GAME_EMOTES_SV2CL_EMOTE = 175,
        S2R_GAME_EMOTES_SV2REL_EMOTE = 176,
        C2S_GAME_EMOTES_CL2SV_EMOTE = 177,
        S2R_GAME_EQUIPPEDAPPEARANCE_SV2REL_SETCOLORVALUE = 178,
        S2R_GAME_EQUIPPEDAPPEARANCE_SV2REL_SETVALUE = 179,

        S2C_GAME_GUI_SV2CL_SHOWPARTYTRAVELCONFIRMATION = 182,
        S2C_GAME_GUI_SV2CL_SHOWPARTYTRAVELOVERVIEW = 183,
        S2C_GAME_GUI_SV2CL_SHOWTUTORIAL = 184,

        S2C_GAME_GAMEMASTERCONTROLLER_SV2CL_RESETSPEEDBOOST = 186,
        S2C_GAME_GAMEMASTERCONTROLLER_SV2CL_ADDSPEEDBOOST = 187,

        C2S_GAME_GAMEMASTERUTILS_CL2SV_CSSPEED = 210,
        C2S_GAME_GAMEMASTERUTILS_CL2SV_CSSHIELD = 211,

        C2S_GAME_GAMEMASTERUTILS_CL2SV_CSVIS = 213,

        S2C_GAME_LOOTING_SV2CL_CHANGELOOTMODE = 221,
        S2C_GAME_LOOTING_SV2CL_LOOTITEMREJECTED = 222,
        S2C_GAME_LOOTING_SV2CL_REMOVEITEM = 223,
        S2C_GAME_LOOTING_SV2CL_ENDTRANSACTION = 224,
        S2C_GAME_LOOTING_SV2CL_INITLOOTOFFER = 225,

        S2R_GAME_SHIFTABLEAPPEARANCE_SV2CLREL_SHIFTAPPEARANCE = 240,
        S2R_GAME_NPCPAWN_SV2REL_CHAT = 241,
        S2R_GAME_NPCPAWN_SV2REL_SETFOCUS = 242,
        S2R_GAME_NPCPAWN_SV2REL_SETCLIENTFOCUS = 243,
        S2R_GAME_NPCPAWN_SV2REL_STOPMOVEMENT = 244,
        S2R_GAME_NPCPAWN_SV2REL_FOCUSLOCATION = 245,
        S2R_GAME_NPCPAWN_SV2REL_FOCUS = 246,
        S2R_GAME_NPCPAWN_SV2REL_MOVE = 247,

        S2R_GAME_NPCPAWN_SV2REL_SETDEBUGNETLOCATION = 249,
        S2R_GAME_NPCPAWN_SV2REL_UPDATEDEBUGPATHSTR = 250,
        S2R_GAME_NPCPAWN_SV2REL_UPDATEDEBUGINFOSTR = 251,
        S2C_GAME_SKILLS_SV2CL_ONSKILLRECEIVEDTOKENSLOT = 252,

        S2C_GAME_SKILLS_SV2CL_UPDATECOMBOSTATE = 254,
        S2C_GAME_SKILLS_SV2CL_UNINSTALLDISABLESKILLUSEEFFECT = 255,
        S2C_GAME_SKILLS_SV2CL_INSTALLDISABLESKILLUSEEFFECT = 256,
        S2R_GAME_SKILLS_SV2REL_ADDACTIVESKILL = 257,
        S2C_GAME_SKILLS_SV2CL_ADDACTIVESKILL = 258,
        S2C_GAME_SKILLS_SV2CL_CLEARLASTSKILL = 259,
        S2C_GAME_SKILLS_SV2CL_UPDATESHAREDUFFS = 260,

        S2R_GAME_SKILLS_SV2CLREL_UPDATEDUFFS = 261,
        C2S_GAME_SKILLS_CL2SV_EXECUTEL = 262,
        C2S_GAME_SKILLS_CL2SV_EXECUTET = 263,
        C2S_GAME_SKILLS_CL2SV_EXECUTE = 264,
        C2S_GAME_SKILLS_CL2SV_EXECUTEINDEXL = 265,
        C2S_GAME_SKILLS_CL2SV_EXECUTEINDEX = 266,
        S2R_GAME_SKILLS_SV2CLREL_RUNEVENTL = 267,
        S2R_GAME_SKILLS_SV2CLREL_RUNEVENT = 268,
        S2C_GAME_SKILLS_SV2CL_LEARNSKILL = 269,
        C2S_GAME_SKILLS_CL2SV_LEARNSKILL = 270,

        S2C_GAME_SKILLS_SV2CL_ONSKILLLOG = 272,
        S2C_GAME_PAWN_SV2CL_UNSHIFT = 273,
        S2C_GAME_PAWN_SV2CL_SHIFT = 274,

        S2R_GAME_PAWN_SV2CLREL_SETINVISIBLE = 276,
        S2R_GAME_PAWN_SV2CLREL_REMOVEPET = 277,

        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTEVADE = 279,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTIMMUNE = 280,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTDUFFUNAPPLY = 281,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTDUFFAPPLY = 282,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTDUFFAPPLY = 283,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTDRAINNONDAMAGE = 284,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTDRAINNONDAMAGE = 285,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTDRAINDAMAGE = 286,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTDRAINDAMAGE = 287,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTTELEPORT = 288,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTHEAL = 289,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTHEAL = 290,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTHEALOVERTIME = 291,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTSTATE = 292,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTSTATE = 293,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTSTATEOVERTIME = 294,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTDAMAGE = 295,

        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTDAMAGE = 296,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTDAMAGEOVERTIME = 297,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTSHARENONDAMAGE = 298,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTSHARENONDAMAGE = 299,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTSHAREDAMAGE = 300,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTSHAREDAMAGE = 301,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTRETURNREFLECTNONDAMAGE = 302,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTRETURNREFLECTNONDAMAGE = 303,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEINPUTRETURNREFLECTDAMAGE = 304,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEOUTPUTRETURNREFLECTDAMAGE = 305,

        S2R_GAME_PAWN_SV2REL_COMBATMESSAGEDEATH = 306,
        S2C_GAME_PAWN_SV2CL_COMBATMESSAGEDEATH = 307,
        S2R_GAME_PAWN_SV2CLREL_COMBATLOGMESSAGE = 308,
        S2C_GAME_PAWN_SV2CL_SENDGAMECONSOLEMESSAGEID = 309,
        S2C_GAME_PAWN_SV2CL_SENDGAMECONSOLEMESSAGE = 310,
        S2R_GAME_PAWN_SV2CLREL_PLAYPAWNEFFECTDIRECT = 311,
        S2R_GAME_PAWN_SV2CLREL_PLAYPAWNEFFECT = 312,
        C2S_GAME_PAWN_CL2SV_REST = 313,
        C2S_GAME_PAWN_CL2SV_INTERACT = 314,
        S2R_GAME_PAWN_SV2CLREL_FACEPOSITION = 315,
        S2C_GAME_PAWN_SV2CL_ROTATETOORIENTATION = 316,
        S2C_GAME_PAWN_SV2CL_SETTARGETDESTINATION = 317,
        S2R_GAME_PAWN_SV2CLREL_STATICPLAYSOUND = 318,

        S2R_GAME_PAWN_SV2CLREL_UPDATENETSTATE = 326,
        S2C_GAME_PAWN_SV2CL_ADDSCROLLINGCOMBATDAMAGE = 327,
        S2R_GAME_PAWN_SV2REL_ADDSCROLLINGCOMBATMESSAGE = 328,
        S2C_GAME_PAWN_SV2CL_ADDRELAYSCROLLINGCOMBATMESSAGE = 329,
        S2C_GAME_PAWN_SV2CL_ADDSCROLLINGCOMBATMESSAGE = 330,
        C2S_GAME_PAWN_CL2SV_TAKEDAMAGE = 331,
        S2R_GAME_PAWN_SV2REL_SETINVULNERABLE = 332,

        S2R_GAME_PAWN_SV2CLREL_UPDATEGROUNDSPEEDMODIFIER = 333,
        S2R_GAME_PAWN_SV2CLREL_SUBMERGE = 334,
        S2R_GAME_PAWN_SV2CLREL_EMERGE = 335,

        S2R_GAME_PAWN_SV2CLREL_TELEPORTTO = 336,
        S2C_GAME_PAWN_SV2CL_UPDATEMUTED = 337,
        S2C_GAME_PAWN_SV2CL_REQUESTIDENTIFICATION = 338,

        S2R_GAME_PETPAWN_SV2CLREL_SETPETOWNER = 340,
        S2R_GAME_PETPAWN_SV2CLREL_SETPETATTACKSTATE = 341,
        S2R_GAME_PETPAWN_SV2CLREL_SETPETMOVESTATE = 342,
        S2R_GAME_PLAYERCHARACTER_SV2CLREL_UPDATEGUILDNAME = 343,
        S2C_GAME_PLAYERCHARACTER_SV2CL_UPDATEMONEY = 344,
        S2C_GAME_PLAYERCOMBATSTATE_SV2CL_SHEATHEWEAPON = 345,
        S2C_GAME_PLAYERCOMBATSTATE_SV2CL_DRAWWEAPON = 346,
        S2C_GAME_PLAYERCOMBATSTATE_SV2CL_SETWEAPON = 347,

        C2S_GAME_PLAYERCOMBATSTATE_CL2SV_SWITCHWEAPONTYPE = 348,

        C2S_GAME_PLAYERCOMBATSTATE_CL2SV_DRAWSHEATHEWEAPON = 350,

        S2C_GAME_PLAYERCONVERSATION_SV2CL_BANNER = 352,
        S2C_GAME_PLAYERCONVERSATION_SV2CL_ENDCONVERSE = 353,
        S2C_GAME_PLAYERCONVERSATION_SV2CL_CONVERSE = 354,
        C2S_GAME_PLAYERCONVERSATION_CL2SV_RESPOND = 355,
        C2S_GAME_PLAYERCONVERSATION_CL2SV_INTERACT = 356,
        C2S_GAME_PLAYERCONVERSATION_CL2SV_REACT = 357,
        C2S_GAME_PLAYERINPUT_CL2SV_SETVIEWTARGET = 358,
        C2S_GAME_PLAYERINPUT_CL2SV_SETTARGETPAWN = 359,
        C2S_GAME_PLAYERINPUT_CL2SV_RESURRECT = 360,
        C2S_GAME_PLAYERITEMMANAGER_CL2SV_USEITEM = 363,
        C2S_GAME_PLAYERITEMMANAGER_CL2SV_SPLITITEM = 364,
        C2S_GAME_PLAYERITEMMANAGER_CL2SV_BREAKDOWNITEM = 365,
        C2S_GAME_PLAYERITEMMANAGER_CL2SV_MOVEITEM = 366,
        S2C_GAME_PLAYERITEMMANAGER_SV2CL_USEDITEM = 367,
        S2C_GAME_PLAYERITEMMANAGER_SV2CL_REMOVEITEM = 368,
        S2C_GAME_PLAYERITEMMANAGER_SV2CL_SETITEM = 369,
        S2C_GAME_PLAYERPAWN_SV2CL_CLIENTSIDETRIGGER = 370,
        S2R_GAME_PLAYERPAWN_SV2REL_SENDMESSAGE = 371,

        S2C_GAME_PLAYERPAWN_SV2CL_SITDOWN = 374,
        S2C_GAME_PLAYERPAWN_SV2CL_SETPVPTIMER = 373,

        S2C_GAME_PLAYERPAWN_SV2CL_FORCEMOVEMENT = 375,
        C2S_GAME_PLAYERPAWN_CL2SV_UPDATEMOVEMENT = 376,
        C2S_GAME_PLAYERPAWN_CL2SV_UPDATEMOVEMENTWITHPHYSICS = 377,
        C2S_GAME_PLAYERPAWN_CL2SV_UPDATEROTATION = 378,
        S2C_GAME_PLAYERQUESTLOG_SV2CL_SETTARGETPROGRESS = 379,
        S2C_GAME_PLAYERQUESTLOG_SV2CL_REMOVEQUEST = 380,
        S2C_GAME_PLAYERQUESTLOG_SV2CL_COMPLETEQUEST = 381,
        S2C_GAME_PLAYERQUESTLOG_SV2CL_ADDQUEST = 382,
        S2C_GAME_PLAYERQUESTLOG_SV2CL_FINISHQUEST = 383,
        S2C_GAME_PLAYERQUESTLOG_SV2CL_ACCEPTQUEST = 384,
        C2S_GAME_PLAYERQUESTLOG_CL2SV_SWIRLYOPTION = 385,
        C2S_GAME_PLAYERQUESTLOG_CL2SV_SWIRLYOPTIONPAWN = 386,
        C2S_GAME_PLAYERQUESTLOG_CL2SV_ABANDONQUEST = 387,

        C2S_GAME_PLAYERSKILLS_CL2SV_SAVESKILLDECKSKILLS = 391,
        S2C_GAME_PLAYERSKILLS_SV2CL_SETSKILLS = 392,
        S2C_GAME_PLAYERSTATS_SV2CL_UPDATEFOCUSANDSOULAFFINITY = 393,
        S2C_GAME_PLAYERSTATS_SV2CL_UPDATEMINDANDSPIRITAFFINITY = 394,
        S2C_GAME_PLAYERSTATS_SV2CL_UPDATEBODYANDRUNEAFFINITY = 395,
        S2C_GAME_PLAYERSTATS_SV2CL_UPDATEUPGRADEINFO = 396,
        S2C_GAME_PLAYERSTATS_SV2CL_UPDATEPEPPOINTS = 397,
        S2C_GAME_PLAYERSTATS_SV2CL_UPDATEFAMEPOINTS = 398,
        S2C_GAME_PLAYERSTATS_SV2CL_SETCLASS = 399,
        C2S_GAME_PLAYERSTATS_CL2SV_SETCLASS = 400,
        S2R_GAME_PLAYERSTATS_SV2CLREL_ONUPDATEPEPRANK = 401,
        S2R_GAME_PLAYERSTATS_SV2CLREL_ONLEVELUP = 402,
        S2C_GAME_PLAYERTEAMS_SV2CL_CANCELPARTYTRAVEL = 403,

        S2C_GAME_PLAYERTEAMS_SV2CL_JOINPARTYTRAVEL = 405,

        C2S_GAME_PROPERTYEDITOR_CL2SV_OPENEDITOBJECT = 407,
        C2S_GAME_PROPERTYEDITOR_CL2SV_SENDCHANGES = 408,
        S2R_GAME_STATUEPAWN_SV2REL_REPLICATESTATE = 409,

        S2C_GAME_TRAVEL_SV2CL_TRAVELRESULT = 445,

        S2C_GAME_TRAVEL_SV2CL_UPDATETIMEOUT = 448,
        S2R_GAME_UNARMEDCOMBATSTATE_SV2REL_SETMONSTERMODE = 449,
        S2R_INTERACTIVEBIRTHSIGN_SV2REL_PLAYSOUNDEVENT = 450,
        S2R_INTERACTIVEBIRTHSIGN_SV2REL_SHOWGLOW = 451
    }
}