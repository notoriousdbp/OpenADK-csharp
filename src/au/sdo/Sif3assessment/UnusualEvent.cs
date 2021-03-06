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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>An UnusualEvent</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class UnusualEvent : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an UnusualEvent
	/// </summary>
	public UnusualEvent() : base ( Sif3assessmentDTD.UNUSUALEVENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="value">Gets or sets the content value of the &amp;lt;UnusualEvent&amp;gt; element</param>
	///
	public UnusualEvent( string value ) : base( Sif3assessmentDTD.UNUSUALEVENT )
	{
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected UnusualEvent( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.UNUSUALEVENT }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;UnusualEvent&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;UnusualEvent&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.UNUSUALEVENT ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.UNUSUALEVENT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <value> The <c>Code</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Code
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.UNUSUALEVENT_CODE ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.UNUSUALEVENT_CODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SIF_Action</c> attribute.
	/// </summary>
	/// <value> The <c>SIF_Action</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string SIF_Action
	{
		get
		{ 
			return GetFieldValue( Sif3assessmentDTD.UNUSUALEVENT_SIF_ACTION );
		}
		set
		{
			SetField( Sif3assessmentDTD.UNUSUALEVENT_SIF_ACTION, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>SIF_Action</c> attribute.
	/// </summary>
	/// <param name="val">A UnusualEventActionEnum object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetSIF_Action( UnusualEventActionEnum val )
	{
		SetField( Sif3assessmentDTD.UNUSUALEVENT_SIF_ACTION, val );
	}

}}
