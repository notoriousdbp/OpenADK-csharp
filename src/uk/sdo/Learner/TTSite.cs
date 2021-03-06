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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Learner{

/// <summary>A TTSite</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class TTSite : SifDataObject
{
	/// <summary>
	/// Creates an instance of a TTSite
	/// </summary>
	public TTSite() : base( Adk.SifVersion, LearnerDTD.TTSITE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">Unique GUID for this Site</param>
	///<param name="code">A Code</param>
	///<param name="description">A Description</param>
	///
	public TTSite( string refId, string code, string description ) : base( Adk.SifVersion, LearnerDTD.TTSITE )
	{
		this.RefId = refId;
		this.Code = code;
		this.Description = description;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TTSite( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LearnerDTD.TTSITE_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Unique GUID for this Site"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.TTSITE_REFID ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.TTSITE_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Code
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.TTSITE_CODE ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.TTSITE_CODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearnerDTD.TTSITE_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( LearnerDTD.TTSITE_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <value> The <c>Type</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "What "type" of site this is. It is used by the MIS to help with any manual matching."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( LearnerDTD.TTSITE_TYPE );
		}
		set
		{
			SetField( LearnerDTD.TTSITE_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <param name="val">A TTSiteType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "What "type" of site this is. It is used by the MIS to help with any manual matching."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetType( TTSiteType val )
	{
		SetField( LearnerDTD.TTSITE_TYPE, val );
	}

}}
