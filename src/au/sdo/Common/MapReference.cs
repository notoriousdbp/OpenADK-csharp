// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;

namespace OpenADK.Library.au.Common{

/// <summary>A MapReference</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class MapReference : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a MapReference
	/// </summary>
	public MapReference() : base ( CommonDTD.MAPREFERENCE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">Type map reference</param>
	///<param name="xCoordinate">X Co-ordinate of reference</param>
	///<param name="yCoordinate">Y Co-ordinate of reference</param>
	///
	public MapReference( string type, string xCoordinate, string yCoordinate ) : base( CommonDTD.MAPREFERENCE )
	{
		this.Type = type;
		this.XCoordinate = xCoordinate;
		this.YCoordinate = yCoordinate;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MapReference( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.MAPREFERENCE_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Type map reference"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Type
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.MAPREFERENCE_TYPE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.MAPREFERENCE_TYPE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;XCoordinate&gt;</c> element.
	/// </summary>
	/// <value> The <c>XCoordinate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "X Co-ordinate of reference"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string XCoordinate
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.MAPREFERENCE_XCOORDINATE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.MAPREFERENCE_XCOORDINATE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;YCoordinate&gt;</c> element.
	/// </summary>
	/// <value> The <c>YCoordinate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Y Co-ordinate of reference"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string YCoordinate
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.MAPREFERENCE_YCOORDINATE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.MAPREFERENCE_YCOORDINATE, new SifString( value ), value );
		}
	}

}}