# UnitConv
UnitConv is a simple and easy to use unit conversion library.
[![license](https://img.shields.io/github/license/rosen369/unitconv.svg)](https://github.com/Rosen369/UnitConv/blob/master/LICENSE)
[![NuGet](https://img.shields.io/nuget/dt/unitconv.svg)](https://www.nuget.org/packages?q=UnitConv)

# Feeds
* NuGet [![NuGet](https://img.shields.io/nuget/v/UnitConv.svg)](https://www.nuget.org/packages?q=UnitConv)

# Let's get started

From **NuGet**: 
* PM> Install-Package UnitConv

# Create a quantity

```c#
using UnitConv;

var meter1 = new Length(1184, LengthUnit.Meter);
var meter2 = new Length("1184m");
var meter3 = new Length("1184", "m");
var meter4 = new Length(1184, "m");
var meter5 = new Length("1184", LengthUnit.Meter);
```

# Converter

```c#
var kilo = new Length(1.184m, LengthUnit.Kilometer);
var meter = UnitConverter.Length.Convert(kilo, LengthUnit.Meter);
```

# Extension

```c#
using UnitConv.Extension;

var kilo = new Length(1.184m, LengthUnit.Kilometer);
var meter = kilo.ToMeter();
var mile = kilo.ToMile();
```

# Get display

```c#
var kilo = new Length(1.184m, LengthUnit.Kilometer);
var en = kilo.ToString();	//100.142km
var ch = kilo.ToString(Languages.Chinese); //"100.142千米"
```

# Default string settings
```c#
UnitConvSettings.DefaultLanguage = Languages.English;
UnitConvSettings.DefaultDigits = 3;
```

# Supported quantity types

Area
- Acre
- Are
- Hectare
- SquareCentimeter
- SquareDecimeter
- SquareFoot
- SquareInch
- SquareKilometer
- SquareMeter
- SquareMile
- SquareMillimeter
- SquareYard

Data
- Bit
- Byte
- Gigabyte
- Kilobyte
- Megabyte
- Petabyte
- Terabyte

Density
- GramPerCubicCentimeter
- GramPerCubicDecimeter
- GramPerCubicMeter
- KilogramPerCubicCentimeter
- KilogramPerCubicDecimeter
- KilogramPerCubicMeter

Length
- AstronomicalUnit
- Centimeter
- Decimeter
- Fathom
- Foot
- Furlong
- Inch
- Kilometer
- LightYear
- Meter
- Micrometer
- Mile
- Millimeter
- Nanometer
- NauticalMile
- Picometer
- Yard

Power
- BritishHorsepower
- BritishThermalUnitPerSecond
- FootPoundPerSecond
- JoulePerSecond
- KcalPerSecond
- KilogramMeterPerSecond
- Kilowatt
- MetricHorsepower
- NewtonMeterPerSecond
- Watt

Pressure
- Atmosphere
- Bar
- Hectopascal
- InchOfMercury
- Kilopascal
- Megapascal
- Millibar
- MillimeterOfMercury
- NewtonPerSquareMeter
- Pascal
- PoundPerSquareFoot
- PoundPerSquareInch

Speed
- InchPerSecond
- KilometerPerHour
- KilometerPerSecond
- Mach
- MeterPerSecond
- MilePerHour

Strength
- Dyne
- GramForce
- KilogramForce
- KiloNewton
- KilopoundForce
- Newton
- PoundForce
- TonneForce

Volume
- Centilitre
- CubicCentimeter
- CubicDecimeter
- CubicFoot
- CubicInch
- CubicMeter
- CubicMillimeter
- CubicYard
- Deciliter
- HektoLitre
- Litre
- Microliter
- Milliliter
- UKGallon
- USGallon

Weight
- Gram
- Kilogram
- Microgram
- Milligram
- Ounce
- Pound
- Quintal
- Ton

Work
- BritishHorsepowerHour
- BritishThermalUnit
- Calorie
- FootPound
- Joule
- Kilocalorie
- KilogramMeter
- Kilojoule
- KilowattHour
- MetricHorsepowerHour