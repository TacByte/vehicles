﻿using System;
using System.Collections.Generic;
using NFive.SDK.Core.Helpers;
using NFive.SDK.Core.Models;
using NFive.SDK.Core.Models.Audio;

namespace IgiCore.Vehicles.Shared.Models
{
	public class Vehicle : IVehicle
	{
		public Guid Id { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Deleted { get; set; }
		public long Hash { get; set; }
		public int? Handle { get; set; }
		public int? NetId { get; set; }
		public string VIN { get; set; }
		public string LicensePlate { get; set; }
		public Guid TrackingUserId { get; set; }
		public Position Position { get; set; }
		public float Heading { get; set; }
		public float BodyHealth { get; set; } = 1000;
		public float EngineHealth { get; set; } = 1000;
		public float DirtLevel { get; set; }
		public float FuelLevel { get; set; } = 1000;
		public float OilLevel { get; set; } = 1000;
		public float PetrolTankHealth { get; set; } = 1000;
		public float TowingCraneRaisedAmount { get; set; }
		
		public bool HasAlarm { get; set; } = true;
		public bool IsAlarmed { get; set; } = false;
		public bool IsAlarmSounding { get; set; } = false;
		public bool HasLock { get; set; } = true;
		public bool IsDrivable { get; set; }
		public bool IsEngineRunning { get; set; } = true;
		public bool HasSeatBelts { get; set; }
		public bool IsHighBeamsOn { get; set; } = false;
		public bool IsLightsOn { get; set; } = false;
		public bool IsInteriorLightOn { get; set; } = false;
		public bool IsSearchLightOn { get; set; } = false;
		public bool IsTaxiLightOn { get; set; } = false;
		public bool IsLeftIndicatorLightOn { get; set; } = false;
		public bool IsRightIndicatorLightOn { get; set; } = false;
		public bool IsFrontBumperBrokenOff { get; set; } = false;
		public bool IsRearBumperBrokenOff { get; set; } = false;
		public bool IsLeftHeadLightBroken { get; set; } = false;
		public bool IsRightHeadLightBroken { get; set; } = false;
		public bool IsRadioEnabled { get; set; } = false;
		public bool IsRoofOpen { get; set; } = false;
		public bool NeedsToBeHotWired { get; set; }
		public bool HasRoof { get; set; } = true;
		public bool IsVehicleConvertible { get; set; } = false;
		public bool CanTiresBurst { get; set; } = true;
		public VehicleColor PrimaryColor { get; set; } = new VehicleColor();
		public VehicleColor SecondaryColor { get; set; } = new VehicleColor();
		public VehicleStockColor PearlescentColor { get; set; }
		public VehicleStockColor DashboardColor { get; set; }
		public VehicleStockColor RimColor { get; set; }
		public Color NeonColor { get; set; } = new Color();
		public VehicleNeonPositions NeonPositions { get; set; }
		public Color TireSmokeColor { get; set; } = new Color();
		public VehicleStockColor TrimColor { get; set; }
		public VehicleWindowTint WindowTint { get; set; } = VehicleWindowTint.None;
		public VehicleLockStatus LockStatus { get; set; } = VehicleLockStatus.None;
		public RadioStation RadioStation { get; set; }
		public VehicleClass Class { get; set; }
		public virtual List<VehicleExtra> Extras { get; set; } = new List<VehicleExtra>();
		public virtual List<VehicleWindow> Windows { get; set; } = new List<VehicleWindow>();
		public virtual List<VehicleSeat> Seats { get; set; } = new List<VehicleSeat>();
		public virtual List<VehicleMod> Mods { get; set; } = new List<VehicleMod>();
		public virtual List<VehicleDoor> Doors { get; set; } = new List<VehicleDoor>();
		public virtual List<VehicleWheel> Wheels { get; set; } = new List<VehicleWheel>();

		public Vehicle() { this.Id = GuidGenerator.GenerateTimeBasedGuid(); }

	}
}