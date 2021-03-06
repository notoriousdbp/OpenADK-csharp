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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Hrfin{

/// <summary>Taxpayer identification number/Federal tax ID for this vendor.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class FederalTaxId : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a FederalTaxId
	/// </summary>
	public FederalTaxId() : base ( HrfinDTD.FEDERALTAXID ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">The type tax ID that this is. TIN based on IRS Publication 1915 [IRSTIN].</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;FederalTaxId&amp;gt; element</param>
	///
	public FederalTaxId( FederalTaxIdCode code, string value ) : base( HrfinDTD.FEDERALTAXID )
	{
		this.SetCode( code );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FederalTaxId( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { HrfinDTD.FEDERALTAXID_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FederalTaxId&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;FederalTaxId&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FEDERALTAXID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FEDERALTAXID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <value> The <c>Code</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The type tax ID that this is. TIN based on IRS Publication 1915 [IRSTIN]."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( HrfinDTD.FEDERALTAXID_CODE );
		}
		set
		{
			SetField( HrfinDTD.FEDERALTAXID_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <param name="val">A FederalTaxIdCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The type tax ID that this is. TIN based on IRS Publication 1915 [IRSTIN]."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetCode( FederalTaxIdCode val )
	{
		SetField( HrfinDTD.FEDERALTAXID_CODE, val );
	}

}}
