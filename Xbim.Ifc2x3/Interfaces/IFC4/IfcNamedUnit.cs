// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.MeasureResource
{
	public partial class @IfcNamedUnit : IIfcNamedUnit
	{
		IIfcDimensionalExponents IIfcNamedUnit.Dimensions 
		{ 
			get
			{
				return Dimensions as IIfcDimensionalExponents;
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcUnitEnum IIfcNamedUnit.UnitType 
		{ 
			get
			{
				switch (UnitType)
				{
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.ABSORBEDDOSEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.ABSORBEDDOSEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.AREAUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.AREAUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.DOSEEQUIVALENTUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.DOSEEQUIVALENTUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.ELECTRICCAPACITANCEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.ELECTRICCAPACITANCEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.ELECTRICCHARGEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.ELECTRICCHARGEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.ELECTRICCONDUCTANCEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.ELECTRICCONDUCTANCEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.ELECTRICCURRENTUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.ELECTRICCURRENTUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.ELECTRICRESISTANCEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.ELECTRICRESISTANCEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.ELECTRICVOLTAGEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.ELECTRICVOLTAGEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.ENERGYUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.ENERGYUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.FORCEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.FORCEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.FREQUENCYUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.FREQUENCYUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.ILLUMINANCEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.ILLUMINANCEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.INDUCTANCEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.INDUCTANCEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.LENGTHUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.LENGTHUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.LUMINOUSFLUXUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.LUMINOUSFLUXUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.LUMINOUSINTENSITYUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.LUMINOUSINTENSITYUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.MAGNETICFLUXDENSITYUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.MAGNETICFLUXDENSITYUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.MAGNETICFLUXUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.MAGNETICFLUXUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.MASSUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.MASSUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.PLANEANGLEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.PLANEANGLEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.POWERUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.POWERUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.PRESSUREUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.PRESSUREUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.RADIOACTIVITYUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.RADIOACTIVITYUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.SOLIDANGLEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.SOLIDANGLEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.TIMEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.TIMEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.VOLUMEUNIT:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.VOLUMEUNIT;
					
					case Xbim.Ifc2x3.MeasureResource.IfcUnitEnum.USERDEFINED:
						return Xbim.Ifc4.MeasureResource.IfcUnitEnum.USERDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}