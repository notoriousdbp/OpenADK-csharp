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

namespace OpenADK.Library.uk.Common{

/// <summary>Describes an alternate ID for a person</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class OtherId : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an OtherId
	/// </summary>
	public OtherId() : base ( CommonDTD.OTHERID ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">Code that defines the type of this other ID.  Note: A subset of valid values may be specified in data objects.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;OtherId&amp;gt; element</param>
	///
	public OtherId( OtherIdType type, string value ) : base( CommonDTD.OTHERID )
	{
		this.SetType( type );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected OtherId( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.OTHERID_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherId&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;OtherId&amp;gt; element"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.OTHERID ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.OTHERID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code that defines the type of this other ID.  Note: A subset of valid values may be specified in data objects."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( CommonDTD.OTHERID_TYPE );
		}
		set
		{
			SetField( CommonDTD.OTHERID_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <param name="val">A OtherIdType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code that defines the type of this other ID.  Note: A subset of valid values may be specified in data objects."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetType( OtherIdType val )
	{
		SetField( CommonDTD.OTHERID_TYPE, val );
	}

}}