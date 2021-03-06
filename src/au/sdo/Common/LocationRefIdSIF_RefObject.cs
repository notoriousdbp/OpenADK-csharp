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
	/// Defines the set of values that can be specified whenever a LocationRefIdSIF_RefObject
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a LocationRefIdSIF_RefObject object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class LocationRefIdSIF_RefObject : SifEnum
	{
	/// <summary>LEAInfo ("LEAInfo")</summary>
	public static readonly LocationRefIdSIF_RefObject LEAINFO = new LocationRefIdSIF_RefObject("LEAInfo");

	/// <summary>SchoolInfo ("SchoolInfo")</summary>
	public static readonly LocationRefIdSIF_RefObject SCHOOLINFO = new LocationRefIdSIF_RefObject("SchoolInfo");

	/// <summary>RoomInfo ("RoomInfo")</summary>
	public static readonly LocationRefIdSIF_RefObject ROOMINFO = new LocationRefIdSIF_RefObject("RoomInfo");

	///<summary>Wrap an arbitrary string value in a LocationRefIdSIF_RefObject object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static LocationRefIdSIF_RefObject Wrap( String wrappedValue ) {
		return new LocationRefIdSIF_RefObject( wrappedValue );
	}

	private LocationRefIdSIF_RefObject( string enumDefValue ) : base( enumDefValue ) {}
	}
}
