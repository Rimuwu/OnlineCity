﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.ModelMails
{

    [Serializable]
    public class ModelMailStartIncident : ModelMail, IModelPlace
    {
        public int Tile { get; set; }
        public long PlaceServerId { get; set; }

        public IncidentTypes IncidentType { get; set; }
        public int IncidentMult { get; set; }
        public IncidentStrategys IncidentStrategy { get; set; }
        public IncidentArrivalModes IncidentArrivalMode { get; set; }
        public string IncidentFaction { get; set; }
        public string IncidentParam { get; set; }


        public override string GetHash()
        {
            return $"T{Tile}P{PlaceServerId} {(int)IncidentType} {IncidentMult} {(int)IncidentStrategy} {(int)IncidentArrivalMode} {IncidentFaction} {IncidentParam}";
        }
    }

    public enum IncidentTypes
    {
        Raid,
        Caravan,
        ChunkDrop,
        Infistation,
        Quest,
        Bombing,
        Acid,
        EMP,
        Pack,
        Eclipse,
        Storm,
        Plague,
        Def,
    }
    public enum IncidentStrategys
    {
        ImmediateAttack
    }
    public enum IncidentArrivalModes
    {
        EdgeWalkIn,
        RandomDrop,
        CenterDrop,
    }

}
