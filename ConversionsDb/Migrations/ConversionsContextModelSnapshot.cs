﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace Chimerical.Conversions.Db.Migrations
{
    [DbContext(typeof(ConversionsContext))]
    partial class ConversionsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConversionsDb.Models.Conversions.BaseUnitMap", b =>
                {
                    b.Property<int>("UnitTypeId");

                    b.Property<string>("BaseUnitSymbol")
                        .HasMaxLength(8);

                    b.HasKey("UnitTypeId");

                    b.HasIndex("BaseUnitSymbol");

                    b.ToTable("BaseUnitMap", "Conversions");

                    b.HasData(
                        new { UnitTypeId = 1, BaseUnitSymbol = "km²" },
                        new { UnitTypeId = 3, BaseUnitSymbol = "B" },
                        new { UnitTypeId = 4, BaseUnitSymbol = "m" },
                        new { UnitTypeId = 5, BaseUnitSymbol = "J" },
                        new { UnitTypeId = 6, BaseUnitSymbol = "Hz" },
                        new { UnitTypeId = 7, BaseUnitSymbol = "km/L" },
                        new { UnitTypeId = 8, BaseUnitSymbol = "kg" },
                        new { UnitTypeId = 9, BaseUnitSymbol = "deg" },
                        new { UnitTypeId = 10, BaseUnitSymbol = "Pa" },
                        new { UnitTypeId = 11, BaseUnitSymbol = "m/s" },
                        new { UnitTypeId = 13, BaseUnitSymbol = "s" },
                        new { UnitTypeId = 14, BaseUnitSymbol = "L" }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Conversions.Conversion", b =>
                {
                    b.Property<string>("FromUnitSymbol")
                        .HasMaxLength(8);

                    b.Property<string>("ToUnitSymbol")
                        .HasMaxLength(8);

                    b.Property<double>("Multiplier");

                    b.HasKey("FromUnitSymbol", "ToUnitSymbol");

                    b.HasIndex("ToUnitSymbol");

                    b.ToTable("Conversion", "Conversions");

                    b.HasData(
                        new { FromUnitSymbol = "km²", ToUnitSymbol = "ha", Multiplier = 100.0 },
                        new { FromUnitSymbol = "km²", ToUnitSymbol = "m²", Multiplier = 10000000.0 },
                        new { FromUnitSymbol = "mi²", ToUnitSymbol = "km²", Multiplier = 2.58999 },
                        new { FromUnitSymbol = "mi²", ToUnitSymbol = "ac", Multiplier = 640.0 },
                        new { FromUnitSymbol = "mi²", ToUnitSymbol = "yd²", Multiplier = 3097600.0 },
                        new { FromUnitSymbol = "mi²", ToUnitSymbol = "ft²", Multiplier = 27878400.0 },
                        new { FromUnitSymbol = "mi²", ToUnitSymbol = "in²", Multiplier = 4014489600.0 },
                        new { FromUnitSymbol = "B", ToUnitSymbol = "bit", Multiplier = 8.0 },
                        new { FromUnitSymbol = "Kibit", ToUnitSymbol = "kbit", Multiplier = 1.024 },
                        new { FromUnitSymbol = "KiB", ToUnitSymbol = "kB", Multiplier = 1.024 },
                        new { FromUnitSymbol = "PiB", ToUnitSymbol = "TiB", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "TiB", ToUnitSymbol = "GiB", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "GiB", ToUnitSymbol = "MiB", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "MiB", ToUnitSymbol = "KiB", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "KiB", ToUnitSymbol = "B", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "PB", ToUnitSymbol = "TB", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "TB", ToUnitSymbol = "GB", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "GB", ToUnitSymbol = "MB", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "MB", ToUnitSymbol = "kB", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "kB", ToUnitSymbol = "B", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "Pibit", ToUnitSymbol = "Tibit", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "Tibit", ToUnitSymbol = "Gibit", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "Gibit", ToUnitSymbol = "Mibit", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "Mibit", ToUnitSymbol = "Kibit", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "Kibit", ToUnitSymbol = "bit", Multiplier = 1024.0 },
                        new { FromUnitSymbol = "Pbit", ToUnitSymbol = "Tbit", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "Tbit", ToUnitSymbol = "Gbit", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "Gbit", ToUnitSymbol = "Mbit", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "Mbit", ToUnitSymbol = "kbit", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "kbit", ToUnitSymbol = "bit", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "km", ToUnitSymbol = "m", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "m", ToUnitSymbol = "dm", Multiplier = 10.0 },
                        new { FromUnitSymbol = "m", ToUnitSymbol = "cm", Multiplier = 100.0 },
                        new { FromUnitSymbol = "m", ToUnitSymbol = "mm", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "mm", ToUnitSymbol = "μm", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "μm", ToUnitSymbol = "nm", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "ft", ToUnitSymbol = "m", Multiplier = 0.3048 },
                        new { FromUnitSymbol = "mi", ToUnitSymbol = "ft", Multiplier = 5280.0 },
                        new { FromUnitSymbol = "yd", ToUnitSymbol = "ft", Multiplier = 3.0 },
                        new { FromUnitSymbol = "ft", ToUnitSymbol = "in", Multiplier = 12.0 },
                        new { FromUnitSymbol = "nmi", ToUnitSymbol = "ft", Multiplier = 6076.12 },
                        new { FromUnitSymbol = "kJ", ToUnitSymbol = "J", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "cal", ToUnitSymbol = "J", Multiplier = 4.184 },
                        new { FromUnitSymbol = "kCal", ToUnitSymbol = "cal", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "Wh", ToUnitSymbol = "J", Multiplier = 3600.0 },
                        new { FromUnitSymbol = "kWh", ToUnitSymbol = "Wh", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "J", ToUnitSymbol = "eV", Multiplier = 6.242E+18 },
                        new { FromUnitSymbol = "Btu", ToUnitSymbol = "J", Multiplier = 1055.06 },
                        new { FromUnitSymbol = "thm", ToUnitSymbol = "Btu", Multiplier = 99976.1 },
                        new { FromUnitSymbol = "Btu", ToUnitSymbol = "ft-lb", Multiplier = 778.169 },
                        new { FromUnitSymbol = "GHz", ToUnitSymbol = "MHz", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "MHz", ToUnitSymbol = "kHz", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "kHz", ToUnitSymbol = "Hz", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "km/L", ToUnitSymbol = "US mpg", Multiplier = 0.621371192237334 },
                        new { FromUnitSymbol = "US mpg", ToUnitSymbol = "mpg", Multiplier = 0.621371192237334 },
                        new { FromUnitSymbol = "t", ToUnitSymbol = "kg", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "kg", ToUnitSymbol = "g", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "g", ToUnitSymbol = "mg", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "mg", ToUnitSymbol = "μg", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "kg", ToUnitSymbol = "lbs", Multiplier = 2.20462262185 },
                        new { FromUnitSymbol = "lbs", ToUnitSymbol = "oz", Multiplier = 16.0 },
                        new { FromUnitSymbol = "st", ToUnitSymbol = "lbs", Multiplier = 14.0 },
                        new { FromUnitSymbol = "US ton", ToUnitSymbol = "lbs", Multiplier = 2000.0 },
                        new { FromUnitSymbol = "ton", ToUnitSymbol = "US ton", Multiplier = 1.12 },
                        new { FromUnitSymbol = "arcmin", ToUnitSymbol = "arcsec", Multiplier = 60.0 },
                        new { FromUnitSymbol = "rad", ToUnitSymbol = "arcsec", Multiplier = 206265.0 },
                        new { FromUnitSymbol = "rad", ToUnitSymbol = "gon", Multiplier = 63.661977236758133 },
                        new { FromUnitSymbol = "rad", ToUnitSymbol = "mrad", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "rad", ToUnitSymbol = "deg", Multiplier = 57.295779513082323 },
                        new { FromUnitSymbol = "atm", ToUnitSymbol = "Pa", Multiplier = 101325.0 },
                        new { FromUnitSymbol = "atm", ToUnitSymbol = "Torr", Multiplier = 760.0 },
                        new { FromUnitSymbol = "bar", ToUnitSymbol = "Pa", Multiplier = 100000.0 },
                        new { FromUnitSymbol = "psi", ToUnitSymbol = "Pa", Multiplier = 6894.757 },
                        new { FromUnitSymbol = "m/s", ToUnitSymbol = "km/h", Multiplier = 3.6 },
                        new { FromUnitSymbol = "fps", ToUnitSymbol = "m/s", Multiplier = 0.3048 },
                        new { FromUnitSymbol = "mph", ToUnitSymbol = "km/h", Multiplier = 1.609344 },
                        new { FromUnitSymbol = "kn", ToUnitSymbol = "mph", Multiplier = 1.15078 },
                        new { FromUnitSymbol = "century", ToUnitSymbol = "decade", Multiplier = 10.0 },
                        new { FromUnitSymbol = "decade", ToUnitSymbol = "yr", Multiplier = 10.0 },
                        new { FromUnitSymbol = "yr", ToUnitSymbol = "month", Multiplier = 12.0 },
                        new { FromUnitSymbol = "yr", ToUnitSymbol = "day", Multiplier = 365.0 },
                        new { FromUnitSymbol = "week", ToUnitSymbol = "day", Multiplier = 365.0 },
                        new { FromUnitSymbol = "day", ToUnitSymbol = "hr", Multiplier = 24.0 },
                        new { FromUnitSymbol = "hr", ToUnitSymbol = "min", Multiplier = 60.0 },
                        new { FromUnitSymbol = "min", ToUnitSymbol = "s", Multiplier = 60.0 },
                        new { FromUnitSymbol = "s", ToUnitSymbol = "ms", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "ms", ToUnitSymbol = "μs", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "μs", ToUnitSymbol = "ns", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "m³", ToUnitSymbol = "L", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "L", ToUnitSymbol = "mL", Multiplier = 1000.0 },
                        new { FromUnitSymbol = "m³", ToUnitSymbol = "ft³", Multiplier = 0.028316846592000004 },
                        new { FromUnitSymbol = "ft³", ToUnitSymbol = "in³", Multiplier = 1728.0 },
                        new { FromUnitSymbol = "US gal", ToUnitSymbol = "L", Multiplier = 3.78541 },
                        new { FromUnitSymbol = "gal", ToUnitSymbol = "L", Multiplier = 4.54609 },
                        new { FromUnitSymbol = "gal", ToUnitSymbol = "quart", Multiplier = 4.0 },
                        new { FromUnitSymbol = "quart", ToUnitSymbol = "pt", Multiplier = 2.0 },
                        new { FromUnitSymbol = "pt", ToUnitSymbol = "cup", Multiplier = 1.75975 },
                        new { FromUnitSymbol = "pt", ToUnitSymbol = "fluid oz", Multiplier = 20.0 },
                        new { FromUnitSymbol = "fluid oz", ToUnitSymbol = "tbsp", Multiplier = 1.6 },
                        new { FromUnitSymbol = "tbsp", ToUnitSymbol = "tsp", Multiplier = 3.0 },
                        new { FromUnitSymbol = "US gal", ToUnitSymbol = "US quart", Multiplier = 4.0 },
                        new { FromUnitSymbol = "US quart", ToUnitSymbol = "US pt", Multiplier = 2.0 },
                        new { FromUnitSymbol = "US pt", ToUnitSymbol = "US cup", Multiplier = 1.97157 },
                        new { FromUnitSymbol = "US pt", ToUnitSymbol = "US oz", Multiplier = 16.0 },
                        new { FromUnitSymbol = "US oz", ToUnitSymbol = "US tbsp", Multiplier = 2.0 },
                        new { FromUnitSymbol = "US tbsp", ToUnitSymbol = "US tsp", Multiplier = 3.0 }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Conversions.Unit", b =>
                {
                    b.Property<string>("Symbol")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(8);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Symbol");

                    b.ToTable("Unit", "Conversions");

                    b.HasData(
                        new { Symbol = "km²", DisplayName = "Square Kilometre" },
                        new { Symbol = "m²", DisplayName = "Square Metre" },
                        new { Symbol = "mi²", DisplayName = "Square Mile" },
                        new { Symbol = "yd²", DisplayName = "Square Yard" },
                        new { Symbol = "ft²", DisplayName = "Square Foot" },
                        new { Symbol = "in²", DisplayName = "Square Inch" },
                        new { Symbol = "ha", DisplayName = "Hectare" },
                        new { Symbol = "ac", DisplayName = "Acre" },
                        new { Symbol = "bit", DisplayName = "Bit" },
                        new { Symbol = "kbit", DisplayName = "Kilobit" },
                        new { Symbol = "Kibit", DisplayName = "Kibibit" },
                        new { Symbol = "Mbit", DisplayName = "Megabit" },
                        new { Symbol = "Mibit", DisplayName = "Mebibit" },
                        new { Symbol = "Gbit", DisplayName = "Gigabit" },
                        new { Symbol = "Gibit", DisplayName = "Gibibit" },
                        new { Symbol = "Tbit", DisplayName = "Terabit" },
                        new { Symbol = "Tibit", DisplayName = "Tebibit" },
                        new { Symbol = "Pbit", DisplayName = "Petabit" },
                        new { Symbol = "Pibit", DisplayName = "Pebibit" },
                        new { Symbol = "B", DisplayName = "Byte" },
                        new { Symbol = "kB", DisplayName = "Kilobyte" },
                        new { Symbol = "KiB", DisplayName = "Kibibyte" },
                        new { Symbol = "MB", DisplayName = "Megabyte" },
                        new { Symbol = "MiB", DisplayName = "Mebibyte" },
                        new { Symbol = "GB", DisplayName = "Gigabyte" },
                        new { Symbol = "GiB", DisplayName = "Gibibyte" },
                        new { Symbol = "TB", DisplayName = "Terabyte" },
                        new { Symbol = "TiB", DisplayName = "Tebibyte" },
                        new { Symbol = "PB", DisplayName = "Petabyte" },
                        new { Symbol = "PiB", DisplayName = "Pebibyte" },
                        new { Symbol = "km", DisplayName = "Kilometre" },
                        new { Symbol = "m", DisplayName = "Metre" },
                        new { Symbol = "dm", DisplayName = "Decimetre" },
                        new { Symbol = "cm", DisplayName = "Centimetre" },
                        new { Symbol = "mm", DisplayName = "Millimetre" },
                        new { Symbol = "μm", DisplayName = "Micrometre" },
                        new { Symbol = "nm", DisplayName = "Nanometre" },
                        new { Symbol = "mi", DisplayName = "Mile" },
                        new { Symbol = "yd", DisplayName = "Yard" },
                        new { Symbol = "ft", DisplayName = "Foot" },
                        new { Symbol = "in", DisplayName = "Inch" },
                        new { Symbol = "nmi", DisplayName = "Nautical Mile" },
                        new { Symbol = "J", DisplayName = "Joule" },
                        new { Symbol = "kJ", DisplayName = "Kilojoule" },
                        new { Symbol = "cal", DisplayName = "Gram Calorie" },
                        new { Symbol = "kCal", DisplayName = "Kilocalorie" },
                        new { Symbol = "Wh", DisplayName = "Watt Hour" },
                        new { Symbol = "kWh", DisplayName = "Kilowatt Hour" },
                        new { Symbol = "eV", DisplayName = "Electronvolt" },
                        new { Symbol = "Btu", DisplayName = "British Thermal Unit" },
                        new { Symbol = "thm", DisplayName = "US Therm" },
                        new { Symbol = "ft-lb", DisplayName = "Foot-Pound" },
                        new { Symbol = "Hz", DisplayName = "Hertz" },
                        new { Symbol = "kHz", DisplayName = "Kilohertz" },
                        new { Symbol = "MHz", DisplayName = "Megahertz" },
                        new { Symbol = "GHz", DisplayName = "Gigahertz" },
                        new { Symbol = "US mpg", DisplayName = "US Miles per Gallon" },
                        new { Symbol = "mpg", DisplayName = "Miles per Gallon (Imperial)" },
                        new { Symbol = "km/L", DisplayName = "Kilometre per Litre" },
                        new { Symbol = "t", DisplayName = "Tonne" },
                        new { Symbol = "kg", DisplayName = "Kilogram" },
                        new { Symbol = "g", DisplayName = "Gram" },
                        new { Symbol = "mg", DisplayName = "Milligram" },
                        new { Symbol = "μg", DisplayName = "Microgram" },
                        new { Symbol = "ton", DisplayName = "Imperial Ton" },
                        new { Symbol = "US ton", DisplayName = "US Ton" },
                        new { Symbol = "st", DisplayName = "Stone" },
                        new { Symbol = "lbs", DisplayName = "Pound" },
                        new { Symbol = "oz", DisplayName = "Ounce" },
                        new { Symbol = "deg", DisplayName = "Degree" },
                        new { Symbol = "gon", DisplayName = "Gradian" },
                        new { Symbol = "mrad", DisplayName = "Milliradian" },
                        new { Symbol = "arcmin", DisplayName = "MinuteOfArc" },
                        new { Symbol = "rad", DisplayName = "Radian" },
                        new { Symbol = "arcsec", DisplayName = "SecondOfArc" },
                        new { Symbol = "atm", DisplayName = "Atmosphere" },
                        new { Symbol = "bar", DisplayName = "Bar" },
                        new { Symbol = "Pa", DisplayName = "Pascal" },
                        new { Symbol = "psi", DisplayName = "Pounds per Square Inch" },
                        new { Symbol = "Torr", DisplayName = "Torr" },
                        new { Symbol = "mph", DisplayName = "Mile per Hour" },
                        new { Symbol = "fps", DisplayName = "Foot per Second" },
                        new { Symbol = "m/s", DisplayName = "Metre per Second" },
                        new { Symbol = "km/h", DisplayName = "Kilometre per Hour" },
                        new { Symbol = "kn", DisplayName = "Knot" },
                        new { Symbol = "ns", DisplayName = "Nanosecond" },
                        new { Symbol = "μs", DisplayName = "Microsecond" },
                        new { Symbol = "ms", DisplayName = "Millisecond" },
                        new { Symbol = "s", DisplayName = "Second" },
                        new { Symbol = "min", DisplayName = "Minute" },
                        new { Symbol = "hr", DisplayName = "Hour" },
                        new { Symbol = "day", DisplayName = "Day" },
                        new { Symbol = "week", DisplayName = "Week" },
                        new { Symbol = "month", DisplayName = "Month" },
                        new { Symbol = "yr", DisplayName = "Year" },
                        new { Symbol = "decade", DisplayName = "Decade" },
                        new { Symbol = "century", DisplayName = "Century" },
                        new { Symbol = "US gal", DisplayName = "US Liquid Gallon" },
                        new { Symbol = "US quart", DisplayName = "US Liquid Quart" },
                        new { Symbol = "US pt", DisplayName = "US Liquid Pint" },
                        new { Symbol = "US cup", DisplayName = "US Legal Cup" },
                        new { Symbol = "US oz", DisplayName = "US Fluid Ounce" },
                        new { Symbol = "US tbsp", DisplayName = "US Tablespoon" },
                        new { Symbol = "US tsp", DisplayName = "US Teaspoon" },
                        new { Symbol = "m³", DisplayName = "CubicMetre" },
                        new { Symbol = "L", DisplayName = "Litre" },
                        new { Symbol = "mL", DisplayName = "Millilitre" },
                        new { Symbol = "gal", DisplayName = "Imperial Gallon" },
                        new { Symbol = "quart", DisplayName = "Imperial Quart" },
                        new { Symbol = "pt", DisplayName = "Imperial Pint" },
                        new { Symbol = "cup", DisplayName = "Imperial Cup" },
                        new { Symbol = "fluid oz", DisplayName = "Imperial Fluid Ounce" },
                        new { Symbol = "tbsp", DisplayName = "Imperial Tablespoon" },
                        new { Symbol = "tsp", DisplayName = "Imperial Teaspoon" },
                        new { Symbol = "ft³", DisplayName = "Cubic Foot" },
                        new { Symbol = "in³", DisplayName = "Cubic Inch" }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Conversions.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("UnitType", "Conversions");

                    b.HasData(
                        new { Id = 1, DisplayName = "Area" },
                        new { Id = 3, DisplayName = "Digital Storage" },
                        new { Id = 4, DisplayName = "Distance" },
                        new { Id = 5, DisplayName = "Energy" },
                        new { Id = 6, DisplayName = "Frequency" },
                        new { Id = 7, DisplayName = "Fuel Economy" },
                        new { Id = 8, DisplayName = "Mass" },
                        new { Id = 9, DisplayName = "Plane Angle" },
                        new { Id = 10, DisplayName = "Pressure" },
                        new { Id = 11, DisplayName = "Speed" },
                        new { Id = 13, DisplayName = "Time" },
                        new { Id = 14, DisplayName = "Volume" }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Conversions.UnitTypeMap", b =>
                {
                    b.Property<int>("UnitTypeId");

                    b.Property<string>("UnitSymbol")
                        .HasMaxLength(8);

                    b.HasKey("UnitTypeId", "UnitSymbol");

                    b.HasAlternateKey("UnitSymbol", "UnitTypeId");

                    b.ToTable("UnitTypeMap", "Conversions");

                    b.HasData(
                        new { UnitTypeId = 1, UnitSymbol = "km²" },
                        new { UnitTypeId = 1, UnitSymbol = "m²" },
                        new { UnitTypeId = 1, UnitSymbol = "mi²" },
                        new { UnitTypeId = 1, UnitSymbol = "yd²" },
                        new { UnitTypeId = 1, UnitSymbol = "ft²" },
                        new { UnitTypeId = 1, UnitSymbol = "in²" },
                        new { UnitTypeId = 1, UnitSymbol = "ha" },
                        new { UnitTypeId = 1, UnitSymbol = "ac" },
                        new { UnitTypeId = 3, UnitSymbol = "bit" },
                        new { UnitTypeId = 3, UnitSymbol = "kbit" },
                        new { UnitTypeId = 3, UnitSymbol = "Kibit" },
                        new { UnitTypeId = 3, UnitSymbol = "Mbit" },
                        new { UnitTypeId = 3, UnitSymbol = "Mibit" },
                        new { UnitTypeId = 3, UnitSymbol = "Gbit" },
                        new { UnitTypeId = 3, UnitSymbol = "Gibit" },
                        new { UnitTypeId = 3, UnitSymbol = "Tbit" },
                        new { UnitTypeId = 3, UnitSymbol = "Tibit" },
                        new { UnitTypeId = 3, UnitSymbol = "Pbit" },
                        new { UnitTypeId = 3, UnitSymbol = "Pibit" },
                        new { UnitTypeId = 3, UnitSymbol = "B" },
                        new { UnitTypeId = 3, UnitSymbol = "kB" },
                        new { UnitTypeId = 3, UnitSymbol = "KiB" },
                        new { UnitTypeId = 3, UnitSymbol = "MB" },
                        new { UnitTypeId = 3, UnitSymbol = "MiB" },
                        new { UnitTypeId = 3, UnitSymbol = "GB" },
                        new { UnitTypeId = 3, UnitSymbol = "GiB" },
                        new { UnitTypeId = 3, UnitSymbol = "TB" },
                        new { UnitTypeId = 3, UnitSymbol = "TiB" },
                        new { UnitTypeId = 3, UnitSymbol = "PB" },
                        new { UnitTypeId = 3, UnitSymbol = "PiB" },
                        new { UnitTypeId = 4, UnitSymbol = "km" },
                        new { UnitTypeId = 4, UnitSymbol = "m" },
                        new { UnitTypeId = 4, UnitSymbol = "dm" },
                        new { UnitTypeId = 4, UnitSymbol = "cm" },
                        new { UnitTypeId = 4, UnitSymbol = "mm" },
                        new { UnitTypeId = 4, UnitSymbol = "μm" },
                        new { UnitTypeId = 4, UnitSymbol = "nm" },
                        new { UnitTypeId = 4, UnitSymbol = "mi" },
                        new { UnitTypeId = 4, UnitSymbol = "yd" },
                        new { UnitTypeId = 4, UnitSymbol = "ft" },
                        new { UnitTypeId = 4, UnitSymbol = "in" },
                        new { UnitTypeId = 4, UnitSymbol = "nmi" },
                        new { UnitTypeId = 5, UnitSymbol = "J" },
                        new { UnitTypeId = 5, UnitSymbol = "kJ" },
                        new { UnitTypeId = 5, UnitSymbol = "cal" },
                        new { UnitTypeId = 5, UnitSymbol = "kCal" },
                        new { UnitTypeId = 5, UnitSymbol = "Wh" },
                        new { UnitTypeId = 5, UnitSymbol = "kWh" },
                        new { UnitTypeId = 5, UnitSymbol = "eV" },
                        new { UnitTypeId = 5, UnitSymbol = "Btu" },
                        new { UnitTypeId = 5, UnitSymbol = "thm" },
                        new { UnitTypeId = 5, UnitSymbol = "ft-lb" },
                        new { UnitTypeId = 6, UnitSymbol = "Hz" },
                        new { UnitTypeId = 6, UnitSymbol = "kHz" },
                        new { UnitTypeId = 6, UnitSymbol = "MHz" },
                        new { UnitTypeId = 6, UnitSymbol = "GHz" },
                        new { UnitTypeId = 7, UnitSymbol = "US mpg" },
                        new { UnitTypeId = 7, UnitSymbol = "mpg" },
                        new { UnitTypeId = 7, UnitSymbol = "km/L" },
                        new { UnitTypeId = 8, UnitSymbol = "t" },
                        new { UnitTypeId = 8, UnitSymbol = "kg" },
                        new { UnitTypeId = 8, UnitSymbol = "g" },
                        new { UnitTypeId = 8, UnitSymbol = "mg" },
                        new { UnitTypeId = 8, UnitSymbol = "μg" },
                        new { UnitTypeId = 8, UnitSymbol = "ton" },
                        new { UnitTypeId = 8, UnitSymbol = "US ton" },
                        new { UnitTypeId = 8, UnitSymbol = "st" },
                        new { UnitTypeId = 8, UnitSymbol = "lbs" },
                        new { UnitTypeId = 8, UnitSymbol = "oz" },
                        new { UnitTypeId = 9, UnitSymbol = "deg" },
                        new { UnitTypeId = 9, UnitSymbol = "gon" },
                        new { UnitTypeId = 9, UnitSymbol = "mrad" },
                        new { UnitTypeId = 9, UnitSymbol = "arcmin" },
                        new { UnitTypeId = 9, UnitSymbol = "rad" },
                        new { UnitTypeId = 9, UnitSymbol = "arcsec" },
                        new { UnitTypeId = 10, UnitSymbol = "atm" },
                        new { UnitTypeId = 10, UnitSymbol = "bar" },
                        new { UnitTypeId = 10, UnitSymbol = "Pa" },
                        new { UnitTypeId = 10, UnitSymbol = "psi" },
                        new { UnitTypeId = 10, UnitSymbol = "Torr" },
                        new { UnitTypeId = 11, UnitSymbol = "mph" },
                        new { UnitTypeId = 11, UnitSymbol = "fps" },
                        new { UnitTypeId = 11, UnitSymbol = "m/s" },
                        new { UnitTypeId = 11, UnitSymbol = "km/h" },
                        new { UnitTypeId = 11, UnitSymbol = "kn" },
                        new { UnitTypeId = 13, UnitSymbol = "ns" },
                        new { UnitTypeId = 13, UnitSymbol = "μs" },
                        new { UnitTypeId = 13, UnitSymbol = "ms" },
                        new { UnitTypeId = 13, UnitSymbol = "s" },
                        new { UnitTypeId = 13, UnitSymbol = "min" },
                        new { UnitTypeId = 13, UnitSymbol = "hr" },
                        new { UnitTypeId = 13, UnitSymbol = "day" },
                        new { UnitTypeId = 13, UnitSymbol = "week" },
                        new { UnitTypeId = 13, UnitSymbol = "month" },
                        new { UnitTypeId = 13, UnitSymbol = "yr" },
                        new { UnitTypeId = 13, UnitSymbol = "decade" },
                        new { UnitTypeId = 13, UnitSymbol = "century" },
                        new { UnitTypeId = 14, UnitSymbol = "US gal" },
                        new { UnitTypeId = 14, UnitSymbol = "US quart" },
                        new { UnitTypeId = 14, UnitSymbol = "US pt" },
                        new { UnitTypeId = 14, UnitSymbol = "US cup" },
                        new { UnitTypeId = 14, UnitSymbol = "US oz" },
                        new { UnitTypeId = 14, UnitSymbol = "US tbsp" },
                        new { UnitTypeId = 14, UnitSymbol = "US tsp" },
                        new { UnitTypeId = 14, UnitSymbol = "m³" },
                        new { UnitTypeId = 14, UnitSymbol = "L" },
                        new { UnitTypeId = 14, UnitSymbol = "mL" },
                        new { UnitTypeId = 14, UnitSymbol = "gal" },
                        new { UnitTypeId = 14, UnitSymbol = "quart" },
                        new { UnitTypeId = 14, UnitSymbol = "pt" },
                        new { UnitTypeId = 14, UnitSymbol = "cup" },
                        new { UnitTypeId = 14, UnitSymbol = "fluid oz" },
                        new { UnitTypeId = 14, UnitSymbol = "tbsp" },
                        new { UnitTypeId = 14, UnitSymbol = "tsp" },
                        new { UnitTypeId = 14, UnitSymbol = "ft³" },
                        new { UnitTypeId = 14, UnitSymbol = "in³" }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Lists.Converter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UnitTypeId");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypeId");

                    b.ToTable("Converter", "Lists");
                });

            modelBuilder.Entity("ConversionsDb.Models.Lists.ConverterIo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ConverterId");

                    b.Property<int>("ConverterIoTypeId");

                    b.Property<string>("UnitSymbol")
                        .IsRequired();

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ConverterId");

                    b.HasIndex("ConverterIoTypeId");

                    b.HasIndex("UnitSymbol");

                    b.ToTable("ConverterIo", "Lists");
                });

            modelBuilder.Entity("ConversionsDb.Models.Lists.ConverterIoType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("ConverterIoType", "Lists");

                    b.HasData(
                        new { Id = 1, Name = "Input" },
                        new { Id = 2, Name = "Output" }
                    );
                });

            modelBuilder.Entity("ConversionsDb.Models.Lists.ConverterList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("ConverterList", "Lists");
                });

            modelBuilder.Entity("ConversionsDb.Models.Lists.ConverterListMap", b =>
                {
                    b.Property<Guid>("ConverterListId");

                    b.Property<Guid>("ConverterId");

                    b.HasKey("ConverterListId", "ConverterId");

                    b.HasAlternateKey("ConverterId", "ConverterListId");

                    b.ToTable("ConverterListMap", "Lists");
                });

            modelBuilder.Entity("ConversionsDb.Models.Conversions.BaseUnitMap", b =>
                {
                    b.HasOne("ConversionsDb.Models.Conversions.Unit", "BaseUnit")
                        .WithMany()
                        .HasForeignKey("BaseUnitSymbol");

                    b.HasOne("ConversionsDb.Models.Conversions.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConversionsDb.Models.Conversions.Conversion", b =>
                {
                    b.HasOne("ConversionsDb.Models.Conversions.Unit", "FromUnit")
                        .WithMany()
                        .HasForeignKey("FromUnitSymbol")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConversionsDb.Models.Conversions.Unit", "ToUnit")
                        .WithMany()
                        .HasForeignKey("ToUnitSymbol")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConversionsDb.Models.Conversions.UnitTypeMap", b =>
                {
                    b.HasOne("ConversionsDb.Models.Conversions.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitSymbol")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConversionsDb.Models.Conversions.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConversionsDb.Models.Lists.Converter", b =>
                {
                    b.HasOne("ConversionsDb.Models.Conversions.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConversionsDb.Models.Lists.ConverterIo", b =>
                {
                    b.HasOne("ConversionsDb.Models.Lists.Converter", "Converter")
                        .WithMany()
                        .HasForeignKey("ConverterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConversionsDb.Models.Lists.ConverterIoType", "ConverterIoType")
                        .WithMany()
                        .HasForeignKey("ConverterIoTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConversionsDb.Models.Conversions.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitSymbol")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConversionsDb.Models.Lists.ConverterListMap", b =>
                {
                    b.HasOne("ConversionsDb.Models.Lists.Converter", "Converter")
                        .WithMany()
                        .HasForeignKey("ConverterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConversionsDb.Models.Lists.ConverterList", "ConverterList")
                        .WithMany()
                        .HasForeignKey("ConverterListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
