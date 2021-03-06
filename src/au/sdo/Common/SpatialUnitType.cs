// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SpatialUnitType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SpatialUnitType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class SpatialUnitType : SifEnum
	{
	/// <summary>Indigenous Location ("ILOC")</summary>
	public static readonly SpatialUnitType ILOC = new SpatialUnitType("ILOC");

	/// <summary>Statistical Area Level 4 ("SA4")</summary>
	public static readonly SpatialUnitType SA4 = new SpatialUnitType("SA4");

	/// <summary>Tourism Region ("TR")</summary>
	public static readonly SpatialUnitType TR = new SpatialUnitType("TR");

	/// <summary>Statistical Area Level 3 ("SA3")</summary>
	public static readonly SpatialUnitType SA3 = new SpatialUnitType("SA3");

	/// <summary>Greater Capital City Statistical Areas ("GCCSA")</summary>
	public static readonly SpatialUnitType GCCSA = new SpatialUnitType("GCCSA");

	/// <summary>Statistical Area Level 2 ("SA2")</summary>
	public static readonly SpatialUnitType SA2 = new SpatialUnitType("SA2");

	/// <summary>Statistical Area Level 1 ("SA1")</summary>
	public static readonly SpatialUnitType SA1 = new SpatialUnitType("SA1");

	/// <summary>Mesh Block ("MB")</summary>
	public static readonly SpatialUnitType MB = new SpatialUnitType("MB");

	/// <summary>State and Territory ("S/T")</summary>
	public static readonly SpatialUnitType S_T = new SpatialUnitType("S/T");

	/// <summary>Local Government Area ("LG")</summary>
	public static readonly SpatialUnitType LG = new SpatialUnitType("LG");

	/// <summary>Indigenous Area ("IARE")</summary>
	public static readonly SpatialUnitType IARE = new SpatialUnitType("IARE");

	/// <summary>Indigenous Region ("IREG")</summary>
	public static readonly SpatialUnitType IREG = new SpatialUnitType("IREG");

	///<summary>Wrap an arbitrary string value in a SpatialUnitType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SpatialUnitType Wrap( String wrappedValue ) {
		return new SpatialUnitType( wrappedValue );
	}

	private SpatialUnitType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
