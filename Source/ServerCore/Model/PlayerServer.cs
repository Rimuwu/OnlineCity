﻿using Model;
using OCUnion.Transfer;
using OCUnion.Transfer.Types;
using ServerOnlineCity.Services;
using System;
using System.Collections.Generic;
using Transfer;

namespace ServerOnlineCity.Model
{
    [Serializable]
    public class PlayerServer : IPlayerEx
    {
        public Player Public { get; set; }

        //повторить логику на сервере тут: PlayerClient
        public bool Online =>
            Public.LastOnlineTime == DateTime.MinValue ? Public.LastSaveTime > DateTime.UtcNow.AddMinutes(-17) :
            Public.LastOnlineTime > (DateTime.UtcNow).AddSeconds(-10);

        public string Pass;

        public bool IsAdmin;

        public Guid DiscordToken;

        /// <summary>
        /// Причина разрыва соединения
        /// </summary>
        [NonSerialized]
        public DisconnectReason ExitReason;

        /// <summary>
        /// Разрешаем ли загрузку мира: только если файлы Steam и моды идентичные
        /// </summary>
        [NonSerialized]
        public ApproveLoadWorldReason ApproveLoadWorldReason;

        /// Key: ChatId, Value: lastPostIndex, last changed list of Logins
        public Dictionary<Chat, ModelUpdateTime> Chats;

        public DateTime SaveDataPacketTime;

        public DateTime LastUpdateTime;

        public List<ModelMailTrade> Mails = new List<ModelMailTrade>();

        [NonSerialized]
        public AttackServer AttackData;

        /// <summary>
        /// По умолчанию когда =0 - принимается 15 минут
        /// </summary>
        public int SettingDelaySaveGame;

        /// <summary>
        /// Записывать ли логи в файл на клиенте, по умолчанию отключено, для быстродействия
        /// </summary>
        public bool SettingEnableFileLog;

        /// <summary>
        /// Когда можно будет поменять галку "Учавствую в PVP"
        /// </summary>
        public DateTime TimeChangeEnablePVP;

        /// <summary>
        /// Когда последний раз нападали
        /// </summary>
        public DateTime PVPHostLastTime;

        private PlayerServer()
        {
            ExitReason = DisconnectReason.AllGood;
            ApproveLoadWorldReason = ApproveLoadWorldReason.LoginOk;
        }

        public PlayerServer(string login)
        {
            Public = new Player()
            {
                Login = login
            };

            Chats = new Dictionary<Chat, ModelUpdateTime>(1);
            Chats.Add(ChatManager.Instance.PublicChat, new ModelUpdateTime() { Value = -1 });
        }

        public WorldObjectsValues CostWorldObjects(long serverId = 0)
        {
            var values = new WorldObjectsValues();

            var data = Repository.GetData;

            for (int i = 0; i < data.WorldObjects.Count; i++)
            {
                if (data.WorldObjects[i].LoginOwner != Public.Login) continue;
                if (serverId != 0 && data.WorldObjects[i].ServerId != serverId) continue;

                values.MarketValue += data.WorldObjects[i].MarketValue;
                values.MarketValuePawn += data.WorldObjects[i].MarketValuePawn;
                if (data.WorldObjects[i].Type == WorldObjectEntryType.Base)
                    values.BaseCount++;
                else
                    values.CaravanCount++;
            }

            return values;
        }
    }
}
